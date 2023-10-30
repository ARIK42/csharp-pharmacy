
namespace Group_Assignment
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_adminID = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.cbox_showpw = new System.Windows.Forms.CheckBox();
            this.txt_AdminID = new System.Windows.Forms.TextBox();
            this.txt_adminPass = new System.Windows.Forms.TextBox();
            this.lbl_register = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cbox_remember = new System.Windows.Forms.CheckBox();
            this.lbl_forgot = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.lbl_login);
            this.panel_header.Controls.Add(this.btn_exit);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(467, 62);
            this.panel_header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_login.Location = new System.Drawing.Point(179, 16);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(146, 29);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Login Page";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(427, 13);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_adminID
            // 
            this.lbl_adminID.AutoSize = true;
            this.lbl_adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_adminID.Location = new System.Drawing.Point(52, 140);
            this.lbl_adminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adminID.Name = "lbl_adminID";
            this.lbl_adminID.Size = new System.Drawing.Size(92, 24);
            this.lbl_adminID.TabIndex = 2;
            this.lbl_adminID.Text = "ADMIN ID";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_password.Location = new System.Drawing.Point(52, 247);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(118, 24);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "PASSWORD";
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_login.Location = new System.Drawing.Point(47, 358);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(180, 42);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cbox_showpw
            // 
            this.cbox_showpw.AutoSize = true;
            this.cbox_showpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.cbox_showpw.Location = new System.Drawing.Point(295, 279);
            this.cbox_showpw.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_showpw.Name = "cbox_showpw";
            this.cbox_showpw.Size = new System.Drawing.Size(129, 21);
            this.cbox_showpw.TabIndex = 5;
            this.cbox_showpw.Text = "Show Password";
            this.cbox_showpw.UseVisualStyleBackColor = true;
            this.cbox_showpw.CheckedChanged += new System.EventHandler(this.cbox_showpw_CheckedChanged);
            // 
            // txt_AdminID
            // 
            this.txt_AdminID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_AdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminID.Location = new System.Drawing.Point(203, 137);
            this.txt_AdminID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminID.Name = "txt_AdminID";
            this.txt_AdminID.Size = new System.Drawing.Size(221, 27);
            this.txt_AdminID.TabIndex = 6;
            this.txt_AdminID.TextChanged += new System.EventHandler(this.txt_AdminID_TextChanged);
            // 
            // txt_adminPass
            // 
            this.txt_adminPass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_adminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminPass.Location = new System.Drawing.Point(203, 244);
            this.txt_adminPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminPass.Name = "txt_adminPass";
            this.txt_adminPass.PasswordChar = '*';
            this.txt_adminPass.Size = new System.Drawing.Size(221, 27);
            this.txt_adminPass.TabIndex = 7;
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_register.Location = new System.Drawing.Point(124, 483);
            this.lbl_register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(248, 17);
            this.lbl_register.TabIndex = 12;
            this.lbl_register.Text = "Not registed? Go to Registration page";
            this.lbl_register.Click += new System.EventHandler(this.lbl_register_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_clear.Location = new System.Drawing.Point(245, 358);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(180, 42);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cbox_remember
            // 
            this.cbox_remember.AutoSize = true;
            this.cbox_remember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.cbox_remember.Location = new System.Drawing.Point(302, 172);
            this.cbox_remember.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_remember.Name = "cbox_remember";
            this.cbox_remember.Size = new System.Drawing.Size(122, 21);
            this.cbox_remember.TabIndex = 14;
            this.cbox_remember.Text = "Remember Me";
            this.cbox_remember.UseVisualStyleBackColor = true;
            // 
            // lbl_forgot
            // 
            this.lbl_forgot.AutoSize = true;
            this.lbl_forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_forgot.Location = new System.Drawing.Point(178, 443);
            this.lbl_forgot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_forgot.Name = "lbl_forgot";
            this.lbl_forgot.Size = new System.Drawing.Size(122, 17);
            this.lbl_forgot.TabIndex = 15;
            this.lbl_forgot.Text = "Forgot Password?";
            this.lbl_forgot.Click += new System.EventHandler(this.lbl_forgot_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(467, 547);
            this.Controls.Add(this.lbl_forgot);
            this.Controls.Add(this.cbox_remember);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.txt_adminPass);
            this.Controls.Add(this.txt_AdminID);
            this.Controls.Add(this.cbox_showpw);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_adminID);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_adminID;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox cbox_showpw;
        private System.Windows.Forms.TextBox txt_AdminID;
        private System.Windows.Forms.TextBox txt_adminPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.CheckBox cbox_remember;
        private System.Windows.Forms.Label lbl_forgot;
    }
}