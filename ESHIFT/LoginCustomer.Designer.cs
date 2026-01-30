namespace ESHIFT
{
    partial class LoginCustomer
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
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.txt_Cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button(); // Instantiated Register Button
            this.checkbox_showpassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            this.txt_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cancel.Location = new System.Drawing.Point(461, 354);
            this.txt_Cancel.Name = "txt_Cancel";
            this.txt_Cancel.Size = new System.Drawing.Size(110, 40);
            this.txt_Cancel.TabIndex = 15;
            this.txt_Cancel.Text = "Cancel";
            this.txt_Cancel.UseVisualStyleBackColor = false;
            this.txt_Cancel.Click += new System.EventHandler(this.txt_Cancel_Click);
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(274, 354);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(110, 40);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(87, 354);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(110, 40);
            this.btn_register.TabIndex = 16;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            this.checkbox_showpassword.AutoSize = true;
            this.checkbox_showpassword.Location = new System.Drawing.Point(323, 304);
            this.checkbox_showpassword.Name = "checkbox_showpassword";
            this.checkbox_showpassword.Size = new System.Drawing.Size(148, 24);
            this.checkbox_showpassword.TabIndex = 13;
            this.checkbox_showpassword.Text = "Show Password";
            this.checkbox_showpassword.UseVisualStyleBackColor = true;
            this.checkbox_showpassword.CheckedChanged += new System.EventHandler(this.checkbox_showpassword_CheckedChanged);
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Name";
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Location = new System.Drawing.Point(323, 236);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(223, 26);
            this.txt_password.TabIndex = 10;
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Location = new System.Drawing.Point(323, 141);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(223, 26);
            this.txt_username.TabIndex = 9;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 43);
            this.label4.TabIndex = 16;
            this.label4.Text = "Customer Login";
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 125);
            this.panel1.TabIndex = 17;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(716, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "ESHIFT";
            this.pictureBox1.Image = global::ESHIFT.Properties.Resources.ChatGPT_Image_Sep_7__2025__02_52_36_PM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::ESHIFT.Properties.Resources.ChatGPT_Image_Sep_8__2025__12_43_24_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_register); // Added Register Button
            this.Controls.Add(this.txt_Cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.checkbox_showpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginCustomer";
            this.Text = "LoginCustomer";
            this.Load += new System.EventHandler(this.LoginCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Button btn_register; // Declared Register Button
        private System.Windows.Forms.Button txt_Cancel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox checkbox_showpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
