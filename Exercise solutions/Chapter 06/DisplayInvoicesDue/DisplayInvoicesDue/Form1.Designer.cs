namespace DisplayInvoicesDue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvInvoices = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.txtTotalBalanceDue = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GetAllInvoicesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.VendorIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.GetVendorInvoicesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvInvoices
            // 
            this.lvInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvInvoices.Location = new System.Drawing.Point(14, 40);
            this.lvInvoices.Name = "lvInvoices";
            this.lvInvoices.Size = new System.Drawing.Size(642, 241);
            this.lvInvoices.TabIndex = 0;
            this.lvInvoices.UseCompatibleStateImageBehavior = false;
            this.lvInvoices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Invoice Number";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Invoice Date";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Invoice Total";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Payment Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Credit Total";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Balance Due";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Due Date";
            this.columnHeader7.Width = 80;
            // 
            // txtTotalBalanceDue
            // 
            this.txtTotalBalanceDue.Location = new System.Drawing.Point(445, 298);
            this.txtTotalBalanceDue.Name = "txtTotalBalanceDue";
            this.txtTotalBalanceDue.ReadOnly = true;
            this.txtTotalBalanceDue.Size = new System.Drawing.Size(110, 20);
            this.txtTotalBalanceDue.TabIndex = 6;
            this.txtTotalBalanceDue.TabStop = false;
            this.txtTotalBalanceDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(313, 301);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(117, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Total Balance Due:";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetAllInvoicesToolStripButton,
            this.ToolStripSeparator1,
            this.ToolStripLabel1,
            this.VendorIDToolStripTextBox,
            this.GetVendorInvoicesToolStripButton,
            this.ToolStripSeparator2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(668, 25);
            this.ToolStrip1.TabIndex = 4;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // GetAllInvoicesToolStripButton
            // 
            this.GetAllInvoicesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GetAllInvoicesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GetAllInvoicesToolStripButton.Image")));
            this.GetAllInvoicesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GetAllInvoicesToolStripButton.Name = "GetAllInvoicesToolStripButton";
            this.GetAllInvoicesToolStripButton.Size = new System.Drawing.Size(85, 22);
            this.GetAllInvoicesToolStripButton.Text = "Get All Invoices";
            this.GetAllInvoicesToolStripButton.Click += new System.EventHandler(this.GetAllInvoicesToolStripButton_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.ToolStripLabel1.Text = "Vendor ID:";
            // 
            // VendorIDToolStripTextBox
            // 
            this.VendorIDToolStripTextBox.Name = "VendorIDToolStripTextBox";
            this.VendorIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // GetVendorInvoicesToolStripButton
            // 
            this.GetVendorInvoicesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GetVendorInvoicesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GetVendorInvoicesToolStripButton.Image")));
            this.GetVendorInvoicesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GetVendorInvoicesToolStripButton.Name = "GetVendorInvoicesToolStripButton";
            this.GetVendorInvoicesToolStripButton.Size = new System.Drawing.Size(108, 22);
            this.GetVendorInvoicesToolStripButton.Text = "Get Vendor Invoices";
            this.GetVendorInvoicesToolStripButton.Click += new System.EventHandler(this.GetVendorInvoicesToolStripButton_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 334);
            this.Controls.Add(this.txtTotalBalanceDue);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.lvInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices by Due Date";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInvoices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        internal System.Windows.Forms.TextBox txtTotalBalanceDue;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton GetAllInvoicesToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox VendorIDToolStripTextBox;
        internal System.Windows.Forms.ToolStripButton GetVendorInvoicesToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
    }
}

