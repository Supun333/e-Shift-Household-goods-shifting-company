using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ESHIFT
{
    public partial class RegisterCustomer : Form
    {
        private string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";

        public RegisterCustomer()
        {
            InitializeComponent();
        }

        public RegisterCustomer(string username)
        {
            InitializeComponent();
            txt_username.Text = username;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string firstname = txt_firstname.Text.Trim();
            string lastname = txt_lastname.Text.Trim();
            string nic = txt_nic.Text.Trim();
            string phone = txt_phone.Text.Trim();
            string email = txt_email.Text.Trim();
            string address = txt_address.Text.Trim();
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();
            string confirmPassword = txt_confirmPassword.Text.Trim();
            
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || 
                string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullname = firstname + " " + lastname;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    EnsureUserNameColumnExists(con);
                    EnsureLoginTableSchema(con);

                    bool isRepairMode = false;
                    string checkQuery = "SELECT COUNT(*) FROM Login WHERE UserName = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            string checkProfileQuery = "SELECT COUNT(*) FROM Customer WHERE UserName = @username";
                            using (SqlCommand checkProfileCmd = new SqlCommand(checkProfileQuery, con))
                            {
                                checkProfileCmd.Parameters.AddWithValue("@username", username);
                                int profileCount = (int)checkProfileCmd.ExecuteScalar();

                                if (profileCount > 0)
                                {
                                    MessageBox.Show("Username already exists. Choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else
                                {
                                    DialogResult result = MessageBox.Show($"The account '{username}' exists but has no profile data (it is orphaned).\n\n" +
                                        "Do you want to create a profile for this existing account now?", 
                                        "Account Repair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    
                                    if (result == DialogResult.Yes)
                                    {
                                        isRepairMode = true;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        if (!isRepairMode)
                        {
                            string loginQuery = "INSERT INTO Login (UserName, Password, Role) VALUES (@username, @password, 'Customer')";
                            using (SqlCommand loginCmd = new SqlCommand(loginQuery, con, transaction))
                            {
                                loginCmd.Parameters.AddWithValue("@username", username);
                                loginCmd.Parameters.AddWithValue("@password", password);
                                loginCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string updateLoginQuery = "UPDATE Login SET Password = @password WHERE UserName = @username";
                            using (SqlCommand updateCmd = new SqlCommand(updateLoginQuery, con, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@username", username);
                                updateCmd.Parameters.AddWithValue("@password", password);
                                updateCmd.ExecuteNonQuery();
                            }
                        }

                        string customerQuery = "INSERT INTO Customer (Name, UserName, CustomerIdNo, Phone, Email, Address) VALUES (@name, @username, @nic, @phone, @email, @address)";
                        using (SqlCommand custCmd = new SqlCommand(customerQuery, con, transaction))
                        {
                            custCmd.Parameters.AddWithValue("@name", fullname); 
                            custCmd.Parameters.AddWithValue("@username", username);
                            custCmd.Parameters.AddWithValue("@nic", nic);
                            custCmd.Parameters.AddWithValue("@phone", phone);
                            custCmd.Parameters.AddWithValue("@email", email);
                            custCmd.Parameters.AddWithValue("@address", address);
                            custCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Registration Successful! All data saved. You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Transaction Failed: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EnsureUserNameColumnExists(SqlConnection con)
        {
            try
            {
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
            }
            catch
            {
            }
        }

        private void EnsureLoginTableSchema(SqlConnection con)
        {
            try
            {
                string checkOldCol = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Login' AND COLUMN_NAME = 'Login'";
                using (SqlCommand cmd = new SqlCommand(checkOldCol, con))
                {
                    int oldExists = (int)cmd.ExecuteScalar();
                    if (oldExists > 0)
                    {
                        string renameQuery = "EXEC sp_rename 'Login.Login', 'UserName', 'COLUMN'";
                        using (SqlCommand renameCmd = new SqlCommand(renameQuery, con))
                        {
                            renameCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Auto-Repair Schema Error: " + ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
