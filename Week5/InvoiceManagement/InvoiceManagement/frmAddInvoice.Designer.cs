namespace InvoiceManagement
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
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label termsIDLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label accountNoLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label amountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInvoice));
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payablesDataSet = new InvoiceManagement.PayablesDataSet();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.termsIDComboBox = new System.Windows.Forms.ComboBox();
            this.termsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dueDaysTextBox = new System.Windows.Forms.TextBox();
            this.accountNoComboBox = new System.Windows.Forms.ComboBox();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.invoiceLineItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.getDataByVendorIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.vendorIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.vendorIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByVendorIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vendorNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.vendorNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByVendorNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vendorsTableAdapter = new InvoiceManagement.PayablesDataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new InvoiceManagement.PayablesDataSetTableAdapters.TableAdapterManager();
            this.invoiceLineItemsTableAdapter = new InvoiceManagement.PayablesDataSetTableAdapters.InvoiceLineItemsTableAdapter();
            this.invoicesTableAdapter = new InvoiceManagement.PayablesDataSetTableAdapters.InvoicesTableAdapter();
            this.gLAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gLAccountsTableAdapter = new InvoiceManagement.PayablesDataSetTableAdapters.GLAccountsTableAdapter();
            this.termsTableAdapter = new InvoiceManagement.PayablesDataSetTableAdapters.TermsTableAdapter();
            vendorIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            termsIDLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            accountNoLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).BeginInit();
            this.getDataByVendorIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(17, 91);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(86, 20);
            vendorIDLabel.TabIndex = 1;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 123);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(17, 155);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(72, 20);
            address1Label.TabIndex = 5;
            address1Label.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(17, 219);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(116, 20);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City, State, Zip:";
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(17, 287);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(123, 20);
            invoiceNumberLabel.TabIndex = 14;
            invoiceNumberLabel.Text = "Invoice Number:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(17, 321);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(102, 20);
            invoiceDateLabel.TabIndex = 15;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // termsIDLabel
            // 
            termsIDLabel.AutoSize = true;
            termsIDLabel.Location = new System.Drawing.Point(17, 351);
            termsIDLabel.Name = "termsIDLabel";
            termsIDLabel.Size = new System.Drawing.Size(57, 20);
            termsIDLabel.TabIndex = 16;
            termsIDLabel.Text = "Terms:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(17, 385);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(83, 20);
            dueDateLabel.TabIndex = 18;
            dueDateLabel.Text = "Due Days:";
            // 
            // accountNoLabel
            // 
            accountNoLabel.AutoSize = true;
            accountNoLabel.Location = new System.Drawing.Point(40, 445);
            accountNoLabel.Name = "accountNoLabel";
            accountNoLabel.Size = new System.Drawing.Size(96, 20);
            accountNoLabel.TabIndex = 20;
            accountNoLabel.Text = "Account No:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(356, 445);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(736, 445);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(69, 20);
            amountLabel.TabIndex = 24;
            amountLabel.Text = "Amount:";
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.payablesDataSet;
            // 
            // payablesDataSet
            // 
            this.payablesDataSet.DataSetName = "PayablesDataSet";
            this.payablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorID", true));
            this.vendorIDTextBox.Location = new System.Drawing.Point(159, 88);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.ReadOnly = true;
            this.vendorIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.vendorIDTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(159, 120);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(550, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(159, 152);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.ReadOnly = true;
            this.address1TextBox.Size = new System.Drawing.Size(550, 26);
            this.address1TextBox.TabIndex = 6;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(159, 184);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.ReadOnly = true;
            this.address2TextBox.Size = new System.Drawing.Size(550, 26);
            this.address2TextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(159, 216);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(253, 26);
            this.cityTextBox.TabIndex = 10;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(418, 216);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(100, 26);
            this.stateTextBox.TabIndex = 12;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(524, 216);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(185, 26);
            this.zipCodeTextBox.TabIndex = 14;
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceNumber", true));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(159, 284);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(200, 26);
            this.invoiceNumberTextBox.TabIndex = 15;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.payablesDataSet;
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(159, 316);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.ShowCheckBox = true;
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.invoiceDateDateTimePicker.TabIndex = 16;
            this.invoiceDateDateTimePicker.ValueChanged += new System.EventHandler(this.invoiceDateDateTimePicker_ValueChanged);
            // 
            // termsIDComboBox
            // 
            this.termsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "TermsID", true));
            this.termsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.termsBindingSource, "TermsID", true));
            this.termsIDComboBox.DataSource = this.termsBindingSource;
            this.termsIDComboBox.DisplayMember = "Description";
            this.termsIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termsIDComboBox.FormattingEnabled = true;
            this.termsIDComboBox.Location = new System.Drawing.Point(159, 348);
            this.termsIDComboBox.Name = "termsIDComboBox";
            this.termsIDComboBox.Size = new System.Drawing.Size(200, 28);
            this.termsIDComboBox.TabIndex = 17;
            this.termsIDComboBox.ValueMember = "TermsID";
            this.termsIDComboBox.SelectedIndexChanged += new System.EventHandler(this.termsIDComboBox_SelectedIndexChanged);
            // 
            // termsBindingSource
            // 
            this.termsBindingSource.DataMember = "Terms";
            this.termsBindingSource.DataSource = this.payablesDataSet;
            // 
            // dueDaysTextBox
            // 
            this.dueDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "DueDate", true));
            this.dueDaysTextBox.Location = new System.Drawing.Point(159, 382);
            this.dueDaysTextBox.Name = "dueDaysTextBox";
            this.dueDaysTextBox.ReadOnly = true;
            this.dueDaysTextBox.Size = new System.Drawing.Size(200, 26);
            this.dueDaysTextBox.TabIndex = 19;
            // 
            // accountNoComboBox
            // 
            this.accountNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceLineItemsBindingSource, "AccountNo", true));
            this.accountNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNoComboBox.FormattingEnabled = true;
            this.accountNoComboBox.Location = new System.Drawing.Point(159, 442);
            this.accountNoComboBox.Name = "accountNoComboBox";
            this.accountNoComboBox.Size = new System.Drawing.Size(170, 28);
            this.accountNoComboBox.TabIndex = 21;
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "InvoiceLineItems";
            this.invoiceLineItemsBindingSource.DataSource = this.payablesDataSet;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceLineItemsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(455, 442);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(254, 26);
            this.descriptionTextBox.TabIndex = 23;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceLineItemsBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(811, 442);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 26);
            this.amountTextBox.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(950, 442);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 26);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // invoiceLineItemsDataGridView
            // 
            this.invoiceLineItemsDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.invoiceLineItemsDataGridView.DataSource = this.invoiceLineItemsBindingSource;
            this.invoiceLineItemsDataGridView.Location = new System.Drawing.Point(44, 508);
            this.invoiceLineItemsDataGridView.Name = "invoiceLineItemsDataGridView";
            this.invoiceLineItemsDataGridView.RowHeadersWidth = 62;
            this.invoiceLineItemsDataGridView.RowTemplate.Height = 28;
            this.invoiceLineItemsDataGridView.Size = new System.Drawing.Size(991, 136);
            this.invoiceLineItemsDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InvoiceSequence";
            this.dataGridViewTextBoxColumn2.HeaderText = "InvoiceSequence";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "AccountNo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(697, 702);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(166, 43);
            this.btnAccept.TabIndex = 28;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(869, 702);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 43);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.AutoSize = true;
            this.lblInvoiceTotal.Location = new System.Drawing.Point(761, 662);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(102, 20);
            this.lblInvoiceTotal.TabIndex = 30;
            this.lblInvoiceTotal.Text = "Invoice Total:";
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(869, 659);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.Size = new System.Drawing.Size(166, 26);
            this.txtInvoiceTotal.TabIndex = 31;
            // 
            // getDataByVendorIDToolStrip
            // 
            this.getDataByVendorIDToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.getDataByVendorIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorIDToolStripLabel,
            this.vendorIDToolStripTextBox,
            this.fillByVendorIDToolStripButton,
            this.vendorNameToolStripLabel,
            this.vendorNameToolStripTextBox,
            this.fillByVendorNameToolStripButton});
            this.getDataByVendorIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.getDataByVendorIDToolStrip.Name = "getDataByVendorIDToolStrip";
            this.getDataByVendorIDToolStrip.Size = new System.Drawing.Size(1063, 38);
            this.getDataByVendorIDToolStrip.TabIndex = 32;
            this.getDataByVendorIDToolStrip.Text = "getDataByVendorIDToolStrip";
            // 
            // vendorIDToolStripLabel
            // 
            this.vendorIDToolStripLabel.Name = "vendorIDToolStripLabel";
            this.vendorIDToolStripLabel.Size = new System.Drawing.Size(96, 29);
            this.vendorIDToolStripLabel.Text = "Vendor ID:";
            // 
            // vendorIDToolStripTextBox
            // 
            this.vendorIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vendorIDToolStripTextBox.Name = "vendorIDToolStripTextBox";
            this.vendorIDToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByVendorIDToolStripButton
            // 
            this.fillByVendorIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByVendorIDToolStripButton.Margin = new System.Windows.Forms.Padding(10, 2, 0, 3);
            this.fillByVendorIDToolStripButton.Name = "fillByVendorIDToolStripButton";
            this.fillByVendorIDToolStripButton.Size = new System.Drawing.Size(50, 29);
            this.fillByVendorIDToolStripButton.Text = "Find";
            this.fillByVendorIDToolStripButton.Click += new System.EventHandler(this.fillByVendorIDToolStripButton_Click);
            // 
            // vendorNameToolStripLabel
            // 
            this.vendorNameToolStripLabel.Margin = new System.Windows.Forms.Padding(50, 2, 0, 3);
            this.vendorNameToolStripLabel.Name = "vendorNameToolStripLabel";
            this.vendorNameToolStripLabel.Size = new System.Drawing.Size(63, 29);
            this.vendorNameToolStripLabel.Text = "Name:";
            // 
            // vendorNameToolStripTextBox
            // 
            this.vendorNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vendorNameToolStripTextBox.Name = "vendorNameToolStripTextBox";
            this.vendorNameToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByVendorNameToolStripButton
            // 
            this.fillByVendorNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByVendorNameToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillByVendorNameToolStripButton.Image")));
            this.fillByVendorNameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillByVendorNameToolStripButton.Margin = new System.Windows.Forms.Padding(10, 2, 0, 3);
            this.fillByVendorNameToolStripButton.Name = "fillByVendorNameToolStripButton";
            this.fillByVendorNameToolStripButton.Size = new System.Drawing.Size(50, 33);
            this.fillByVendorNameToolStripButton.Text = "Find";
            this.fillByVendorNameToolStripButton.Click += new System.EventHandler(this.fillByVendorNameToolStripButton_Click);
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GLAccountsTableAdapter = null;
            this.tableAdapterManager.InvoiceLineItemsTableAdapter = this.invoiceLineItemsTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.TermsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InvoiceManagement.PayablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoiceLineItemsTableAdapter
            // 
            this.invoiceLineItemsTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // gLAccountsBindingSource
            // 
            this.gLAccountsBindingSource.DataMember = "GLAccounts";
            this.gLAccountsBindingSource.DataSource = this.payablesDataSet;
            // 
            // gLAccountsTableAdapter
            // 
            this.gLAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // termsTableAdapter
            // 
            this.termsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 765);
            this.Controls.Add(this.getDataByVendorIDToolStrip);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.lblInvoiceTotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.invoiceLineItemsDataGridView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(accountNoLabel);
            this.Controls.Add(this.accountNoComboBox);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDaysTextBox);
            this.Controls.Add(termsIDLabel);
            this.Controls.Add(this.termsIDComboBox);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(invoiceNumberLabel);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Name = "frmAddInvoice";
            this.Text = "Add Invoice";
            this.Load += new System.EventHandler(this.frmAddInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).EndInit();
            this.getDataByVendorIDToolStrip.ResumeLayout(false);
            this.getDataByVendorIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PayablesDataSet payablesDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private PayablesDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private PayablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private PayablesDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.ComboBox termsIDComboBox;
        private System.Windows.Forms.TextBox dueDaysTextBox;
        private PayablesDataSetTableAdapters.InvoiceLineItemsTableAdapter invoiceLineItemsTableAdapter;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private System.Windows.Forms.ComboBox accountNoComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView invoiceLineItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.ToolStrip getDataByVendorIDToolStrip;
        private System.Windows.Forms.ToolStripLabel vendorIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox vendorIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByVendorIDToolStripButton;
        private System.Windows.Forms.ToolStripLabel vendorNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox vendorNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByVendorNameToolStripButton;
        private System.Windows.Forms.BindingSource gLAccountsBindingSource;
        private PayablesDataSetTableAdapters.GLAccountsTableAdapter gLAccountsTableAdapter;
        private System.Windows.Forms.BindingSource termsBindingSource;
        private PayablesDataSetTableAdapters.TermsTableAdapter termsTableAdapter;
    }
}

