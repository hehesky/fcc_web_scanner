﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

using MyWebScan;



/*TODO:
1.(x)Finish Scanner class 
2.(x)setup threads for scanner
3.(x)setup scanner event(s), hook them up with subscribers

4.(x)code notification icon and setup minimization event
5.code remaining ui coms
    -(x)Sort buttons
    -Current ID display
6.(-x, partially fixed)Fix title regex 
7.set up scanner network error event
*/
namespace fcc_web_scanner
{

    delegate void scanner_pause_event_delegate();//delegate for event that ask scanner to pause scanning or start
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            


            ///create backend objects
            scanner = new Scanner(10000, 60000);
            entry_manager = new EntryManager();
            entry_list = entry_manager.ExportAsList();
            update_listbox();


            bool recovered = scanner.RecoverLastScan();
            ///hook up form events

            LinkLabel.Click += On_Linklabel_Clicked;
            EntryListBox.SelectedIndexChanged += On_Entry_List_Box_Item_Selected;
            FormClosing += On_Form_Being_Closed;
            ExitButton.Click += On_Exit_Button_Clicked;
            ResumeButton.Click += On_Resume_Button_Clicked;
            StopButton.Click += On_Stop_Button_Clicked;
            PauseButton.Click += On_Pause_Button_Clicked;
            JumpButton.Click += On_Jump_Button_Clicked;
            SortByIDButton.Click += On_Sort_By_ID_Button_Clicked;
            SortByDateButton.Click += On_Sort_By_Publication_Date_Clicked;
            ForceUpdateCheckBox.CheckedChanged += On_Force_Update_Checkbox_Changed;

            Resize += On_Form_Resize;
            traynotifyIcon.Click += On_Tray_Icon_Clicked;
            //entry_manager.Data_Bank_Change += On_Entry_Manager_Changed;

            ///hook up scanner-entryManager events
            entry_manager.Data_Bank_Change += On_Entry_Manager_Changed;
            entry_manager.FE_Being_Processed += On_Scanner_Found_FE ;
            scanner.Found_Future_Entry_Event += entry_manager.On_Found_Future_Entry;
            scanner.Done_Scanning += On_Scanner_Done_Scanning;
            scanner.Scanner_Current_ID_Auto_Change += On_Scanner_Current_ID_Changed;
            scanner.Connection_Error_Event += On_Scanner_Connection_Error;
            ///wait for UI interaction
            CurrentIDTextBox.Text = scanner.Current_id.ToString();
            EntryCountTextBox.Text = entry_list.Count.ToString();
            string recover_msg;
            recover_msg = "Recovered Last Scan at id" + scanner.Current_id.ToString() + "\nDo you wish to continue this scan?";
            if (recovered && MessageBox.Show(recover_msg,"Restore",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                scanner.KeepScanning = true;
                scannerThread = new Thread(scanner.do_full_scan);
                scannerThread.Start(Math.Max(scanner.MinID, scanner.Current_id));
                ScannerStatusLabel.Text = "Scanner Running";
            }
            else
            {
                ScannerStatusLabel.Text = "Standing by";
            }

        }

        private void Entry_manager_FE_Being_Processed(object sender, StatusBarDrawItemEventArgs sbdevent)
        {
            throw new NotImplementedException();
        }

        #region utility methods
        private void setup_scanner_thread()
        {
            if (scannerThread==null||scannerThread.IsAlive==false)
            {
                scannerThread = new Thread(scanner.do_full_scan);
                scannerThread.Start(scanner.Current_id);
                ScannerStatusLabel.Text = "Scanner Running";
            }
        }

        private void update_listbox()
        {
            
            if (entry_list == null)
                return;
            int pre_selected_index = EntryListBox.SelectedIndex;//remember the index selected
            EntryListBox.Items.Clear();
            foreach (FutureEntry fe in entry_list)
            {
                
                if(fe.publication_date>DateTime.Today)
                {
                    fe.title = "!FE!" + fe.title;
                }
                EntryListBox.Items.Add(fe);
            }
            try
            {
                EntryListBox.SelectedIndex = pre_selected_index;
            }
            catch
            {
                EntryListBox.SelectedIndex = -1;
            }
        }

        private void display_selected_item()
        {
            if (EntryListBox.SelectedIndex < 0)
                return;
            IDTextBox.Text = entry_list[EntryListBox.SelectedIndex].id.ToString();
            DateTime pub_day = entry_list[EntryListBox.SelectedIndex].publication_date;
            PublicationDateTextBox.Text = pub_day.Year.ToString()+"-"+pub_day.Month.ToString()+"-"+pub_day.Day.ToString();
            if(entry_list[EntryListBox.SelectedIndex].publication_date>DateTime.Today)
            {
                PublicationDateTextBox.BackColor = Color.Red;
            }
            else
            {
                PublicationDateTextBox.BackColor = Color.White;
            }
            DateTime f_day = entry_list[EntryListBox.SelectedIndex].found_date;
            ScanDateTextBox.Text = f_day.Year.ToString()+"-"+f_day.Month.ToString()+"-"+f_day.Day.ToString();
            TitleTextBox.Text = entry_list[EntryListBox.SelectedIndex].title.ToString();
            
        }
        private void update_current_id_textbox()
        {
            CurrentIDTextBox.Text = scanner.Current_id.ToString();
        }
        private void update_status_bar(FutureEntry arg)
        {
            RecentChangeLabel.Text = arg.ToString();
        }

        private void update_display()
        {
            entry_list = entry_manager.ExportAsList();
            update_listbox();
            EntryCountTextBox.Text = entry_list.Count.ToString();
        }
        private void handle_connection_error()
        {
            ScannerStatusLabel.Text = "Scanner Paused; Error connecting to FCC website";
        }
        #endregion
        #region UI event handlers
        private void On_Form_Being_Closed(object sender, FormClosingEventArgs arg)
        {
            //stop the scanner if it is running
            //dump the current state of scanner
            //save data bank file if needed

            scanner.KeepScanning = false;
            if (scannerThread == null)
                return;
            if (scannerThread.IsAlive)
                scannerThread.Join(100);
            
            scannerThread.Abort();
            
            scanner.DumpCurrentState();
        
            entry_manager.update_data_file();
            

        }
        private void On_Form_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                traynotifyIcon.ShowBalloonTip(500);
            }
            else
            {
                Show();
            }
        }
        ///Backend-triggered event handlers
        private void On_Entry_Manager_Changed(object sender,EventArgs args)
        {
            Invoke(new form_control_delegate(update_display));
           
        }

        private void On_Scanner_Found_FE(object sender, ScannerEventArg arg)
        {
            //
            Invoke(new status_bar_update_delegate(update_status_bar),arg.Fe);
        }
        private void On_Scanner_Done_Scanning(object sender, EventArgs arg)
        {
            ScannerStatusLabel.Text = "Done Scanning";
        }
        ///UI components-triggered event handlers
        ///
        private void On_Sort_By_ID_Button_Clicked(object sender, EventArgs e)
        {
            entry_list.Sort(FutureEntry.CompareByID);
            update_listbox();
        }
        private void On_Sort_By_Publication_Date_Clicked(object sender,EventArgs e)
        {
            entry_list.Sort(FutureEntry.CompareByPublicationDate);
            entry_list.Reverse();
            update_listbox();
        }

        private void On_Pause_Button_Clicked(object sender, EventArgs args)
        {
            scanner.KeepScanning = false;
            ScannerStatusLabel.Text = "Scanner Paused";
        }
        private void On_Resume_Button_Clicked(object sender, EventArgs args)
        {
            scanner.KeepScanning = true;
            setup_scanner_thread();
            ScannerStatusLabel.Text = "Scanner Running";
        }
        private void On_Stop_Button_Clicked(object sender, EventArgs args)
        {
            scanner.KeepScanning = false;
            if(scannerThread!=null && scannerThread.IsAlive==true)
                scannerThread.Join(100);
            scanner.Current_id = scanner.MinID;
            ScannerStatusLabel.Text = "Scanner reset";
            CurrentIDTextBox.Text = scanner.Current_id.ToString();

        }
        private void On_Refresh_Button_Clicked(object sender, EventArgs args)
        {
            entry_list = entry_manager.ExportAsList();
            update_listbox();
        }
        private void On_Exit_Button_Clicked(object sender, EventArgs args)
        {
            Close();
        }

        private void On_Entry_List_Box_Item_Selected(object sender, EventArgs arg)
        {
            //use invoke here
            Invoke(new form_control_delegate(display_selected_item));
        }
        private void On_Linklabel_Clicked(object sender, EventArgs arg)
        {
            if (IDTextBox.Text =="")
                return;
            string url = "https://apps.fcc.gov/oetcf/kdb/forms/FTSSearchResultPage.cfm?id=" + IDTextBox.Text + "&switch=P";
            Process.Start(url);
        }
        private void On_Jump_Button_Clicked(object sender,EventArgs e)
        {
            scanner.KeepScanning = false;
            if(scannerThread!=null && scannerThread.IsAlive==true)
            {
                scannerThread.Join(100);
            }
            scanner.Current_id = decimal.ToInt32(JumpIDNumericInput.Value);
            ScannerStatusLabel.Text = "Scanner Paused and jumped to " + scanner.Current_id.ToString();
            CurrentIDTextBox.Text = scanner.Current_id.ToString();
        }
        private void On_Tray_Icon_Clicked(object sender, EventArgs e)
        {
            Show();
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }
        private void On_Scanner_Current_ID_Changed(object sender,EventArgs e)
        {
            Invoke(new form_control_delegate(update_current_id_textbox));
        }
        private void On_Scanner_Connection_Error(object sender,EventArgs e)
        {
            Invoke(new form_control_delegate(handle_connection_error));
        }
        private void On_Force_Update_Checkbox_Changed(object sender,EventArgs e)
        {
            entry_manager.ForceUpdate = ForceUpdateCheckBox.Checked;
        }
        #endregion
        private delegate void form_control_delegate();
        private delegate void status_bar_update_delegate(FutureEntry arg);


        #region MainForm fields
        private Scanner scanner;
        private EntryManager entry_manager;
        private Thread scannerThread;
        private List<FutureEntry> entry_list;
        #endregion

        private void updatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RightHalfPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    /// <summary>
    /// maintains a dictionary of 'future entries' found; initialize the dictionary on start up with datafile(databank.txt); updates datafile if the dictionary changes;
    /// entries are formated as:
    /// id,f_year,f_month,f_day,p_year,p_month,p_day,title
    /// </summary>
    public class EntryManager
    {
        
        public EntryManager()
        {
            ForceUpdate = false;
            databank = new Dictionary<int, FutureEntry>();
            if(File.Exists(data_file_dir)== true)
            {
                //read from file and populate databank
                StreamReader datafile = new StreamReader(data_file_dir);
                string line;
                while((line=datafile.ReadLine())!=null)
                {
                    string[] segs = line.Split(delimeter);//delimeter is private static member of this class
                    try
                    {
                        int id = int.Parse(segs[0]);
                        DateTime f_date = new DateTime(int.Parse(segs[1]), int.Parse(segs[2]), int.Parse(segs[3]));
                        DateTime p_date = new DateTime(int.Parse(segs[4]), int.Parse(segs[5]), int.Parse(segs[6]));
                        string title = segs[7];
                        if(segs.Length>8)
                        {
                            for(int i=8;i<segs.Length;i++)
                            {
                                title += ",";
                                title += segs[i];
                            }
                        }
                        databank[id] = new FutureEntry(f_date, p_date, id, title);
                    }
                    catch
                    {
                        continue;
                    }
                    
                }
                datafile.Close();
            }
            else
            {
                File.Create(data_file_dir);
            }
            databank_modified = false;
            Data_Bank_Change += On_Data_Bank_Change;
        }

        #region methods
        //assuming this method is not called during initialization as it raises Data_Bank_Change event
        public void AddEntry(FutureEntry fe)
        {
            if(ForceUpdate||isNewerEntry(fe))
            {
                databank[fe.id] = fe;
                Data_Bank_Change(this,new EventArgs());
                databank_modified = true;
            }
        }

        public void update_data_file()
        {
            if (File.Exists(data_file_dir) == false)
                File.Create(data_file_dir);

            if (databank_modified == true)
            {
                StreamWriter writer = new StreamWriter(data_file_dir);
                foreach (var entry in databank)
                {
                    string line = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", entry.Value.id, entry.Value.found_date.Year,
                                                                                entry.Value.found_date.Month,
                                                                                entry.Value.found_date.Day,
                                                                                entry.Value.publication_date.Year,
                                                                                entry.Value.publication_date.Month,
                                                                                entry.Value.publication_date.Day,
                                                                                entry.Value.title);
                    writer.WriteLine(line);

                }
                writer.Close();
                databank_modified = false;
            }
        }

        public List<FutureEntry> ExportAsList()
        {

            if(databank.Count==0)
            {
                return null;
            }
            List<FutureEntry> ret=new List<FutureEntry>();
            foreach(KeyValuePair<int,FutureEntry> entry in databank)
            {
                ret.Add(entry.Value);
            }
            ret.Sort(FutureEntry.CompareByID);
            return ret;
        }

        private bool isNewerEntry(FutureEntry fe)
        {
            if (databank.ContainsKey(fe.id))
            {
                if (databank[fe.id].publication_date < fe.publication_date)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return true;
        }
        public void RemoveEntry(int id)
        {
            if(databank.ContainsKey(id))
            {
                databank.Remove(id);
                Data_Bank_Change(this, new EventArgs());
                databank_modified = true;
            }
        }
        #endregion
        #region event handlers
        public void On_Found_Future_Entry(object sender,ScannerEventArg arg)
        {
            //handles event

            FutureEntry fe = arg.Fe;
            AddEntry(fe);
            
            FE_Being_Processed(this, new ScannerEventArg(fe));
        }
        private void On_Data_Bank_Change(object sender,EventArgs arg)
        {
            //update file
            //UI should also handle Data_Bank_Change event
            update_data_file();
        }
        #endregion
        #region fields, protperties and events
        private Dictionary<int, FutureEntry> databank;
        private static string data_file_dir = "databank.txt";
        private static char[] delimeter = { ',' };

        public bool ForceUpdate
        { get; set; }
        private bool databank_modified
        {
            get; set;
        }
        public event EventHandler Data_Bank_Change;
        public delegate void StatusBarUpdateEventHandler (object sender, ScannerEventArg arg);
        public event StatusBarUpdateEventHandler FE_Being_Processed;
        #endregion
    }

}
namespace MyWebScan
{
    public partial class Scanner
    {
        //expose following event(s) to MainForm and EntryManager
        public event FEFoundEventHandler Found_Future_Entry_Event;
        public event EventHandler Done_Scanning;
        public event EventHandler Scanner_Current_ID_Auto_Change;
        public event EventHandler Connection_Error_Event;
    }
}
