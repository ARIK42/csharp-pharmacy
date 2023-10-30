

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Group_Assignment
{
    public partial class SendCode : Form
    {
        private string randomCode;
        private string adminID;
        public SendCode()
        {
            InitializeComponent();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btn_sendcode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            adminID = txt_adminID.Text;

            if (adminID == "")
            {
                MessageBox.Show("Please enter your Admin ID", "Empty Field", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_adminID.Focus();
            }

            else
            {
                string email = UserDatabase.FindEmail(adminID);
                if (email == "")
                {
                    MessageBox.Show("Admin ID doesn't exist in the system!", "Warning", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                }
                else
                {
                    randomCode = (rand.Next(999999)).ToString();
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("segipharmaceuticals@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Reset OTP";
                        mail.Body = "Your OTP is " + randomCode;
                        //email.Attachments.Add(new Attachment("the physical file path"));

                        using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")) //gmail's smtp server for outgoing email
                    {
                            smtpClient.Credentials = new NetworkCredential("segipharmaceuticals@gmail.com", "1q@W3e$R");
                            smtpClient.EnableSsl = true;
                            try
                            {
                                smtpClient.Send(mail);
                                MessageBox.Show("Code sent successfully. Please check your email.", "Code sent",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }

        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please fill in your code", "Empty Field", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

            else if (txt_code.Text == randomCode)
            {
                ChangePassword cp = new ChangePassword(adminID);
                cp.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong code entered!", "Warning", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }

        }
    }
}
