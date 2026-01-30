namespace ESHIFT
{
    partial class Reports
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
            this.dgv_Reports = new System.Windows.Forms.DataGridView();
            this.btn_LoadJobsReport = new System.Windows.Forms.Button();
            this.btn_LoadDelivered = new System.Windows.Forms.Button();
            this.btn_LoadPending = new System.Windows.Forms.Button();
            this.btn_LoadProcessing = new System.Windows.Forms.Button();
            this.btn_LoadHold = new System.Windows.Forms.Button();
            this.btn_LoadCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reports)).BeginInit();
            this.SuspendLayout();
            this.dgv_Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reports.Location = new System.Drawing.Point(12, 90);
            this.dgv_Reports.Name = "dgv_Reports";
            this.dgv_Reports.Size = new System.Drawing.Size(1077, 413);
            this.dgv_Reports.TabIndex = 0;
            this.dgv_Reports.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Reports_CellDoubleClick);
            this.btn_LoadJobsReport.Location = new System.Drawing.Point(12, 12);
            this.btn_LoadJobsReport.Name = "btn_LoadJobsReport";
            this.btn_LoadJobsReport.Size = new System.Drawing.Size(120, 30);
            this.btn_LoadJobsReport.TabIndex = 1;
            this.btn_LoadJobsReport.Text = "All Jobs Report";
            this.btn_LoadJobsReport.UseVisualStyleBackColor = true;
            this.btn_LoadJobsReport.Click += new System.EventHandler(this.btn_LoadJobsReport_Click);
            this.btn_LoadDelivered.Location = new System.Drawing.Point(428, 12);
            this.btn_LoadDelivered.Name = "btn_LoadDelivered";
            this.btn_LoadDelivered.Size = new System.Drawing.Size(120, 30);
            this.btn_LoadDelivered.TabIndex = 3;
            this.btn_LoadDelivered.Text = "Delivered Items";
            this.btn_LoadDelivered.UseVisualStyleBackColor = true;
            this.btn_LoadDelivered.Click += new System.EventHandler(this.btn_LoadDelivered_Click);
            this.btn_LoadPending.Location = new System.Drawing.Point(150, 12);
            this.btn_LoadPending.Name = "btn_LoadPending";
            this.btn_LoadPending.Size = new System.Drawing.Size(120, 30);
            this.btn_LoadPending.TabIndex = 4;
            this.btn_LoadPending.Text = "Pending Items";
            this.btn_LoadPending.UseVisualStyleBackColor = true;
            this.btn_LoadPending.Click += new System.EventHandler(this.btn_LoadPending_Click);
            this.btn_LoadProcessing.Location = new System.Drawing.Point(290, 12);
            this.btn_LoadProcessing.Name = "btn_LoadProcessing";
            this.btn_LoadProcessing.Size = new System.Drawing.Size(120, 30);
            this.btn_LoadProcessing.TabIndex = 5;
            this.btn_LoadProcessing.Text = "Processing Items";
            this.btn_LoadProcessing.UseVisualStyleBackColor = true;
            this.btn_LoadProcessing.Click += new System.EventHandler(this.btn_LoadProcessing_Click);
            this.btn_LoadHold.Location = new System.Drawing.Point(571, 12);
            this.btn_LoadHold.Name = "btn_LoadHold";
            this.btn_LoadHold.Size = new System.Drawing.Size(120, 30);
            this.btn_LoadHold.TabIndex = 6;
            this.btn_LoadHold.Text = "Hold Items";
            this.btn_LoadHold.UseVisualStyleBackColor = true;
            this.btn_LoadHold.Click += new System.EventHandler(this.btn_LoadHold_Click);
            this.btn_LoadCancel.Location = new System.Drawing.Point(709, 12);
            this.btn_LoadCancel.Name = "btn_LoadCancel";
            this.btn_LoadCancel.Size = new System.Drawing.Size(120, 30);
            this.btn_LoadCancel.TabIndex = 7;
            this.btn_LoadCancel.Text = "Cancelled Items";
            this.btn_LoadCancel.UseVisualStyleBackColor = true;
            this.btn_LoadCancel.Click += new System.EventHandler(this.btn_LoadCancel_Click);
            this.BackgroundImage = global::ESHIFT.Properties.Resources.ChatGPT_Image_Sep_8__2025__12_43_24_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 623);
            this.Controls.Add(this.btn_LoadCancel);
            this.Controls.Add(this.btn_LoadHold);
            this.Controls.Add(this.btn_LoadProcessing);
            this.Controls.Add(this.btn_LoadPending);
            this.Controls.Add(this.btn_LoadDelivered);
            this.Controls.Add(this.btn_LoadJobsReport);
            this.Controls.Add(this.dgv_Reports);
            this.Name = "Reports";
            this.Text = "Reports Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reports)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.DataGridView dgv_Reports;
        private System.Windows.Forms.Button btn_LoadJobsReport;
        private System.Windows.Forms.Button btn_LoadDelivered;
        private System.Windows.Forms.Button btn_LoadPending;
        private System.Windows.Forms.Button btn_LoadProcessing;
        private System.Windows.Forms.Button btn_LoadHold;
        private System.Windows.Forms.Button btn_LoadCancel;
    }
}
