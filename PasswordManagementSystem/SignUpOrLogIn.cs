using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementSystem
{
    public partial class SignUpOrLogInForm : Form
    {
        public SignUpOrLogInForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm f2 = new LogInForm();
            f2.ShowDialog();
            this.Close(); 
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {            
            this.Hide();
            SignUpForm f1 = new SignUpForm();
            f1.ShowDialog();
            this.Close();
        }
    }
}
