using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SemanticBUApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //SignIn Signin = new SignIn();
            //Signin.ShowDialog();

            // Get the current Windows user
            string currentUsername = WindowsIdentity.GetCurrent().Name;

            // Log the user in directly
            Home home = new Home();
            home.Close();

            // Pass the Windows username to the next form
            Form1 backup = new Form1(currentUsername);
            
            backup.ShowDialog();
            this.Close();


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //SignUp Signup = new SignUp();
            //Signup.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gbCredits.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             gbCredits.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             gbCredits.Visible = false;
        }
    }
}
