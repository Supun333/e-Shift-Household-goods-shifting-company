namespace ESHIFT
{
    partial class TransportSearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton rdo_Driver;
        private System.Windows.Forms.RadioButton rdo_Assistant;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_TransportUnits;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Cancel;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.rdo_Driver = new System.Windows.Forms.RadioButton();
            this.rdo_Assistant = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_TransportUnits = new System.Windows.Forms.DataGridView();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransportUnits)).BeginInit();
            this.SuspendLayout();
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(20, 20);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(75, 13);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Search Name:";
            this.txt_Search.Location = new System.Drawing.Point(130, 17);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(200, 20);
            this.txt_Search.TabIndex = 0;
            this.rdo_Driver.AutoSize = true;
            this.rdo_Driver.Checked = true;
            this.rdo_Driver.Location = new System.Drawing.Point(340, 18);
            this.rdo_Driver.Name = "rdo_Driver";
            this.rdo_Driver.Size = new System.Drawing.Size(53, 17);
            this.rdo_Driver.TabIndex = 1;
            this.rdo_Driver.TabStop = true;
            this.rdo_Driver.Text = "Driver";
            this.rdo_Driver.UseVisualStyleBackColor = true;
            this.rdo_Assistant.AutoSize = true;
            this.rdo_Assistant.Location = new System.Drawing.Point(430, 18);
            this.rdo_Assistant.Name = "rdo_Assistant";
            this.rdo_Assistant.Size = new System.Drawing.Size(67, 17);
            this.rdo_Assistant.TabIndex = 2;
            this.rdo_Assistant.Text = "Assistant";
            this.rdo_Assistant.UseVisualStyleBackColor = true;
            this.btn_Search.Location = new System.Drawing.Point(540, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 30);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.dgv_TransportUnits.AllowUserToAddRows = false;
            this.dgv_TransportUnits.AllowUserToDeleteRows = false;
            this.dgv_TransportUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransportUnits.Location = new System.Drawing.Point(20, 60);
            this.dgv_TransportUnits.Name = "dgv_TransportUnits";
            this.dgv_TransportUnits.ReadOnly = true;
            this.dgv_TransportUnits.RowHeadersWidth = 51;
            this.dgv_TransportUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TransportUnits.Size = new System.Drawing.Size(600, 300);
            this.dgv_TransportUnits.TabIndex = 4;
            this.dgv_TransportUnits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TransportUnits_CellDoubleClick);
            this.btn_Select.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Select.Location = new System.Drawing.Point(200, 380);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(100, 40);
            this.btn_Select.TabIndex = 5;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            this.btn_Cancel.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(340, 380);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.BackgroundImage = global::ESHIFT.Properties.Resources.ChatGPT_Image_Sep_8__2025__12_43_24_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 440);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.rdo_Driver);
            this.Controls.Add(this.rdo_Assistant);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_TransportUnits);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransportSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Transport Unit";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransportUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
