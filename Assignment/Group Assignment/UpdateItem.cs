

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group_Assignment
{
    public partial class UpdateItem : Form
    {

        public UpdateItem()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
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
                SqlCommand command = new SqlCommand("SELECT * FROM Inventory", con);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgrid_inventory.DataSource = dt;
            }
        }

        public bool Check()
        {
            bool found = false;
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTNPUJ0\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True"))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Inventory WHERE ItemID = '" + txt_itemID.Text + "' ", con);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    found = true; //Item ID exist in the table
                }
            }
            return found;
        }


        private void btn_updt_Click(object sender, EventArgs e)
        {
            bool found = Check();
            if (found == false)
            {
                MessageBox.Show("Empty field(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source = DESKTOP-GTNPUJ0\\SQLEXPRESS; " +
                    "Initial Catalog = Assignment; Integrated Security = True;"))

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Inventory SET UnitName = @UnitName, Category = " +
                    "@Category, UnitsOrdered = @UnitsOrdered, UnitsAvailable = @UnitsAvailable, " +
                    "StorePrice = @StorePrice WHERE ItemID = @ItemID ", con);

                try
                {
                    cmd.Parameters.AddWithValue("@UnitName", txt_itemName.Text);
                    cmd.Parameters.AddWithValue("@category", txt_category.Text);
                    cmd.Parameters.AddWithValue("@UnitsOrdered", int.Parse(txt_order.Text));
                    cmd.Parameters.AddWithValue("@UnitsAvailable", int.Parse(txt_available.Text));
                    cmd.Parameters.AddWithValue("@StorePrice", int.Parse(txt_price.Text));
                    cmd.Parameters.AddWithValue("@ItemID", txt_itemID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data is sucessfully updated", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }

                catch
                {
                    MessageBox.Show("Update failed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                }
            }
        }
        

        private void Clear()
        {
            txt_itemID.Text = txt_available.Text = txt_category.Text = txt_itemName.Text = txt_order.Text = txt_price.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }   
    }  
}
