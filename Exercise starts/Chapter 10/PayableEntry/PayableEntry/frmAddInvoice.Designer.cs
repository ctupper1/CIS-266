namespace PayableEntry
{
    partial class frmAddInvoice
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
            System.Windows.Forms.Label DescriptionLabel1;
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label InvoiceDateLabel;
            System.Windows.Forms.Label InvoiceNumberLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gLAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineItemDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteLineItemButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.accountNoComboBox = new System.Windows.Forms.ComboBox();
            this.termsIDComboBox = new System.Windows.Forms.ComboBox();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            DescriptionLabel1 = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            InvoiceDateLabel = new System.Windows.Forms.Label();
            InvoiceNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionLabel1
            // 
            DescriptionLabel1.AutoSize = true;
            DescriptionLabel1.Location = new System.Drawing.Point(12, 174);
            DescriptionLabel1.Name = "DescriptionLabel1";
            DescriptionLabel1.Size = new System.Drawing.Size(50, 13);
            DescriptionLabel1.TabIndex = 27;
            DescriptionLabel1.Text = "Account:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new System.Drawing.Point(13, 119);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(39, 13);
            DescriptionLabel.TabIndex = 26;
            DescriptionLabel.Text = "Terms:";
            // 
            // InvoiceDateLabel
            // 
            InvoiceDateLabel.AutoSize = true;
            InvoiceDateLabel.Location = new System.Drawing.Point(13, 94);
            InvoiceDateLabel.Name = "InvoiceDateLabel";
            InvoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            InvoiceDateLabel.TabIndex = 24;
            InvoiceDateLabel.Text = "Invoice Date:";
            // 
            // InvoiceNumberLabel
            // 
            InvoiceNumberLabel.AutoSize = true;
            InvoiceNumberLabel.Location = new System.Drawing.Point(13, 64);
            InvoiceNumberLabel.Name = "InvoiceNumberLabel";
            InvoiceNumberLabel.Size = new System.Drawing.Size(85, 13);
            InvoiceNumberLabel.TabIndex = 22;
            InvoiceNumberLabel.Text = "Invoice Number:";
            // 
            // lineItemBindingSource
            // 
            this.lineItemBindingSource.DataSource = typeof(PayablesData.LineItem);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(PayablesData.Invoice);
            // 
            // gLAccountBindingSource
            // 
            this.gLAccountBindingSource.DataSource = typeof(PayablesData.GLAccount);
            // 
            // termsBindingSource
            // 
            this.termsBindingSource.DataSource = typeof(PayablesData.Terms);
            // 
            // lineItemDataGridView
            // 
            this.lineItemDataGridView.AllowUserToAddRows = false;
            this.lineItemDataGridView.AllowUserToDeleteRows = false;
            this.lineItemDataGridView.AutoGenerateColumns = false;
            this.lineItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn3,
            this.DeleteLineItemButton});
            this.lineItemDataGridView.DataSource = this.lineItemBindingSource;
            this.lineItemDataGridView.Location = new System.Drawing.Point(13, 209);
            this.lineItemDataGridView.Name = "lineItemDataGridView";
            this.lineItemDataGridView.Size = new System.Drawing.Size(811, 201);
            this.lineItemDataGridView.TabIndex = 39;
            this.lineItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lineItemDataGridView_CellContentClick);
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "InvoiceID";
            this.DataGridViewTextBoxColumn2.HeaderText = "InvoiceID";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.Visible = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "InvoiceSequence";
            this.DataGridViewTextBoxColumn1.HeaderText = "InvoiceSequence";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.Visible = false;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.DataPropertyName = "AccountNo";
            this.DataGridViewTextBoxColumn6.HeaderText = "AccountNo";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.Visible = false;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.DataPropertyName = "AccountDescription";
            this.DataGridViewTextBoxColumn4.HeaderText = "Account";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Width = 250;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.DataGridViewTextBoxColumn5.HeaderText = "Description";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.Width = 300;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            // 
            // DeleteLineItemButton
            // 
            this.DeleteLineItemButton.HeaderText = "";
            this.DeleteLineItemButton.Name = "DeleteLineItemButton";
            this.DeleteLineItemButton.Text = "Delete";
            this.DeleteLineItemButton.UseColumnTextForButtonValue = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(713, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel Invoice";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(596, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save Invoice";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtInvoiceTotal.Location = new System.Drawing.Point(603, 419);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceTotal.TabIndex = 36;
            this.txtInvoiceTotal.TabStop = false;
            this.txtInvoiceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(525, 422);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 13);
            this.Label4.TabIndex = 35;
            this.Label4.Text = "Invoice Total:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(749, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(655, 171);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(74, 20);
            this.txtAmount.TabIndex = 33;
            this.txtAmount.Tag = "Amount";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(603, 174);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(46, 13);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "Amount:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(339, 171);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 20);
            this.txtDescription.TabIndex = 31;
            this.txtDescription.Tag = "Description";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(270, 174);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Description:";
            // 
            // accountNoComboBox
            // 
            this.accountNoComboBox.DataSource = this.gLAccountBindingSource;
            this.accountNoComboBox.DisplayMember = "Description";
            this.accountNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNoComboBox.FormattingEnabled = true;
            this.accountNoComboBox.Location = new System.Drawing.Point(68, 171);
            this.accountNoComboBox.Name = "accountNoComboBox";
            this.accountNoComboBox.Size = new System.Drawing.Size(187, 21);
            this.accountNoComboBox.TabIndex = 29;
            this.accountNoComboBox.ValueMember = "AccountNo";
            // 
            // termsIDComboBox
            // 
            this.termsIDComboBox.DataSource = this.termsBindingSource;
            this.termsIDComboBox.DisplayMember = "Description";
            this.termsIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termsIDComboBox.FormattingEnabled = true;
            this.termsIDComboBox.Location = new System.Drawing.Point(104, 116);
            this.termsIDComboBox.Name = "termsIDComboBox";
            this.termsIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.termsIDComboBox.TabIndex = 28;
            this.termsIDComboBox.ValueMember = "TermsID";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(104, 90);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.invoiceDateDateTimePicker.TabIndex = 25;
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.Location = new System.Drawing.Point(104, 64);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.invoiceNoTextBox.TabIndex = 23;
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(63, 13);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.ReadOnly = true;
            this.txtVendor.Size = new System.Drawing.Size(275, 20);
            this.txtVendor.TabIndex = 21;
            this.txtVendor.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Vendor:";
            // 
            // frmAddInvoice
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(837, 490);
            this.Controls.Add(this.lineItemDataGridView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.Label2);
            this.Controls.Add(DescriptionLabel1);
            this.Controls.Add(this.accountNoComboBox);
            this.Controls.Add(DescriptionLabel);
            this.Controls.Add(this.termsIDComboBox);
            this.Controls.Add(InvoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(InvoiceNumberLabel);
            this.Controls.Add(this.invoiceNoTextBox);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Invoice";
            this.Load += new System.EventHandler(this.frmAddInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lineItemBindingSource;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingSource gLAccountBindingSource;
        private System.Windows.Forms.BindingSource termsBindingSource;
        internal System.Windows.Forms.DataGridView lineItemDataGridView;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal System.Windows.Forms.DataGridViewButtonColumn DeleteLineItemButton;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtInvoiceTotal;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox accountNoComboBox;
        internal System.Windows.Forms.ComboBox termsIDComboBox;
        internal System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        internal System.Windows.Forms.TextBox invoiceNoTextBox;
        internal System.Windows.Forms.TextBox txtVendor;
        internal System.Windows.Forms.Label Label1;
    }
}