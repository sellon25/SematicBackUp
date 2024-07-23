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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
