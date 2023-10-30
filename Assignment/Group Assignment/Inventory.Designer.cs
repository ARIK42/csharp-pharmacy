
namespace Group_Assignment
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_IM = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dgrid_inventory = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.lbl_itemsearching = new System.Windows.Forms.Label();
            this.lbl_adminName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_manufacturer = new System.Windows.Forms.Button();
            this.lbl_aboutUs = new System.Windows.Forms.Label();
            this.lbl_adminID = new System.Windows.Forms.Label();
            this.lbl_logID = new System.Windows.Forms.Label();
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
            this.panel_header.Controls.Add(this.lbl_IM);
            this.panel_header.Controls.Add(this.btn_exit);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1200, 62);
            this.panel_header.TabIndex = 2;
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
            this.lbl_IM.Location = new System.Drawing.Point(485, 24);
            this.lbl_IM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IM.Name = "lbl_IM";
            this.lbl_IM.Size = new System.Drawing.Size(227, 29);
            this.lbl_IM.TabIndex = 1;
            this.lbl_IM.Text = "Inventory Manager";
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
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgrid_inventory
            // 
            this.dgrid_inventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.dgrid_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_inventory.Location = new System.Drawing.Point(272, 209);
            this.dgrid_inventory.Margin = new System.Windows.Forms.Padding(4);
            this.dgrid_inventory.Name = "dgrid_inventory";
            this.dgrid_inventory.RowHeadersWidth = 51;
            this.dgrid_inventory.Size = new System.Drawing.Size(870, 461);
            this.dgrid_inventory.TabIndex = 3;
            this.dgrid_inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_inventory_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(954, 148);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(186, 27);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_Report
            // 
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_Report.Location = new System.Drawing.Point(52, 489);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(170, 60);
            this.btn_Report.TabIndex = 13;
            this.btn_Report.Text = "Report Page";
            this.toolTip1.SetToolTip(this.btn_Report, "Click here to move to Report Page");
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // lbl_itemsearching
            // 
            this.lbl_itemsearching.AutoSize = true;
            this.lbl_itemsearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemsearching.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_itemsearching.Location = new System.Drawing.Point(804, 151);
            this.lbl_itemsearching.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemsearching.Name = "lbl_itemsearching";
            this.lbl_itemsearching.Size = new System.Drawing.Size(110, 20);
            this.lbl_itemsearching.TabIndex = 11;
            this.lbl_itemsearching.Text = "Item Search";
            // 
            // lbl_adminName
            // 
            this.lbl_adminName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_adminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_adminName.Location = new System.Drawing.Point(155, 96);
            this.lbl_adminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adminName.Name = "lbl_adminName";
            this.lbl_adminName.Size = new System.Drawing.Size(165, 28);
            this.lbl_adminName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Welcome! ";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_add.Location = new System.Drawing.Point(52, 222);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(170, 60);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add | Delete";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_update.Location = new System.Drawing.Point(52, 311);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(170, 60);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_manufacturer
            // 
            this.btn_manufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_manufacturer.Location = new System.Drawing.Point(52, 578);
            this.btn_manufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_manufacturer.Name = "btn_manufacturer";
            this.btn_manufacturer.Size = new System.Drawing.Size(170, 60);
            this.btn_manufacturer.TabIndex = 25;
            this.btn_manufacturer.Text = "Manufacturer";
            this.toolTip1.SetToolTip(this.btn_manufacturer, "Click here to move to Report Page");
            this.btn_manufacturer.UseVisualStyleBackColor = true;
            this.btn_manufacturer.Click += new System.EventHandler(this.btn_manufacturer_Click);
            // 
            // lbl_aboutUs
            // 
            this.lbl_aboutUs.AutoSize = true;
            this.lbl_aboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_aboutUs.Location = new System.Drawing.Point(23, 699);
            this.lbl_aboutUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aboutUs.Name = "lbl_aboutUs";
            this.lbl_aboutUs.Size = new System.Drawing.Size(86, 20);
            this.lbl_aboutUs.TabIndex = 21;
            this.lbl_aboutUs.Text = "About Us";
            this.lbl_aboutUs.Click += new System.EventHandler(this.lbl_aboutUs_Click);
            // 
            // lbl_adminID
            // 
            this.lbl_adminID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_adminID.Location = new System.Drawing.Point(80, 143);
            this.lbl_adminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adminID.Name = "lbl_adminID";
            this.lbl_adminID.Size = new System.Drawing.Size(76, 28);
            this.lbl_adminID.TabIndex = 22;
            // 
            // lbl_logID
            // 
            this.lbl_logID.AutoSize = true;
            this.lbl_logID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_logID.Location = new System.Drawing.Point(32, 143);
            this.lbl_logID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_logID.Name = "lbl_logID";
            this.lbl_logID.Size = new System.Drawing.Size(40, 25);
            this.lbl_logID.TabIndex = 23;
            this.lbl_logID.Text = "ID:";
            // 
            // btn_sell
            // 
            this.btn_sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_sell.Location = new System.Drawing.Point(52, 400);
            this.btn_sell.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(170, 60);
            this.btn_sell.TabIndex = 26;
            this.btn_sell.Text = "Sell";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click_1);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_manufacturer);
            this.Controls.Add(this.lbl_logID);
            this.Controls.Add(this.lbl_adminID);
            this.Controls.Add(this.lbl_aboutUs);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_adminName);
            this.Controls.Add(this.lbl_itemsearching);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgrid_inventory);
            this.Controls.Add(this.panel_header);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
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
        private System.Windows.Forms.Label lbl_IM;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dgrid_inventory;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label lbl_itemsearching;
        private System.Windows.Forms.Label lbl_adminName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_aboutUs;
        private System.Windows.Forms.Label lbl_adminID;
        private System.Windows.Forms.Label lbl_logID;
        private System.Windows.Forms.Button btn_manufacturer;
        private System.Windows.Forms.Button btn_sell;
    }
}