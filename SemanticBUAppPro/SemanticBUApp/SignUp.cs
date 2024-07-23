using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemanticBUApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGLJ33N;Initial Catalog=SemanticBackup;Integrated Security=True");
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into SignUp values('" + txtEmail.Text + "','" + txtPassword.Text.Trim() + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sign Up Successful!");

            this.Close();

            txtEmail.Clear();
            txtPassword.Clear();

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gbTermsandCons.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbTermsandCons.Visible = false;
        }

        private void gbTermsandCons_Enter(object sender, EventArgs e)
        {

        }
    }
}
