﻿namespace fcc_web_scanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.EntryCountTextBox = new System.Windows.Forms.TextBox();
            this.EntryCountLabel = new System.Windows.Forms.Label();
            this.ForceUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.EntryButtonsLabel = new System.Windows.Forms.Label();
            this.CurrentIDTextBox = new System.Windows.Forms.TextBox();
            this.CurrentIDLabel = new System.Windows.Forms.Label();
            this.JumpPanel = new System.Windows.Forms.Panel();
            this.JumpIDNumericInput = new System.Windows.Forms.NumericUpDown();
            this.JumpButton = new System.Windows.Forms.Button();
            this.JumpIDLabel = new System.Windows.Forms.Label();
            this.SortByIDButton = new System.Windows.Forms.Button();
            this.SortByDateButton = new System.Windows.Forms.Button();
            this.RightHalfPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.JumpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpIDNumericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // EntryListBox
            // 
            this.EntryListBox.FormattingEnabled = true;
            this.EntryListBox.ItemHeight = 16;
            this.EntryListBox.Location = new System.Drawing.Point(3, 9);
            this.EntryListBox.Name = "EntryListBox";
            this.EntryListBox.ScrollAlwaysVisible = true;
            this.EntryListBox.Size = new System.Drawing.Size(242, 276);
            this.EntryListBox.TabIndex = 0;
            // 
            // RightHalfPanel
            // 
            this.RightHalfPanel.AutoSize = true;
            this.RightHalfPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightHalfPanel.Controls.Add(this.LinkLabel);
            this.RightHalfPanel.Controls.Add(this.TitleTextBox);
            this.RightHalfPanel.Controls.Add(this.ScanDateTextBox);
            this.RightHalfPanel.Controls.Add(this.PublicationDateTextBox);
            this.RightHalfPanel.Controls.Add(this.TitleLabel);
            this.RightHalfPanel.Controls.Add(this.ScanDateLabel);
            this.RightHalfPanel.Controls.Add(this.PublicationDateLabel);
            this.RightHalfPanel.Controls.Add(this.IDTextBox);
            this.RightHalfPanel.Controls.Add(this.IDLabel);
            this.RightHalfPanel.Location = new System.Drawing.Point(245, 12);
            this.RightHalfPanel.Name = "RightHalfPanel";
            this.RightHalfPanel.Size = new System.Drawing.Size(416, 237);
            this.RightHalfPanel.TabIndex = 1;
            this.RightHalfPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RightHalfPanel_Paint);
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.Location = new System.Drawing.Point(28, 198);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(120, 17);
            this.LinkLabel.TabIndex = 6;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Open Webpage";
            this.LinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(150, 153);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TitleTextBox.Size = new System.Drawing.Size(263, 81);
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
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(31, 153);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(76, 18);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title/Topic";
            // 
            // ScanDateLabel
            // 
            this.ScanDateLabel.AutoSize = true;
            this.ScanDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanDateLabel.Location = new System.Drawing.Point(28, 113);
            this.ScanDateLabel.Name = "ScanDateLabel";
            this.ScanDateLabel.Size = new System.Drawing.Size(101, 18);
            this.ScanDateLabel.TabIndex = 3;
            this.ScanDateLabel.Text = "Date Scanned";
            // 
            // PublicationDateLabel
            // 
            this.PublicationDateLabel.AutoSize = true;
            this.PublicationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicationDateLabel.Location = new System.Drawing.Point(28, 71);
            this.PublicationDateLabel.Name = "PublicationDateLabel";
            this.PublicationDateLabel.Size = new System.Drawing.Size(115, 18);
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
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(28, 23);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(22, 18);
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
            this.statusStrip1.Size = new System.Drawing.Size(670, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ScannerStatusLabel
            // 
            this.ScannerStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ScannerStatusLabel.Name = "ScannerStatusLabel";
            this.ScannerStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.ScannerStatusLabel.Text = "Status";
            // 
            // PauseButton
            // 
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PauseButton.Location = new System.Drawing.Point(460, 85);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(183, 28);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Pause Scanning";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // ResumeButton
            // 
            this.ResumeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResumeButton.Location = new System.Drawing.Point(460, 33);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(183, 28);
            this.ResumeButton.TabIndex = 4;
            this.ResumeButton.Text = "Start/Resume Scanning";
            this.ResumeButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(460, 210);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(183, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(3, 135);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(180, 28);
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
            this.updatePanel.Size = new System.Drawing.Size(410, 30);
            this.updatePanel.TabIndex = 8;
            this.updatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.updatePanel_Paint);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(460, 135);
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
            this.traynotifyIcon.BalloonTipTitle = "FCC Web Scanner";
            this.traynotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("traynotifyIcon.Icon")));
            this.traynotifyIcon.Text = "FCC Web Scanner";
            this.traynotifyIcon.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EntryCountTextBox);
            this.panel1.Controls.Add(this.EntryCountLabel);
            this.panel1.Controls.Add(this.ForceUpdateCheckBox);
            this.panel1.Controls.Add(this.EntryButtonsLabel);
            this.panel1.Controls.Add(this.CurrentIDTextBox);
            this.panel1.Controls.Add(this.CurrentIDLabel);
            this.panel1.Controls.Add(this.JumpPanel);
            this.panel1.Controls.Add(this.ResumeButton);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.SortByIDButton);
            this.panel1.Controls.Add(this.SortByDateButton);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.PauseButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 240);
            this.panel1.TabIndex = 10;
            // 
            // EntryCountTextBox
            // 
            this.EntryCountTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EntryCountTextBox.Location = new System.Drawing.Point(112, 210);
            this.EntryCountTextBox.Name = "EntryCountTextBox";
            this.EntryCountTextBox.ReadOnly = true;
            this.EntryCountTextBox.Size = new System.Drawing.Size(48, 22);
            this.EntryCountTextBox.TabIndex = 19;
            this.EntryCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EntryCountLabel
            // 
            this.EntryCountLabel.AutoSize = true;
            this.EntryCountLabel.Location = new System.Drawing.Point(13, 210);
            this.EntryCountLabel.Name = "EntryCountLabel";
            this.EntryCountLabel.Size = new System.Drawing.Size(92, 17);
            this.EntryCountLabel.TabIndex = 18;
            this.EntryCountLabel.Text = "Total Entries:";
            // 
            // ForceUpdateCheckBox
            // 
            this.ForceUpdateCheckBox.AutoSize = true;
            this.ForceUpdateCheckBox.Location = new System.Drawing.Point(16, 181);
            this.ForceUpdateCheckBox.Name = "ForceUpdateCheckBox";
            this.ForceUpdateCheckBox.Size = new System.Drawing.Size(337, 21);
            this.ForceUpdateCheckBox.TabIndex = 17;
            this.ForceUpdateCheckBox.Text = "update the entry list even if it is NOT a new entry";
            this.ForceUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // EntryButtonsLabel
            // 
            this.EntryButtonsLabel.AutoSize = true;
            this.EntryButtonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryButtonsLabel.Location = new System.Drawing.Point(13, 0);
            this.EntryButtonsLabel.Name = "EntryButtonsLabel";
            this.EntryButtonsLabel.Size = new System.Drawing.Size(147, 18);
            this.EntryButtonsLabel.TabIndex = 16;
            this.EntryButtonsLabel.Text = "Entry Display Control";
            // 
            // CurrentIDTextBox
            // 
            this.CurrentIDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CurrentIDTextBox.Location = new System.Drawing.Point(314, 25);
            this.CurrentIDTextBox.Name = "CurrentIDTextBox";
            this.CurrentIDTextBox.ReadOnly = true;
            this.CurrentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.CurrentIDTextBox.TabIndex = 15;
            // 
            // CurrentIDLabel
            // 
            this.CurrentIDLabel.AutoSize = true;
            this.CurrentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIDLabel.Location = new System.Drawing.Point(217, 25);
            this.CurrentIDLabel.Name = "CurrentIDLabel";
            this.CurrentIDLabel.Size = new System.Drawing.Size(90, 18);
            this.CurrentIDLabel.TabIndex = 14;
            this.CurrentIDLabel.Text = "Current ID:";
            // 
            // JumpPanel
            // 
            this.JumpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JumpPanel.Controls.Add(this.JumpIDNumericInput);
            this.JumpPanel.Controls.Add(this.JumpButton);
            this.JumpPanel.Controls.Add(this.JumpIDLabel);
            this.JumpPanel.Location = new System.Drawing.Point(217, 54);
            this.JumpPanel.Name = "JumpPanel";
            this.JumpPanel.Size = new System.Drawing.Size(200, 111);
            this.JumpPanel.TabIndex = 13;
            // 
            // JumpIDNumericInput
            // 
            this.JumpIDNumericInput.Location = new System.Drawing.Point(29, 41);
            this.JumpIDNumericInput.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.JumpIDNumericInput.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.JumpIDNumericInput.Name = "JumpIDNumericInput";
            this.JumpIDNumericInput.Size = new System.Drawing.Size(77, 22);
            this.JumpIDNumericInput.TabIndex = 14;
            this.JumpIDNumericInput.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // JumpButton
            // 
            this.JumpButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.JumpButton.Location = new System.Drawing.Point(77, 80);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(122, 28);
            this.JumpButton.TabIndex = 12;
            this.JumpButton.Text = "Pause and Jump";
            this.JumpButton.UseVisualStyleBackColor = true;
            // 
            // JumpIDLabel
            // 
            this.JumpIDLabel.AutoSize = true;
            this.JumpIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumpIDLabel.Location = new System.Drawing.Point(11, 9);
            this.JumpIDLabel.Name = "JumpIDLabel";
            this.JumpIDLabel.Size = new System.Drawing.Size(95, 18);
            this.JumpIDLabel.TabIndex = 11;
            this.JumpIDLabel.Text = "Jump to ID:";
            // 
            // SortByIDButton
            // 
            this.SortByIDButton.Location = new System.Drawing.Point(3, 85);
            this.SortByIDButton.Name = "SortByIDButton";
            this.SortByIDButton.Size = new System.Drawing.Size(183, 28);
            this.SortByIDButton.TabIndex = 6;
            this.SortByIDButton.Text = "Sort by ID";
            this.SortByIDButton.UseVisualStyleBackColor = true;
            // 
            // SortByDateButton
            // 
            this.SortByDateButton.Location = new System.Drawing.Point(3, 33);
            this.SortByDateButton.Name = "SortByDateButton";
            this.SortByDateButton.Size = new System.Drawing.Size(183, 28);
            this.SortByDateButton.TabIndex = 6;
            this.SortByDateButton.Text = "Sort by Publication Date";
            this.SortByDateButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(670, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RightHalfPanel);
            this.Controls.Add(this.EntryListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 600);
            this.Name = "MainForm";
            this.Text = "FCC Web Scanner";
            this.RightHalfPanel.ResumeLayout(false);
            this.RightHalfPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.JumpPanel.ResumeLayout(false);
            this.JumpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpIDNumericInput)).EndInit();
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
        private System.Windows.Forms.Panel JumpPanel;
        private System.Windows.Forms.Button JumpButton;
        private System.Windows.Forms.Label JumpIDLabel;
        private System.Windows.Forms.Button SortByIDButton;
        private System.Windows.Forms.Button SortByDateButton;
        private System.Windows.Forms.NumericUpDown JumpIDNumericInput;
        private System.Windows.Forms.TextBox CurrentIDTextBox;
        private System.Windows.Forms.Label CurrentIDLabel;
        private System.Windows.Forms.Label EntryButtonsLabel;
        private System.Windows.Forms.CheckBox ForceUpdateCheckBox;
        private System.Windows.Forms.TextBox EntryCountTextBox;
        private System.Windows.Forms.Label EntryCountLabel;
    }
}

