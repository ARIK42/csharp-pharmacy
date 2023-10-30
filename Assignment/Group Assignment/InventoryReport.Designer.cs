
namespace Group_Assignment
{
    partial class InventoryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReport));
            this.lbl_IM = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dgrid_table = new System.Windows.Forms.DataGridView();
            this.btn_Report = new System.Windows.Forms.Button();
            this.lbl_itemsearching = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.InventoryDoc = new System.Drawing.Printing.PrintDocument();
            this.btn_totItem = new System.Windows.Forms.Button();
            this.btn_totValue = new System.Windows.Forms.Button();
            this.lbl_totalItems = new System.Windows.Forms.Label();
            this.lbl_iValue = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_table)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IM
            // 
            this.lbl_IM.AutoSize = true;
            this.lbl_IM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_IM.Location = new System.Drawing.Point(478, 30);
            this.lbl_IM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IM.Name = "lbl_IM";
            this.lbl_IM.Size = new System.Drawing.Size(216, 29);
            this.lbl_IM.TabIndex = 1;
            this.lbl_IM.Text = "Report Generator";
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
            this.panel_header.Size = new System.Drawing.Size(1179, 62);
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
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(1139, 13);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgrid_table
            // 
            this.dgrid_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.dgrid_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_table.Location = new System.Drawing.Point(277, 137);
            this.dgrid_table.Margin = new System.Windows.Forms.Padding(4);
            this.dgrid_table.Name = "dgrid_table";
            this.dgrid_table.RowHeadersWidth = 51;
            this.dgrid_table.Size = new System.Drawing.Size(863, 508);
            this.dgrid_table.TabIndex = 12;
            // 
            // btn_Report
            // 
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_Report.Location = new System.Drawing.Point(50, 150);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(191, 71);
            this.btn_Report.TabIndex = 14;
            this.btn_Report.Text = "Generate Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // lbl_itemsearching
            // 
            this.lbl_itemsearching.AutoSize = true;
            this.lbl_itemsearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemsearching.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.lbl_itemsearching.Location = new System.Drawing.Point(807, 99);
            this.lbl_itemsearching.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemsearching.Name = "lbl_itemsearching";
            this.lbl_itemsearching.Size = new System.Drawing.Size(110, 20);
            this.lbl_itemsearching.TabIndex = 16;
            this.lbl_itemsearching.Text = "Item Search";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(954, 96);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(186, 27);
            this.txt_search.TabIndex = 15;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // InventoryDoc
            // 
            this.InventoryDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.InventoryDoc_PrintPage);
            // 
            // btn_totItem
            // 
            this.btn_totItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_totItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_totItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_totItem.Location = new System.Drawing.Point(50, 301);
            this.btn_totItem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_totItem.Name = "btn_totItem";
            this.btn_totItem.Size = new System.Drawing.Size(191, 53);
            this.btn_totItem.TabIndex = 19;
            this.btn_totItem.Text = "Total Items";
            this.btn_totItem.UseVisualStyleBackColor = true;
            this.btn_totItem.Click += new System.EventHandler(this.btn_totItem_Click);
            // 
            // btn_totValue
            // 
            this.btn_totValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_totValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_totValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(163)))));
            this.btn_totValue.Location = new System.Drawing.Point(50, 458);
            this.btn_totValue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_totValue.Name = "btn_totValue";
            this.btn_totValue.Size = new System.Drawing.Size(191, 53);
            this.btn_totValue.TabIndex = 18;
            this.btn_totValue.Text = "Inventory Value";
            this.btn_totValue.UseVisualStyleBackColor = true;
            this.btn_totValue.Click += new System.EventHandler(this.btn_totValue_Click);
            // 
            // lbl_totalItems
            // 
            this.lbl_totalItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.lbl_totalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalItems.ForeColor = System.Drawing.Color.White;
            this.lbl_totalItems.Location = new System.Drawing.Point(105, 370);
            this.lbl_totalItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalItems.Name = "lbl_totalItems";
            this.lbl_totalItems.Size = new System.Drawing.Size(136, 34);
            this.lbl_totalItems.TabIndex = 20;
            this.lbl_totalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_totalItems.Click += new System.EventHandler(this.lbl_totalItems_Click);
            // 
            // lbl_iValue
            // 
            this.lbl_iValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.lbl_iValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iValue.ForeColor = System.Drawing.Color.White;
            this.lbl_iValue.Location = new System.Drawing.Point(105, 524);
            this.lbl_iValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_iValue.Name = "lbl_iValue";
            this.lbl_iValue.Size = new System.Drawing.Size(136, 34);
            this.lbl_iValue.TabIndex = 21;
            this.lbl_iValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.lbl_iValue);
            this.Controls.Add(this.lbl_totalItems);
            this.Controls.Add(this.btn_totItem);
            this.Controls.Add(this.btn_totValue);
            this.Controls.Add(this.lbl_itemsearching);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.dgrid_table);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryReport";
            this.Load += new System.EventHandler(this.InventoryReport_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IM;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dgrid_table;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label lbl_itemsearching;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument InventoryDoc;
        private System.Windows.Forms.Button btn_totItem;
        private System.Windows.Forms.Button btn_totValue;
        private System.Windows.Forms.Label lbl_totalItems;
        private System.Windows.Forms.Label lbl_iValue;
    }
}