
namespace Group_Assignment
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_register = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dgrid_inventory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_inventory)).BeginInit();
            this.SuspendLayout();
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
            this.panel_header.Size = new System.Drawing.Size(687, 62);
            this.panel_header.TabIndex = 53;
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
            this.lbl_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_register.Location = new System.Drawing.Point(284, 17);
            this.lbl_register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(129, 29);
            this.lbl_register.TabIndex = 1;
            this.lbl_register.Text = "Sell Items";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(647, 17);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgrid_inventory
            // 
            this.dgrid_inventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.dgrid_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_inventory.Location = new System.Drawing.Point(39, 298);
            this.dgrid_inventory.Margin = new System.Windows.Forms.Padding(4);
            this.dgrid_inventory.Name = "dgrid_inventory";
            this.dgrid_inventory.RowHeadersWidth = 51;
            this.dgrid_inventory.Size = new System.Drawing.Size(611, 306);
            this.dgrid_inventory.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(194, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Quantity";
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_itemID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_itemID.Location = new System.Drawing.Point(194, 123);
            this.lbl_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(63, 20);
            this.lbl_itemID.TabIndex = 63;
            this.lbl_itemID.Text = "Item ID";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_quantity.Location = new System.Drawing.Point(302, 171);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(205, 26);
            this.txt_quantity.TabIndex = 58;
            // 
            // txt_itemID
            // 
            this.txt_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_itemID.Location = new System.Drawing.Point(302, 121);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(205, 26);
            this.txt_itemID.TabIndex = 57;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_clear.Location = new System.Drawing.Point(361, 227);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(146, 38);
            this.btn_clear.TabIndex = 56;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_sell.Location = new System.Drawing.Point(198, 227);
            this.btn_sell.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(146, 38);
            this.btn_sell.TabIndex = 55;
            this.btn_sell.Text = "Sell";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(687, 640);
            this.Controls.Add(this.dgrid_inventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_itemID);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_itemID);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.Sell_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dgrid_inventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_sell;
    }
}