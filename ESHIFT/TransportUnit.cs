using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ESHIFT
{
    public partial class TransportUnit : Form
    {
        private string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";
        public string UserRole { get; set; }

        public TransportUnit(string role = "Admin")
        {
            InitializeComponent();
            UserRole = role;
        }

        private void TransportUnit_Load(object sender, EventArgs e)
        {
            cmb_SearchBy.SelectedIndex = 0;
            cmb_Status.SelectedIndex = 0;
            if(!string.IsNullOrEmpty(txt_VehicleType.Text)) txt_VehicleType.Clear();
            ToggleView(false);
            LoadAllTransportUnits();
        }

        private void ToggleView(bool showDetails, bool isEditMode = false)
        {
            grp_Vehicle.Visible = showDetails;
            grp_Driver.Visible = showDetails;
            grp_Assistant.Visible = showDetails;
            grp_Search.Visible = !showDetails;
            dgv_TransportList.Visible = !showDetails;
            btn_New.Visible = !showDetails;
            btn_Register.Visible = showDetails && !isEditMode;
            btn_Cancel.Visible = showDetails;
            btn_Clear.Visible = showDetails;

            bool isAdmin = UserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase);
            btn_Update.Visible = showDetails && isEditMode && isAdmin;
            btn_Delete.Visible = showDetails && isEditMode && isAdmin;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            ClearFields();
            cmb_Status.SelectedItem = "Available"; 
            ToggleView(true, isEditMode: false);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ToggleView(false);
            LoadAllTransportUnits();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NumberPlate.Text) || string.IsNullOrWhiteSpace(txt_DriverName.Text) || string.IsNullOrWhiteSpace(txt_VehicleType.Text))
            {
                MessageBox.Show("Please fill in Number Plate, Driver Name, and Vehicle Type.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO TransportUnit 
                                    (VehicleNumberPlate, DriverName, DriverPhone, DriverIdNo, 
                                     AssistantName, AssistantPhone, AssistantIdNo, ContainerId, Status, VehicleType)
                                     VALUES (@NoPlate, @DName, @DPhone, @DNIC, @AName, @APhone, @ANIC, @Container, @Status, @VehicleType);
                                     SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NoPlate", txt_NumberPlate.Text.Trim());
                        cmd.Parameters.AddWithValue("@DName", txt_DriverName.Text.Trim());
                        cmd.Parameters.AddWithValue("@DPhone", txt_DriverPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@DNIC", txt_DriverNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@AName", txt_AssistantName.Text.Trim());
                        cmd.Parameters.AddWithValue("@APhone", txt_AssistantPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@ANIC", txt_AssistantNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@Container", txt_ContainerID.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", cmb_Status.SelectedItem?.ToString() ?? "Available");
                        cmd.Parameters.AddWithValue("@VehicleType", txt_VehicleType.Text.Trim());

                        object result = cmd.ExecuteScalar();
                        int newId = Convert.ToInt32(result);
                        string formattedId = $"TRCK{newId:D7}";
                        
                        MessageBox.Show($"Transport Unit Registered Successfully! Unit ID: {formattedId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ToggleView(false);
                        LoadAllTransportUnits();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving: " + ex.Message);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_UnitID.Text)) return;

            string rawId = txt_UnitID.Text.Replace("TRCK", "").TrimStart('0');
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE TransportUnit SET 
                                    VehicleNumberPlate=@NoPlate, DriverName=@DName, DriverPhone=@DPhone, DriverIdNo=@DNIC,
                                    AssistantName=@AName, AssistantPhone=@APhone, AssistantIdNo=@ANIC, ContainerId=@Container, Status=@Status, VehicleType=@VehicleType
                                    WHERE UnitId=@Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NoPlate", txt_NumberPlate.Text.Trim());
                        cmd.Parameters.AddWithValue("@DName", txt_DriverName.Text.Trim());
                        cmd.Parameters.AddWithValue("@DPhone", txt_DriverPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@DNIC", txt_DriverNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@AName", txt_AssistantName.Text.Trim());
                        cmd.Parameters.AddWithValue("@APhone", txt_AssistantPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@ANIC", txt_AssistantNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@Container", txt_ContainerID.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", cmb_Status.SelectedItem?.ToString() ?? "Available");
                        cmd.Parameters.AddWithValue("@VehicleType", txt_VehicleType.Text.Trim());
                        cmd.Parameters.AddWithValue("@Id", rawId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Transport Unit Updated Successfully!");
                            ToggleView(false); // Return to list
                            LoadAllTransportUnits();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating: " + ex.Message);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txt_UnitID.Text)) return;

            if (MessageBox.Show("Are you sure you want to delete this unit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string rawId = txt_UnitID.Text.Replace("TRCK", "").TrimStart('0');
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM TransportUnit WHERE UnitId=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", rawId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully.");
                        ToggleView(false);
                        LoadAllTransportUnits();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting: " + ex.Message);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields(bool clearId = true)
        {
            if (clearId) txt_UnitID.Clear();
            txt_NumberPlate.Clear();
            txt_ContainerID.Clear();
            txt_DriverName.Clear();
            txt_DriverPhone.Clear();
            txt_DriverNIC.Clear();
            txt_AssistantName.Clear();
            txt_AssistantPhone.Clear();
            txt_AssistantNIC.Clear();
            txt_AssistantNIC.Clear();
            txt_VehicleType.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
             string keyword = txt_Search.Text.Trim();
             if (string.IsNullOrWhiteSpace(keyword)) 
             {
                 LoadAllTransportUnits();
                 return;
             }
             
             string column = "UnitId";
             switch(cmb_SearchBy.SelectedItem?.ToString())
             {
                 case "Number Plate": column = "VehicleNumberPlate"; break;
                 case "Driver Name": column = "DriverName"; break;
                 case "Assistant Name": column = "AssistantName"; break;
             }

             using (SqlConnection con = new SqlConnection(connectionString))
             {
                 try
                 {
                     con.Open();
                     string query = $"SELECT * FROM TransportUnit WHERE {column} LIKE @key";
                     using (SqlCommand cmd = new SqlCommand(query, con))
                     {
                         if (column == "UnitId" && int.TryParse(keyword, out int id))
                         {
                             query = $"SELECT * FROM TransportUnit WHERE UnitId = @key";
                             cmd.CommandText = query;
                             cmd.Parameters.AddWithValue("@key", id);
                         }
                         else
                         {
                             cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                         }
                         
                         SqlDataAdapter da = new SqlDataAdapter(cmd);
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         dgv_TransportList.DataSource = dt;
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Search Error: " + ex.Message);
                 }
             }
        }

        private void btn_ViewAll_Click(object sender, EventArgs e)
        {
            LoadAllTransportUnits();
        }

        private void LoadAllTransportUnits()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT UnitId, VehicleNumberPlate, DriverName, DriverPhone, DriverIdNo, 
                                     AssistantName, AssistantPhone, AssistantIdNo, ContainerId, 
                                     CASE WHEN Status = 'Busy' THEN 'Booked' ELSE Status END AS Status, 
                                     VehicleType 
                                     FROM TransportUnit";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_TransportList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void dgv_TransportList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow row = null;
                if (dgv_TransportList.SelectedRows.Count > 0)
                {
                     DataRowView drv = dgv_TransportList.SelectedRows[0].DataBoundItem as DataRowView;
                     if (drv != null) row = drv.Row;
                }
                else 
                {
                     var dgvRow = dgv_TransportList.Rows[e.RowIndex];
                     DataRowView drv = dgvRow.DataBoundItem as DataRowView;
                     if (drv != null) row = drv.Row;
                }

                if (row != null)
                {
                    ToggleView(true, isEditMode: true); 

                    txt_UnitID.Text = $"TRCK{row["UnitId"]:D7}";
                    txt_NumberPlate.Text = row["VehicleNumberPlate"].ToString();
                    txt_ContainerID.Text = row["ContainerId"].ToString();
                    txt_DriverName.Text = row["DriverName"].ToString();
                    txt_DriverPhone.Text = row["DriverPhone"].ToString();
                    txt_DriverNIC.Text = row["DriverIdNo"].ToString();
                    txt_AssistantName.Text = row["AssistantName"].ToString();
                    txt_AssistantPhone.Text = row["AssistantPhone"].ToString();
                    txt_AssistantNIC.Text = row["AssistantIdNo"].ToString();
                    if (row.Table.Columns.Contains("Status"))
                    {
                         string status = row["Status"].ToString();
                         if (cmb_Status.Items.Contains(status))
                            cmb_Status.SelectedItem = status;
                    }

                    if (row.Table.Columns.Contains("VehicleType"))
                    {
                         txt_VehicleType.Text = row["VehicleType"].ToString();
                    }
                }
            }


            }


        private void btn_ShowJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_UnitID.Text))
            {
                 MessageBox.Show("Please select a unit first.");
                 return;
            }

            string rawId = txt_UnitID.Text.Replace("TRCK", "").TrimStart('0');
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT TOP 1 JobId, Status FROM Job 
                                     WHERE UnitId = @uid AND Status IN ('Pending', 'Processing', 'Hold', 'OnRoute') 
                                     ORDER BY JobId DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uid", rawId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int jobId = Convert.ToInt32(reader["JobId"]);
                                string status = reader["Status"].ToString();
                                MessageBox.Show($"This unit is currently assigned to Job ID: {jobId} (Status: {status})", "Active Job Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (cmb_Status.SelectedItem != null && cmb_Status.SelectedItem.ToString() == "Booked")
                                {
                                    DialogResult dr = MessageBox.Show("No active job found for this unit, but it is marked as 'Booked'.\n\nDo you want to reset it to 'Available'?", "Status Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (dr == DialogResult.Yes)
                                    {
                                        reader.Close();
                                        string updateQuery = "UPDATE TransportUnit SET Status = 'Available' WHERE UnitId = @uid";
                                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                                        {
                                            updateCmd.Parameters.AddWithValue("@uid", rawId);
                                            updateCmd.ExecuteNonQuery();
                                        }
                                        MessageBox.Show("Unit status reset to Available.");
                                        ToggleView(false);
                                        LoadAllTransportUnits();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No active jobs found for this unit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking active jobs: " + ex.Message);
                }
            }
        }
    }
}

