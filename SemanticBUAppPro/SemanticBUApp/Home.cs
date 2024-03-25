using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            SignIn Signin = new SignIn();
            Signin.ShowDialog();

            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp Signup = new SignUp();
            Signup.ShowDialog();

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
    }
}
