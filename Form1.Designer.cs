namespace SQL_Backup_Tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label14 = new Label();
            label10 = new Label();
            label11 = new Label();
            button8 = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtServer = new TextBox();
            textBox2 = new TextBox();
            txtBackupLocation1 = new TextBox();
            txtBackupLocation2 = new TextBox();
            txtBackupLocation3 = new TextBox();
            textBox6 = new TextBox();
            btnReset = new Button();
            button2 = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            btnAddTime = new Button();
            dudAMPM = new DomainUpDown();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            cmbDatabases = new ComboBox();
            btnFolderBrowser1 = new Button();
            btnFolderBrowser2 = new Button();
            btnFolderBrowser3 = new Button();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            toolTip1 = new ToolTip(components);
            dudMinutes = new DomainUpDown();
            dudHours = new DomainUpDown();
            lstBackupTimes = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 248, 248);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 54);
            panel1.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(26, 26, 26);
            label14.Location = new Point(29, 32);
            label14.Name = "label14";
            label14.Size = new Size(34, 13);
            label14.TabIndex = 29;
            label14.Text = "v24.0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(26, 26, 26);
            label10.Location = new Point(25, 0);
            label10.Name = "label10";
            label10.Size = new Size(203, 32);
            label10.TabIndex = 0;
            label10.Text = "SQL Backup Tool";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(26, 26, 26);
            label11.Location = new Point(509, 26);
            label11.Name = "label11";
            label11.Size = new Size(175, 19);
            label11.TabIndex = 1;
            label11.Text = "Next Backup scheduled at ";
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Highlight;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(248, 248, 248);
            button8.Location = new Point(781, 17);
            button8.Name = "button8";
            button8.Size = new Size(116, 32);
            button8.TabIndex = 27;
            button8.Text = "Backup Now";
            button8.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(26, 26, 26);
            label3.Location = new Point(678, 21);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 30;
            label3.Text = "12:00 AM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(26, 26, 26);
            label1.Location = new Point(41, 88);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 1;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(26, 26, 26);
            label2.Location = new Point(41, 131);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 2;
            label2.Text = "Databases";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(26, 26, 26);
            label4.Location = new Point(41, 171);
            label4.Name = "label4";
            label4.Size = new Size(112, 19);
            label4.TabIndex = 4;
            label4.Text = "Backup Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(26, 26, 26);
            label5.Location = new Point(41, 200);
            label5.Name = "label5";
            label5.Size = new Size(173, 19);
            label5.TabIndex = 5;
            label5.Text = "Alternate Backup Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(41, 219);
            label6.Name = "label6";
            label6.Size = new Size(185, 15);
            label6.TabIndex = 6;
            label6.Text = "Network Location Recommended";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(26, 26, 26);
            label7.Location = new Point(41, 240);
            label7.Name = "label7";
            label7.Size = new Size(173, 19);
            label7.TabIndex = 7;
            label7.Text = "Alternate Backup Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(41, 259);
            label8.Name = "label8";
            label8.Size = new Size(198, 15);
            label8.TabIndex = 8;
            label8.Text = "Cloud Sync Location Recommended";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(26, 26, 26);
            label9.Location = new Point(41, 291);
            label9.Name = "label9";
            label9.Size = new Size(141, 19);
            label9.TabIndex = 9;
            label9.Text = "Backup Expiry (Days)";
            // 
            // txtServer
            // 
            txtServer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtServer.Location = new Point(268, 85);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(341, 29);
            txtServer.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(268, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 29);
            textBox2.TabIndex = 11;
            // 
            // txtBackupLocation1
            // 
            txtBackupLocation1.Anchor = AnchorStyles.Left;
            txtBackupLocation1.Font = new Font("Segoe UI", 12F);
            txtBackupLocation1.ForeColor = Color.FromArgb(64, 64, 64);
            txtBackupLocation1.Location = new Point(268, 165);
            txtBackupLocation1.Name = "txtBackupLocation1";
            txtBackupLocation1.Size = new Size(341, 29);
            txtBackupLocation1.TabIndex = 12;
            // 
            // txtBackupLocation2
            // 
            txtBackupLocation2.Font = new Font("Segoe UI", 12F);
            txtBackupLocation2.ForeColor = Color.FromArgb(64, 64, 64);
            txtBackupLocation2.Location = new Point(268, 205);
            txtBackupLocation2.Name = "txtBackupLocation2";
            txtBackupLocation2.Size = new Size(341, 29);
            txtBackupLocation2.TabIndex = 13;
            // 
            // txtBackupLocation3
            // 
            txtBackupLocation3.Font = new Font("Segoe UI", 12F);
            txtBackupLocation3.ForeColor = Color.FromArgb(64, 64, 64);
            txtBackupLocation3.Location = new Point(268, 245);
            txtBackupLocation3.Name = "txtBackupLocation3";
            txtBackupLocation3.Size = new Size(341, 29);
            txtBackupLocation3.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.ForeColor = Color.FromArgb(64, 64, 64);
            textBox6.Location = new Point(268, 285);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 29);
            textBox6.TabIndex = 15;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Window;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(26, 26, 26);
            btnReset.Location = new Point(374, 282);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 32);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(248, 248, 248);
            button2.Location = new Point(470, 282);
            button2.Name = "button2";
            button2.Size = new Size(139, 32);
            button2.TabIndex = 17;
            button2.Text = "Save Settings";
            button2.UseVisualStyleBackColor = false;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // btnAddTime
            // 
            btnAddTime.BackColor = SystemColors.Highlight;
            btnAddTime.Cursor = Cursors.Hand;
            btnAddTime.FlatAppearance.BorderSize = 0;
            btnAddTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTime.ForeColor = Color.FromArgb(248, 248, 248);
            btnAddTime.Image = Properties.Resources.plus_8_16;
            btnAddTime.Location = new Point(877, 279);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new Size(32, 32);
            btnAddTime.TabIndex = 24;
            btnAddTime.UseVisualStyleBackColor = false;
            btnAddTime.Click += btnAddTime_Click;
            btnAddTime.MouseHover += btnAddTime_MouseHover;
            // 
            // dudAMPM
            // 
            dudAMPM.BorderStyle = BorderStyle.FixedSingle;
            dudAMPM.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dudAMPM.ForeColor = Color.FromArgb(26, 26, 26);
            dudAMPM.Items.Add("AM");
            dudAMPM.Items.Add("PM");
            dudAMPM.Location = new Point(823, 282);
            dudAMPM.Name = "dudAMPM";
            dudAMPM.Size = new Size(48, 29);
            dudAMPM.TabIndex = 26;
            dudAMPM.Text = "AM";
            dudAMPM.Wrap = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(26, 26, 26);
            label12.Location = new Point(715, 83);
            label12.Name = "label12";
            label12.Size = new Size(91, 17);
            label12.TabIndex = 27;
            label12.Text = "Backup Times";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(41, 333);
            label13.Name = "label13";
            label13.Size = new Size(189, 13);
            label13.TabIndex = 28;
            label13.Text = "©Grapes Innovative Solutions 2024";
            // 
            // label15
            // 
            label15.BackColor = SystemColors.ControlDark;
            label15.ForeColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(678, 88);
            label15.Name = "label15";
            label15.Size = new Size(1, 222);
            label15.TabIndex = 29;
            // 
            // cmbDatabases
            // 
            cmbDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabases.Font = new Font("Segoe UI", 12F);
            cmbDatabases.FormattingEnabled = true;
            cmbDatabases.Location = new Point(132, 125);
            cmbDatabases.Name = "cmbDatabases";
            cmbDatabases.Size = new Size(121, 29);
            cmbDatabases.TabIndex = 31;
            cmbDatabases.MouseClick += cmbDatabases_MouseClick;
            // 
            // btnFolderBrowser1
            // 
            btnFolderBrowser1.BackColor = SystemColors.Window;
            btnFolderBrowser1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnFolderBrowser1.Location = new Point(615, 165);
            btnFolderBrowser1.Name = "btnFolderBrowser1";
            btnFolderBrowser1.Size = new Size(33, 29);
            btnFolderBrowser1.TabIndex = 32;
            btnFolderBrowser1.Text = "...";
            btnFolderBrowser1.TextAlign = ContentAlignment.TopCenter;
            btnFolderBrowser1.UseVisualStyleBackColor = false;
            // 
            // btnFolderBrowser2
            // 
            btnFolderBrowser2.BackColor = SystemColors.Window;
            btnFolderBrowser2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnFolderBrowser2.Location = new Point(615, 205);
            btnFolderBrowser2.Name = "btnFolderBrowser2";
            btnFolderBrowser2.Size = new Size(33, 29);
            btnFolderBrowser2.TabIndex = 33;
            btnFolderBrowser2.Text = "...";
            btnFolderBrowser2.TextAlign = ContentAlignment.TopCenter;
            btnFolderBrowser2.UseVisualStyleBackColor = false;
            // 
            // btnFolderBrowser3
            // 
            btnFolderBrowser3.BackColor = SystemColors.Window;
            btnFolderBrowser3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnFolderBrowser3.Location = new Point(615, 245);
            btnFolderBrowser3.Name = "btnFolderBrowser3";
            btnFolderBrowser3.Size = new Size(33, 29);
            btnFolderBrowser3.TabIndex = 34;
            btnFolderBrowser3.Text = "...";
            btnFolderBrowser3.TextAlign = ContentAlignment.TopCenter;
            btnFolderBrowser3.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic);
            label16.Location = new Point(715, 266);
            label16.Name = "label16";
            label16.Size = new Size(36, 13);
            label16.TabIndex = 35;
            label16.Text = "Hours";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic);
            label17.Location = new Point(769, 266);
            label17.Name = "label17";
            label17.Size = new Size(46, 13);
            label17.TabIndex = 36;
            label17.Text = "Minutes";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.Location = new Point(823, 266);
            label18.Name = "label18";
            label18.Size = new Size(44, 13);
            label18.TabIndex = 37;
            label18.Text = "AM/PM";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.BackColor = SystemColors.Window;
            toolTip1.ForeColor = Color.FromArgb(26, 26, 26);
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 100;
            // 
            // dudMinutes
            // 
            dudMinutes.BorderStyle = BorderStyle.FixedSingle;
            dudMinutes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dudMinutes.ForeColor = Color.FromArgb(26, 26, 26);
            dudMinutes.Items.Add("59");
            dudMinutes.Items.Add("58");
            dudMinutes.Items.Add("57");
            dudMinutes.Items.Add("56");
            dudMinutes.Items.Add("55");
            dudMinutes.Items.Add("54");
            dudMinutes.Items.Add("53");
            dudMinutes.Items.Add("52");
            dudMinutes.Items.Add("51");
            dudMinutes.Items.Add("50");
            dudMinutes.Items.Add("49");
            dudMinutes.Items.Add("48");
            dudMinutes.Items.Add("47");
            dudMinutes.Items.Add("46");
            dudMinutes.Items.Add("45");
            dudMinutes.Items.Add("44");
            dudMinutes.Items.Add("43");
            dudMinutes.Items.Add("42");
            dudMinutes.Items.Add("41");
            dudMinutes.Items.Add("40");
            dudMinutes.Items.Add("39");
            dudMinutes.Items.Add("38");
            dudMinutes.Items.Add("37");
            dudMinutes.Items.Add("36");
            dudMinutes.Items.Add("35");
            dudMinutes.Items.Add("34");
            dudMinutes.Items.Add("33");
            dudMinutes.Items.Add("32");
            dudMinutes.Items.Add("31");
            dudMinutes.Items.Add("30");
            dudMinutes.Items.Add("29");
            dudMinutes.Items.Add("28");
            dudMinutes.Items.Add("27");
            dudMinutes.Items.Add("26");
            dudMinutes.Items.Add("25");
            dudMinutes.Items.Add("24");
            dudMinutes.Items.Add("23");
            dudMinutes.Items.Add("22");
            dudMinutes.Items.Add("21");
            dudMinutes.Items.Add("20");
            dudMinutes.Items.Add("19");
            dudMinutes.Items.Add("18");
            dudMinutes.Items.Add("17");
            dudMinutes.Items.Add("16");
            dudMinutes.Items.Add("15");
            dudMinutes.Items.Add("14");
            dudMinutes.Items.Add("13");
            dudMinutes.Items.Add("12");
            dudMinutes.Items.Add("11");
            dudMinutes.Items.Add("10");
            dudMinutes.Items.Add("09");
            dudMinutes.Items.Add("08");
            dudMinutes.Items.Add("07");
            dudMinutes.Items.Add("06");
            dudMinutes.Items.Add("05");
            dudMinutes.Items.Add("04");
            dudMinutes.Items.Add("03");
            dudMinutes.Items.Add("02");
            dudMinutes.Items.Add("01");
            dudMinutes.Items.Add("00");
            dudMinutes.Location = new Point(769, 282);
            dudMinutes.Name = "dudMinutes";
            dudMinutes.Size = new Size(48, 29);
            dudMinutes.TabIndex = 38;
            dudMinutes.Text = "00";
            dudMinutes.Wrap = true;
            // 
            // dudHours
            // 
            dudHours.BorderStyle = BorderStyle.FixedSingle;
            dudHours.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dudHours.ForeColor = Color.FromArgb(26, 26, 26);
            dudHours.Items.Add("12");
            dudHours.Items.Add("11");
            dudHours.Items.Add("10");
            dudHours.Items.Add("09");
            dudHours.Items.Add("08");
            dudHours.Items.Add("07");
            dudHours.Items.Add("06");
            dudHours.Items.Add("05");
            dudHours.Items.Add("04");
            dudHours.Items.Add("03");
            dudHours.Items.Add("02");
            dudHours.Items.Add("01");
            dudHours.Location = new Point(715, 282);
            dudHours.Name = "dudHours";
            dudHours.Size = new Size(48, 29);
            dudHours.TabIndex = 39;
            dudHours.Text = "12";
            dudHours.Wrap = true;
            // 
            // lstBackupTimes
            // 
            lstBackupTimes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lstBackupTimes.FormattingEnabled = true;
            lstBackupTimes.ItemHeight = 21;
            lstBackupTimes.Location = new Point(715, 103);
            lstBackupTimes.Name = "lstBackupTimes";
            lstBackupTimes.Size = new Size(194, 151);
            lstBackupTimes.TabIndex = 40;
            lstBackupTimes.MouseHover += lstBackupTimes_MouseHover;
            lstBackupTimes.MouseUp += lstBackupTimes_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(951, 364);
            Controls.Add(lstBackupTimes);
            Controls.Add(dudHours);
            Controls.Add(dudMinutes);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(btnFolderBrowser3);
            Controls.Add(btnFolderBrowser2);
            Controls.Add(btnFolderBrowser1);
            Controls.Add(cmbDatabases);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(dudAMPM);
            Controls.Add(btnAddTime);
            Controls.Add(button2);
            Controls.Add(btnReset);
            Controls.Add(textBox6);
            Controls.Add(txtBackupLocation3);
            Controls.Add(txtBackupLocation2);
            Controls.Add(txtBackupLocation1);
            Controls.Add(textBox2);
            Controls.Add(txtServer);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL Backup Tool";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtServer;
        private TextBox textBox2;
        private TextBox txtBackupLocation1;
        private TextBox txtBackupLocation2;
        private TextBox txtBackupLocation3;
        private TextBox textBox6;
        private Button btnReset;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog;
        private Button btnFolderBrowser1;
        private Button btnFolderBrowser2;
        private Button btnFolderBrowser3;
        private Button btnAddTime;
        private DomainUpDown dudAMPM;
        private Label label10;
        private Label label11;
        private Button button8;
        private Label label14;
        private Label label12;
        private Label label13;
        private Label label3;
        private Label label15;
        private ComboBox cmbDatabases;
        private Label label16;
        private Label label17;
        private Label label18;
        private ToolTip toolTip1;
        private DomainUpDown dudMinutes;
        private DomainUpDown dudHours;
        private ListBox lstBackupTimes;
        private ContextMenuStrip contextMenuStrip1;
    }
}
