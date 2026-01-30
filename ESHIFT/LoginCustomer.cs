using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ESHIFT
{
    public partial class LoginCustomer : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public LoginCustomer()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_username.Text.Trim();
                string password = txt_password.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string storedPassword = null;
                    string storedRole = "";
                    bool userFound = false;

                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Password, Role FROM Login WHERE UserName = @u", con))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                storedPassword = reader["Password"] != DBNull.Value ? reader["Password"].ToString() : null;
                                storedRole = reader["Role"] != DBNull.Value ? reader["Role"].ToString() : "";
                                userFound = true;
                            }
                        }
                    }
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Database Error (Login Table): " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (!userFound)
                {
                    MessageBox.Show($"User '{username}' not found in database.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (storedPassword == null || storedPassword != password)
                {
                    MessageBox.Show("Incorrect Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (storedRole == null || !storedRole.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Access Denied. Role is '{storedRole}'. Only Customers can login.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int customerId = 0;
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT CustomerId FROM Customer WHERE UserName = @u", con))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        object res = cmd.ExecuteScalar();
                        if (res != null && res != DBNull.Value) customerId = Convert.ToInt32(res);
                    }

                    if (customerId == 0)
                    {
                         using (SqlCommand cmd = new SqlCommand("SELECT CustomerId FROM Customer WHERE Name = @u", con))
                         {
                             cmd.Parameters.AddWithValue("@u", username);
                             object res = cmd.ExecuteScalar();
                             if (res != null && res != DBNull.Value) customerId = Convert.ToInt32(res);
                         }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving Customer ID: " + ex.Message);
                    return;
                }

                if (customerId == 0)
                {
                    DialogResult result = MessageBox.Show($"Login Valid (Role: {storedRole}), but No Customer Profile found linked to username '{username}'.\n\n" +
                                    "Your account exists but is missing profile data.\n\n" +
                                    "Would you like to Repair your account now?\n" +
                                    "This will open the Registration page where you can re-enter your details to fix the link.", 
                                    "Action Required: Repair Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    
                    if (result == DialogResult.Yes)
                    {
                        RegisterCustomer repairForm = new RegisterCustomer(username);
                        repairForm.Show();
                    }
                    return;
                }

                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerForm form = new CustomerForm(customerId);
                form.Show();
                this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error Catch: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkbox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = checkbox_showpassword.Checked ? '\0' : '*';
        }

        private void txt_Cancel_Click(object sender, EventArgs e)
        {
            Selector selector = new Selector();
            selector.Show();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void LoginCustomer_Load(object sender, EventArgs e)
        {
            txt_Cancel.Text = "Back";

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();
                    string checkCol = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Customer' AND COLUMN_NAME = 'UserName'";
                    using (SqlCommand cmd = new SqlCommand(checkCol, con))
                    {
                        int exists = (int)cmd.ExecuteScalar();
                        if (exists == 0)
                        {
                            string addCol = "ALTER TABLE Customer ADD UserName NVARCHAR(50)";
                            using (SqlCommand addCmd = new SqlCommand(addCol, con))
                            {
                                addCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    string stats = "";
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Login", con)) 
                        stats += "Total Logins: " + cmd.ExecuteScalar().ToString() + "\n";
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customer", con)) 
                        stats += "Total Customers: " + cmd.ExecuteScalar().ToString() + "\n";
                    
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customer WHERE UserName IS NULL", con))
                        stats += "Customers with NULL UserName: " + cmd.ExecuteScalar().ToString() + "\n";
                }
                catch { }
            }
        }
            
        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterCustomer registerForm = new RegisterCustomer();
            registerForm.Show();
        }
    }
}
