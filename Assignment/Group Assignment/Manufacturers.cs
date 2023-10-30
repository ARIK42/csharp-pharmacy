

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MouveForm;
using System.Data.SqlClient;
using System.IO;

namespace Group_Assignment
{
    public partial class Manufacturers : Form
    {
        public Manufacturers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manufacturers_Load(object sender, EventArgs e)
        {
            BindData();
            MouveForm.Mouve.Go(panel_header);
        }

        public void BindData()
        {
            using (SqlConnection con = new SqlConnection("Data Source = DESKTOP-GTNPUJ0\\SQLEXPRESS; " +
                "Initial Catalog = Assignment; Integrated Security = True;"))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Manufacturer", con);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgrid_manufacturer.DataSource = dt;
            }
        }


        public void SearchData(string search)
        {
            using (SqlConnection con = new SqlConnection("Data Source = DESKTOP-GTNPUJ0\\SQLEXPRESS; " +
                    "Initial Catalog = Assignment; Integrated Security = True;"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Manufacturer WHERE (ItemName LIKE '%" + search + "%') OR (ItemID LIKE '%" + search + "%')", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgrid_manufacturer.DataSource = dt;
            }
        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            SearchData(txt_search.Text);
        }
    }
}
