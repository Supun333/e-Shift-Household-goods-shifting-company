namespace ESHIFT
{
    partial class JobProcessingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbl_JobId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.TextBox txt_UnitId;
        private System.Windows.Forms.TextBox txt_Driver;
        private System.Windows.Forms.TextBox txt_Assistant;
        private System.Windows.Forms.TextBox txt_PaymentAmount;
        private System.Windows.Forms.Button btn_SearchUnit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DateTimePicker dtp_DeliveryDate; // New Control
        private System.Windows.Forms.Label lbl_DeliveryDate; // New Label
        private System.Windows.Forms.Label lbl_ItemDescription;
        private System.Windows.Forms.TextBox txt_ItemDescription;
        private System.Windows.Forms.Label lbl_ItemWeight;
        private System.Windows.Forms.TextBox txt_ItemWeight;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lbl_JobId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.txt_UnitId = new System.Windows.Forms.TextBox();
            this.txt_Driver = new System.Windows.Forms.TextBox();
            this.txt_Assistant = new System.Windows.Forms.TextBox();
            this.btn_SearchUnit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PaymentAmount = new System.Windows.Forms.TextBox();
            this.dtp_DeliveryDate = new System.Windows.Forms.DateTimePicker(); // Init
            this.lbl_DeliveryDate = new System.Windows.Forms.Label(); // Init
            this.lbl_ItemDescription = new System.Windows.Forms.Label();
            this.txt_ItemDescription = new System.Windows.Forms.TextBox();
            this.lbl_ItemWeight = new System.Windows.Forms.Label();
            this.txt_ItemWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.lbl_JobId.AutoSize = true;
            this.lbl_JobId.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_JobId.Location = new System.Drawing.Point(20, 20);
            this.lbl_JobId.Name = "lbl_JobId";
            this.lbl_JobId.Size = new System.Drawing.Size(67, 23);
            this.lbl_JobId.TabIndex = 0;
            this.lbl_JobId.Text = "Job ID";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transport Unit ID:";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Driver:";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Assistant:";
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "Pending",
            "Delivered",
            "Hold",
            "Processing",
            "Cancel"});
            this.cmb_Status.Location = new System.Drawing.Point(150, 77);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(220, 21);
            this.cmb_Status.TabIndex = 2;
            this.txt_UnitId.Location = new System.Drawing.Point(150, 135);
            this.txt_UnitId.Name = "txt_UnitId";
            this.txt_UnitId.Size = new System.Drawing.Size(100, 20);
            this.txt_UnitId.TabIndex = 4;
            this.txt_Driver.Location = new System.Drawing.Point(150, 187);
            this.txt_Driver.Name = "txt_Driver";
            this.txt_Driver.ReadOnly = true;
            this.txt_Driver.Size = new System.Drawing.Size(220, 20);
            this.txt_Driver.TabIndex = 7;
            this.txt_Assistant.Location = new System.Drawing.Point(150, 227);
            this.txt_Assistant.Name = "txt_Assistant";
            this.txt_Assistant.ReadOnly = true;
            this.txt_Assistant.Size = new System.Drawing.Size(220, 20);
            this.txt_Assistant.TabIndex = 9;
            this.btn_SearchUnit.Location = new System.Drawing.Point(279, 129);
            this.btn_SearchUnit.Name = "btn_SearchUnit";
            this.btn_SearchUnit.Size = new System.Drawing.Size(120, 30);
            this.btn_SearchUnit.TabIndex = 5;
            this.btn_SearchUnit.Text = "Search Transport";
            this.btn_SearchUnit.Click += new System.EventHandler(this.btn_SearchUnit_Click);
            this.btn_Save.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(100, 440); // Shifted Down
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 40);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Update Job";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Cancel.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(250, 440); // Shifted Down
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.label5.AutoSize = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 350);
            this.label5.Name = "label5";
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment (Rs.):";
            this.txt_PaymentAmount.Location = new System.Drawing.Point(150, 347);
            this.txt_PaymentAmount.Name = "txt_PaymentAmount";
            this.txt_PaymentAmount.Size = new System.Drawing.Size(150, 20);
            this.txt_PaymentAmount.TabIndex = 11;
            this.txt_PaymentAmount.Text = "0.00";
            this.lbl_DeliveryDate.AutoSize = true;
            this.lbl_DeliveryDate.Location = new System.Drawing.Point(30, 390);
            this.lbl_DeliveryDate.Name = "lbl_DeliveryDate";
            this.lbl_DeliveryDate.Size = new System.Drawing.Size(74, 13);
            this.lbl_DeliveryDate.TabIndex = 14;
            this.lbl_DeliveryDate.Text = "Delivery Date:";
            this.dtp_DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DeliveryDate.Location = new System.Drawing.Point(150, 387);
            this.dtp_DeliveryDate.Name = "dtp_DeliveryDate";
            this.dtp_DeliveryDate.Size = new System.Drawing.Size(150, 20);
            this.dtp_DeliveryDate.TabIndex = 15;
            this.lbl_ItemDescription.AutoSize = true;
            this.lbl_ItemDescription.Location = new System.Drawing.Point(30, 270);
            this.lbl_ItemDescription.Name = "lbl_ItemDescription";
            this.lbl_ItemDescription.Size = new System.Drawing.Size(86, 13);
            this.lbl_ItemDescription.TabIndex = 16;
            this.lbl_ItemDescription.Text = "Item Description:";
            this.txt_ItemDescription.Location = new System.Drawing.Point(150, 267);
            this.txt_ItemDescription.Name = "txt_ItemDescription";
            this.txt_ItemDescription.Size = new System.Drawing.Size(220, 20);
            this.txt_ItemDescription.TabIndex = 17;
            this.lbl_ItemWeight.AutoSize = true;
            this.lbl_ItemWeight.Location = new System.Drawing.Point(30, 310);
            this.lbl_ItemWeight.Name = "lbl_ItemWeight";
            this.lbl_ItemWeight.Size = new System.Drawing.Size(68, 13);
            this.lbl_ItemWeight.TabIndex = 18;
            this.lbl_ItemWeight.Text = "Weight (Kg):";
            this.txt_ItemWeight.Location = new System.Drawing.Point(150, 307);
            this.txt_ItemWeight.Name = "txt_ItemWeight";
            this.txt_ItemWeight.Size = new System.Drawing.Size(150, 20);
            this.txt_ItemWeight.TabIndex = 19;
            this.BackgroundImage = global::ESHIFT.Properties.Resources.ChatGPT_Image_Sep_8__2025__12_43_24_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.lbl_JobId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UnitId);
            this.Controls.Add(this.btn_SearchUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Driver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Assistant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PaymentAmount);
            this.Controls.Add(this.lbl_DeliveryDate); // Add
            this.Controls.Add(this.dtp_DeliveryDate); // Add
            this.Controls.Add(this.lbl_ItemDescription);
            this.Controls.Add(this.txt_ItemDescription);
            this.Controls.Add(this.lbl_ItemWeight);
            this.Controls.Add(this.txt_ItemWeight);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobProcessingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process Job";
            this.Load += new System.EventHandler(this.JobProcessingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
