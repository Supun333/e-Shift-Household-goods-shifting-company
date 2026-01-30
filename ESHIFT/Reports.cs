using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ESHIFT
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private string baseQuery = @"
            SELECT 
                j.JobId, 
                j.Status, 
                j.StartLocation, 
                j.Destination, 
                j.PickupDate, 
                j.DeliveryDate, 
                j.PaymentAmount,
                (SELECT STRING_AGG(t.ContainerId, ', ') 
                 FROM (SELECT DISTINCT tu.ContainerId 
                       FROM Load l 
                       INNER JOIN TransportUnit tu ON l.TransportUnitId = tu.UnitId 
                       WHERE l.JobId = j.JobId) t) AS ContainerId,
                (SELECT STRING_AGG(Description, ', ') FROM Load WHERE JobId = j.JobId) AS Items,
                (SELECT COALESCE(SUM(WeightKg), 0) FROM Load WHERE JobId = j.JobId) AS TotalWeight
            FROM Job j ";

        private void btn_LoadJobsReport_Click(object sender, EventArgs e)
        {
            LoadReport(baseQuery);
        }



        private void btn_LoadDelivered_Click(object sender, EventArgs e)
        {
            LoadReport(baseQuery + " WHERE j.Status = 'Delivered'");
        }

        private void btn_LoadPending_Click(object sender, EventArgs e)
        {
            LoadReport(baseQuery + " WHERE j.Status = 'Pending'");
        }

        private void btn_LoadProcessing_Click(object sender, EventArgs e)
        {
            LoadReport(baseQuery + " WHERE j.Status = 'Processing'");
        }

        private void btn_LoadHold_Click(object sender, EventArgs e)
        {
            LoadReport(baseQuery + " WHERE j.Status = 'Hold'");
        }

        private void btn_LoadCancel_Click(object sender, EventArgs e)
        {
            LoadReport(baseQuery + " WHERE j.Status = 'Cancel'");
        }

        private void dgv_Reports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgv_Reports.Columns.Contains("JobId") && dgv_Reports.Rows[e.RowIndex].Cells["JobId"].Value != DBNull.Value)
                {
                    int jobId = Convert.ToInt32(dgv_Reports.Rows[e.RowIndex].Cells["JobId"].Value);
                    JobProcessingForm processForm = new JobProcessingForm(jobId);
                    processForm.ShowDialog();
                }
            }
        }

        private void LoadReport(string query)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_Reports.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message);
                }
            }
        }

    }
}
