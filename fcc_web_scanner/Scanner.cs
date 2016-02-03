using System;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyWebScan //it's just a name
{
    
    public class ScannerEventArg:EventArgs
    {
        public ScannerEventArg(FutureEntry _fe)
        {
            fe = _fe;
        }
        private FutureEntry fe;
        public FutureEntry Fe
        {
            get
            {
                return fe;
            }
        }
    }
    
    /// <summary>
    /// contains information about a "future entry" found by scanner
    /// </summary>
    public class FutureEntry //create a FutureEntry class object to pass along the "future entry" found by scanner
    {
        public FutureEntry(DateTime _found_date, DateTime _publication_date, int _id, string _title)
        {
            found_date = _found_date;
            id = _id;
            publication_date = _publication_date;
            title = _title;
        }
        static public int CompareByID(FutureEntry x, FutureEntry y)
        {
            if (x.id < y.id)
            {
                return -1;
            }
            else if (x.id > y.id)
            {
                return 1;
            }
            else
                return 0;
        }
        static public int CompareByFoundDate(FutureEntry x, FutureEntry y)
        {
            if (x.found_date < y.found_date)
            {
                return -1;
            }
            else if (x.found_date > y.found_date)
            {
                return 1;
            }
            else
                return 0;
        }
        static public int CompareByPublicationDate(FutureEntry x, FutureEntry y)
        {
            if (x.publication_date < y.publication_date)
            {
                return -1;
            }
            else if (x.publication_date > y.publication_date)
            {
                return 1;
            }
            else
                return 0;
        }
        /// <summary>
        /// convert FE object into string; shows id and title
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return id.ToString()+" "+title;
        }
        public DateTime found_date { get; set; }
        public DateTime publication_date { get; set; }
        public int id { get; set; }
        public string title { get; set; }

    }
/// <summary>
/// scans FCC website and look for webpages published "in the future" 
/// </summary>
    public partial class Scanner
    {
        public delegate void FEFoundEventHandler(object sender, ScannerEventArg arg); //delegate for the event of finding a future entry
        public Scanner(int _min_id=10000, int _max_id=60000)
        {
            min_id = _min_id;
            max_id = _max_id;
            client = new WebClient();
            KeepScanning = false;
            
            
        }
        #region Methods
        

        public void DumpCurrentState()
        {
            if(!File.Exists(DumpDir))
            {
                File.Create(DumpDir);
            }
            StreamWriter dump_writer = new StreamWriter(DumpDir);
            if(Current_id>max_id||Current_id<min_id)
            {
                dump_writer.WriteLine("null");
            }
            else
            {
                dump_writer.WriteLine(Current_id.ToString());
            }
            dump_writer.Close();

        }
        public bool RecoverLastScan()
        {
            bool ret=false;
            if (File.Exists(DumpDir))
            {
                StreamReader reader = new StreamReader(DumpDir);
                string line = reader.ReadLine();
                try
                {
                    int i = int.Parse(line);
                    Current_id = i;
                    if (i == min_id)
                        ret = false;
                    else
                        ret = true;
                }
                catch
                {
                    Current_id = min_id;
                }
                reader.Close();
            }
            return ret;
        }

        private string process_title(string rough_t)
        {
            string ret = rough_t.Replace("&nbsp;", " ");
            ret = ret.Replace("<BR>", "\n");
            
            
            ret = ret.Replace("</DIV>", "");
            ret = ret.Replace("</P>", "");
            Regex left_span_regex = new Regex("<SPAN[^>]*>");
            Regex right_span_regex = new Regex("</SPAN>");
            
            ret = left_span_regex.Replace(ret, "");
            ret = right_span_regex.Replace(ret, "");

            ret = new Regex("<DIV[^>]*>").Replace(ret, "");
            ret = new Regex("<P[^>]*>").Replace(ret, "");
            ret = new Regex("^\\s+").Replace(ret, "");

            return ret;
        }
        public void do_full_scan(object s_id)
        {
            
            int starting_id = (int)s_id;
            if (starting_id < min_id)
                Current_id = min_id;
            else if (starting_id > max_id)
                Current_id = min_id;
            else
                Current_id = starting_id;

            while (KeepScanning && Current_id <=max_id)
            {
                scan_by_id(Current_id);
                Current_id += 1;                
            }
            if(Current_id>max_id)
            {
                Current_id = min_id;
                Done_Scanning(this,new EventArgs());
            }
            //MessageBox.Show("Done");
        }
        private void scan_by_id(int id)
        {
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)"); //set headers
            string url = "https://apps.fcc.gov/oetcf/kdb/forms/FTSSearchResultPage.cfm?id=" + id.ToString() + "&switch=P";
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string html = reader.ReadToEnd();
            reader.Close();
            //search for a date
            Match date_m = date_regex.Match(html);
            if (date_m.Success) //found a date
            {
                string year = date_m.Groups[3].Value;
                string month = date_m.Groups[1].Value;
                string day = date_m.Groups[2].Value;
                DateTime publication_date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

                
                if (true)//publication_date > DateTime.Today)
                {
                    string title;
                    //search for title
                    Match title_m = title_regex.Match(html);
                    if (title_m.Success)
                    {
                        title = title_m.Groups[1].Value;
                        title = process_title(title);

                    }
                    else
                    {
                        title = "No title";
                    }
                    FutureEntry fe = new FutureEntry(DateTime.Today, publication_date, id, title);
                    //raise an event that emits a notification object
                    
                    Found_Future_Entry_Event(this,new ScannerEventArg(fe));
                }
                
            }
                            
        }
        #endregion
        
        #region event handler
        //create pause/resume scanning event in Form1.cs
        public void on_pause_required()
        {
            KeepScanning = false;
        }
        public void on_resume_require()
        {
            KeepScanning = true;
        }
        

        #endregion
        #region events,properties and fields
        public bool KeepScanning { get; set; } //change back to private later
        public int Current_id { get; set; }
        public int MinID { get { return min_id; } }
        private int min_id;
        private int max_id;
        private WebClient client;
        static private string date_search_pattern = @"Publication Date.+(\d\d).+(\d\d).+(\d\d\d\d)";
        static private string title_search_pattern = @"<TD> <B> Question: <\/B>(.*)<\/TD>";
        static private Regex date_regex = new Regex(date_search_pattern);
        static private Regex title_regex = new Regex(title_search_pattern);
        static public string DumpDir = "scanner_state.txt";
        #endregion
    }
}