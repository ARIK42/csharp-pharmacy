
namespace Group_Assignment
{
    partial class AdminRegistration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegistration));
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_register = new System.Windows.Forms.Label();
            this.lbl_adminID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_adminID = new System.Windows.Forms.TextBox();
            this.txt_adminName = new System.Windows.Forms.TextBox();
            this.txt_adminPass = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.cbox_showpw = new System.Windows.Forms.CheckBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_adminEmail = new System.Windows.Forms.Label();
            this.txt_adminEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cAdminPass = new System.Windows.Forms.TextBox();
            this.error_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(608, 13);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.lbl_register);
            this.panel_header.Controls.Add(this.btn_exit);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(652, 62);
            this.panel_header.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_register.Location = new System.Drawing.Point(279, 20);
            this.lbl_register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(126, 25);
            this.lbl_register.TabIndex = 1;
            this.lbl_register.Text = "Registration";
            // 
            // lbl_adminID
            // 
            this.lbl_adminID.AutoSize = true;
            this.lbl_adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_adminID.Location = new System.Drawing.Point(79, 105);
            this.lbl_adminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adminID.Name = "lbl_adminID";
            this.lbl_adminID.Size = new System.Drawing.Size(78, 20);
            this.lbl_adminID.TabIndex = 2;
            this.lbl_adminID.Text = "Admin ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_name.Location = new System.Drawing.Point(79, 161);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(105, 20);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Admin Name";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_pass.Location = new System.Drawing.Point(79, 273);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(83, 20);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password";
            // 
            // txt_adminID
            // 
            this.txt_adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminID.Location = new System.Drawing.Point(306, 103);
            this.txt_adminID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminID.Name = "txt_adminID";
            this.txt_adminID.Size = new System.Drawing.Size(251, 27);
            this.txt_adminID.TabIndex = 5;
            // 
            // txt_adminName
            // 
            this.txt_adminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminName.Location = new System.Drawing.Point(306, 159);
            this.txt_adminName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminName.Name = "txt_adminName";
            this.txt_adminName.Size = new System.Drawing.Size(251, 27);
            this.txt_adminName.TabIndex = 6;
            // 
            // txt_adminPass
            // 
            this.txt_adminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminPass.Location = new System.Drawing.Point(306, 271);
            this.txt_adminPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminPass.Name = "txt_adminPass";
            this.txt_adminPass.PasswordChar = '*';
            this.txt_adminPass.Size = new System.Drawing.Size(251, 27);
            this.txt_adminPass.TabIndex = 7;
            // 
            // btn_register
            // 
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_register.Location = new System.Drawing.Point(241, 402);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(164, 42);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cbox_showpw
            // 
            this.cbox_showpw.AutoSize = true;
            this.cbox_showpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.cbox_showpw.Location = new System.Drawing.Point(428, 366);
            this.cbox_showpw.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_showpw.Name = "cbox_showpw";
            this.cbox_showpw.Size = new System.Drawing.Size(129, 21);
            this.cbox_showpw.TabIndex = 10;
            this.cbox_showpw.Text = "Show Password";
            this.cbox_showpw.UseVisualStyleBackColor = true;
            this.cbox_showpw.CheckedChanged += new System.EventHandler(this.cbox_showpw_CheckedChanged);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_login.Location = new System.Drawing.Point(216, 467);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(228, 17);
            this.lbl_login.TabIndex = 11;
            this.lbl_login.Text = "Already registed? Go to login page";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // lbl_adminEmail
            // 
            this.lbl_adminEmail.AutoSize = true;
            this.lbl_adminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_adminEmail.Location = new System.Drawing.Point(79, 217);
            this.lbl_adminEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adminEmail.Name = "lbl_adminEmail";
            this.lbl_adminEmail.Size = new System.Drawing.Size(51, 20);
            this.lbl_adminEmail.TabIndex = 12;
            this.lbl_adminEmail.Text = "Email";
            // 
            // txt_adminEmail
            // 
            this.txt_adminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminEmail.Location = new System.Drawing.Point(306, 215);
            this.txt_adminEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminEmail.Name = "txt_adminEmail";
            this.txt_adminEmail.Size = new System.Drawing.Size(251, 27);
            this.txt_adminEmail.TabIndex = 13;
            this.txt_adminEmail.Leave += new System.EventHandler(this.txt_adminEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(79, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirm Password";
            // 
            // txt_cAdminPass
            // 
            this.txt_cAdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cAdminPass.Location = new System.Drawing.Point(306, 327);
            this.txt_cAdminPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cAdminPass.Name = "txt_cAdminPass";
            this.txt_cAdminPass.PasswordChar = '*';
            this.txt_cAdminPass.Size = new System.Drawing.Size(251, 27);
            this.txt_cAdminPass.TabIndex = 15;
            // 
            // error_email
            // 
            this.error_email.ContainerControl = this;
            // 
            // AdminRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(652, 506);
            this.Controls.Add(this.txt_cAdminPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_adminEmail);
            this.Controls.Add(this.lbl_adminEmail);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.cbox_showpw);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_adminPass);
            this.Controls.Add(this.txt_adminName);
            this.Controls.Add(this.txt_adminID);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_adminID);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRegistration";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Label lbl_adminID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_adminID;
        private System.Windows.Forms.TextBox txt_adminName;
        private System.Windows.Forms.TextBox txt_adminPass;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbox_showpw;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_adminEmail;
        private System.Windows.Forms.TextBox txt_adminEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cAdminPass;
        private System.Windows.Forms.ErrorProvider error_email;
    }
}