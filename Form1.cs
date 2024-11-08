using System;
using System.Net;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Microsoft.Identity.Client;
using static SQL_Backup_Tool.Form1;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System.IO.Compression;
using System.Globalization;


namespace SQL_Backup_Tool
{
    public partial class Form1 : Form
    {
        private readonly string jsonFilePath = "config.json";

        ToolStripMenuItem deleteTimeItem = new ToolStripMenuItem("Delete Time");
        ToolStripMenuItem deleteLocationItem = new ToolStripMenuItem("Delete Location");

        public string serverName;
        public List<string> backupLocationsList = new List<string>();
        public string mainBackupFolderPath;

        public Form1()
        {
            InitializeComponent();

            deleteTimeItem.Click += tsmDeleteTimeItem_Click;
            deleteLocationItem.Click += tsmDeleteLocationItem_Click;

            lstBackupTimes.MouseUp += lstBackupTimes_MouseUp;
            lstBackupLocations.MouseUp += lstBackupLocations_MouseUp;

        }

        public class BackupLocation
        {
            public string Location { get; set; }
            public string Remark { get; set; }
        }

        public class BackupSettings
        {
            //public string Server { get; set; } = string.Empty;
            //public int Port { get; set; }
            public List<string> Databases { get; set; } = new List<string>();
            public List<string> BackupTimes { get; set; } = new List<string>();
            public List<BackupLocation> BackupLocations { get; set; } = new List<BackupLocation>();
            public int Expiry { get; set; }
        }


        private void btnFolderBrowser1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string Folder = folderBrowserDialog.SelectedPath;

                txtBackupLocation.Text = Folder;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetHostIPAddress();
            serverName = Dns.GetHostName();
            LoadSqlServerInstances();
            GetSQLPortNumber();

            // Load settings
            BackupSettings settings = LoadSettings();

            //cmbSqlServer.Items.Clear();
            //cmbSqlServer.Items.Add(settings.Server);
            //cmbSqlServer.SelectedIndex = 0 ;

            //txtPort.Text = settings.Port.ToString();

            int dbCount = settings.Databases.Count;
            int i = 0;
            foreach (string db in settings.Databases)
            {
                i += 1;
                if (i == dbCount)
                {
                    txtDatabases.Text += db;
                }
                else
                {
                    txtDatabases.Text += db + ",";
                }
            }

            lblNextBackupTime.Text = "";

            // Populate ListBox with backup times
            lstBackupTimes.Items.Clear();
            foreach (string time in settings.BackupTimes)
            {
                // Parse saved time and check if it's after the current time
                if (DateTime.ParseExact(time, "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture) > DateTime.Now)
                {
                    lblNextBackupTime.Text = time;
                }
                lstBackupTimes.Items.Add(time);
            }

            OrderBackupTimesInListBox();

            // Populate ListView with backup locations
            lstBackupLocations.Items.Clear();
            foreach (var location in settings.BackupLocations)
            {
                var item = new ListViewItem(new[] { location.Location, location.Remark });
                lstBackupLocations.Items.Add(item);
                backupLocationsList.Add(location.Location);
            }

            txtExpiry.Text = settings.Expiry.ToString();


        }



        private void btnAddTime_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add This Time For Backup", btnAddTime);
        }

        private void lstBackupTimes_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Right Click To Delete An Item", lstBackupTimes);
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            lstBackupTimes.Items.Add(dtpBackupTime.Value.ToString("hh:mm tt"));
            OrderBackupTimesInListBox();

        }

        private void lstBackupTimes_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the index of the item that was clicked
                int index = lstBackupTimes.IndexFromPoint(e.Location);

                // Ensure the index is valid (i.e., an item was clicked)
                if (index != ListBox.NoMatches)
                {
                    // Clear any existing items in the context menu
                    contextMenuStrip1.Items.Clear();

                    // Add the delete time menu item
                    contextMenuStrip1.Items.Add(deleteTimeItem);

                    // Select the clicked item in the ListBox
                    lstBackupTimes.SelectedIndex = index;

                    // Show the context menu at the mouse pointer location
                    contextMenuStrip1.Show(lstBackupTimes, e.Location);
                }
            }
        }

        private void tsmDeleteTimeItem_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected before trying to delete
            if (lstBackupTimes.SelectedIndex != -1)
            {
                lstBackupTimes.Items.RemoveAt(lstBackupTimes.SelectedIndex);
            }
        }

        private void tsmDeleteLocationItem_Click(object sender, EventArgs e)
        {
            if (lstBackupLocations.SelectedItems.Count > 0)
            {
                // Remove the selected item from the ListView
                lstBackupLocations.Items.Remove(lstBackupLocations.SelectedItems[0]);
            }
        }

        private void btnRefreshDB_Click(object sender, EventArgs e)
        {
            LoadDatabases();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (txtBackupLocation.Text != "")
            {
                //string[] backup_location = { txtBackupLocation.Text, txtBackupRemark.Text };
                //lstBackupLocations.Items.Add(new ListViewItem(backup_location));
                //txtBackupLocation.Text = "";
                //txtBackupRemark.Text = "";

                var backupLocation = new ListViewItem(new[] { txtBackupLocation.Text, txtBackupRemark.Text });
                lstBackupLocations.Items.Add(backupLocation);
                txtBackupLocation.Clear();
                txtBackupRemark.Clear();
            }
        }

        private void btnRefreshDB_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Load Databases", btnRefreshDB);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void lstBackupLocations_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the item under the mouse pointer
                var hitTest = lstBackupLocations.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    // Select the item under the mouse pointer
                    lstBackupLocations.SelectedItems.Clear();
                    hitTest.Item.Selected = true;

                    // Clear any existing items in the context menu
                    contextMenuStrip1.Items.Clear();

                    // Add the delete location menu item
                    contextMenuStrip1.Items.Add(deleteLocationItem);

                    // Show the context menu at the mouse location
                    contextMenuStrip1.Show(lstBackupLocations, e.Location);
                }
            }
        }

        public void SaveSettings(BackupSettings settings)
        {
            try
            {
                // Serialize the data to JSON format
                string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });

                // Write the JSON string to the file
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message);
            }
        }

        public BackupSettings LoadSettings()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    // Read the JSON file contents
                    string json = File.ReadAllText(jsonFilePath);

                    // Deserialize JSON to the BackupSettings object
                    return JsonSerializer.Deserialize<BackupSettings>(json);
                }
                else
                {
                    // Return a new instance if file doesn't exist
                    return new BackupSettings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading settings: " + ex.Message);
                return new BackupSettings(); // Return a default instance on error
            }
        }

        private void SaveCurrentSettings()
        {
            // Gather current settings from controls
            BackupSettings settings = new BackupSettings();


            //settings.Server = cmbSqlServer.Text;
            //settings.Port = Convert.ToInt32(txtPort.Text.Trim());
            settings.Databases = txtDatabases.Text.Split(',').ToList();
            // Collect times from ListBox
            foreach (string item in lstBackupTimes.Items)
            {
                settings.BackupTimes.Add(item);
            }
            // Collect locations and remarks from ListView
            foreach (ListViewItem item in lstBackupLocations.Items)
            {
                settings.BackupLocations.Add(new BackupLocation
                {
                    Location = item.SubItems[0].Text,
                    Remark = item.SubItems[1].Text
                });
            }
            settings.Expiry = Convert.ToInt32(txtExpiry.Text.Trim());

            // Save to JSON
            SaveSettings(settings);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            // Validate Server and Instance
            // .....

            // Validating Port Number
            try
            {
                int port = Convert.ToInt32(txtPort.Text.Trim());
                if (port < 1 || port > 65535)
                {
                    MessageBox.Show("Please enter a port number between 1 and 65535.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid port number.");
                return;
            }

            // Validate Locations

            // Validate Expiry
            try
            {
                int port = Convert.ToInt32(txtExpiry.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Check Expiry Days.");
                return;
            }

            // Save updated settings
            SaveCurrentSettings();
        }

        private void LoadSqlServerInstances()
        {
            try
            {
                string ServerName = Environment.MachineName;
                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                    if (instanceKey != null)
                    {
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            cmbSqlServer.Items.Add(serverName.ToUpper() + "\\" + instanceName);
                        }
                    }

                    LoadDatabases();
                }


                //// SMO method to enumerate available SQL Server instances
                //DataTable instances = SmoApplication.EnumAvailableSqlServers(false);

                //cmbSqlServers.Items.Clear();

                //foreach (DataRow row in instances.Rows)
                //{
                //    string serverName = row["Name"].ToString();
                //    string instanceName = row["Instance"].ToString();
                //    string fullInstanceName = string.IsNullOrEmpty(instanceName) ? serverName : $"{serverName}\\{instanceName}";

                //    cmbSqlServers.Items.Add(fullInstanceName);
                //}

                if (cmbSqlServer.Items.Count > 0)
                {
                    cmbSqlServer.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No SQL Server instances found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving SQL Server instances: " + ex.Message);
            }
        }

        private void LoadDatabases()
        {
            // Get the server name from the text box
            //string serverName = "LIBIN\\MSSQLSERVER";

            // Connection string to connect to the SQL Server instance (uses Windows Authentication)
            string connectionString = $"Server={serverName};Database=master;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to retrieve all database names
                    string query = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            cmbDatabases.Items.Clear();

                            // Read each database name and add it to the ComboBox
                            while (reader.Read())
                            {
                                cmbDatabases.Items.Add(reader["name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
        }

        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabases.SelectedIndex != -1)
            {
                string selectedDB = cmbDatabases.SelectedItem.ToString().Trim();

                if (txtDatabases.Text.Contains(selectedDB))
                {
                    MessageBox.Show("Database already added!");
                    cmbDatabases.SelectedIndex = -1;
                    return;
                }

                if (txtDatabases.Text.Trim() == "")
                {
                    txtDatabases.Text = selectedDB;
                }
                else
                {
                    txtDatabases.Text = txtDatabases.Text + "," + selectedDB;
                }
            }

            cmbDatabases.SelectedIndex = -1;
        }

        private void GetHostIPAddress()
        {
            // Get the hostname of the local machine
            string hostName = Dns.GetHostName();

            // Get the IP addresses associated with the local machine
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);

            foreach (IPAddress ip in hostEntry.AddressList)
            {
                // Filter for IPv4 addresses only (to avoid IPv6 if it's not needed)
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    cmbSqlServer.Text = ip.ToString();
                }
            }

        }

        private void GetSQLPortNumber()
        {
            string instanceName = "MSSQLSERVER";
            string keyPath = $@"SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL16.{instanceName}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll";

            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(keyPath);

            if (registryKey != null)
            {
                // Check for the TCP Port (used if configured with a static port)
                string staticPort = registryKey.GetValue("TcpPort")?.ToString();

                txtPort.Text = staticPort;
            }
            // need to check MSSQL16 or other version. code in chatGPT.
        }

        private void btnFolderBrowser1_MouseLeave(object sender, EventArgs e)
        {
            btnFolderBrowser1.Image = Properties.Resources.folder_dark;
        }

        private void btnFolderBrowser1_MouseEnter(object sender, EventArgs e)
        {
            btnFolderBrowser1.Image = Properties.Resources.folder_light;
        }

        private void btnAddLocation_MouseEnter(object sender, EventArgs e)
        {
            btnAddLocation.Image = Properties.Resources.add_light;
        }

        private void btnAddLocation_MouseLeave(object sender, EventArgs e)
        {
            btnAddLocation.Image = Properties.Resources.add_dark;
        }

        private void btnAddTime_MouseEnter(object sender, EventArgs e)
        {
            btnAddTime.Image = Properties.Resources.add_light;
        }

        private void btnAddTime_MouseLeave(object sender, EventArgs e)
        {
            btnAddTime.Image = Properties.Resources.add_dark;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            foreach (var location in backupLocationsList)
            {
                if (location.Substring(0, 2) == "\\")
                {

                    return;
                }
            }

            //try
            //{
            //    // Ensure backup folder exists
            //    if (!Directory.Exists(mainBackupFolderPath))
            //        Directory.CreateDirectory(backupFolderPath);

            //    foreach (string databaseName in databaseNames)
            //    {
            //        BackupDatabase(databaseName);
            //    }

            //    // Compress all backups into a single ZIP file
            //    string zipFilePath = Path.Combine(backupFolderPath, "AllDatabasesBackup.zip");
            //    CompressBackups(zipFilePath);

            //    MessageBox.Show("Backup and compression completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        //private void BackupDatabase(string databaseName)
        //{
        //    // Set up the connection string
        //    string connectionString = $"Server={serverInstance},{port};Database={databaseName};Trusted_Connection=True;";

        //    // Create backup file path
        //    string backupFilePath = Path.Combine(backupFolderPath, $"{databaseName}.bak");

        //    // SQL command for backup
        //    string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}' WITH INIT, FORMAT";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(backupQuery, connection);
        //        connection.Open();
        //        command.ExecuteNonQuery();
        //        connection.Close();
        //    }

        //    Console.WriteLine($"Backup for database '{databaseName}' completed successfully.");
        //}

        //private void CompressBackups(string zipFilePath)
        //{
        //    // Ensure no previous zip file exists
        //    if (File.Exists(zipFilePath))
        //        File.Delete(zipFilePath);

        //    // Create a zip file with all .bak files in the backup folder
        //    using (ZipArchive zip = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
        //    {
        //        foreach (string filePath in Directory.GetFiles(backupFolderPath, "*.bak"))
        //        {
        //            string fileName = Path.GetFileName(filePath);
        //            zip.CreateEntryFromFile(filePath, fileName);
        //        }
        //    }

        //    Console.WriteLine("Compression of backups completed successfully.");
        //}

        //public static List<string> OrderBackupTimes(List<string> backupTimes)
        //{
        //    // Sort times using DateTime.ParseExact for correct time format interpretation
        //    return backupTimes.OrderBy(time => DateTime.ParseExact(time, "hh:mm tt", CultureInfo.InvariantCulture)).ToList();
        //}

        private void OrderBackupTimesInListBox()
        {
            var backupTimes = lstBackupTimes.Items.Cast<string>().ToList();
            backupTimes = backupTimes.OrderBy(time => DateTime.ParseExact(time, "hh:mm tt", CultureInfo.InvariantCulture)).ToList();
            
            lstBackupTimes.Items.Clear();
            foreach (var time in backupTimes)
            {
                lstBackupTimes.Items.Add(time);
            }
        }
    }
}
