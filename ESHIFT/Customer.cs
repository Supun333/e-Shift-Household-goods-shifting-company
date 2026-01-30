using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ESHIFT
{
    public partial class Customer : Form
    {
        private string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";

        private int currentCustomerId = 0;

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.dgv_Customers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customers_CellDoubleClick);

            if (cmb_SearchBy.Items.Count > 0)
                cmb_SearchBy.SelectedIndex = 0;

            ShowMainView();
            LoadAllCustomers();
        }

        private void ShowMainView()
        {
            panelMain.Visible = true;
            panelDetails.Visible = false;
        }

        private void ShowDetailsView()
        {
            panelMain.Visible = false;
            panelDetails.Visible = true;
            DisableEditMode();
        }

        private void LoadAllCustomers()
        {
            LoadCustomersQuery("SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC, Address FROM Customer");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string search = txt_Search.Text.Trim();
            string searchType = cmb_SearchBy.SelectedItem?.ToString() ?? "All";

            if (string.IsNullOrEmpty(search))
            {
                LoadAllCustomers();
                return;
            }

            string query = "";
            SqlParameter param = new SqlParameter("@s", "%" + search + "%");

            switch (searchType)
            {
                case "Name":
                    query = "SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC, Address FROM Customer WHERE Name LIKE @s";
                    break;
                case "NIC":
                    query = "SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC, Address FROM Customer WHERE CustomerIdNo LIKE @s";
                    break;
                case "Phone":
                    query = "SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC, Address FROM Customer WHERE Phone LIKE @s";
                    break;
                case "All":
                default:
                    query = @"SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC, Address 
                             FROM Customer 
                             WHERE Name LIKE @s 
                                OR Phone LIKE @s 
                                OR Email LIKE @s 
                                OR CustomerIdNo LIKE @s";
                    break;
            }

            LoadCustomersQuery(query, param);
        }

        private void LoadCustomersQuery(string query, SqlParameter param = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        if (param != null) da.SelectCommand.Parameters.Add(param);

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_Customers.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customers: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_Customers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(dgv_Customers.Rows[e.RowIndex].Cells["CustomerId"].Value);
                LoadCustomerDetails(customerId);
                ShowDetailsView();
            }
        }

        private void LoadCustomerDetails(int customerId)
        {
            currentCustomerId = customerId;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string profileQuery = "SELECT * FROM Customer WHERE CustomerId = @id";
                    using (SqlCommand cmd = new SqlCommand(profileQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@id", customerId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_DetailsName.Text = reader["Name"]?.ToString();
                                txt_DetailsNIC.Text = reader["CustomerIdNo"]?.ToString();
                                txt_DetailsPhone.Text = reader["Phone"]?.ToString();
                                txt_DetailsEmail.Text = reader["Email"]?.ToString();
                                txt_DetailsAddress.Text = reader["Address"]?.ToString();
                            }
                        }
                    }

                    string jobQuery = @"SELECT JobId, StartLocation, Destination, PickupDate, Status 
                                       FROM Job 
                                       WHERE CustomerId = @id 
                                       ORDER BY PickupDate DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(jobQuery, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@id", customerId);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_CustomerJobs.DataSource = dt;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ShowMainView();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (currentCustomerId == 0)
            {
                MessageBox.Show("No customer selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EnableEditMode();
        }

        private void EnableEditMode()
        {
            txt_DetailsName.ReadOnly = false;
            txt_DetailsNIC.ReadOnly = false;
            txt_DetailsPhone.ReadOnly = false;
            txt_DetailsEmail.ReadOnly = false;
            txt_DetailsAddress.ReadOnly = false;

            btn_Edit.Enabled = false;
            btn_SaveUpdates.Enabled = true;

            txt_DetailsName.BackColor = Color.LightYellow;
            txt_DetailsNIC.BackColor = Color.LightYellow;
            txt_DetailsPhone.BackColor = Color.LightYellow;
            txt_DetailsEmail.BackColor = Color.LightYellow;
            txt_DetailsAddress.BackColor = Color.LightYellow;
        }

        private void DisableEditMode()
        {
            txt_DetailsName.ReadOnly = true;
            txt_DetailsNIC.ReadOnly = true;
            txt_DetailsPhone.ReadOnly = true;
            txt_DetailsEmail.ReadOnly = true;
            txt_DetailsAddress.ReadOnly = true;

            btn_Edit.Enabled = true;
            btn_SaveUpdates.Enabled = false;

            txt_DetailsName.BackColor = SystemColors.Control;
            txt_DetailsNIC.BackColor = SystemColors.Control;
            txt_DetailsPhone.BackColor = SystemColors.Control;
            txt_DetailsEmail.BackColor = SystemColors.Control;
            txt_DetailsAddress.BackColor = SystemColors.Control;
        }

        private void btn_SaveUpdates_Click(object sender, EventArgs e)
        {
             if (currentCustomerId == 0) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE Customer 
                                     SET Name = @n, CustomerIdNo = @nic, Phone = @p, Email = @e, Address = @a 
                                     WHERE CustomerId = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@n", txt_DetailsName.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic", txt_DetailsNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@p", txt_DetailsPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@e", txt_DetailsEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@a", txt_DetailsAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", currentCustomerId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisableEditMode();
                            LoadAllCustomers();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Record may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (currentCustomerId == 0)
            {
                MessageBox.Show("No customer selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to DELETE this customer (ID: " + currentCustomerId + ")?\n\nThis will also delete ALL their Job History and cannot be undone.", 
                "Confirm Delete", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                 using (SqlConnection con = new SqlConnection(connectionString))
                 {
                     try
                     {
                         con.Open();

                         string deleteLoads = @"DELETE FROM Load 
                                                WHERE JobId IN (SELECT JobId FROM Job WHERE CustomerId = @id)";
                         using (SqlCommand cmd = new SqlCommand(deleteLoads, con))
                         {
                             cmd.Parameters.AddWithValue("@id", currentCustomerId);
                             cmd.ExecuteNonQuery();
                         }

                         string deleteJobs = "DELETE FROM Job WHERE CustomerId = @id";
                         using (SqlCommand cmd = new SqlCommand(deleteJobs, con))
                         {
                             cmd.Parameters.AddWithValue("@id", currentCustomerId);
                             cmd.ExecuteNonQuery();
                         }

                         string deleteCust = "DELETE FROM Customer WHERE CustomerId = @id";
                         using (SqlCommand cmd = new SqlCommand(deleteCust, con))
                         {
                             cmd.Parameters.AddWithValue("@id", currentCustomerId);
                             int rows = cmd.ExecuteNonQuery();

                             if (rows > 0)
                             {
                                 MessageBox.Show("Customer and related data deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 ShowMainView();
                                 LoadAllCustomers();
                             }
                             else
                             {
                                 MessageBox.Show("Delete failed. Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Database Error during delete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
            }
        }


    }
}
