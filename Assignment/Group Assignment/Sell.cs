

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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sell_Load(object sender, EventArgs e)
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

        private void Clear()
        {
            txt_itemID.Text = txt_quantity.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            bool found = Check();
            decimal quantity;

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
                SqlCommand cmd = new SqlCommand("SELECT UnitsAvailable FROM Inventory WHERE ItemID =  '" + txt_itemID.Text + "' ", con);
                object quant = cmd.ExecuteScalar();
                quantity = Convert.ToDecimal(quant);
                quantity -= Convert.ToDecimal(txt_quantity.Text);

                if (quantity < 0)
                {
                    MessageBox.Show("Not enough stock, please select fewer items", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    quantity = Convert.ToDecimal(quant);
                }
              

                try
                {
                    cmd = new SqlCommand("UPDATE Inventory SET UnitsAvailable = " + quantity + "WHERE ItemID = '" + txt_itemID.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@UnitsAvailable", quantity);
                    cmd.ExecuteNonQuery();
                    Clear();
                }

                catch
                {
                    MessageBox.Show("Selling failed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                }
            }
        }
    }
}
