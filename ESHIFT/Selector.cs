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
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void Selector_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_Ca_Click(object sender, EventArgs e)
        {

        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Login employeeLogin = new Login();
            employeeLogin.Show();
            this.Hide();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            LoginCustomer customerLogin = new LoginCustomer();
            customerLogin.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
