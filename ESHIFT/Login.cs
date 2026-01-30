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
using static Guna.UI2.Native.WinApi;

namespace ESHIFT
{
    
    public partial class Login : Form
    {
        bool mousedown;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Cancel.Text = "Back";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L7O0S1C\\SQLEXPRESS;Initial Catalog=eShiftDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();

                    string query = "SELECT Role FROM Login WHERE UserName = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txt_password.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string role = result.ToString();

                            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase) || role.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Login Success (" + role + ")", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mainForm = new MainForm(role);
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Access Denied! Role not authorized.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txt_Cancel_Click(object sender, EventArgs e)
        {
            Selector selector = new Selector();
            selector.Show();
            this.Close();
        }

        private void checkbox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = checkbox_showpassword.Checked ? '\0' : '*';
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
