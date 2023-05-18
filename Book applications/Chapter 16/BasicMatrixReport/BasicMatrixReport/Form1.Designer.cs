namespace BasicMatrixReport
{
    partial class Form1
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
            this.PayablesDataSet = new BasicMatrixReport.PayablesDataSet();
            this.InvoiceStateCityDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceStateCityDataTableTableAdapter = new BasicMatrixReport.PayablesDataSetTableAdapters.InvoiceStateCityDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PayablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceStateCityDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportDataSet";
            reportDataSource1.Value = this.InvoiceStateCityDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BasicMatrixReport.CityBreakdownReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(786, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // PayablesDataSet
            // 
            this.PayablesDataSet.DataSetName = "PayablesDataSet";
            this.PayablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InvoiceStateCityDataTableBindingSource
            // 
            this.InvoiceStateCityDataTableBindingSource.DataMember = "InvoiceStateCityDataTable";
            this.InvoiceStateCityDataTableBindingSource.DataSource = this.PayablesDataSet;
            // 
            // InvoiceStateCityDataTableTableAdapter
            // 
            this.InvoiceStateCityDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 466);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Invoices Breakdown By Date, State and City";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceStateCityDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InvoiceStateCityDataTableBindingSource;
        private PayablesDataSet PayablesDataSet;
        private PayablesDataSetTableAdapters.InvoiceStateCityDataTableTableAdapter InvoiceStateCityDataTableTableAdapter;
    }
}

