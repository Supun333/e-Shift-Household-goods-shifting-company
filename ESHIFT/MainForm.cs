using System;
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
    public partial class MainForm : Form
    {
        public string CurrentRole { get; private set; }

        public MainForm(string role = "Admin")
        {
            InitializeComponent();
            CurrentRole = (role ?? "Admin").Trim();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void lbl_Customer_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
        }

        private void btn_Transport_Controller_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TransportUnit(CurrentRole));
        }



        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            panelContainer.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void btn_Job_controller_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Jobs());
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Selector selectorForm = new Selector();
            selectorForm.Show();
            this.Close();

        }




        private void btn_Reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
