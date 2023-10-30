
namespace Group_Assignment
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_resetPassword = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_cNewpass = new System.Windows.Forms.TextBox();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.lbl_confirmNPW = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.cbox_showpw = new System.Windows.Forms.CheckBox();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.lbl_resetPassword);
            this.panel_header.Controls.Add(this.btn_exit);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(587, 62);
            this.panel_header.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_resetPassword
            // 
            this.lbl_resetPassword.AutoSize = true;
            this.lbl_resetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_resetPassword.Location = new System.Drawing.Point(233, 16);
            this.lbl_resetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resetPassword.Name = "lbl_resetPassword";
            this.lbl_resetPassword.Size = new System.Drawing.Size(167, 25);
            this.lbl_resetPassword.TabIndex = 1;
            this.lbl_resetPassword.Text = "Reset Password";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(547, 13);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_submit.Location = new System.Drawing.Point(185, 254);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(223, 38);
            this.btn_submit.TabIndex = 23;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_cNewpass
            // 
            this.txt_cNewpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_cNewpass.Location = new System.Drawing.Point(185, 178);
            this.txt_cNewpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cNewpass.Name = "txt_cNewpass";
            this.txt_cNewpass.PasswordChar = '*';
            this.txt_cNewpass.Size = new System.Drawing.Size(221, 22);
            this.txt_cNewpass.TabIndex = 21;
            // 
            // txt_newpass
            // 
            this.txt_newpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_newpass.Location = new System.Drawing.Point(185, 107);
            this.txt_newpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.PasswordChar = '*';
            this.txt_newpass.Size = new System.Drawing.Size(221, 22);
            this.txt_newpass.TabIndex = 20;
            // 
            // lbl_confirmNPW
            // 
            this.lbl_confirmNPW.AutoSize = true;
            this.lbl_confirmNPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmNPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_confirmNPW.Location = new System.Drawing.Point(181, 154);
            this.lbl_confirmNPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_confirmNPW.Name = "lbl_confirmNPW";
            this.lbl_confirmNPW.Size = new System.Drawing.Size(163, 20);
            this.lbl_confirmNPW.TabIndex = 19;
            this.lbl_confirmNPW.Text = "Confirm Password";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_newPassword.Location = new System.Drawing.Point(181, 83);
            this.lbl_newPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(133, 20);
            this.lbl_newPassword.TabIndex = 18;
            this.lbl_newPassword.Text = "New Password";
            // 
            // cbox_showpw
            // 
            this.cbox_showpw.AutoSize = true;
            this.cbox_showpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.cbox_showpw.Location = new System.Drawing.Point(279, 208);
            this.cbox_showpw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_showpw.Name = "cbox_showpw";
            this.cbox_showpw.Size = new System.Drawing.Size(129, 21);
            this.cbox_showpw.TabIndex = 24;
            this.cbox_showpw.Text = "Show Password";
            this.cbox_showpw.UseVisualStyleBackColor = true;
            this.cbox_showpw.CheckedChanged += new System.EventHandler(this.cbox_showpw_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(587, 314);
            this.Controls.Add(this.cbox_showpw);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.txt_cNewpass);
            this.Controls.Add(this.lbl_newPassword);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.lbl_confirmNPW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_resetPassword;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_cNewpass;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.Label lbl_confirmNPW;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.CheckBox cbox_showpw;
    }
}