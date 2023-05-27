namespace InvoiceEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.payablesDataSet = new InvoiceEntry.PayablesDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new InvoiceEntry.PayablesDataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new InvoiceEntry.PayablesDataSetTableAdapters.TableAdapterManager();
            this.invoiceLineItemsTableAdapter = new InvoiceEntry.PayablesDataSetTableAdapters.InvoiceLineItemsTableAdapter();
            this.invoicesTableAdapter = new InvoiceEntry.PayablesDataSetTableAdapters.InvoicesTableAdapter();
            this.fillByVendorIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.vendorIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.vendorIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByVendorIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.termsIDComboBox = new System.Windows.Forms.ComboBox();
            this.termsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dueDateTextBox = new System.Windows.Forms.TextBox();
            this.termsTableAdapter = new InvoiceEntry.PayablesDataSetTableAdapters.TermsTableAdapter();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountNoComboBox = new System.Windows.Forms.ComboBox();
            this.gLAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gLAccountsTableAdapter = new InvoiceEntry.PayablesDataSetTableAdapters.GLAccountsTableAdapter();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.invoiceLineItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceSequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteLineItemButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.InvoiceTotalTextBox = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.fillByVendorIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(24, 72);
            vendorIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(86, 20);
            vendorIDLabel.TabIndex = 2;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(24, 112);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(24, 152);
            address1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(72, 20);
            address1Label.TabIndex = 6;
            address1Label.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(24, 232);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(116, 20);
            cityLabel.TabIndex = 10;
            cityLabel.Text = "City, State, Zip:";
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(24, 318);
            invoiceNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(123, 20);
            invoiceNumberLabel.TabIndex = 15;
            invoiceNumberLabel.Text = "Invoice Number:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(24, 360);
            invoiceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(102, 20);
            invoiceDateLabel.TabIndex = 16;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // termsIDLabel
            // 
            termsIDLabel.AutoSize = true;
            termsIDLabel.Location = new System.Drawing.Point(24, 398);
            termsIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            termsIDLabel.Name = "termsIDLabel";
            termsIDLabel.Size = new System.Drawing.Size(78, 20);
            termsIDLabel.TabIndex = 17;
            termsIDLabel.Text = "Terms ID:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(24, 440);
            dueDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(82, 20);
            dueDateLabel.TabIndex = 18;
            dueDateLabel.Text = "Due Date:";
            // 
            // accountNoLabel
            // 
            accountNoLabel.AutoSize = true;
            accountNoLabel.Location = new System.Drawing.Point(24, 526);
            accountNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accountNoLabel.Name = "accountNoLabel";
            accountNoLabel.Size = new System.Drawing.Size(72, 20);
            accountNoLabel.TabIndex = 20;
            accountNoLabel.Text = "Account:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(386, 526);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(808, 526);
            amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(69, 20);
            amountLabel.TabIndex = 24;
            amountLabel.Text = "Amount:";
            // 
            // payablesDataSet
            // 
            this.payablesDataSet.DataSetName = "PayablesDataSet";
            this.payablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.payablesDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceLineItemsTableAdapter = this.invoiceLineItemsTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = InvoiceEntry.PayablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoiceLineItemsTableAdapter
            // 
            this.invoiceLineItemsTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // fillByVendorIDToolStrip
            // 
            this.fillByVendorIDToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByVendorIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorIDToolStripLabel,
            this.vendorIDToolStripTextBox,
            this.fillByVendorIDToolStripButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.nameToolStripTextBox,
            this.fillByNameToolStripButton});
            this.fillByVendorIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByVendorIDToolStrip.Name = "fillByVendorIDToolStrip";
            this.fillByVendorIDToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.fillByVendorIDToolStrip.Size = new System.Drawing.Size(1124, 34);
            this.fillByVendorIDToolStrip.TabIndex = 1;
            this.fillByVendorIDToolStrip.Text = "fillByVendorIDToolStrip";
            // 
            // vendorIDToolStripLabel
            // 
            this.vendorIDToolStripLabel.Name = "vendorIDToolStripLabel";
            this.vendorIDToolStripLabel.Size = new System.Drawing.Size(91, 29);
            this.vendorIDToolStripLabel.Text = "VendorID:";
            // 
            // vendorIDToolStripTextBox
            // 
            this.vendorIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vendorIDToolStripTextBox.Name = "vendorIDToolStripTextBox";
            this.vendorIDToolStripTextBox.Size = new System.Drawing.Size(73, 34);
            // 
            // fillByVendorIDToolStripButton
            // 
            this.fillByVendorIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByVendorIDToolStripButton.Name = "fillByVendorIDToolStripButton";
            this.fillByVendorIDToolStripButton.Size = new System.Drawing.Size(50, 29);
            this.fillByVendorIDToolStripButton.Text = "Find";
            this.fillByVendorIDToolStripButton.Click += new System.EventHandler(this.fillByVendorIDToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 29);
            this.toolStripLabel1.Text = "Name:";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(148, 34);
            // 
            // fillByNameToolStripButton
            // 
            this.fillByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNameToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillByNameToolStripButton.Image")));
            this.fillByNameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillByNameToolStripButton.Name = "fillByNameToolStripButton";
            this.fillByNameToolStripButton.Size = new System.Drawing.Size(50, 29);
            this.fillByNameToolStripButton.Text = "Find";
            this.fillByNameToolStripButton.Click += new System.EventHandler(this.fillByNameToolStripButton_Click);
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "VendorID", true));
            this.vendorIDTextBox.Location = new System.Drawing.Point(152, 68);
            this.vendorIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.ReadOnly = true;
            this.vendorIDTextBox.Size = new System.Drawing.Size(73, 26);
            this.vendorIDTextBox.TabIndex = 3;
            this.vendorIDTextBox.TabStop = false;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.payablesDataSet;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(152, 108);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(484, 26);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TabStop = false;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(152, 148);
            this.address1TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.ReadOnly = true;
            this.address1TextBox.Size = new System.Drawing.Size(484, 26);
            this.address1TextBox.TabIndex = 7;
            this.address1TextBox.TabStop = false;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(152, 188);
            this.address2TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.ReadOnly = true;
            this.address2TextBox.Size = new System.Drawing.Size(484, 26);
            this.address2TextBox.TabIndex = 9;
            this.address2TextBox.TabStop = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(152, 228);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(258, 26);
            this.cityTextBox.TabIndex = 11;
            this.cityTextBox.TabStop = false;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(420, 228);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(56, 26);
            this.stateTextBox.TabIndex = 13;
            this.stateTextBox.TabStop = false;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(488, 228);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(148, 26);
            this.zipCodeTextBox.TabIndex = 15;
            this.zipCodeTextBox.TabStop = false;
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceNumber", true));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(160, 314);
            this.invoiceNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.invoiceNumberTextBox.TabIndex = 16;
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(160, 354);
            this.invoiceDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.ShowCheckBox = true;
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(148, 26);
            this.invoiceDateDateTimePicker.TabIndex = 17;
            this.invoiceDateDateTimePicker.ValueChanged += new System.EventHandler(this.invoiceDateDateTimePicker_ValueChanged);
            // 
            // termsIDComboBox
            // 
            this.termsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.termsBindingSource, "TermsID", true));
            this.termsIDComboBox.DataSource = this.termsBindingSource;
            this.termsIDComboBox.DisplayMember = "Description";
            this.termsIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termsIDComboBox.FormattingEnabled = true;
            this.termsIDComboBox.Location = new System.Drawing.Point(160, 394);
            this.termsIDComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.termsIDComboBox.Name = "termsIDComboBox";
            this.termsIDComboBox.Size = new System.Drawing.Size(206, 28);
            this.termsIDComboBox.TabIndex = 18;
            this.termsIDComboBox.ValueMember = "TermsID";
            this.termsIDComboBox.SelectedIndexChanged += new System.EventHandler(this.termsIDComboBox_SelectedIndexChanged);
            // 
            // termsBindingSource
            // 
            this.termsBindingSource.DataMember = "Terms";
            this.termsBindingSource.DataSource = this.payablesDataSet;
            // 
            // dueDateTextBox
            // 
            this.dueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "DueDate", true));
            this.dueDateTextBox.Location = new System.Drawing.Point(160, 435);
            this.dueDateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.ReadOnly = true;
            this.dueDateTextBox.Size = new System.Drawing.Size(148, 26);
            this.dueDateTextBox.TabIndex = 19;
            this.dueDateTextBox.TabStop = false;
            // 
            // termsTableAdapter
            // 
            this.termsTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "InvoiceLineItems";
            this.invoiceLineItemsBindingSource.DataSource = this.payablesDataSet;
            // 
            // accountNoComboBox
            // 
            this.accountNoComboBox.DataSource = this.gLAccountsBindingSource;
            this.accountNoComboBox.DisplayMember = "Description";
            this.accountNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNoComboBox.FormattingEnabled = true;
            this.accountNoComboBox.Location = new System.Drawing.Point(108, 522);
            this.accountNoComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountNoComboBox.Name = "accountNoComboBox";
            this.accountNoComboBox.Size = new System.Drawing.Size(259, 28);
            this.accountNoComboBox.TabIndex = 21;
            this.accountNoComboBox.ValueMember = "AccountNo";
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
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(489, 522);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(298, 26);
            this.descriptionTextBox.TabIndex = 23;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(886, 522);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(110, 26);
            this.amountTextBox.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1008, 518);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 35);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // invoiceLineItemsDataGridView
            // 
            this.invoiceLineItemsDataGridView.AllowUserToAddRows = false;
            this.invoiceLineItemsDataGridView.AllowUserToDeleteRows = false;
            this.invoiceLineItemsDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.invoiceSequenceDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.accountDescriptionDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.DeleteLineItemButton});
            this.invoiceLineItemsDataGridView.DataSource = this.invoiceLineItemsBindingSource;
            this.invoiceLineItemsDataGridView.Location = new System.Drawing.Point(0, 577);
            this.invoiceLineItemsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceLineItemsDataGridView.Name = "invoiceLineItemsDataGridView";
            this.invoiceLineItemsDataGridView.ReadOnly = true;
            this.invoiceLineItemsDataGridView.RowHeadersWidth = 62;
            this.invoiceLineItemsDataGridView.Size = new System.Drawing.Size(1072, 242);
            this.invoiceLineItemsDataGridView.TabIndex = 27;
            this.invoiceLineItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceLineItemsDataGridView_CellContentClick);
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceIDDataGridViewTextBoxColumn.Visible = false;
            this.invoiceIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceSequenceDataGridViewTextBoxColumn
            // 
            this.invoiceSequenceDataGridViewTextBoxColumn.DataPropertyName = "InvoiceSequence";
            this.invoiceSequenceDataGridViewTextBoxColumn.HeaderText = "InvoiceSequence";
            this.invoiceSequenceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceSequenceDataGridViewTextBoxColumn.Name = "invoiceSequenceDataGridViewTextBoxColumn";
            this.invoiceSequenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceSequenceDataGridViewTextBoxColumn.Visible = false;
            this.invoiceSequenceDataGridViewTextBoxColumn.Width = 150;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "Account No";
            this.accountNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNoDataGridViewTextBoxColumn.Width = 90;
            // 
            // accountDescriptionDataGridViewTextBoxColumn
            // 
            this.accountDescriptionDataGridViewTextBoxColumn.DataPropertyName = "AccountDescription";
            this.accountDescriptionDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accountDescriptionDataGridViewTextBoxColumn.Name = "accountDescriptionDataGridViewTextBoxColumn";
            this.accountDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 240;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 75;
            // 
            // DeleteLineItemButton
            // 
            this.DeleteLineItemButton.HeaderText = "";
            this.DeleteLineItemButton.MinimumWidth = 8;
            this.DeleteLineItemButton.Name = "DeleteLineItemButton";
            this.DeleteLineItemButton.ReadOnly = true;
            this.DeleteLineItemButton.Text = "Delete";
            this.DeleteLineItemButton.UseColumnTextForButtonValue = true;
            this.DeleteLineItemButton.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 834);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Invoice Total:";
            // 
            // InvoiceTotalTextBox
            // 
            this.InvoiceTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceTotal", true));
            this.InvoiceTotalTextBox.Location = new System.Drawing.Point(813, 829);
            this.InvoiceTotalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InvoiceTotalTextBox.Name = "InvoiceTotalTextBox";
            this.InvoiceTotalTextBox.ReadOnly = true;
            this.InvoiceTotalTextBox.Size = new System.Drawing.Size(110, 26);
            this.InvoiceTotalTextBox.TabIndex = 29;
            this.InvoiceTotalTextBox.TabStop = false;
            this.InvoiceTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(806, 888);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(142, 35);
            this.btnAccept.TabIndex = 30;
            this.btnAccept.Text = "Accept Invoice";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(957, 888);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 35);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel Invoice";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InvoiceID";
            this.Column1.HeaderText = "InvoiceID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 150;
            // 
            // frmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1124, 945);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.InvoiceTotalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoiceLineItemsDataGridView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(accountNoLabel);
            this.Controls.Add(this.accountNoComboBox);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDateTextBox);
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
            this.Controls.Add(this.fillByVendorIDToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddInvoice_FormClosing);
            this.Load += new System.EventHandler(this.frmAddInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.fillByVendorIDToolStrip.ResumeLayout(false);
            this.fillByVendorIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PayablesDataSet payablesDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private InvoiceEntry.PayablesDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private InvoiceEntry.PayablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByVendorIDToolStrip;
        private System.Windows.Forms.ToolStripLabel vendorIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox vendorIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByVendorIDToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private InvoiceEntry.PayablesDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.ToolStripButton fillByNameToolStripButton;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.ComboBox termsIDComboBox;
        private System.Windows.Forms.TextBox dueDateTextBox;
        private System.Windows.Forms.BindingSource termsBindingSource;
        private InvoiceEntry.PayablesDataSetTableAdapters.TermsTableAdapter termsTableAdapter;
        private InvoiceEntry.PayablesDataSetTableAdapters.InvoiceLineItemsTableAdapter invoiceLineItemsTableAdapter;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private System.Windows.Forms.ComboBox accountNoComboBox;
        private System.Windows.Forms.BindingSource gLAccountsBindingSource;
        private InvoiceEntry.PayablesDataSetTableAdapters.GLAccountsTableAdapter gLAccountsTableAdapter;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView invoiceLineItemsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InvoiceTotalTextBox;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceSequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteLineItemButton;
    }
}

