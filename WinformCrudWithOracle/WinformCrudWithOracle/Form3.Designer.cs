namespace WinformCrudWithOracle
{
    partial class Form3
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
            this.helpdbDataSet = new WinformCrudWithOracle.helpdbDataSet();
            this.EMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMPLOYEETableAdapter = new WinformCrudWithOracle.helpdbDataSetTableAdapters.EMPLOYEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.helpdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EMPLOYEEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinformCrudWithOracle.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 501);
            this.reportViewer1.TabIndex = 0;
            // 
            // helpdbDataSet
            // 
            this.helpdbDataSet.DataSetName = "helpdbDataSet";
            this.helpdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EMPLOYEEBindingSource
            // 
            this.EMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.EMPLOYEEBindingSource.DataSource = this.helpdbDataSet;
            // 
            // EMPLOYEETableAdapter
            // 
            this.EMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 501);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.helpdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EMPLOYEEBindingSource;
        private helpdbDataSet helpdbDataSet;
        private helpdbDataSetTableAdapters.EMPLOYEETableAdapter EMPLOYEETableAdapter;
    }
}