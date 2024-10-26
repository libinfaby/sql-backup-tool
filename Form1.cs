using System;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL_Backup_Tool
{
    public partial class Form1 : Form
    {
        ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete Time");

        public Form1()
        {
            InitializeComponent();

            contextMenuStrip1.Items.Add(deleteMenuItem);
            deleteMenuItem.Click += tsmDeleteListItem_Click;
            lstBackupTimes.MouseUp += lstBackupTimes_MouseUp;
        }

        private void btnFolderBrowser1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string Folder = folderBrowserDialog.SelectedPath;

                txtBackupLocation1.Text = Folder;
            }
        }

        private void btnFolderBrowser2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string Folder = folderBrowserDialog.SelectedPath;

                txtBackupLocation2.Text = Folder;
            }
        }

        private void btnFolderBrowser3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string Folder = folderBrowserDialog.SelectedPath;

                txtBackupLocation3.Text = Folder;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //// Ensure there is a primary screen available
            //if (Screen.PrimaryScreen == null) return;

            //// Get the screen dimensions
            //Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            //// Calculate the position: Bottom-right corner, just above the taskbar
            //int formX = screen.Right - this.Width;        // Aligns form to the right side of the screen
            //int formY = screen.Bottom - this.Height;      // Places form just above the taskbar

            //// Set form position
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(formX, formY);

            //// Show the form
            //this.Show();


        }

        private void cmbDatabases_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnAddTime_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.ToolTipTitle = "Add";
            toolTip1.Show("Add This Time For Backup", btnAddTime);
        }

        private void lstBackupTimes_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Right Click To Delete This Time", lstBackupTimes);
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            lstBackupTimes.Items.Add(dudHours.Text + ":" + dudMinutes.Text + " " + dudAMPM.Text);
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
                    // Select the clicked item in the ListBox
                    lstBackupTimes.SelectedIndex = index;

                    // Show the context menu at the mouse pointer location
                    contextMenuStrip1.Show(lstBackupTimes, e.Location);
                }
            }
        }

        private void tsmDeleteListItem_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected before trying to delete
            if (lstBackupTimes.SelectedIndex != -1)
            {
                lstBackupTimes.Items.RemoveAt(lstBackupTimes.SelectedIndex);
            }
        }

        private void btnRefreshDB_Click(object sender, EventArgs e)
        {
            // Get the server name from the text box
            string serverName = txtServer.Text;

            // Connection string to connect to the SQL Server instance (uses Windows Authentication)
            string connectionString = $"Server={serverName};Database=master;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to retrieve all database names
                    string query = "SELECT name FROM sys.databases";

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
                //cmbDatabases.Text = serverName;

                // MessageBox.Show("Databases loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
