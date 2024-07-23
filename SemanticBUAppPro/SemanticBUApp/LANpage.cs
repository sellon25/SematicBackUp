using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;

namespace SemanticBUApp
{
    public partial class LANpage : Form
    {
        private static string shortFileName = "";
        private static string fileName = "";
        public static LANpage lANpageInstance;
        public LANpage()
        {
            InitializeComponent();
            lANpageInstance=this;
            txtFile.Text = Form1.form1Instance.selectedFile;
            txtHost.Text = 5055.ToString();
        }
     

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "File Sharing Client";
            dlg.ShowDialog();
            txtFile.Text = dlg.FileName;
            fileName = dlg.FileName;
            shortFileName = dlg.SafeFileName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            string ipAddress = txtIPAddress.Text;
            int port = int.Parse(txtHost.Text);
            string fileName = txtFile.Text;
            shortFileName=Path.GetFileName(fileName);
            Task.Factory.StartNew(() => SendFile(ipAddress, port, fileName, shortFileName));
            MessageBox.Show("File Sent");
        }
        public void SendFile(string remoteHostIP, int remoteHostPort,
            string longFileName, string shortFileName)
        {
            try
            {
                if (!string.IsNullOrEmpty(remoteHostIP))
                {
                    byte[] fileNameByte = Encoding.ASCII.GetBytes(shortFileName);
                    byte[] fileData = File.ReadAllBytes(longFileName);
                    byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                    byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
                    fileNameLen.CopyTo(clientData, 0);
                    fileNameByte.CopyTo(clientData, 4); fileData.CopyTo(clientData, 4 + fileNameByte.Length);
                    TcpClient clientSocket = new TcpClient(remoteHostIP, remoteHostPort);
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Write(clientData, 0, clientData.GetLength(0));
                    networkStream.Close();
                }
            }
            catch
            {
            }
        }

        [Obsolete]
        private void GetIP()
        {
            //String strHostName = Dns.GetHostName();

            //// Find host by name
            //IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            //// Enumerate IP addresses
            //int nIP = 0;
            //foreach (IPAddress ipaddress in iphostentry.AddressList)
            //{
            //    listBox1.Items.Add(Dns.GetHostName()+" ("+ipaddress.ToString()+")");
            //}

            Process netUtility = new Process();

            netUtility.StartInfo.FileName = "net.exe";

            netUtility.StartInfo.CreateNoWindow = true;

            netUtility.StartInfo.Arguments = "view";


            netUtility.StartInfo.RedirectStandardOutput = true;

            netUtility.StartInfo.UseShellExecute = false;

            netUtility.StartInfo.RedirectStandardError = true;

            netUtility.Start();



            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);



            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {

                if (line.StartsWith("\\"))
                {
                    string name = line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper();
                    listBox1.Items.Add(name+" ("+ GetLocalIp(name)+") ");

                }

            }

            streamReader.Close();
            netUtility.WaitForExit(1000);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GetIP();
            
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ipAdstr=listBox1.SelectedItem.ToString();
            string[] ipAdstrs=ipAdstr.Split('(',')');
            ipAdstr=ipAdstrs[1];
            txtIPAddress.Text=ipAdstr;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LANpage_Load(object sender, EventArgs e)
        {
            
        }

        

        private void LANpage_Load_1(object sender, EventArgs e)
        {

        }

      

        private void LANpage_Load_2(object sender, EventArgs e)
        {

        }
    }
}

