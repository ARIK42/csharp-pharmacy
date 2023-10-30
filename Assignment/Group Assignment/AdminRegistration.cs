


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MouveForm;
using System.Data.SqlClient;

namespace Group_Assignment
{
    public partial class AdminRegistration : Form
    {
        bool errorPassword;
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_adminID.Text == "" || txt_adminName.Text == "" || txt_adminPass.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (errorPassword == true)
            {
                MessageBox.Show("Please provide valid email address", "Invalid Email", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            else if (txt_adminPass.Text != txt_cAdminPass.Text)
            {
                MessageBox.Show("Password does not match! \nPlease re-enter", "Registration Failed",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_adminPass.Focus();
                txt_cAdminPass.SelectAll();
            }

            else
            {
                string adminID = txt_adminID.Text;
                string adminName = txt_adminName.Text;
                string adminPassword = txt_adminPass.Text;
                string adminEmail = txt_adminEmail.Text;

                //Calling the AddUser method in UserDatabase class to create the user account
                bool result = UserDatabase.AddUser(adminID, adminPassword, adminName, adminEmail);

                if (result == true) //User account is created successfullly
                {
                    MessageBox.Show("Registration Successful!", "Information", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ClearFields();
                }
                else //User account could not be created due to violation of primary key - Staff ID
                {
                    MessageBox.Show("Staff ID has already been registered in the system", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    txt_adminID.Focus();
                    txt_adminID.SelectAll();
                }
            }
        }

        private void ClearFields()
        {
            txt_adminID.Text = txt_adminName.Text = txt_adminPass.Text = "";
        }

        private void cbox_showpw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_showpw.Checked == true)
            {
                txt_adminPass.PasswordChar = '\0';
                txt_cAdminPass.PasswordChar = '\0';
            }
            else
            {
                txt_adminPass.PasswordChar = '*';
                txt_cAdminPass.PasswordChar = '*';
            }
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void txt_adminEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([a-zA-Z0-9_\\.-]+)@([a-zA-Z0-9_\\.-]+)([a-zA-Z0-9_\\.-]+)\\.([a-zA-Z]{2,6})$";
            if (Regex.IsMatch(txt_adminEmail.Text, pattern))
            {
                error_email.Clear();
                errorPassword = false;
            }
            else
            {
                error_email.SetError(this.txt_adminEmail, "Please provide valid email address");
                errorPassword = true;
            }

        }
    }
}
