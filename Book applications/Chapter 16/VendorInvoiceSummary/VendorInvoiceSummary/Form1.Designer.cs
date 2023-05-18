namespace VendorInvoiceSummary
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
            this.PayablesDataSet = new VendorInvoiceSummary.PayablesDataSet();
            this.VendorInvoicesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendorInvoicesDataTableTableAdapter = new VendorInvoiceSummary.PayablesDataSetTableAdapters.VendorInvoicesDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PayablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorInvoicesDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VendorInvoices";
            reportDataSource1.Value = this.VendorInvoicesDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VendorInvoiceSummary.VendorInvoicesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(872, 477);
            this.reportViewer1.TabIndex = 0;
            // 
            // PayablesDataSet
            // 
            this.PayablesDataSet.DataSetName = "PayablesDataSet";
            this.PayablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VendorInvoicesDataTableBindingSource
            // 
            this.VendorInvoicesDataTableBindingSource.DataMember = "VendorInvoicesDataTable";
            this.VendorInvoicesDataTableBindingSource.DataSource = this.PayablesDataSet;
            // 
            // VendorInvoicesDataTableTableAdapter
            // 
            this.VendorInvoicesDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 477);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorInvoicesDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendorInvoicesDataTableBindingSource;
        private PayablesDataSet PayablesDataSet;
        private PayablesDataSetTableAdapters.VendorInvoicesDataTableTableAdapter VendorInvoicesDataTableTableAdapter;
    }
}

