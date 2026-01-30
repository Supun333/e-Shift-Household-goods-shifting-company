namespace ESHIFT
{
    partial class RegisterCustomer
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_username.Location = new System.Drawing.Point(150, 360); // Shifted +80
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(200, 20);
            this.txt_username.TabIndex = 6;
            this.txt_password.Location = new System.Drawing.Point(150, 400); // Shifted +80
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(200, 20);
            this.txt_password.TabIndex = 7;
            this.txt_confirmPassword.Location = new System.Drawing.Point(150, 440); // Shifted +80
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PasswordChar = '*';
            this.txt_confirmPassword.Size = new System.Drawing.Size(200, 20);
            this.txt_confirmPassword.TabIndex = 8;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 363); // Shifted +80
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 403); // Shifted +80
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 443); // Shifted +80
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password:";
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_register.Location = new System.Drawing.Point(150, 490); // Shifted +80
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(90, 30);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.Location = new System.Drawing.Point(260, 490); // Shifted +80
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 30);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            this.txt_firstname.Location = new System.Drawing.Point(150, 120); // Shifted +80
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(200, 20);
            this.txt_firstname.TabIndex = 0;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 123); // Shifted +80
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "First Name:";
            this.txt_lastname.Location = new System.Drawing.Point(150, 160); // Shifted +80
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(200, 20);
            this.txt_lastname.TabIndex = 1;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 163); // Shifted +80
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last Name:";
            this.txt_nic.Location = new System.Drawing.Point(150, 200); // Shifted +80
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(200, 20);
            this.txt_nic.TabIndex = 2;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 203); // Shifted +80
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "NIC:";
            this.txt_phone.Location = new System.Drawing.Point(150, 240); // Shifted +80
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(200, 20);
            this.txt_phone.TabIndex = 3;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(30, 243); // Shifted +80
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phone:";
            this.txt_email.Location = new System.Drawing.Point(150, 280); // Shifted +80
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 20);
            this.txt_email.TabIndex = 4;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(30, 283); // Shifted +80
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email:";
            this.txt_address.Location = new System.Drawing.Point(150, 320); // Shifted +80
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(200, 20);
            this.txt_address.TabIndex = 5;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(30, 323); // Shifted +80
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Address:";
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(420, 580);
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 80);
            this.panel1.TabIndex = 22;
            this.pictureBox1.Image = global::ESHIFT.Properties.Resources.ChatGPT_Image_Sep_7__2025__02_52_36_PM;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(130, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(100, 25);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "ESHIFT";
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.panel1);
            this.BackgroundImage = global::ESHIFT.Properties.Resources.ChatGPT_Image_Sep_8__2025__12_43_24_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Name = "RegisterCustomer";
            this.Text = "Register Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHeader;
    }
}
