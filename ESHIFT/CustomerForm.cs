using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESHIFT
{
    public partial class CustomerForm : Form
    {
        private int currentCustomerId;
        private DataTable dtJobItems;

        public CustomerForm(int customerId = 0)
        {
            InitializeComponent();
            this.currentCustomerId = customerId;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dtJobItems = new DataTable();
            dtJobItems.Columns.Add("Description");
            dtJobItems.Columns.Add("Weight", typeof(double));
            dgv_JobItems.DataSource = dtJobItems;

            DT_PIckup_jobs.Value = DateTime.Now;

            if (this.currentCustomerId == 0) return;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Name, CustomerIdNo, Phone, Email, Address FROM Customer WHERE CustomerId = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", this.currentCustomerId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_name.Text = reader["Name"].ToString();
                                txt_NIC.Text = reader["CustomerIdNo"].ToString();
                                txt_EditNIC.Text = reader["CustomerIdNo"].ToString();
                                txt_Phone.Text = reader["Phone"].ToString();
                                txt_Email.Text = reader["Email"].ToString();
                                txt_Address.Text = reader["Address"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Customer record not found for ID: " + this.currentCustomerId);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile: " + ex.Message);
                }
            }
            
            txt_name.BringToFront();
            txt_NIC.BringToFront();
            lbl_search.BringToFront();
            label8.BringToFront();
        }

        private void btn_UpdateProfile_Click(object sender, EventArgs e)
        {
            if (this.currentCustomerId == 0) return;

            string phone = txt_Phone.Text.Trim();
            string email = txt_Email.Text.Trim();
            string address = txt_Address.Text.Trim();

            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Phone, Email, and Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Customer SET Phone = @phone, Email = @email, Address = @address, CustomerIdNo = @nic WHERE CustomerId = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@nic", txt_EditNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", this.currentCustomerId);
                        
                        cmd.ExecuteNonQuery();
                        txt_NIC.Text = txt_EditNIC.Text.Trim(); 
                        MessageBox.Show("Profile Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txt_NewPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.currentCustomerId == 0) return;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();
                    string updatePassQuery = @"UPDATE Login 
                                               SET Password = @password 
                                               WHERE UserName = (SELECT UserName FROM Customer WHERE CustomerId = @id)";
                    
                    using (SqlCommand cmd = new SqlCommand(updatePassQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@password", newPassword);
                        cmd.Parameters.AddWithValue("@id", this.currentCustomerId);
                        
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Password Changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_NewPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error: Could not find linked Login account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error changing password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_StartLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void DT_PIckup_jobs_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

    private void btn_AddItem_Click(object sender, EventArgs e)
    {
        string item = txt_item.Text.Trim();
        string weightText = txt_Weight.Text.Trim();
        double weight = 0;

        if (string.IsNullOrEmpty(item))
        {
            MessageBox.Show("Please enter an item description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(weightText) || !double.TryParse(weightText, out weight))
        {
             MessageBox.Show("Please enter a valid numeric weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             return;
        }

        dtJobItems.Rows.Add(item, weight);
        txt_item.Clear();
        txt_Weight.Clear();
        txt_item.Focus();
    }

    private void btn_Save_Click(object sender, EventArgs e)
    {
        string startLocation = txt_StartLocation.Text.Trim();
        string destination = txt_Destination.Text.Trim();
        DateTime pickupDate = DT_PIckup_jobs.Value.Date;
        
        if (string.IsNullOrEmpty(startLocation) || string.IsNullOrEmpty(destination))
        {
            MessageBox.Show("Please fill in Start Location and Destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (dtJobItems.Rows.Count == 0)
        {
            MessageBox.Show("Please add at least one item to the job.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (this.currentCustomerId == 0)
        {
            MessageBox.Show("Error: No valid customer session found. Please re-login.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
        {
            try
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string jobQuery = @"INSERT INTO Job (CustomerId, StartLocation, Destination, PickupDate, Status) 
                                        VALUES (@CustomerId, @Start, @Dest, @Date, 'Pending');
                                        SELECT SCOPE_IDENTITY();";

                    int jobId;
                    using (SqlCommand jobCmd = new SqlCommand(jobQuery, con, transaction))
                    {
                        jobCmd.Parameters.AddWithValue("@CustomerId", this.currentCustomerId);
                        jobCmd.Parameters.AddWithValue("@Start", startLocation);
                        jobCmd.Parameters.AddWithValue("@Dest", destination);
                        jobCmd.Parameters.AddWithValue("@Date", pickupDate);
                        
                        object result = jobCmd.ExecuteScalar();
                        jobId = Convert.ToInt32(result);
                    }

                    string loadQuery = @"INSERT INTO Load (JobId, Description, WeightKg)
                                         VALUES (@JobId, @Desc, @Weight)";
                    
                    foreach (DataRow row in dtJobItems.Rows)
                    {
                        using (SqlCommand loadCmd = new SqlCommand(loadQuery, con, transaction))
                        {
                            loadCmd.Parameters.AddWithValue("@JobId", jobId);
                            loadCmd.Parameters.AddWithValue("@Desc", row["Description"]);
                            loadCmd.Parameters.AddWithValue("@Weight", row["Weight"]);
                            loadCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show($"Job Request Sent Successfully! Job ID: {jobId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_StartLocation.Clear();
                    txt_Destination.Clear();
                    dtJobItems.Clear();
                    DT_PIckup_jobs.Value = DateTime.Now;
                    btn_RefreshJobs_Click(sender, e);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_name.Text = string.Empty;
            txt_NIC.Text = string.Empty;
            txt_Phone.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Address.Text = string.Empty;
            txt_item.Text = string.Empty;
            txt_StartLocation.Text = string.Empty;
            txt_Destination.Text = string.Empty;

            DT_PIckup_jobs.Value = DateTime.Today;

            MessageBox.Show("All fields have been cleared.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btn_RefreshJobs_Click(object sender, EventArgs e)
        {
            if (this.currentCustomerId == 0)
            {
                MessageBox.Show("Error: No valid customer session found.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT j.JobId, j.StartLocation, j.Destination, j.PickupDate, j.Status, l.Description as Item
                                     FROM Job j
                                     LEFT JOIN Load l ON j.JobId = l.JobId
                                     WHERE j.CustomerId = @CustomerId
                                     ORDER BY j.JobId DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", this.currentCustomerId);
                        
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgv_MyJobs.DataSource = dt;
                        if(dgv_MyJobs.Columns["JobId"] != null) dgv_MyJobs.Columns["JobId"].HeaderText = "Job ID";
                        if(dgv_MyJobs.Columns["StartLocation"] != null) dgv_MyJobs.Columns["StartLocation"].HeaderText = "Start Location";
                        if(dgv_MyJobs.Columns["PickupDate"] != null) dgv_MyJobs.Columns["PickupDate"].HeaderText = "Pickup Date";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading jobs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Nav_Settings_Click(object sender, EventArgs e)
        {
            pnl_Settings.Visible = true;
            pnl_JobRequest.Visible = false;
            pnl_MyJobs.Visible = false;
        }

        private void btn_Nav_JobRequest_Click(object sender, EventArgs e)
        {
            pnl_Settings.Visible = false;
            pnl_JobRequest.Visible = true;
            pnl_MyJobs.Visible = false;
        }

        private void btn_Nav_MyJobs_Click(object sender, EventArgs e)
        {
            pnl_Settings.Visible = false;
            pnl_JobRequest.Visible = false;
            pnl_MyJobs.Visible = true;
            btn_RefreshJobs_Click(sender, e);
        }

        private void btn_Back_Settings_Click(object sender, EventArgs e)
        {
            pnl_Settings.Visible = false;
            pnl_JobRequest.Visible = false;
            pnl_MyJobs.Visible = false;
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Selector selector = new Selector();
            selector.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
