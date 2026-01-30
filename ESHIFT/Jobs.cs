using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESHIFT
{
    public partial class Jobs : Form
    {
        private int selectedCustomerId = 0;
        private DataTable jobItemsTable;

        public Jobs()
        {
            InitializeComponent();
            InitializeJobItemsTable();
        }

        private void InitializeJobItemsTable()
        {
            jobItemsTable = new DataTable();
            jobItemsTable.Columns.Add("Description", typeof(string));
            jobItemsTable.Columns.Add("Weight", typeof(double));
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            
            btn_Nav_PendingJobs.PerformClick();
            if(cmb_SearchBy_jobs != null && cmb_SearchBy_jobs.Items.Count > 0) 
                cmb_SearchBy_jobs.SelectedIndex = 0;
            InitializeItemGrid();

            this.dgv_PendingJobs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PendingJobs_CellDoubleClick);
        }

        private void InitializeItemGrid()
        {
            Control grp = this.Controls.Find("grp_CreateJob", true).FirstOrDefault();
            Control pnl = this.Controls.Find("pnl_JobManagement", true).FirstOrDefault();
            Control txtWeight = this.Controls.Find("txt_Weight", true).FirstOrDefault();
            Control btnCreate = this.Controls.Find("btn_CreateJob", true).FirstOrDefault();
            Control dtpDate = this.Controls.Find("dtp_PickupDate", true).FirstOrDefault();
            Control lblDate = this.Controls.Find("lbl_Date", true).FirstOrDefault();

            if (grp == null || txtWeight == null) return;

            int spacer = 150;
            if (grp.Height < 400)
            {
                grp.Height += spacer;
                if (pnl != null) pnl.Height = Math.Max(pnl.Height, grp.Top + grp.Height + 20);
                this.Height = Math.Max(this.Height, pnl.Top + pnl.Height + 50);
                if (lblDate != null) lblDate.Top += spacer;
                if (dtpDate != null) dtpDate.Top += spacer;
                if (btnCreate != null) btnCreate.Top += spacer;
            }

            if (grp.Controls.Find("btn_AddItem", true).Length == 0)
            {
                Button btn = new Button();
                btn.Name = "btn_AddItem";
                btn.Text = "Add";
                btn.BackColor = Color.LightGreen;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Location = new Point(txtWeight.Right - 75, txtWeight.Bottom + 5); 
                btn.Size = new Size(75, 24);
                btn.Click += new EventHandler(btn_AddItem_Click);
                grp.Controls.Add(btn);
                btn.BringToFront();
            }

            if (grp.Controls.Find("dgv_JobItems", true).Length == 0)
            {
                DataGridView dgv = new DataGridView();
                dgv.Name = "dgv_JobItems";
                dgv.Location = new Point(14, txtWeight.Bottom + 35);
                dgv.Size = new Size(268, 110);
                dgv.DataSource = jobItemsTable;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                grp.Controls.Add(dgv);
                dgv.BringToFront();
            }

            DataGridView foundDgv = (DataGridView)grp.Controls.Find("dgv_JobItems", true).FirstOrDefault();
            if (foundDgv != null && foundDgv.DataSource == null)
            {
                foundDgv.DataSource = jobItemsTable;
            }
        }
        
        private void btn_AddItem_Click(object sender, EventArgs e)
        {
             string itemDescription = txt_item.Text.Trim();
             string weightText = txt_Weight.Text.Trim();

             if (string.IsNullOrWhiteSpace(itemDescription))
             {
                 MessageBox.Show("Please enter an Item Description.");
                 return;
             }

             double weight = 0;
             if (!string.IsNullOrWhiteSpace(weightText))
             {
                 if (!double.TryParse(weightText, out weight))
                 {
                     MessageBox.Show("Please enter a valid numeric Weight.");
                     return;
                 }
             }

             jobItemsTable.Rows.Add(itemDescription, weight);
             txt_item.Clear();
             txt_Weight.Clear();
             txt_item.Focus();
        }

        private void btn_Nav_PendingJobs_Click(object sender, EventArgs e)
        {
            pnl_PendingJobs.Visible = true;
            pnl_JobManagement.Visible = false;
            LoadPendingJobs();
        }

        private void btn_Nav_ManageJobs_Click(object sender, EventArgs e)
        {
            pnl_PendingJobs.Visible = false;
            pnl_JobManagement.Visible = true;
        }

        private void btn_Nav_ProcessingJobs_Click(object sender, EventArgs e)
        {
            pnl_PendingJobs.Visible = true;
            pnl_JobManagement.Visible = false;
            LoadProcessingJobs();
        }

        private void LoadProcessingJobs()
        {
            string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT j.JobId, c.Name, j.PickupDate, j.StartLocation, j.Destination, j.Status, 
                                     (SELECT STRING_AGG(Description, ', ') FROM Load WHERE JobId = j.JobId) AS Item,
                                     (SELECT COALESCE(SUM(WeightKg), 0) FROM Load WHERE JobId = j.JobId) AS TotalWeight
                                     FROM Job j
                                     INNER JOIN Customer c ON j.CustomerId = c.CustomerId
                                     WHERE j.Status IN ('Pending', 'Hold', 'Processing')"; 
                                     
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_PendingJobs.DataSource = dt;
                    if(dgv_PendingJobs.Columns["JobId"] != null) dgv_PendingJobs.Columns["JobId"].HeaderText = "Job ID";
                    if(dgv_PendingJobs.Columns["StartLocation"] != null) dgv_PendingJobs.Columns["StartLocation"].HeaderText = "Start Location";
                    if(dgv_PendingJobs.Columns["PickupDate"] != null) dgv_PendingJobs.Columns["PickupDate"].HeaderText = "Pickup Date";
                    if(dgv_PendingJobs.Columns["Item"] != null) dgv_PendingJobs.Columns["Item"].HeaderText = "Item Description";
                    if(dgv_PendingJobs.Columns["TotalWeight"] != null) dgv_PendingJobs.Columns["TotalWeight"].HeaderText = "Total Weight (Kg)";
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Error loading processing jobs: " + ex.Message);
                }
            }
        }
        
        private void LoadPendingJobs()
        {
            string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT j.JobId, c.Name, j.PickupDate, j.StartLocation, j.Destination, j.Status, 
                                     (SELECT STRING_AGG(Description, ', ') FROM Load WHERE JobId = j.JobId) AS Item,
                                     (SELECT COALESCE(SUM(WeightKg), 0) FROM Load WHERE JobId = j.JobId) AS TotalWeight
                                     FROM Job j
                                     INNER JOIN Customer c ON j.CustomerId = c.CustomerId
                                     WHERE j.Status = 'Pending'"; 
                                     
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_PendingJobs.DataSource = dt;
                    if(dgv_PendingJobs.Columns["JobId"] != null) dgv_PendingJobs.Columns["JobId"].HeaderText = "Job ID";
                    if(dgv_PendingJobs.Columns["StartLocation"] != null) dgv_PendingJobs.Columns["StartLocation"].HeaderText = "Start Location";
                    if(dgv_PendingJobs.Columns["PickupDate"] != null) dgv_PendingJobs.Columns["PickupDate"].HeaderText = "Pickup Date";
                    if(dgv_PendingJobs.Columns["Item"] != null) dgv_PendingJobs.Columns["Item"].HeaderText = "Item Description";
                    if(dgv_PendingJobs.Columns["TotalWeight"] != null) dgv_PendingJobs.Columns["TotalWeight"].HeaderText = "Total Weight (Kg)";
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Error loading pending jobs: " + ex.Message);
                }
            }
        }

        private void btn_RefreshPending_Click(object sender, EventArgs e)
        {
            LoadPendingJobs();
        }

        private void dgv_PendingJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int jobId = Convert.ToInt32(dgv_PendingJobs.Rows[e.RowIndex].Cells["JobId"].Value);
                JobProcessingForm processForm = new JobProcessingForm(jobId);
                processForm.ShowDialog();
                LoadPendingJobs();
            }
        }

        private void btn_Search_jobs_Click(object sender, EventArgs e)
        {
            string search = txt_Search_jobs.Text.Trim();
            string searchType = cmb_SearchBy_jobs.SelectedItem?.ToString() ?? "All";
            
            string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "";
                    SqlParameter param = new SqlParameter("@s", "%" + search + "%");

                    switch (searchType)
                    {
                        case "Name":
                            query = "SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC FROM Customer WHERE Name LIKE @s";
                            break;
                        case "Phone":
                            query = "SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC FROM Customer WHERE Phone LIKE @s";
                            break;
                         case "NIC":
                            query = "SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC FROM Customer WHERE CustomerIdNo LIKE @s";
                            break;
                        case "All":
                        default:
                            query = "SELECT CustomerId, Name, Phone, Email, CustomerIdNo as NIC FROM Customer WHERE Name LIKE @s OR Phone LIKE @s OR CustomerIdNo LIKE @s";
                            break;
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.Add(param);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_CustomerSearch_jobs.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Error: " + ex.Message);
                }
            }
        }

        private void dgv_CustomerSearch_jobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCustomerId = Convert.ToInt32(dgv_CustomerSearch_jobs.Rows[e.RowIndex].Cells["CustomerId"].Value);
                string name = dgv_CustomerSearch_jobs.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                
                lbl_SelectedCustomer.Text = "Selected: " + name + " (ID: " + selectedCustomerId + ")";
                lbl_SelectedCustomer.ForeColor = Color.Green;
            }
        }

        private void btn_CreateJob_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please search and select a customer first.");
                return;
            }

            string startLocation = txt_StartLocation.Text.Trim();
            string destination = txt_Destination.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(startLocation) || string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please enter Start Location and Destination.");
                return;
            }

            if (jobItemsTable.Rows.Count == 0)
            {
                string currentItem = txt_item.Text.Trim();
                string currentWeight = txt_Weight.Text.Trim();

                if (!string.IsNullOrWhiteSpace(currentItem) && !string.IsNullOrWhiteSpace(currentWeight))
                {
                     double weight = 0;
                     if (double.TryParse(currentWeight, out weight))
                     {
                         jobItemsTable.Rows.Add(currentItem, weight);
                     }
                     else
                     {
                         MessageBox.Show("Please enter a valid numeric Weight.");
                         return;
                     }
                }
                else
                {
                    MessageBox.Show("Please add at least one item to the job.");
                    return;
                }
            }

            string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string jobQuery = @"INSERT INTO Job (CustomerId, StartLocation, Destination, PickupDate, Status) 
                                            VALUES (@cid, @start, @dest, @date, 'Pending');
                                            SELECT SCOPE_IDENTITY();";
                        
                        int newJobId = 0;

                        using (SqlCommand cmd = new SqlCommand(jobQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@cid", selectedCustomerId);
                            cmd.Parameters.AddWithValue("@start", startLocation);
                            cmd.Parameters.AddWithValue("@dest", destination);
                            cmd.Parameters.AddWithValue("@date", dtp_PickupDate.Value);
                            
                            object result = cmd.ExecuteScalar();
                            newJobId = Convert.ToInt32(result);
                        }

                        if (newJobId > 0)
                        {
                            string loadQuery = @"INSERT INTO Load (JobId, Description, WeightKg) 
                                                 VALUES (@jid, @desc, @w)";
                            
                            using (SqlCommand cmdLoad = new SqlCommand(loadQuery, con, transaction))
                            {
                                cmdLoad.Parameters.Add(new SqlParameter("@jid", SqlDbType.Int));
                                cmdLoad.Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar));
                                cmdLoad.Parameters.Add(new SqlParameter("@w", SqlDbType.Float));

                                foreach (DataRow row in jobItemsTable.Rows)
                                {
                                    cmdLoad.Parameters["@jid"].Value = newJobId;
                                    cmdLoad.Parameters["@desc"].Value = row["Description"];
                                    cmdLoad.Parameters["@w"].Value = row["Weight"];
                                    cmdLoad.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();

                        MessageBox.Show("Job request created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_StartLocation.Clear();
                        txt_Destination.Clear();
                        txt_item.Clear();
                        txt_Weight.Clear();
                        jobItemsTable.Clear();
                        selectedCustomerId = 0;
                        lbl_SelectedCustomer.Text = "Select a customer from the list...";
                        lbl_SelectedCustomer.ForeColor = Color.Blue;
                        dtp_PickupDate.Value = DateTime.Now;
                         DialogResult dr = MessageBox.Show("View Pending Jobs now?", "Navigate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                         if (dr == DialogResult.Yes)
                         {
                             btn_Nav_PendingJobs.PerformClick();
                         }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error creating job: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_SelectedCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
