using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ESHIFT
{
    public partial class TransportSearchForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True";
        public string SelectedUnitId { get; private set; }
        public string SelectedDriver { get; private set; }
        public string SelectedAssistant { get; private set; }

        public TransportSearchForm()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text.Trim();
            string searchField = rdo_Driver.Checked ? "DriverName" : "AssistantName";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT UnitId, VehicleNumberPlate, DriverName, AssistantName FROM TransportUnit WHERE {searchField} LIKE @keyword";
                    
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        dgv_TransportUnits.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching: " + ex.Message);
                }
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (dgv_TransportUnits.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_TransportUnits.SelectedRows[0];
                SelectedUnitId = row.Cells["UnitId"].Value.ToString();
                SelectedDriver = row.Cells["DriverName"].Value.ToString();
                SelectedAssistant = row.Cells["AssistantName"].Value.ToString();
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a transport unit.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgv_TransportUnits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Select_Click(sender, e);
        }
    }
}
