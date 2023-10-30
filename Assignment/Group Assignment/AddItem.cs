

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
using MouveForm;

namespace Group_Assignment
{
    public partial class AddItem : Form
    {
      
        public AddItem()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txt_itemID.Text = txt_itemName.Text = txt_category.Text = txt_order.Text = txt_available.Text = txt_price.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {   try
            {
                int itemID = int.Parse(txt_itemID.Text);
                string itemName = txt_itemName.Text;
                string category = txt_category.Text;
                int unitsOrdered = int.Parse(txt_order.Text);
                int unitsAvailable = int.Parse(txt_available.Text);
                int storePrice = int.Parse(txt_price.Text);
                // converting DateTimePicker date format to the format used by SQL
                bool result = UserDatabase.AddItem(itemID, itemName, category, unitsOrdered, unitsAvailable, storePrice);
                if (result == true)
                {
                    MessageBox.Show("Successfully Added into the Database", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inventory.inven1.BindData();
                    ClearFields();
                }
                else //Data could not be inserted due to violation of primary key - Emp ID
                {
                    MessageBox.Show("ItemID ID has already been registered in the system", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_itemID.Focus();
                    txt_itemID.SelectAll();
                }
            }

            catch
            {
                MessageBox.Show("Invalid values entered", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
            

        }
        private void ClearFields()
        {
            txt_itemID.Text = txt_itemName.Text = txt_category.Text = txt_order.Text = txt_available.Text = txt_price.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool found = Check();
            if (found == false)
            {
                MessageBox.Show("Delete Failed! \nItemID doesn't exist / Item ID is empty", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFields();
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTNPUJ0\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Inventory WHERE ItemID = @ItemID ", con);

                    cmd.Parameters.AddWithValue("@ItemID", txt_itemID.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data is sucessfully deleted", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Inventory.inven1.BindData();
                        ClearFields();
                    }
                    catch
                    {
                        MessageBox.Show("Delete failed!", "Warning!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        ClearFields();
                    }
                }
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

        private void AddItem_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel_header);
        }
    }
}
