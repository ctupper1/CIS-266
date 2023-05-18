namespace BarChartReport
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
            this.FreightCostsDataSet = new BarChartReport.FreightCostsDataSet();
            this.FreightTotalsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FreightTotalsDataTableTableAdapter = new BarChartReport.FreightCostsDataSetTableAdapters.FreightTotalsDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FreightCostsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreightTotalsDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "FreightReportDataSet";
            reportDataSource1.Value = this.FreightTotalsDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BarChartReport.FreightCostsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(766, 549);
            this.reportViewer1.TabIndex = 0;
            // 
            // FreightCostsDataSet
            // 
            this.FreightCostsDataSet.DataSetName = "FreightCostsDataSet";
            this.FreightCostsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FreightTotalsDataTableBindingSource
            // 
            this.FreightTotalsDataTableBindingSource.DataMember = "FreightTotalsDataTable";
            this.FreightTotalsDataTableBindingSource.DataSource = this.FreightCostsDataSet;
            // 
            // FreightTotalsDataTableTableAdapter
            // 
            this.FreightTotalsDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 549);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Freight Costs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FreightCostsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreightTotalsDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FreightTotalsDataTableBindingSource;
        private FreightCostsDataSet FreightCostsDataSet;
        private FreightCostsDataSetTableAdapters.FreightTotalsDataTableTableAdapter FreightTotalsDataTableTableAdapter;
    }
}

