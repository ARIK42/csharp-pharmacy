
namespace Group_Assignment
{
    partial class Manufacturers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manufacturers));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_IM = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgrid_manufacturer = new System.Windows.Forms.DataGridView();
            this.lbl_itemsearching = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_manufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_header.Controls.Add(this.button1);
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.lbl_IM);
            this.panel_header.Controls.Add(this.btn_exit);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(694, 62);
            this.panel_header.TabIndex = 3;
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
            // lbl_IM
            // 
            this.lbl_IM.AutoSize = true;
            this.lbl_IM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_IM.Location = new System.Drawing.Point(227, 21);
            this.lbl_IM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IM.Name = "lbl_IM";
            this.lbl_IM.Size = new System.Drawing.Size(260, 29);
            this.lbl_IM.TabIndex = 1;
            this.lbl_IM.Text = "Manfacturer\'s Record";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(1160, 13);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(650, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgrid_manufacturer
            // 
            this.dgrid_manufacturer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.dgrid_manufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_manufacturer.Location = new System.Drawing.Point(37, 165);
            this.dgrid_manufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.dgrid_manufacturer.Name = "dgrid_manufacturer";
            this.dgrid_manufacturer.RowHeadersWidth = 51;
            this.dgrid_manufacturer.Size = new System.Drawing.Size(610, 242);
            this.dgrid_manufacturer.TabIndex = 4;
            // 
            // lbl_itemsearching
            // 
            this.lbl_itemsearching.AutoSize = true;
            this.lbl_itemsearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemsearching.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_itemsearching.Location = new System.Drawing.Point(306, 112);
            this.lbl_itemsearching.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemsearching.Name = "lbl_itemsearching";
            this.lbl_itemsearching.Size = new System.Drawing.Size(110, 20);
            this.lbl_itemsearching.TabIndex = 13;
            this.lbl_itemsearching.Text = "Item Search";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(456, 109);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(186, 27);
            this.txt_search.TabIndex = 12;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            // 
            // Manufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.lbl_itemsearching);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgrid_manufacturer);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manufacturers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manufacturers";
            this.Load += new System.EventHandler(this.Manufacturers_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_manufacturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_IM;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgrid_manufacturer;
        private System.Windows.Forms.Label lbl_itemsearching;
        private System.Windows.Forms.TextBox txt_search;
    }
}