

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel_header);
            if (Properties.Settings.Default.AdminID != "")
            {
                txt_AdminID.Text = Properties.Settings.Default.AdminID;
                txt_adminPass.Text = Properties.Settings.Default.Password;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            AdminRegistration reg = new AdminRegistration();
            reg.Show();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (cbox_remember.Checked == true) //assign the text in both fields to the variables created in Properties Settings
            {
                Properties.Settings.Default.AdminID = txt_AdminID.Text;
                Properties.Settings.Default.Password = txt_adminPass.Text;
                Properties.Settings.Default.Save(); //save the values assigned
            }
            else //assign empty strings to the variables created in Properties Settings 
            {
                Properties.Settings.Default.AdminID = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save(); //save the values assigned
            }

            if (txt_AdminID.Text == "" || txt_adminPass.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Login Failed", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
            }
            else
            {
                string adminID = txt_AdminID.Text;
                string adminPassword = txt_adminPass.Text;
                //Calling the ValidateUser method in UserDatabase class to validate the staff ID + password
                bool result = UserDatabase.ValidateUser(adminID, adminPassword);
                if (result == false)
                {
                    MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
                else //Correct staff ID + password entered, will go straight to the Dashboard
                {
                    Inventory inven = new Inventory(adminID);
                    inven.Show();
                    this.Close();
                }
            }

        }

        private void ClearFields()
        {
            txt_AdminID.Text = txt_adminPass.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cbox_showpw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_showpw.Checked == true)
            {
                txt_adminPass.PasswordChar = '\0';
            }
            else
            {
                txt_adminPass.PasswordChar = '*';
            }
        }

        private void lbl_forgot_Click(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            sc.Show();
            this.Close();
        }

        private void txt_AdminID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public static class UserDatabase
    {
        private static string connectionString = "Data Source=DESKTOP-FK710GQ\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True";

        public static bool AddUser(string adminID, string adminPassword, string adminName, string adminEmail) //This method will add a user to the database
        {
            // First create a new Guid for the user. This will be unique for each user
            Guid adminGuid = System.Guid.NewGuid();

            // Hash the password together with the unique userGuid created
            string hashedPassword = Security.HashSHA1(adminPassword + adminGuid.ToString());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                byte[] image = { 0 };
                con.Open();
                //Add the input as parameters to avoid SQL injections
                SqlCommand cmd = new SqlCommand("INSERT INTO Admin VALUES (@AdminID, @AdminPassword, @AdminName, @AdminEmail, @AdminGuid)", con);
                cmd.Parameters.AddWithValue("@AdminID", adminID);
                cmd.Parameters.AddWithValue("@AdminPassword", hashedPassword);
                cmd.Parameters.AddWithValue("@AdminName", adminName);
                cmd.Parameters.AddWithValue("AdminEmail", adminEmail);
                cmd.Parameters.AddWithValue("@AdminGuid", adminGuid);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //violation of primary key
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateUser(string adminID, string adminPassword) //This method will validate the Staff ID with the password
        {
            bool match = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT AdminPassword, AdminGuid FROM Admin WHERE AdminID = '" + adminID + "' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string dbAdminPassword = Convert.ToString(dr["AdminPassword"]); //converting from object to string
                    string dbAdminGuid = Convert.ToString(dr["AdminGuid"]);
                    // Now we hash the UserGuid from the database with the password we want to check
                    // In the same way as when we saved it to the database in the first place. 
                    string hashedPassword = Security.HashSHA1(adminPassword + dbAdminGuid);
                    // if the password is correct, the result of the hash will be the same as in the database
                    if (dbAdminPassword == hashedPassword) //password entered and the pasword in the DB are the same
                    {
                        match = true;
                    }
                }
            }
            return match; //true if matching username + password, false if username and/or password is wrong.
        }

        public static string FindEmail(string adminID) //to find the user's email in the database
        {
            string email = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT AdminEmail FROM Admin WHERE AdminID = '" + adminID + "' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    email = Convert.ToString(dr["AdminEmail"]);
                }
            }
            return email;
        }

        public static bool ChangePassword(string adminID, string adminPassword) //This method will change the password in the database
        {
            // First create a new Guid for the user. This will be unique for each user
            Guid adminGuid = System.Guid.NewGuid();
            // Hash the password together with the unique userGuid created
            string hashedPassword = Security.HashSHA1(adminPassword + adminGuid.ToString());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //Add the input as parameters to avoid SQL injections
                SqlCommand cmd = new SqlCommand("UPDATE Admin SET AdminPassword = @AdminPassword, AdminGuid = @Adminguid WHERE AdminID = '" + adminID + "' ", con);
                cmd.Parameters.AddWithValue("@AdminPassword", hashedPassword); //store the hashedPassword
                cmd.Parameters.AddWithValue("@AdminGuid", adminGuid); //store the Guid
                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch
                {
                    return false;
                }

            }
            return true;
        }

        public static void ReadProfile(object[] adminName, string adminID) //to read and store user’s Data in the variables
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT AdminName FROM Admin WHERE AdminID = '" + adminID + "' ";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    adminName[0] = Convert.ToString(dr["AdminName"]);
                }
            }
        }

        public static DataTable FillData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ItemID AS 'Item ID', UnitName AS 'Item Name', Category AS 'Item Category', UnitsOrdered AS 'Items Ordered', UnitsAvailable AS 'Available Items', StorePrice AS 'Item Price' FROM Inventory ", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                using (DataTable dt = new DataTable())
                {
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool AddItem(int itemID, string itemName, string category, int unitsOrdered, int unitsAvailable, int storePrice)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Inventory VALUES(@ItemID,@UnitName, @Category, @UnitsOrdered, @UnitsAvailable, @StorePrice)", con);
                cmd.Parameters.AddWithValue("@ItemID", itemID);
                cmd.Parameters.AddWithValue("@UnitName", itemName);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@UnitsOrdered", unitsOrdered);
                cmd.Parameters.AddWithValue("@UnitsAvailable", unitsAvailable);
                cmd.Parameters.AddWithValue("@StorePrice", storePrice);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }



        public static decimal CalculateValue()
            {
                decimal sumValue;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT SUM(TotalValue) FROM Inventory", con);
                    object sum = cmd.ExecuteScalar();
                    sumValue = Convert.ToDecimal(sum);
                    return sumValue;
                }
            }

            public static decimal CalculateTotal()
            {
                decimal sumTotal;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT SUM(UnitsAvailable) FROM Inventory", con);
                    object tot = cmd.ExecuteScalar();
                    sumTotal = Convert.ToDecimal(tot);
                    return sumTotal;
                }
            }

    }
        public class MyApplicationContext : ApplicationContext
        {
            public MyApplicationContext(Form mainForm) : base(mainForm)
            { }
            protected override void OnMainFormClosed(object sender, EventArgs e)
            {
                if (Form.ActiveForm != null)
                {
                    this.MainForm = Form.ActiveForm;
                }
                else
                {
                    base.OnMainFormClosed(sender, e);
                }
            }
        }
        public static class Security
        {
            public static string HashSHA1(string value)
            {
                // SHA-1 which will return a string with a length of 40 no matter what the input value is
                var sha1 = System.Security.Cryptography.SHA1.Create();
                var inputBytes = Encoding.ASCII.GetBytes(value);
                var hash = sha1.ComputeHash(inputBytes);
                var sb = new StringBuilder();
                for (var i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    
}
