using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemanticBUApp
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password;

            Username = txtSIEmail.Text;
            Password = txtSIPassword.Text;

            try
            {
                string querry = "SELECT * FROM SignUp WHERE Email_Address = '"+ txtSIEmail.Text +"' AND Password = '"+ txtSIPassword.Text +"' ";
                SqlDataAdapter dataadapter = new SqlDataAdapter(querry, conn);


                DataTable datatable = new DataTable();
                dataadapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {
                    Username = txtSIEmail.Text;
                    Password = txtSIPassword.Text;

                    Home home = new Home();
                    home.Close();

                    Form1 backup = new Form1(txtSIEmail.Text);
                    backup.ShowDialog();
                    this.Close();

                    

                }
                else
                {
                    lblerror.Visible = true;

                    txtSIEmail.Clear();
                    txtSIPassword.Clear();
                    
                }
              

            }
         
            finally
            {
                conn.Close();
            }


            //redirecting to another win form.
            //Backup backup = new Backup();
            ////this button allows you to log in once the info is proven to be present in the databse, it then passes you to a the next page, which will be withing the website.
            //using (SqlConnection con = new SqlConnection("Data Source=TAYDOW;Initial Catalog=SemanticBackupApp;Integrated Security=True"))
            //{
            //    con.Open();
            //    string q = "SELECT COUNT(1) FROM SignUp WHERE username=@Username AND password=@Password";
            //    SqlCommand sqlCmd = new SqlCommand(q, con);
            //    sqlCmd.Parameters.AddWithValue("@Username", txtSIUsername.Text.Trim());
            //    sqlCmd.Parameters.AddWithValue("@Password", txtSIPassword.Text.Trim());
            //    int cnt = (sqlCmd.ExecuteScalar()).GetHashCode();
            //    if (cnt == 1)
            //    {
            //        Session["Username"] = txtSIUsername.Text.Trim();
            //        backup.ShowDialog();
            //    }
            //    else
            //    {
            //        lblerror.Visible = true;

            //        txtSIUsername.Clear();
            //        txtSIPassword.Clear();
            //    }
            //}

            
            
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
