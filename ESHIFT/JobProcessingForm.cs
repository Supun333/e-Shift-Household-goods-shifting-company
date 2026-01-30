using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ESHIFT
{
    public partial class JobProcessingForm : Form
    {
        private int currentJobId;
        private string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";
        private DataGridView dgv_LoadItems;
        
        public JobProcessingForm(int jobId)
        {
            InitializeComponent();
            this.currentJobId = jobId;
        }

        private void JobProcessingForm_Load(object sender, EventArgs e)
        {
            lbl_JobId.Text = "Job ID: " + currentJobId;
            
            txt_UnitId.Visible = false;
            txt_Driver.Visible = false;
            txt_Assistant.Visible = false;
            txt_ItemDescription.Visible = false;
            txt_ItemWeight.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lbl_ItemDescription.Visible = false;
            lbl_ItemWeight.Visible = false;
            btn_SearchUnit.Text = "Assign Unit to Selected";
            btn_SearchUnit.Size = new System.Drawing.Size(160, 30);
            btn_SearchUnit.Location = new System.Drawing.Point(150, 105);
            InitializeLoadGrid();
            
            LoadJobDetails();
            cmb_Status.SelectedIndexChanged += new EventHandler(this.cmb_Status_SelectedIndexChanged);
        }
        
        private void InitializeLoadGrid()
        {
            dgv_LoadItems = new DataGridView();
            dgv_LoadItems.Name = "dgv_LoadItems";
            dgv_LoadItems.Location = new System.Drawing.Point(30, 140);
            dgv_LoadItems.Size = new System.Drawing.Size(390, 190);
            dgv_LoadItems.AllowUserToAddRows = false;
            dgv_LoadItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_LoadItems.MultiSelect = true; 
            dgv_LoadItems.Columns.Add("LoadId", "LoadId");
            dgv_LoadItems.Columns["LoadId"].Visible = false;
            
            dgv_LoadItems.Columns.Add("Description", "Item");
            dgv_LoadItems.Columns["Description"].Width = 100;
            
            dgv_LoadItems.Columns.Add("Weight", "Weight");
            dgv_LoadItems.Columns["Weight"].Width = 60;
            
            dgv_LoadItems.Columns.Add("UnitId", "Unit ID");
            dgv_LoadItems.Columns["UnitId"].Width = 50;
            dgv_LoadItems.Columns["UnitId"].ReadOnly = true;

            dgv_LoadItems.Columns.Add("Driver", "Driver");
            dgv_LoadItems.Columns["Driver"].Width = 100;
            dgv_LoadItems.Columns["Driver"].ReadOnly = true;

            this.Controls.Add(dgv_LoadItems);
        }

        private void cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFieldLocks();
        }

        private void UpdateFieldLocks()
        {
            bool isDelivered = cmb_Status.SelectedItem?.ToString() == "Delivered";
            
            if(dgv_LoadItems != null) dgv_LoadItems.ReadOnly = isDelivered;
            btn_SearchUnit.Enabled = !isDelivered;
        }

        private void LoadJobDetails()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT Status, PaymentAmount, DeliveryDate FROM Job WHERE JobId = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", currentJobId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmb_Status.SelectedItem = reader["Status"].ToString();
                                
                                if (reader["PaymentAmount"] != DBNull.Value)
                                    txt_PaymentAmount.Text = Convert.ToDecimal(reader["PaymentAmount"]).ToString("0.00");
                                
                                if (reader["DeliveryDate"] != DBNull.Value)
                                    dtp_DeliveryDate.Value = Convert.ToDateTime(reader["DeliveryDate"]);
                                else
                                    dtp_DeliveryDate.Value = DateTime.Now;

                                if (reader["Status"].ToString() == "Delivered")
                                {
                                    cmb_Status.Enabled = false;
                                    btn_Save.Enabled = false;
                                    dtp_DeliveryDate.Enabled = false;
                                    txt_PaymentAmount.ReadOnly = true;
                                }
                            }
                        }
                    }

                    string loadQuery = @"SELECT l.LoadId, l.Description, l.WeightKg, l.TransportUnitId, u.DriverName 
                                         FROM Load l 
                                         LEFT JOIN TransportUnit u ON l.TransportUnitId = u.UnitId
                                         WHERE l.JobId = @jid";
                    
                    using (SqlCommand cmdLoad = new SqlCommand(loadQuery, con))
                    {
                        cmdLoad.Parameters.AddWithValue("@jid", currentJobId);
                        SqlDataAdapter da = new SqlDataAdapter(cmdLoad);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        dgv_LoadItems.Rows.Clear();
                        foreach(DataRow row in dt.Rows)
                        {
                            dgv_LoadItems.Rows.Add(
                                row["LoadId"],
                                row["Description"],
                                row["WeightKg"],
                                row["TransportUnitId"] != DBNull.Value ? row["TransportUnitId"].ToString() : "",
                                row["DriverName"] != DBNull.Value ? row["DriverName"].ToString() : ""
                            );
                        }
                    }
                    
                    UpdateFieldLocks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading job: " + ex.Message);
                }
            }
        }

        private void btn_SearchUnit_Click(object sender, EventArgs e)
        {
            if (dgv_LoadItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one or more items to assign.");
                return;
            }

            TransportSearchForm searchForm = new TransportSearchForm();
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                string selectedUnitId = searchForm.SelectedUnitId;
                string selectedDriver = searchForm.SelectedDriver;
                
                foreach (DataGridViewRow row in dgv_LoadItems.SelectedRows)
                {
                    row.Cells["UnitId"].Value = selectedUnitId;
                    row.Cells["Driver"].Value = selectedDriver;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    
                    try 
                    {
                        string jobQuery = "UPDATE Job SET Status = @status, PaymentAmount = @payment, DeliveryDate = @dd WHERE JobId = @jid";
                        using (SqlCommand cmd = new SqlCommand(jobQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@status", cmb_Status.SelectedItem?.ToString() ?? "Pending");
                            
                            decimal payment = 0;
                            decimal.TryParse(txt_PaymentAmount.Text, out payment);
                            cmd.Parameters.AddWithValue("@payment", payment);

                            if (cmb_Status.SelectedItem?.ToString() == "Delivered")
                                cmd.Parameters.AddWithValue("@dd", dtp_DeliveryDate.Value);
                            else
                                cmd.Parameters.AddWithValue("@dd", DBNull.Value);

                            cmd.Parameters.AddWithValue("@jid", currentJobId);
                            cmd.ExecuteNonQuery();
                        }

                        string loadUpdateQuery = "UPDATE Load SET Description = @desc, WeightKg = @w, TransportUnitId = @uid WHERE LoadId = @lid";
                        using(SqlCommand cmdLoad = new SqlCommand(loadUpdateQuery, con, transaction))
                        {
                            cmdLoad.Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar));
                            cmdLoad.Parameters.Add(new SqlParameter("@w", SqlDbType.Float));
                            cmdLoad.Parameters.Add(new SqlParameter("@uid", SqlDbType.Int));
                            cmdLoad.Parameters.Add(new SqlParameter("@lid", SqlDbType.Int));
                            
                            foreach(DataGridViewRow row in dgv_LoadItems.Rows)
                            {
                                int loadId = Convert.ToInt32(row.Cells["LoadId"].Value);
                                string desc = row.Cells["Description"].Value?.ToString();
                                double weight = 0;
                                double.TryParse(row.Cells["Weight"].Value?.ToString(), out weight);
                                
                                string unitIdStr = row.Cells["UnitId"].Value?.ToString();
                                int? unitId = string.IsNullOrEmpty(unitIdStr) ? (int?)null : Convert.ToInt32(unitIdStr);
                                
                                cmdLoad.Parameters["@desc"].Value = desc;
                                cmdLoad.Parameters["@w"].Value = weight;
                                cmdLoad.Parameters["@uid"].Value = (object)unitId ?? DBNull.Value;
                                cmdLoad.Parameters["@lid"].Value = loadId;
                                
                                cmdLoad.ExecuteNonQuery();
                            }
                        }
                        
                        string status = cmb_Status.SelectedItem?.ToString() ?? "Pending";
                        HashSet<int> unitIds = new HashSet<int>();
                        foreach(DataGridViewRow row in dgv_LoadItems.Rows)
                        {
                            string uid = row.Cells["UnitId"].Value?.ToString();
                            if(!string.IsNullOrEmpty(uid)) unitIds.Add(Convert.ToInt32(uid));
                        }
                        
                        string updateUnitQuery = "UPDATE TransportUnit SET Status = @ustatus WHERE UnitId = @uid";
                        using (SqlCommand cmdUnit = new SqlCommand(updateUnitQuery, con, transaction))
                        {
                            cmdUnit.Parameters.Add(new SqlParameter("@ustatus", SqlDbType.NVarChar));
                            cmdUnit.Parameters.Add(new SqlParameter("@uid", SqlDbType.Int));
                            
                            foreach(int uid in unitIds)
                            {
                                if (status == "Delivered")
                                    cmdUnit.Parameters["@ustatus"].Value = "Available";
                                else
                                    cmdUnit.Parameters["@ustatus"].Value = "Booked";
                                    
                                cmdUnit.Parameters["@uid"].Value = uid;
                                cmdUnit.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Job Processed Successfully!");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving: " + ex.Message);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
