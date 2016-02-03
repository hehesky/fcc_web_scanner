namespace fcc_web_scanner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EntryListBox = new System.Windows.Forms.ListBox();
            this.RightHalfPanel = new System.Windows.Forms.Panel();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ScanDateTextBox = new System.Windows.Forms.TextBox();
            this.PublicationDateTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ScanDateLabel = new System.Windows.Forms.Label();
            this.PublicationDateLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ScannerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.RecentChangeLabel = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.StopButton = new System.Windows.Forms.Button();
            this.traynotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightHalfPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntryListBox
            // 
            this.EntryListBox.FormattingEnabled = true;
            this.EntryListBox.ItemHeight = 16;
            this.EntryListBox.Location = new System.Drawing.Point(12, 9);
            this.EntryListBox.Name = "EntryListBox";
            this.EntryListBox.ScrollAlwaysVisible = true;
            this.EntryListBox.Size = new System.Drawing.Size(233, 276);
            this.EntryListBox.TabIndex = 0;
            // 
            // RightHalfPanel
            // 
            this.RightHalfPanel.Controls.Add(this.LinkLabel);
            this.RightHalfPanel.Controls.Add(this.TitleTextBox);
            this.RightHalfPanel.Controls.Add(this.ScanDateTextBox);
            this.RightHalfPanel.Controls.Add(this.PublicationDateTextBox);
            this.RightHalfPanel.Controls.Add(this.TitleLabel);
            this.RightHalfPanel.Controls.Add(this.ScanDateLabel);
            this.RightHalfPanel.Controls.Add(this.PublicationDateLabel);
            this.RightHalfPanel.Controls.Add(this.IDTextBox);
            this.RightHalfPanel.Controls.Add(this.IDLabel);
            this.RightHalfPanel.Location = new System.Drawing.Point(248, 12);
            this.RightHalfPanel.Name = "RightHalfPanel";
            this.RightHalfPanel.Size = new System.Drawing.Size(362, 234);
            this.RightHalfPanel.TabIndex = 1;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(28, 195);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(108, 17);
            this.LinkLabel.TabIndex = 6;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Open Webpage";
            this.LinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleTextBox.Location = new System.Drawing.Point(150, 148);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(209, 86);
            this.TitleTextBox.TabIndex = 5;
            // 
            // ScanDateTextBox
            // 
            this.ScanDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScanDateTextBox.Location = new System.Drawing.Point(150, 113);
            this.ScanDateTextBox.Name = "ScanDateTextBox";
            this.ScanDateTextBox.ReadOnly = true;
            this.ScanDateTextBox.Size = new System.Drawing.Size(138, 22);
            this.ScanDateTextBox.TabIndex = 5;
            // 
            // PublicationDateTextBox
            // 
            this.PublicationDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PublicationDateTextBox.Location = new System.Drawing.Point(150, 71);
            this.PublicationDateTextBox.Name = "PublicationDateTextBox";
            this.PublicationDateTextBox.ReadOnly = true;
            this.PublicationDateTextBox.Size = new System.Drawing.Size(138, 22);
            this.PublicationDateTextBox.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(31, 153);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // ScanDateLabel
            // 
            this.ScanDateLabel.AutoSize = true;
            this.ScanDateLabel.Location = new System.Drawing.Point(28, 113);
            this.ScanDateLabel.Name = "ScanDateLabel";
            this.ScanDateLabel.Size = new System.Drawing.Size(98, 17);
            this.ScanDateLabel.TabIndex = 3;
            this.ScanDateLabel.Text = "Date Scanned";
            // 
            // PublicationDateLabel
            // 
            this.PublicationDateLabel.AutoSize = true;
            this.PublicationDateLabel.Location = new System.Drawing.Point(28, 71);
            this.PublicationDateLabel.Name = "PublicationDateLabel";
            this.PublicationDateLabel.Size = new System.Drawing.Size(111, 17);
            this.PublicationDateLabel.TabIndex = 2;
            this.PublicationDateLabel.Text = "Publication Date";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.IDTextBox.Location = new System.Drawing.Point(150, 23);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(138, 22);
            this.IDTextBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(28, 28);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScannerStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ScannerStatusLabel
            // 
            this.ScannerStatusLabel.Name = "ScannerStatusLabel";
            this.ScannerStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.ScannerStatusLabel.Text = "Status";
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(287, 80);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(183, 28);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Pause Scanning";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(287, 12);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(183, 29);
            this.ResumeButton.TabIndex = 4;
            this.ResumeButton.Text = "Resume Scanning";
            this.ResumeButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(206, 207);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(183, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(32, 62);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(183, 28);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // RecentChangeLabel
            // 
            this.RecentChangeLabel.AutoEllipsis = true;
            this.RecentChangeLabel.AutoSize = true;
            this.RecentChangeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RecentChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentChangeLabel.Location = new System.Drawing.Point(3, 3);
            this.RecentChangeLabel.MinimumSize = new System.Drawing.Size(1, 10);
            this.RecentChangeLabel.Name = "RecentChangeLabel";
            this.RecentChangeLabel.Size = new System.Drawing.Size(203, 20);
            this.RecentChangeLabel.TabIndex = 7;
            this.RecentChangeLabel.Text = "Most recently found entry:";
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatePanel.Controls.Add(this.RecentChangeLabel);
            this.updatePanel.Location = new System.Drawing.Point(248, 252);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(362, 30);
            this.updatePanel.TabIndex = 8;
            this.updatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.updatePanel_Paint);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(287, 144);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(183, 30);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop and Reset Scanner";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // traynotifyIcon
            // 
            this.traynotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.traynotifyIcon.BalloonTipText = "The Scanner is minimized over here";
            this.traynotifyIcon.BalloonTipTitle = "Minimized Scanner";
            this.traynotifyIcon.Text = "notify icon";
            this.traynotifyIcon.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ResumeButton);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.PauseButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 240);
            this.panel1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(649, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RightHalfPanel);
            this.Controls.Add(this.EntryListBox);
            this.Name = "MainForm";
            this.Text = "FCC Web Scanner";
            this.RightHalfPanel.ResumeLayout(false);
            this.RightHalfPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EntryListBox;
        private System.Windows.Forms.Panel RightHalfPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ScannerStatusLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox ScanDateTextBox;
        private System.Windows.Forms.TextBox PublicationDateTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ScanDateLabel;
        private System.Windows.Forms.Label PublicationDateLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label RecentChangeLabel;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.NotifyIcon traynotifyIcon;
        private System.Windows.Forms.Panel panel1;
    }
}

