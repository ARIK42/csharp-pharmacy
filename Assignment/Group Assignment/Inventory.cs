

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
    public partial class Inventory : Form
    {
        internal static Inventory inven1;
        private string inven_adminID;
        private object[] adminName = new object[1];
        

        public Inventory(string adminID)
        {
            InitializeComponent();
            inven_adminID = adminID;
            inven1 = this;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            lbl_adminID.Text = inven_adminID;
            UserDatabase.ReadProfile(adminName,inven_adminID);
            lbl_adminName.Text = Convert.ToString(adminName[0]);
            BindData();
            MouveForm.Mouve.Go(panel_header);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddItem add = new AddItem();
            add.ShowDialog();

        }

        private void lbl_aboutUs_Click(object sender, EventArgs e)
        {
            AboutUs us = new AboutUs(inven_adminID);
            us.Show();
            this.Close();
        }

        public void BindData()
        {
            DataTable dt = new DataTable();
            dt = UserDatabase.FillData();
            dgrid_inventory.DataSource = dt;
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            InventoryReport rep = new InventoryReport();
            rep.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateItem updt = new UpdateItem();
            updt.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

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
                dgrid_inventory.DataSource = dt;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchData(txt_search.Text);
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            UpdateItem SI = new UpdateItem();
            SI.ShowDialog();
        }

        private void dgrid_inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_manufacturer_Click(object sender, EventArgs e)
        {
            Manufacturers manu = new Manufacturers();
            manu.ShowDialog();
        }

        private void btn_sell_Click_1(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.ShowDialog();
        }
    }
}
