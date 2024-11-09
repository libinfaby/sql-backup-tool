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
            lblTomorrow = new Label();
            lblNextBackupTime = new Label();
            lblNextBackupMsg = new Label();
            label14 = new Label();
            btnBackup = new Button();
            label10 = new Label();
            btnRefreshDB = new Button();
            txtPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label9 = new Label();
            txtDatabases = new TextBox();
            txtBackupLocation = new TextBox();
            txtExpiry = new TextBox();
            btnReset = new Button();
            btnSaveSettings = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            btnAddTime = new Button();
            label12 = new Label();
            label13 = new Label();
            cmbDatabases = new ComboBox();
            btnFolderBrowser1 = new Button();
            toolTip1 = new ToolTip(components);
            lstBackupTimes = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label5 = new Label();
            btnAddLocation = new Button();
            txtBackupRemark = new TextBox();
            dtpBackupTime = new DateTimePicker();
            lstBackupLocations = new ListView();
            lstViewColHeader1 = new ColumnHeader();
            lstViewColHeader2 = new ColumnHeader();
            label7 = new Label();
            cmbSqlServer = new ComboBox();
            label8 = new Label();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(lblTomorrow);
            panel1.Controls.Add(lblNextBackupTime);
            panel1.Controls.Add(lblNextBackupMsg);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(btnBackup);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnRefreshDB);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 46);
            panel1.TabIndex = 0;
            // 
            // lblTomorrow
            // 
            lblTomorrow.Anchor = AnchorStyles.None;
            lblTomorrow.AutoSize = true;
            lblTomorrow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTomorrow.ForeColor = SystemColors.ControlDarkDark;
            lblTomorrow.Location = new Point(727, 14);
            lblTomorrow.Name = "lblTomorrow";
            lblTomorrow.Size = new Size(43, 17);
            lblTomorrow.TabIndex = 42;
            lblTomorrow.Text = "today";
            lblTomorrow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNextBackupTime
            // 
            lblNextBackupTime.Anchor = AnchorStyles.None;
            lblNextBackupTime.AutoSize = true;
            lblNextBackupTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNextBackupTime.ForeColor = Color.FromArgb(0, 95, 184);
            lblNextBackupTime.Location = new Point(664, 14);
            lblNextBackupTime.Name = "lblNextBackupTime";
            lblNextBackupTime.Size = new Size(64, 17);
            lblNextBackupTime.TabIndex = 30;
            lblNextBackupTime.Text = "00:00 AM";
            lblNextBackupTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNextBackupMsg
            // 
            lblNextBackupMsg.Anchor = AnchorStyles.None;
            lblNextBackupMsg.AutoSize = true;
            lblNextBackupMsg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNextBackupMsg.ForeColor = SystemColors.ControlDarkDark;
            lblNextBackupMsg.Location = new Point(492, 14);
            lblNextBackupMsg.Name = "lblNextBackupMsg";
            lblNextBackupMsg.Size = new Size(173, 17);
            lblNextBackupMsg.TabIndex = 1;
            lblNextBackupMsg.Text = "Next Backup scheduled for";
            lblNextBackupMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(26, 26, 26);
            label14.Location = new Point(172, 20);
            label14.Name = "label14";
            label14.Size = new Size(27, 13);
            label14.TabIndex = 29;
            label14.Text = "v1.0";
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.FromArgb(0, 95, 184);
            btnBackup.Cursor = Cursors.Hand;
            btnBackup.FlatAppearance.BorderSize = 0;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackup.ForeColor = Color.FromArgb(248, 248, 248);
            btnBackup.Location = new Point(787, 10);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(114, 25);
            btnBackup.TabIndex = 27;
            btnBackup.Text = "Backup Now";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(26, 26, 26);
            label10.Location = new Point(14, 11);
            label10.Name = "label10";
            label10.Size = new Size(161, 25);
            label10.TabIndex = 0;
            label10.Text = "SQL Backup Tool";
            // 
            // btnRefreshDB
            // 
            btnRefreshDB.BackColor = Color.FromArgb(248, 248, 248);
            btnRefreshDB.BackgroundImage = Properties.Resources.refresh;
            btnRefreshDB.BackgroundImageLayout = ImageLayout.Center;
            btnRefreshDB.FlatAppearance.BorderSize = 0;
            btnRefreshDB.FlatStyle = FlatStyle.Flat;
            btnRefreshDB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRefreshDB.Location = new Point(205, 14);
            btnRefreshDB.Name = "btnRefreshDB";
            btnRefreshDB.Size = new Size(24, 25);
            btnRefreshDB.TabIndex = 41;
            btnRefreshDB.TextAlign = ContentAlignment.TopCenter;
            btnRefreshDB.UseVisualStyleBackColor = false;
            btnRefreshDB.Visible = false;
            btnRefreshDB.Click += btnRefreshDB_Click;
            btnRefreshDB.MouseHover += btnRefreshDB_MouseHover;
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPort.Location = new Point(287, 70);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(74, 25);
            txtPort.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(26, 26, 26);
            label1.Location = new Point(26, 50);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 1;
            label1.Text = "Server\\Instance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(26, 26, 26);
            label2.Location = new Point(367, 50);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 2;
            label2.Text = "Databases";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(26, 26, 26);
            label4.Location = new Point(344, 100);
            label4.Name = "label4";
            label4.Size = new Size(115, 17);
            label4.TabIndex = 4;
            label4.Text = "Location Remarks";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(139, 102);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 6;
            label6.Text = "Add Backup Locations";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(26, 26, 26);
            label9.Location = new Point(799, 102);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 9;
            label9.Text = "Expiry (Days)";
            // 
            // txtDatabases
            // 
            txtDatabases.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDatabases.ForeColor = Color.FromArgb(64, 64, 64);
            txtDatabases.Location = new Point(504, 70);
            txtDatabases.Name = "txtDatabases";
            txtDatabases.Size = new Size(409, 25);
            txtDatabases.TabIndex = 11;
            // 
            // txtBackupLocation
            // 
            txtBackupLocation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtBackupLocation.ForeColor = Color.FromArgb(64, 64, 64);
            txtBackupLocation.Location = new Point(26, 120);
            txtBackupLocation.Name = "txtBackupLocation";
            txtBackupLocation.Size = new Size(281, 25);
            txtBackupLocation.TabIndex = 12;
            // 
            // txtExpiry
            // 
            txtExpiry.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtExpiry.ForeColor = Color.FromArgb(64, 64, 64);
            txtExpiry.Location = new Point(799, 122);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(114, 25);
            txtExpiry.TabIndex = 15;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Lavender;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(26, 26, 26);
            btnReset.Location = new Point(799, 235);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 25);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = Color.FromArgb(0, 95, 184);
            btnSaveSettings.Cursor = Cursors.Hand;
            btnSaveSettings.FlatAppearance.BorderSize = 0;
            btnSaveSettings.FlatStyle = FlatStyle.Flat;
            btnSaveSettings.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveSettings.ForeColor = Color.FromArgb(248, 248, 248);
            btnSaveSettings.Location = new Point(799, 266);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(114, 25);
            btnSaveSettings.TabIndex = 17;
            btnSaveSettings.Text = "Save Settings";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // btnAddTime
            // 
            btnAddTime.BackColor = Color.FromArgb(248, 248, 248);
            btnAddTime.Cursor = Cursors.Hand;
            btnAddTime.FlatAppearance.BorderSize = 0;
            btnAddTime.FlatStyle = FlatStyle.Flat;
            btnAddTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTime.ForeColor = Color.FromArgb(248, 248, 248);
            btnAddTime.Image = Properties.Resources.add_dark;
            btnAddTime.Location = new Point(764, 121);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new Size(25, 25);
            btnAddTime.TabIndex = 24;
            btnAddTime.UseVisualStyleBackColor = false;
            btnAddTime.Click += btnAddTime_Click;
            btnAddTime.MouseEnter += btnAddTime_MouseEnter;
            btnAddTime.MouseLeave += btnAddTime_MouseLeave;
            btnAddTime.MouseHover += btnAddTime_MouseHover;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(26, 26, 26);
            label12.Location = new Point(667, 100);
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
            label13.Location = new Point(26, 296);
            label13.Name = "label13";
            label13.Size = new Size(189, 13);
            label13.TabIndex = 28;
            label13.Text = "©Grapes Innovative Solutions 2024";
            // 
            // cmbDatabases
            // 
            cmbDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabases.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDatabases.FormattingEnabled = true;
            cmbDatabases.Location = new Point(367, 70);
            cmbDatabases.Name = "cmbDatabases";
            cmbDatabases.Size = new Size(131, 25);
            cmbDatabases.TabIndex = 31;
            cmbDatabases.SelectedIndexChanged += cmbDatabases_SelectedIndexChanged;
            // 
            // btnFolderBrowser1
            // 
            btnFolderBrowser1.BackColor = Color.FromArgb(248, 248, 248);
            btnFolderBrowser1.Cursor = Cursors.Hand;
            btnFolderBrowser1.FlatAppearance.BorderSize = 0;
            btnFolderBrowser1.FlatStyle = FlatStyle.Flat;
            btnFolderBrowser1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnFolderBrowser1.Image = Properties.Resources.folder_dark;
            btnFolderBrowser1.Location = new Point(310, 121);
            btnFolderBrowser1.Name = "btnFolderBrowser1";
            btnFolderBrowser1.Size = new Size(25, 25);
            btnFolderBrowser1.TabIndex = 32;
            btnFolderBrowser1.UseVisualStyleBackColor = false;
            btnFolderBrowser1.Click += btnFolderBrowser1_Click;
            btnFolderBrowser1.MouseEnter += btnFolderBrowser1_MouseEnter;
            btnFolderBrowser1.MouseLeave += btnFolderBrowser1_MouseLeave;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.BackColor = SystemColors.Window;
            toolTip1.ForeColor = Color.FromArgb(26, 26, 26);
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 100;
            // 
            // lstBackupTimes
            // 
            lstBackupTimes.BackColor = Color.Lavender;
            lstBackupTimes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstBackupTimes.FormattingEnabled = true;
            lstBackupTimes.ItemHeight = 17;
            lstBackupTimes.Location = new Point(667, 151);
            lstBackupTimes.Name = "lstBackupTimes";
            lstBackupTimes.Size = new Size(122, 140);
            lstBackupTimes.TabIndex = 40;
            lstBackupTimes.MouseHover += lstBackupTimes_MouseHover;
            lstBackupTimes.MouseUp += lstBackupTimes_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(26, 26, 26);
            label5.Location = new Point(26, 100);
            label5.Name = "label5";
            label5.Size = new Size(107, 17);
            label5.TabIndex = 43;
            label5.Text = "Backup Location";
            // 
            // btnAddLocation
            // 
            btnAddLocation.BackColor = Color.FromArgb(248, 248, 248);
            btnAddLocation.Cursor = Cursors.Hand;
            btnAddLocation.FlatAppearance.BorderSize = 0;
            btnAddLocation.FlatStyle = FlatStyle.Flat;
            btnAddLocation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddLocation.ForeColor = Color.FromArgb(248, 248, 248);
            btnAddLocation.Image = Properties.Resources.add_dark;
            btnAddLocation.Location = new Point(629, 120);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(25, 25);
            btnAddLocation.TabIndex = 44;
            btnAddLocation.UseVisualStyleBackColor = false;
            btnAddLocation.Click += btnAddLocation_Click;
            btnAddLocation.MouseEnter += btnAddLocation_MouseEnter;
            btnAddLocation.MouseLeave += btnAddLocation_MouseLeave;
            // 
            // txtBackupRemark
            // 
            txtBackupRemark.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtBackupRemark.ForeColor = Color.FromArgb(64, 64, 64);
            txtBackupRemark.Location = new Point(344, 120);
            txtBackupRemark.Name = "txtBackupRemark";
            txtBackupRemark.Size = new Size(279, 25);
            txtBackupRemark.TabIndex = 45;
            // 
            // dtpBackupTime
            // 
            dtpBackupTime.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBackupTime.CustomFormat = " hh:mm tt";
            dtpBackupTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBackupTime.Format = DateTimePickerFormat.Custom;
            dtpBackupTime.Location = new Point(667, 121);
            dtpBackupTime.Name = "dtpBackupTime";
            dtpBackupTime.ShowUpDown = true;
            dtpBackupTime.Size = new Size(91, 25);
            dtpBackupTime.TabIndex = 48;
            // 
            // lstBackupLocations
            // 
            lstBackupLocations.BackColor = Color.Lavender;
            lstBackupLocations.Columns.AddRange(new ColumnHeader[] { lstViewColHeader1, lstViewColHeader2 });
            lstBackupLocations.FullRowSelect = true;
            lstBackupLocations.Location = new Point(26, 151);
            lstBackupLocations.Name = "lstBackupLocations";
            lstBackupLocations.Size = new Size(628, 140);
            lstBackupLocations.TabIndex = 49;
            lstBackupLocations.UseCompatibleStateImageBehavior = false;
            lstBackupLocations.View = View.Details;
            lstBackupLocations.MouseUp += lstBackupLocations_MouseUp;
            // 
            // lstViewColHeader1
            // 
            lstViewColHeader1.Text = "Location";
            lstViewColHeader1.Width = 320;
            // 
            // lstViewColHeader2
            // 
            lstViewColHeader2.Text = "Remarks";
            lstViewColHeader2.Width = 300;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(433, 52);
            label7.Name = "label7";
            label7.Size = new Size(431, 15);
            label7.TabIndex = 50;
            label7.Text = "(Select from the drop-down box or add db names as comma-seperated values)";
            // 
            // cmbSqlServer
            // 
            cmbSqlServer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSqlServer.FormattingEnabled = true;
            cmbSqlServer.Location = new Point(26, 70);
            cmbSqlServer.Name = "cmbSqlServer";
            cmbSqlServer.Size = new Size(255, 25);
            cmbSqlServer.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(26, 26, 26);
            label8.Location = new Point(287, 50);
            label8.Name = "label8";
            label8.Size = new Size(34, 17);
            label8.TabIndex = 52;
            label8.Text = "Port";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(799, 36);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(114, 2);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 53;
            progressBar1.Value = 40;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(936, 315);
            Controls.Add(progressBar1);
            Controls.Add(label8);
            Controls.Add(cmbSqlServer);
            Controls.Add(label7);
            Controls.Add(txtPort);
            Controls.Add(lstBackupLocations);
            Controls.Add(dtpBackupTime);
            Controls.Add(txtBackupRemark);
            Controls.Add(btnAddLocation);
            Controls.Add(label5);
            Controls.Add(lstBackupTimes);
            Controls.Add(btnFolderBrowser1);
            Controls.Add(cmbDatabases);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(btnAddTime);
            Controls.Add(btnSaveSettings);
            Controls.Add(btnReset);
            Controls.Add(txtExpiry);
            Controls.Add(txtBackupLocation);
            Controls.Add(txtDatabases);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
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
        private Label label6;
        private Label label9;
        private TextBox txtPort;
        private TextBox txtDatabases;
        private TextBox txtBackupLocation;
        private TextBox txtExpiry;
        private Button btnReset;
        private Button btnSaveSettings;
        private FolderBrowserDialog folderBrowserDialog;
        private Button btnFolderBrowser1;
        private Button btnAddTime;
        private Label label10;
        private Label lblNextBackupMsg;
        private Button btnBackup;
        private Label label14;
        private Label label12;
        private Label label13;
        private Label lblNextBackupTime;
        private ComboBox cmbDatabases;
        private ToolTip toolTip1;
        private ListBox lstBackupTimes;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnRefreshDB;
        private Label label5;
        private Button btnAddLocation;
        private TextBox txtBackupRemark;
        private DateTimePicker dtpBackupTime;
        private ListView lstBackupLocations;
        private ColumnHeader lstViewColHeader1;
        private ColumnHeader lstViewColHeader2;
        private Label label7;
        private ComboBox cmbSqlServer;
        private Label label8;
        private ProgressBar progressBar1;
        private Label lblTomorrow;
    }
}
