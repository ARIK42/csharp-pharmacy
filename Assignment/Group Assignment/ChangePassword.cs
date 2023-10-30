
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    public partial class ChangePassword : Form
    {
        private string cpAdminID;
        public ChangePassword(string adminID)
        {
            InitializeComponent();
            cpAdminID = adminID;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_newpass.Text == "" || txt_cNewpass.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Empty Fields", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            else if (txt_newpass.Text != txt_cNewpass.Text)
            {
                MessageBox.Show("Password does not match! Please re-enter.", "Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txt_newpass.Focus();
                txt_cNewpass.SelectAll();
            }
            else
            {
                string adminPassword = txt_newpass.Text;
                bool result = UserDatabase.ChangePassword(cpAdminID, adminPassword);

                if (result == false)
                {
                    if (MessageBox.Show("Password update failed. \nDo you want to start again?", "Update Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        SendCode sc = new SendCode();
                        sc.Show();
                        this.Close();
                    }
                    else
                    {
                        Login log = new Login();
                        log.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Password changed sucessfully.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login log = new Login();
                    log.Show();
                    this.Close();
                }
            }
        }

        private void cbox_showpw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_showpw.Checked)
            {
                txt_cNewpass.PasswordChar = '\0';
                txt_newpass.PasswordChar = '\0';
            }
            else
            {
                txt_newpass.PasswordChar = '*';
                txt_cNewpass.PasswordChar = '*';
            }

        }
    }
}
