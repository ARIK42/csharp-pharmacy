
namespace Group_Assignment
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pbox_logo = new System.Windows.Forms.PictureBox();
            this.timer_splash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_logo.Location = new System.Drawing.Point(34, 297);
            this.lbl_logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(217, 36);
            this.lbl_logo.TabIndex = 1;
            this.lbl_logo.Text = "SEGi Pharmaceuticals";
            // 
            // pbox_logo
            // 
            this.pbox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pbox_logo.Image")));
            this.pbox_logo.Location = new System.Drawing.Point(73, 101);
            this.pbox_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pbox_logo.Name = "pbox_logo";
            this.pbox_logo.Size = new System.Drawing.Size(163, 151);
            this.pbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_logo.TabIndex = 2;
            this.pbox_logo.TabStop = false;
            // 
            // timer_splash
            // 
            this.timer_splash.Enabled = true;
            this.timer_splash.Interval = 2000;
            this.timer_splash.Tick += new System.EventHandler(this.timer_splash_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(311, 425);
            this.Controls.Add(this.pbox_logo);
            this.Controls.Add(this.lbl_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.PictureBox pbox_logo;
        private System.Windows.Forms.Timer timer_splash;
    }
}

