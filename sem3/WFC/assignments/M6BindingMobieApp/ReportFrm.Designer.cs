namespace M6BindingMobieApp
{
    partial class ReportFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CellStoreDataSet = new M6BindingMobieApp.CellStoreDataSet();
            this.CellPhoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CellPhoneTableAdapter = new M6BindingMobieApp.CellStoreDataSetTableAdapters.CellPhoneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CellStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellPhoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CellPhoneBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "M6BindingMobieApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // CellStoreDataSet
            // 
            this.CellStoreDataSet.DataSetName = "CellStoreDataSet";
            this.CellStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CellPhoneBindingSource
            // 
            this.CellPhoneBindingSource.DataMember = "CellPhone";
            this.CellPhoneBindingSource.DataSource = this.CellStoreDataSet;
            // 
            // CellPhoneTableAdapter
            // 
            this.CellPhoneTableAdapter.ClearBeforeFill = true;
            // 
            // ReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportFrm";
            this.Text = "ReportFrm";
            this.Load += new System.EventHandler(this.ReportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CellStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellPhoneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CellPhoneBindingSource;
        private CellStoreDataSet CellStoreDataSet;
        private CellStoreDataSetTableAdapters.CellPhoneTableAdapter CellPhoneTableAdapter;
    }
}