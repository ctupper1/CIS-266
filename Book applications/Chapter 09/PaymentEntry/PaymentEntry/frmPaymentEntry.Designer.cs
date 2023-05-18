namespace PaymentEntry
{
    partial class frmPaymentEntry
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
            System.Windows.Forms.Label PaymentDateLabel;
            System.Windows.Forms.Label DueDateLabel;
            System.Windows.Forms.Label BalanceDueLabel;
            System.Windows.Forms.Label CreditTotalLabel;
            System.Windows.Forms.Label PaymentTotalLabel;
            System.Windows.Forms.Label InvoiceDateLabel;
            System.Windows.Forms.Label InvoiceTotalLabel;
            System.Windows.Forms.Label InvoiceNumberLabel;
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.PaymentDateTextBox = new System.Windows.Forms.TextBox();
            this.DueDateTextBox = new System.Windows.Forms.TextBox();
            this.BalanceDueTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CreditTotalTextBox = new System.Windows.Forms.TextBox();
            this.PaymentTotalTextBox = new System.Windows.Forms.TextBox();
            this.InvoiceDateTextBox = new System.Windows.Forms.TextBox();
            this.InvoiceTotalTextBox = new System.Windows.Forms.TextBox();
            this.InvoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            PaymentDateLabel = new System.Windows.Forms.Label();
            DueDateLabel = new System.Windows.Forms.Label();
            BalanceDueLabel = new System.Windows.Forms.Label();
            CreditTotalLabel = new System.Windows.Forms.Label();
            PaymentTotalLabel = new System.Windows.Forms.Label();
            InvoiceDateLabel = new System.Windows.Forms.Label();
            InvoiceTotalLabel = new System.Windows.Forms.Label();
            InvoiceNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(223, 177);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 20);
            this.txtPayment.TabIndex = 24;
            this.txtPayment.Tag = "Payment amount";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(118, 180);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 13);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Payment Amount:";
            // 
            // PaymentDateLabel
            // 
            PaymentDateLabel.AutoSize = true;
            PaymentDateLabel.Location = new System.Drawing.Point(220, 133);
            PaymentDateLabel.Name = "PaymentDateLabel";
            PaymentDateLabel.Size = new System.Drawing.Size(100, 13);
            PaymentDateLabel.TabIndex = 41;
            PaymentDateLabel.Text = "Last Payment Date:";
            // 
            // PaymentDateTextBox
            // 
            this.PaymentDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaymentDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.PaymentDateTextBox.Location = new System.Drawing.Point(326, 130);
            this.PaymentDateTextBox.Name = "PaymentDateTextBox";
            this.PaymentDateTextBox.ReadOnly = true;
            this.PaymentDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.PaymentDateTextBox.TabIndex = 43;
            this.PaymentDateTextBox.TabStop = false;
            // 
            // DueDateLabel
            // 
            DueDateLabel.AutoSize = true;
            DueDateLabel.Location = new System.Drawing.Point(220, 107);
            DueDateLabel.Name = "DueDateLabel";
            DueDateLabel.Size = new System.Drawing.Size(56, 13);
            DueDateLabel.TabIndex = 40;
            DueDateLabel.Text = "Due Date:";
            // 
            // DueDateTextBox
            // 
            this.DueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DueDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.DueDateTextBox.Location = new System.Drawing.Point(326, 104);
            this.DueDateTextBox.Name = "DueDateTextBox";
            this.DueDateTextBox.ReadOnly = true;
            this.DueDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.DueDateTextBox.TabIndex = 42;
            this.DueDateTextBox.TabStop = false;
            // 
            // BalanceDueLabel
            // 
            BalanceDueLabel.AutoSize = true;
            BalanceDueLabel.Location = new System.Drawing.Point(221, 81);
            BalanceDueLabel.Name = "BalanceDueLabel";
            BalanceDueLabel.Size = new System.Drawing.Size(72, 13);
            BalanceDueLabel.TabIndex = 38;
            BalanceDueLabel.Text = "Balance Due:";
            // 
            // BalanceDueTextBox
            // 
            this.BalanceDueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "BalanceDue", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.BalanceDueTextBox.Location = new System.Drawing.Point(326, 78);
            this.BalanceDueTextBox.Name = "BalanceDueTextBox";
            this.BalanceDueTextBox.ReadOnly = true;
            this.BalanceDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.BalanceDueTextBox.TabIndex = 39;
            this.BalanceDueTextBox.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(121, 223);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 25;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(62, 13);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.ReadOnly = true;
            this.txtVendor.Size = new System.Drawing.Size(364, 20);
            this.txtVendor.TabIndex = 37;
            this.txtVendor.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "Vendor:";
            // 
            // CreditTotalLabel
            // 
            CreditTotalLabel.AutoSize = true;
            CreditTotalLabel.Location = new System.Drawing.Point(221, 55);
            CreditTotalLabel.Name = "CreditTotalLabel";
            CreditTotalLabel.Size = new System.Drawing.Size(64, 13);
            CreditTotalLabel.TabIndex = 34;
            CreditTotalLabel.Text = "Credit Total:";
            // 
            // CreditTotalTextBox
            // 
            this.CreditTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CreditTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.CreditTotalTextBox.Location = new System.Drawing.Point(326, 52);
            this.CreditTotalTextBox.Name = "CreditTotalTextBox";
            this.CreditTotalTextBox.ReadOnly = true;
            this.CreditTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreditTotalTextBox.TabIndex = 35;
            this.CreditTotalTextBox.TabStop = false;
            // 
            // PaymentTotalLabel
            // 
            PaymentTotalLabel.AutoSize = true;
            PaymentTotalLabel.Location = new System.Drawing.Point(12, 133);
            PaymentTotalLabel.Name = "PaymentTotalLabel";
            PaymentTotalLabel.Size = new System.Drawing.Size(78, 13);
            PaymentTotalLabel.TabIndex = 31;
            PaymentTotalLabel.Text = "Payment Total:";
            // 
            // PaymentTotalTextBox
            // 
            this.PaymentTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaymentTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.PaymentTotalTextBox.Location = new System.Drawing.Point(103, 130);
            this.PaymentTotalTextBox.Name = "PaymentTotalTextBox";
            this.PaymentTotalTextBox.ReadOnly = true;
            this.PaymentTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.PaymentTotalTextBox.TabIndex = 33;
            this.PaymentTotalTextBox.TabStop = false;
            // 
            // InvoiceDateLabel
            // 
            InvoiceDateLabel.AutoSize = true;
            InvoiceDateLabel.Location = new System.Drawing.Point(12, 81);
            InvoiceDateLabel.Name = "InvoiceDateLabel";
            InvoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            InvoiceDateLabel.TabIndex = 29;
            InvoiceDateLabel.Text = "Invoice Date:";
            // 
            // InvoiceDateTextBox
            // 
            this.InvoiceDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceDate", true));
            this.InvoiceDateTextBox.Location = new System.Drawing.Point(103, 78);
            this.InvoiceDateTextBox.Name = "InvoiceDateTextBox";
            this.InvoiceDateTextBox.ReadOnly = true;
            this.InvoiceDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.InvoiceDateTextBox.TabIndex = 32;
            this.InvoiceDateTextBox.TabStop = false;
            // 
            // InvoiceTotalLabel
            // 
            InvoiceTotalLabel.AutoSize = true;
            InvoiceTotalLabel.Location = new System.Drawing.Point(12, 107);
            InvoiceTotalLabel.Name = "InvoiceTotalLabel";
            InvoiceTotalLabel.Size = new System.Drawing.Size(72, 13);
            InvoiceTotalLabel.TabIndex = 28;
            InvoiceTotalLabel.Text = "Invoice Total:";
            // 
            // InvoiceTotalTextBox
            // 
            this.InvoiceTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.InvoiceTotalTextBox.Location = new System.Drawing.Point(103, 104);
            this.InvoiceTotalTextBox.Name = "InvoiceTotalTextBox";
            this.InvoiceTotalTextBox.ReadOnly = true;
            this.InvoiceTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.InvoiceTotalTextBox.TabIndex = 30;
            this.InvoiceTotalTextBox.TabStop = false;
            // 
            // InvoiceNumberLabel
            // 
            InvoiceNumberLabel.AutoSize = true;
            InvoiceNumberLabel.Location = new System.Drawing.Point(12, 55);
            InvoiceNumberLabel.Name = "InvoiceNumberLabel";
            InvoiceNumberLabel.Size = new System.Drawing.Size(85, 13);
            InvoiceNumberLabel.TabIndex = 23;
            InvoiceNumberLabel.Text = "Invoice Number:";
            // 
            // InvoiceNumberTextBox
            // 
            this.InvoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceNumber", true));
            this.InvoiceNumberTextBox.Location = new System.Drawing.Point(103, 52);
            this.InvoiceNumberTextBox.Name = "InvoiceNumberTextBox";
            this.InvoiceNumberTextBox.ReadOnly = true;
            this.InvoiceNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.InvoiceNumberTextBox.TabIndex = 26;
            this.InvoiceNumberTextBox.TabStop = false;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(PayablesData.Invoice);
            // 
            // frmPaymentEntry
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(443, 260);
            this.ControlBox = false;
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.Label2);
            this.Controls.Add(PaymentDateLabel);
            this.Controls.Add(this.PaymentDateTextBox);
            this.Controls.Add(DueDateLabel);
            this.Controls.Add(this.DueDateTextBox);
            this.Controls.Add(BalanceDueLabel);
            this.Controls.Add(this.BalanceDueTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.Label1);
            this.Controls.Add(CreditTotalLabel);
            this.Controls.Add(this.CreditTotalTextBox);
            this.Controls.Add(PaymentTotalLabel);
            this.Controls.Add(this.PaymentTotalTextBox);
            this.Controls.Add(InvoiceDateLabel);
            this.Controls.Add(this.InvoiceDateTextBox);
            this.Controls.Add(InvoiceTotalLabel);
            this.Controls.Add(this.InvoiceTotalTextBox);
            this.Controls.Add(InvoiceNumberLabel);
            this.Controls.Add(this.InvoiceNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Entry";
            this.Load += new System.EventHandler(this.frmPaymentEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceBindingSource;
        internal System.Windows.Forms.TextBox txtPayment;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox PaymentDateTextBox;
        internal System.Windows.Forms.TextBox DueDateTextBox;
        internal System.Windows.Forms.TextBox BalanceDueTextBox;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnAccept;
        internal System.Windows.Forms.TextBox txtVendor;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox CreditTotalTextBox;
        internal System.Windows.Forms.TextBox PaymentTotalTextBox;
        internal System.Windows.Forms.TextBox InvoiceDateTextBox;
        internal System.Windows.Forms.TextBox InvoiceTotalTextBox;
        internal System.Windows.Forms.TextBox InvoiceNumberTextBox;
    }
}