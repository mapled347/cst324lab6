using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST324LAB5_Dana_Posey
{
    public partial class frmAdminLogin : Form
    {
        // the username and password should be added to the database to be stored so it can be changed
        // it will be hard-coded for now because it is not a requirement of Lab 5

        private string username = "admin";
        private string password = "password";

        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsPresent())
            {
                if (IsValidCredentials(txtUsername.Text, txtPassword.Text))
                {
                    frmResponseMaintenance responseMaintenance = new frmResponseMaintenance();
                    DialogResult result = responseMaintenance.ShowDialog();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsPresent()
        {
            return
                Validator.IsPresent(txtUsername, "Username") &&
                Validator.IsPresent(txtPassword, "Password");
        }

        private bool IsValidCredentials(string u, string p)
        {
            if (u == username && p == password)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username or password is incorrect", "ERROR!");
                txtUsername.Focus();
                return false;          
            }

        }
    }
}
