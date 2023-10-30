
namespace Group_Assignment
{
    partial class SendCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendCode));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_sendCode = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_StaffID = new System.Windows.Forms.Label();
            this.lbl_ECode = new System.Windows.Forms.Label();
            this.txt_adminID = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.btn_sendcode = new System.Windows.Forms.Button();
            this.btn_validate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.lbl_sendCode);
            this.panel_header.Controls.Add(this.btn_exit);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(587, 62);
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
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_sendCode
            // 
            this.lbl_sendCode.AutoSize = true;
            this.lbl_sendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sendCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_sendCode.Location = new System.Drawing.Point(237, 16);
            this.lbl_sendCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sendCode.Name = "lbl_sendCode";
            this.lbl_sendCode.Size = new System.Drawing.Size(121, 25);
            this.lbl_sendCode.TabIndex = 1;
            this.lbl_sendCode.Text = "Send Code";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(547, 13);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_StaffID
            // 
            this.lbl_StaffID.AutoSize = true;
            this.lbl_StaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_StaffID.Location = new System.Drawing.Point(43, 99);
            this.lbl_StaffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StaffID.Name = "lbl_StaffID";
            this.lbl_StaffID.Size = new System.Drawing.Size(143, 25);
            this.lbl_StaffID.TabIndex = 12;
            this.lbl_StaffID.Text = "Enter Admin ID";
            // 
            // lbl_ECode
            // 
            this.lbl_ECode.AutoSize = true;
            this.lbl_ECode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ECode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_ECode.Location = new System.Drawing.Point(310, 99);
            this.lbl_ECode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ECode.Name = "lbl_ECode";
            this.lbl_ECode.Size = new System.Drawing.Size(111, 25);
            this.lbl_ECode.TabIndex = 13;
            this.lbl_ECode.Text = "Enter Code";
            // 
            // txt_adminID
            // 
            this.txt_adminID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminID.Location = new System.Drawing.Point(48, 142);
            this.txt_adminID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminID.Name = "txt_adminID";
            this.txt_adminID.Size = new System.Drawing.Size(221, 24);
            this.txt_adminID.TabIndex = 14;
            // 
            // txt_code
            // 
            this.txt_code.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(315, 142);
            this.txt_code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(221, 24);
            this.txt_code.TabIndex = 15;
            // 
            // btn_sendcode
            // 
            this.btn_sendcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_sendcode.Location = new System.Drawing.Point(48, 209);
            this.btn_sendcode.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendcode.Name = "btn_sendcode";
            this.btn_sendcode.Size = new System.Drawing.Size(223, 38);
            this.btn_sendcode.TabIndex = 16;
            this.btn_sendcode.Text = "Send Code to Email";
            this.toolTip1.SetToolTip(this.btn_sendcode, "Code will be sent to the email that has been registered with your AdminID");
            this.btn_sendcode.UseVisualStyleBackColor = true;
            this.btn_sendcode.Click += new System.EventHandler(this.btn_sendcode_Click);
            // 
            // btn_validate
            // 
            this.btn_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_validate.Location = new System.Drawing.Point(313, 209);
            this.btn_validate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(223, 38);
            this.btn_validate.TabIndex = 17;
            this.btn_validate.Text = "Validate";
            this.toolTip2.SetToolTip(this.btn_validate, "Validate the code that has been sent to your email");
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // SendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(587, 283);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.btn_sendcode);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_adminID);
            this.Controls.Add(this.lbl_ECode);
            this.Controls.Add(this.lbl_StaffID);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendCode";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_sendCode;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_StaffID;
        private System.Windows.Forms.Label lbl_ECode;
        private System.Windows.Forms.TextBox txt_adminID;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button btn_sendcode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}