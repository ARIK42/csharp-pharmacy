
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouveForm;
using System.Data.SqlClient;

namespace Group_Assignment
{
    public partial class InventoryReport : Form
    {
        Bitmap imagePrint;
       
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(imagePrint, 0, 0);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            //Process of Print Preview
            Panel panel = new Panel();
            this.Controls.Add(panel);

            //GDI+ is graphics engine in . NET that allows developers to build graphics applications for Windows. 
            //The Graphics class provides methods for drawing objects to the display device

            Graphics graphics = panel.CreateGraphics();
            Size formSize = this.ClientSize;

            //Initializes a new instance of the Bitmap class with the specified size and with the resolution of the
            //specified Graphics object.

            imagePrint = new Bitmap(formSize.Width, formSize.Height, graphics);
            //Creates a new Graphics from the specified Image.
            graphics = Graphics.FromImage(imagePrint);
            Point panelLocation = PointToScreen(panel.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = InventoryDoc;
            printPreviewDialog1.ShowDialog();

        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            BindData();
            MouveForm.Mouve.Go(panel_header);
        }

        public void BindData()
        {
            DataTable dt = new DataTable();
            dt = UserDatabase.FillData();
            dgrid_table.DataSource = dt;
        }

        private void btn_totValue_Click(object sender, EventArgs e)
        {
            lbl_iValue.Text = UserDatabase.CalculateValue().ToString("C");
        }

        private void btn_totItem_Click(object sender, EventArgs e)
        {
            lbl_totalItems.Text = UserDatabase.CalculateTotal().ToString();
        }

        public void SearchData(string search)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTNPUJ0\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory WHERE (UnitName LIKE '%" + search + "%') OR (ItemID LIKE '%" + search + "%')", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgrid_table.DataSource = dt;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchData(txt_search.Text);
        }

        private void lbl_totalItems_Click(object sender, EventArgs e)
        {

        }
    }
}
