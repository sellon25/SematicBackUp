using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SemanticBUApp
{
    public partial class Form1 : Form
    {
        public static Form1 form1Instance;
        string backedZipPath { get; set; }
        string temp { get; set; }
        List<string> fetchedFiles { get; set; }
        public bool approveBackup { get; set; }
        static long totalSize;
        static long namesOnlySize, allegibleSize;
        public string userName;
        public string selectedFile;
        private void FetchProccess()
        {

            long sizeOfMusic = 0;
            long sizeOfDocuments = 0;
            long sizeOfVidoes = 0;
            long sizeOfImages = 0;
            long sizeOfOthers = 0;
            string[] paths = new string[6];
            paths[0] = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            paths[1] = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            paths[2] = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            paths[3] = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            paths[4] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            paths[5] = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            FetchFileData retrieveFiles;
            List<string> files = new List<string>();
            foreach (string path in paths)
            {
                retrieveFiles = new FetchFileData(path);
                if (cb_audios.Checked)
                {
                    files.AddRange(retrieveFiles.audios);
                    
                }
                if (cb_docs.Checked)
                {
                    files.AddRange(retrieveFiles.documents);
                    retrieveFiles.documents=null;
                }
                if (cb_pics.Checked)
                {
                    files.AddRange(retrieveFiles.images);
                   

                }
                if (cb_vids.Checked)
                {
                    files.AddRange(retrieveFiles.videos);
                   
                }
                files.AddRange(retrieveFiles.other);
               
                //files.Sort();

                FileInfo fl;
                foreach (string file in files)
                {
                    fl = new FileInfo(file);
                    fetchDataBindingSource.Add(new FetchData()
                    {
                        Name = Path.GetFileNameWithoutExtension(fl.FullName),
                        Type = fl.Extension,
                        Size = (fl.Length / 1000).ToString() + " Kb",
                        DirectoryPath = fl.FullName,
                        DateCreated = fl.CreationTime.ToString(),
                        LastUpdated = fl.LastWriteTime.ToString(),
                        backupFile = true
                    });

                }
                files = new List<string>();
                sizeOfDocuments += retrieveFiles.SizeOfDocuments;
                sizeOfImages += retrieveFiles.SizeOfImages;
                sizeOfVidoes += retrieveFiles.SizeOfVideos;
                sizeOfMusic += retrieveFiles.SizeOfAudios;
                sizeOfOthers += retrieveFiles.SizeOfOther;
                
            }
            totalSize = sizeOfDocuments + sizeOfImages + sizeOfVidoes + sizeOfMusic;
            lbAudios.Text = sizeOfMusic.ToString() + " MB";
            lbImages.Text = sizeOfImages.ToString() + " MB";
            lbDocuments.Text = sizeOfDocuments.ToString() + " MB";
            lbVideos.Text = sizeOfVidoes.ToString() + " MB";
            fetchedFiles = files;
           
            //allegibleSize = totalSize;

        }

        public Form1(string name)
        {
            InitializeComponent();
            lblUsername.Text = name;

            tb_customBUname.Text = temp = "Backup" + DateTime.Now.ToString("_yyyyMdd_HHmm");
            btn_fetchFiles.Enabled = false;
            btn_StartBackup.Enabled = false;
            btn_browseFolders.Enabled = false;
            btn_browseFolders.Enabled = false;
            this.approveBackup = approveBackup;
            this.userName=lblUsername.Text;
            form1Instance = this;
            
        }

        public Form1()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Date

            lbldate.Text = DateTime.Now.ToShortDateString();

            //Time
            timer1.Start();
            lblTimer.Text = DateTime.Now.ToLongTimeString();



            cb_docs.CheckState = CheckState.Checked;
            cb_pics.CheckState = CheckState.Checked;
            cb_vids.CheckState = CheckState.Checked;
            cb_pics.CheckState = CheckState.Checked;
            cb_audios.CheckState = CheckState.Checked;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelloading.Visible = false;

            dataGridView2.Rows.Clear();
            dataGridView2.Visible = true;

            //fetchs data from pc
            FetchProccess();
            allegibleSize = 0;
            namesOnlySize = 0;
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {
                FileInfo fl = new FileInfo(dataGridView2.Rows[i].Cells["DirectoryPath"].Value.ToString());
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells["backUpFile"].FormattedValue) == true)
                {
                    allegibleSize += (fl.Length / 100000);
                }
                else
                {
                    namesOnlySize += (fl.Length / 100000);
                }
            }
            lbBackupSize.Text = allegibleSize.ToString() + " MB";

            string[] checkFormats = { ".mp3", ".wav", ".3ga", ".m4a", ".m4b", ",wma", ".m4p", "mp4", ".avi", ".mpeg", ".mpg", ".mov", ".webm", ".3pg", "wmv", ".mkv", ".flv", ".vob", ".gifv", ".m4v" };
            for (int i = 0; i < (dataGridView2.RowCount - 1); i++)
            {
                foreach (string format in checkFormats)
                {
                    string cformat = dataGridView2.Rows[i].Cells["Type"].Value.ToString();
                    if (cformat == format)
                    {
                        //do nothing
                        break;
                    }
                    else
                    {
                        dataGridView2.Rows[i].Cells["btnView"] = new DataGridViewTextBoxCell();
                        dataGridView2.Rows[i].Cells["btnView"].Value = "";
                        dataGridView2.Rows[i].Cells["btnView"].ReadOnly = true;
                        break;
                    }
                }
            }

            //
            btn_browseFolders.Enabled = true;
            if (tb_customBUname.Text.Trim() == null || tb_customBUname.Text.Trim() == "" || tb_customBUname.Text == temp)
            {
                tb_customBUname.Text = "Backup" + DateTime.Now.ToString("_yyyymmmdd_HHmm");
            }


        }

        private void btn_browseFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tb_targetPath.Text = dlg.SelectedPath;
            }
            btn_StartBackup.Enabled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "btnView")
            {
                string term = dataGridView2.Rows[e.RowIndex].Cells["fileName"].FormattedValue.ToString();
                Form2 f2 = new Form2(term, e.RowIndex);
                f2.ShowDialog();
                dataGridView2.Rows[e.RowIndex].Cells["backupFile"].Value = approveBackup;




                if (Form2.form2Instance.urls.Count > 0)
                {
                    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView2["urls", e.RowIndex];
                    foreach (string url in Form2.form2Instance.urls)
                    {
                        comboCell.Items.Add(url);
                    }
                    //comboCell.Items.Remove("No urls available.");
                }

                
                lbBackupSize_Click(null, null, e.RowIndex);
            }

            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                dataGridView2.EndEdit();             
                            
                lbBackupSize_Click(null, null, e.RowIndex);
                
            }


        }



        private string GetLocalIp(string name)
        {
            IPHostEntry host;
            host = Dns.GetHostByName(name);
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }


            return "Couldn't Find!";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //save approved files backup locally
            List<string> approvedFiles = new List<string>();
            LocalBackUpFiles bu = new LocalBackUpFiles();
            string targetDir, backUpFileName;
            if (tb_customBUname.Text.Trim() == null || tb_customBUname.Text.Trim() == "")
            {
                tb_customBUname.Text = "Backup" + DateTime.Now.ToString("_yyyymmmdd_HHmm");
            }
            targetDir = tb_targetPath.Text + "\\" + tb_customBUname.Text;
            backUpFileName = tb_targetPath.Text + "\\" + tb_customBUname.Text + ".zip";


            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells["backupFile"].Value) == true)
                {
                    string aFile = dataGridView2.Rows[i].Cells["DirectoryPath"].Value.ToString();
                    approvedFiles.Add(aFile);
                    FileInfo aFi = new FileInfo(aFile);
                    long allegibleSize = 0;
                    allegibleSize += aFi.Length / 100000;

                }

            }
            //
         

            //determines whether to keep the backup file locally or send to cloud

            FileInfo fl = new FileInfo(backUpFileName);
            string savedName = null;
            string savedPath = null;
            string savedSize = null;
            if (File.Exists(backUpFileName) != true)
            {
                bu.LocalBacKUpFilesTo(approvedFiles, backUpFileName, targetDir);
                savedName = fl.Name;
                savedPath = fl.FullName;
                savedSize = (fl.Length / 100000).ToString() + " MB";

                if (cbLocal.Checked)
                {
                    MessageBox.Show(backUpFileName + "\nBack up complete.");
                }
                else if (cbCloud.Checked)       //stores on google drive: 
                {
                                       
                    CloudBackupFile cub = new CloudBackupFile(lblUsername.Text, backUpFileName);
                    savedPath = "Saved to Google drive";

                    File.Delete(savedPath);
                }
                else if (cb_lan.Checked)
                {
                    selectedFile = savedPath;
                    LANpage lp = new LANpage();
                    lp.ShowDialog();
                    File.Delete(savedPath);
                }
              
            }
            else
            {
                savedName = fl.Name;
                savedPath = fl.FullName;
                savedSize = (fl.Length / 100000).ToString() + " MB";

                //Sqlconnection, save to databhase.
                if (cbLocal.Checked)
                {

                    MessageBox.Show(backUpFileName + "\nAlready exists. Try changing your backup file name!");
                }

                //store on google drive:
                else if (cbCloud.Checked)
                {

                    CloudBackupFile cub = new CloudBackupFile(lblUsername.Text, backUpFileName);
                    //string folderId = cub.DriveCreateFolder(backUpFileName);
                    savedPath = "Saved to Google drive";

                }
                
                


            }
            string cal = lbldate.Text + "|" + lblTimer.Text;
         
            //change backup name
            tb_customBUname.Text = "Backup" + DateTime.Now.ToString("_yyyymmmdd_HHmm");

           //sends table data for archives:
            List<string> strData = new List<string>();

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                string data = "";                
                for (int j = 0; j <= (dataGridView2.Columns.Count); j++)
                {
                    if (j < 7)
                    {
                        data += dataGridView2.Rows[i].Cells[j].Value.ToString() + " | ";
                    }
                    else if (j == 9)
                    {
                        DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView2["urls", i];
                        foreach (string url in comboCell.Items)
                        {
                            data += url + "; ";
                        }

                    }

                }
                data += "%";
                strData.Add(data);

            }

            string SBUappPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + "Semantic Backup";
            string appData = SBUappPath + "\\" + lblUsername.Text;
            string newPath;
            if (Directory.Exists(SBUappPath))
            {
                if (Directory.Exists(appData))
                {
                    newPath = appData + "\\" + Path.GetFileNameWithoutExtension(backUpFileName);

                    Directory.CreateDirectory(newPath);
                    TextWriter tw = new StreamWriter(newPath + "//" + Path.GetFileNameWithoutExtension(backUpFileName) + ".txt", true);
                    foreach (string str in strData)
                    {
                        tw.WriteLine(str);
                    }
                    tw.Close();
                }
                else
                {
                    Directory.CreateDirectory(appData);
                    newPath = appData + "\\" + Path.GetFileNameWithoutExtension(backUpFileName);
                    Directory.CreateDirectory(newPath);
                    TextWriter tw = new StreamWriter(newPath + "//" + Path.GetFileNameWithoutExtension(backUpFileName) + ".txt", true);
                    foreach (string str in strData)
                    {
                        tw.WriteLine(str);
                    }
                    tw.Close();
                }
            }
            else
            {
                Directory.CreateDirectory(SBUappPath);
                if (Directory.Exists(appData))
                {
                    newPath = appData + "\\" + Path.GetFileNameWithoutExtension(backUpFileName);

                    Directory.CreateDirectory(newPath);
                    TextWriter tw = new StreamWriter(newPath + "//" + Path.GetFileNameWithoutExtension(backUpFileName) + ".txt", true);
                    foreach (string str in strData)
                    {
                        tw.WriteLine(str);
                    }
                    tw.Close();

                }
                else
                {
                    Directory.CreateDirectory(appData);
                    newPath = appData + "\\" + Path.GetFileNameWithoutExtension(backUpFileName);
                    Directory.CreateDirectory(newPath);
                    TextWriter tw = new StreamWriter(newPath + "//" + Path.GetFileNameWithoutExtension(backUpFileName) + ".txt", true);
                    foreach (string str in strData)
                    {
                        tw.WriteLine(str);
                    }
                    tw.Close();

                }

            }

            //sends to archive page/History table(Database)

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True");
                con.Open();
                SqlCommand comm = new SqlCommand("Insert into History values('" + lblUsername.Text + "','" + savedName.ToString() + "','" + savedPath.ToString() + "','" + savedSize.ToString() + "', '" + cal.ToString() + "')", con);
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                File.Delete(savedPath);
                MessageBox.Show("Path name is too long. Try another path or backup name.");
            }


        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Archives f3 = new Archives(lblUsername.Text);
            f3.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }



        //...
        private void cb_audios_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_audios.Checked || cb_docs.Checked || cb_pics.Checked || cb_vids.Checked)
            {
                btn_fetchFiles.Enabled = true;
            }
            else
            {
                btn_fetchFiles.Enabled = false;

            }
        }

        private void cb_pics_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_audios.Checked || cb_docs.Checked || cb_pics.Checked || cb_vids.Checked)
            {
                btn_fetchFiles.Enabled = true;
            }
            else
            {
                btn_fetchFiles.Enabled = false;

            }
        }

        private void cb_docs_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_audios.Checked || cb_docs.Checked || cb_pics.Checked || cb_vids.Checked)
            {
                btn_fetchFiles.Enabled = true;
            }
            else
            {
                btn_fetchFiles.Enabled = false;

            }
        }

        private void cb_vids_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_audios.Checked || cb_docs.Checked || cb_pics.Checked || cb_vids.Checked)
            {
                btn_fetchFiles.Enabled = true;
            }
            else
            {
                btn_fetchFiles.Enabled = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbCloud_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void lbBackupSize_Click(object sender, EventArgs e, int rIndex)
        {

           //Calculates overall sizes:
            if (Convert.ToBoolean(dataGridView2.Rows[rIndex].Cells["backUpFile"].FormattedValue) == true)
            {
                FileInfo fl = new FileInfo(dataGridView2.Rows[rIndex].Cells["DirectoryPath"].Value.ToString());
                allegibleSize += (fl.Length / 100000);
                namesOnlySize -= (fl.Length / 100000);
                lbBackupSize.Text = allegibleSize.ToString() + " MB";
                lbBuNamesOnly.Text = namesOnlySize.ToString() + " MB";
            }
            else
            {
                FileInfo fl = new FileInfo(dataGridView2.Rows[rIndex].Cells["DirectoryPath"].Value.ToString());
                allegibleSize -= (fl.Length / 100000);
                namesOnlySize += (fl.Length / 100000);
                lbBackupSize.Text = allegibleSize.ToString() + " MB";
                lbBuNamesOnly.Text = namesOnlySize.ToString() + " MB";
            }


        }

        private void lbBackupSize_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
               
        }

        private void lbBuNamesOnly_Click(object sender, EventArgs e)
        {

        }
        //
        // 
      

        private void cb_lan_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

       
    }
}

