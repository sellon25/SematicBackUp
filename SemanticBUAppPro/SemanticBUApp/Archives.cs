using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace SemanticBUApp
{
    public partial class Archives : Form
    {
        public DataGridView dgv;
        public static Archives form3intance;
        public BindingSource dgvBindingSource;
        public Archives(string name)
        {
            InitializeComponent();
            lblUsername.Text = name;
            form3intance= this;
            dgvArchive.EnableHeadersVisualStyles = false;
            dgvArchive.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvArchive.ColumnHeadersDefaultCellStyle.BackColor;

        }

        private void Archives_Load(object sender, EventArgs e)
        {
            LoadHistoryData();
        }

        private void LoadHistoryData()
        {
            string backupInfoFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Semantic Backup", lblUsername.Text);
            if (Directory.Exists(backupInfoFolderPath))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Size");
                dt.Columns.Add("Path");
                dt.Columns.Add("Date");

                foreach (string backupInfoFile in Directory.GetFiles(backupInfoFolderPath, "*.txt"))
                {
                    string[] lines = File.ReadAllLines(backupInfoFile);
                    string backupName = null;
                    string backupSize = null;
                    string backupPath = null;
                    string backupDate = null;

                    foreach (string line in lines)
                    {
                        if (line.StartsWith("Backup Name:"))
                        {
                            backupName = line.Substring("Backup Name:".Length).Trim();
                        }
                        else if (line.StartsWith("Backup Location:"))
                        {
                            backupPath = line.Substring("Backup Location:".Length).Trim();
                        }
                        else if (line.StartsWith("Backup Size:"))
                        {
                            backupSize = line.Substring("Backup Size:".Length).Trim();
                        }
                        else if (line.StartsWith("Backup Date:"))
                        {
                            backupDate = line.Substring("Backup Date:".Length).Trim();
                        }
                    }

                    if (backupName != null && backupPath != null && backupSize != null && backupDate != null)
                    {
                        dt.Rows.Add(backupName, backupSize, backupPath, backupDate);
                    }
                }

                dgvArchive.DataSource = dt;
                dgvArchive.AllowUserToAddRows = false;
            }
        }

        private void backupFileBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        

        private void dgvArchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFetchData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Get the user's backup info folder path
            string userBackupFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Semantic Backup", lblUsername.Text);

            // Check if the folder exists
            if (Directory.Exists(userBackupFolderPath))
            {
                // Delete all backup info txt files in the folder
                foreach (string file in Directory.GetFiles(userBackupFolderPath, "*.txt"))
                {
                    File.Delete(file);
                }

                // Clear the DataGridView
                //dgvArchive.Rows.Clear();
                dgvArchive.Refresh();

                MessageBox.Show("All backup info deleted!");
            }
            else
            {
                MessageBox.Show("Backup info folder not found for the user!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string backupName = dgvArchive.Rows[dgvArchive.CurrentCell.RowIndex].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            string backupInfoFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Semantic Backup", lblUsername.Text);
            string backupInfoFilePath = Path.Combine(backupInfoFolderPath, backupName + ".txt");

            // Delete the backup info txt file
            if (File.Exists(backupInfoFilePath))
            {
                File.Delete(backupInfoFilePath);

                // Remove the corresponding row from the DataGridView
                dgvArchive.Rows.RemoveAt(dgvArchive.CurrentCell.RowIndex);
                dgvArchive.Refresh();

                MessageBox.Show("Backup info deleted!");
            }
            else
            {
                MessageBox.Show("Backup info not found!");
            };
            

        }

        private void btnViewH_Click(object sender, EventArgs e)
        {
            int rIndex = dgvArchive.CurrentCell.RowIndex;

            if (rIndex != -1)
            {
                //dgvFetchData.Rows.Clear();
                string backupName = dgvArchive.Rows[rIndex].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                string backupInfoFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Semantic Backup", lblUsername.Text);
                string backupInfoFilePath = Path.Combine(backupInfoFolderPath, backupName + ".txt");

                try
                {
                    DataTable dtFetchData = new DataTable();
                    dtFetchData.Columns.Add("Name");
                    dtFetchData.Columns.Add("Type");
                    dtFetchData.Columns.Add("Size");
                    dtFetchData.Columns.Add("DirectoryPath");
                    dtFetchData.Columns.Add("DateCreated");
                    dtFetchData.Columns.Add("LastUpdated");
                    dtFetchData.Columns.Add("backupFile", typeof(bool));

                    string[] backupSections = File.ReadAllText(backupInfoFilePath).Split(new[] { "-------------------------------------------------------------------------------------------------------" }, StringSplitOptions.RemoveEmptyEntries);

                    if (backupSections.Length >= 1)
                    {
                        string filesSection = backupSections[1];
                        string[] lines = filesSection.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                        string name = "", filePath = "", size = "", date = "";

                        foreach (string line in lines)
                        {
                            if (line.StartsWith("File Name:"))
                            {
                                name = line.Substring("File Name:".Length).Trim();
                            }
                            else if (line.StartsWith("File Path:"))
                            {
                                filePath = line.Substring("File Path:".Length).Trim();
                            }
                            else if (line.StartsWith("File Size:"))
                            {
                                size = line.Substring("File Size:".Length).Trim();
                            }
                            else if (line.StartsWith("Backup Date:"))
                            {
                                date = line.Substring("Backup Date:".Length).Trim();

                                // Add the data to the DataTable
                                string type = Path.GetExtension(name);
                                bool backupFile = true; // Assuming all files are backed up
                                dtFetchData.Rows.Add(name, type, size, filePath, date, date, backupFile);

                                // Reset variables for the next file
                                name = filePath = size = date = "";
                            }
                        }
                    }
                    dgvFetchData.DataSource = dtFetchData;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Backup not found or available: " + ex.Message);
                }
            }
        }


    }
}
