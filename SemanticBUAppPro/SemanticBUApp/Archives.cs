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
            // TODO: This line of code loads data into the 'semanticBackupDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.semanticBackupDataSet.History);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True");


            try
            {
                SqlCommand cmd = new SqlCommand("Select Name, Path, Size, Date from History where Email_Address = @parm1", con);
                cmd.Parameters.AddWithValue("parm1", lblUsername.Text);
                SqlDataAdapter da = new SqlDataAdapter();   
                da.SelectCommand = cmd; 
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dgvArchive.DataSource = dt;
                dgvArchive.AllowUserToAddRows = false;

            }
            finally
            {

            }


            



            //dgvBindingSource= new BindingSource();
            //dgvBindingSource.DataSource = backupFileBindingSource;

            //show the backedup information

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True");

            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}
            //SqlCommand cmd = new SqlCommand("SELECT * FROM SignUp WHERE Email_Address = '"+ lblUsername.Text +"'");
            //SqlDataAdapter adapter = new SqlDataAdapter(); 

            //DataTable dt = new DataTable();

            //adapter.SelectCommand = cmd;

            //dt.Clear();
            //adapter.Fill(dt);

            //dataGridView1.DataSource = dt;

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM History WHERE Email_Address = '" + lblUsername.Text + "'",con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    //lblUsername.Text = dr["Name"].ToString();

                
                

            //}
            //con.Close();








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

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True");

            //for (int j = 0; j > dgvArchive.Rows.Count - 1;)
            //{

            //    SqlCommand cmd = new SqlCommand("DELETE FROM History where Name = @Name", con);

            //    cmd.Parameters.AddWithValue("Name", dgvArchive.SelectedRows[index: j].Cells[j].Value.ToString());
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True"))
            {
                con.Open();
                var jj = con.BeginTransaction();

                foreach (DataGridViewRow dr in dgvArchive.Rows)
                {
                    //int inr = Convert.ToInt32(dgvArchive.Rows[dgvArchive.CurrentRow.Index].Cells[0].Value);

                    //con.Open();
                    //SqlCommand cmd = new SqlCommand("DELETE FROM SemanticBackup.History WHERE (Name = @name)", con);
                    //cmd.Parameters.AddWithValue("name", inr);
                    //cmd.ExecuteNonQuery();
                    //con.Close();
                    
                    var cmd = new SqlCommand("DELETE FROM History WHERE (Name = @name)", con);
                    cmd.Transaction = jj;
                    cmd.Parameters.AddWithValue("name", dr.Cells[Name].Value ?? DBNull.Value);
                    cmd.ExecuteNonQuery(); 

                }
                jj.Commit();
                con.Close();
            }

            MessageBox.Show("All Achieves Deleted!");

            dgvArchive.Refresh();
           // dgvArchive.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True");
           
            SqlCommand cmd = new SqlCommand("DELETE FROM History WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("Name", dgvArchive.SelectedRows[index:0].Cells[0].Value.ToString());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            int rIndex=dgvArchive.CurrentCell.RowIndex;
            dgvArchive.Rows.RemoveAt(rIndex);
            dgvArchive.Refresh();
            MessageBox.Show("Deleted!");
            

        }

        private void btnViewH_Click(object sender, EventArgs e)
        {
            int rIndex = dgvArchive.CurrentCell.RowIndex;

            if (rIndex != -1)
            {
                dgvFetchData.Rows.Clear();
                //string backupName = dgvArchive.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string backupName = dgvArchive.Rows[rIndex].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                string[] buName = backupName.Split('.');
                backupName = buName[0];
                string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Semantic Backup\\" + lblUsername.Text + "\\" + backupName + "\\" + backupName + ".txt";
                try
                {
                    TextReader rw = new StreamReader(path, true);
                    var rows = File.ReadAllText(path).ToString();

                    //string line; 
                    string[] lines = rows.Split('%');
                    int rowIndex = 0;

                    foreach (string line in lines)
                    {
                        if (line != "\r\n")
                        {
                            string[] dataLine = line.Split(new char[] { '|' });
                            bool bu;
                            try
                            {
                                if (dataLine[6] == "True")
                                    bu = true;
                                else
                                    bu = false;
                            }
                            catch (Exception)
                            {
                                bu = true;
                            }

                            fetchDataBindingSource.Add(new FetchData()
                            {
                                Name = dataLine[0],
                                Type = dataLine[1],
                                Size = dataLine[2],
                                DirectoryPath = dataLine[3],
                                DateCreated = dataLine[4],
                                LastUpdated = dataLine[5],
                                backupFile = bu
                            });
                            if (dataLine.Length >= 7)
                            {
                                string[] urls = dataLine[7].Split(new char[] { ';' });
                                if (urls.Count() > 0)
                                {
                                    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dgvFetchData["urls", rowIndex];
                                    comboCell.Items.Clear();
                                    foreach (string url in urls)
                                    {
                                        comboCell.Items.Add(url);
                                    }
                                    //comboCell.Items.Remove("No urls available.");
                                }
                                if (rowIndex == (lines.Length - 10))
                                {
                                    break;

                                }
                            }
                            rowIndex++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Back up not found or available: " + ex.Message);
                }
            }
        }
    }
}
