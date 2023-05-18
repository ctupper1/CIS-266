namespace VendorMaintenance
{
    partial class frmAddModifyVendor
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
            System.Windows.Forms.Label ContactLNameLabel;
            System.Windows.Forms.Label ContactFNameLabel;
            System.Windows.Forms.Label PhoneLabel;
            System.Windows.Forms.Label DescriptionLabel1;
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label ZipCodeLabel;
            System.Windows.Forms.Label StateNameLabel;
            System.Windows.Forms.Label CityLabel;
            System.Windows.Forms.Label Address1Label;
            System.Windows.Forms.Label NameLabel;
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.cboTerms = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ContactLNameLabel = new System.Windows.Forms.Label();
            ContactFNameLabel = new System.Windows.Forms.Label();
            PhoneLabel = new System.Windows.Forms.Label();
            DescriptionLabel1 = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            ZipCodeLabel = new System.Windows.Forms.Label();
            StateNameLabel = new System.Windows.Forms.Label();
            CityLabel = new System.Windows.Forms.Label();
            Address1Label = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactLNameLabel
            // 
            ContactLNameLabel.AutoSize = true;
            ContactLNameLabel.Location = new System.Drawing.Point(6, 74);
            ContactLNameLabel.Name = "ContactLNameLabel";
            ContactLNameLabel.Size = new System.Drawing.Size(59, 13);
            ContactLNameLabel.TabIndex = 4;
            ContactLNameLabel.Text = "Last name:";
            // 
            // ContactFNameLabel
            // 
            ContactFNameLabel.AutoSize = true;
            ContactFNameLabel.Location = new System.Drawing.Point(6, 48);
            ContactFNameLabel.Name = "ContactFNameLabel";
            ContactFNameLabel.Size = new System.Drawing.Size(58, 13);
            ContactFNameLabel.TabIndex = 2;
            ContactFNameLabel.Text = "First name:";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new System.Drawing.Point(6, 22);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new System.Drawing.Size(41, 13);
            PhoneLabel.TabIndex = 0;
            PhoneLabel.Text = "Phone:";
            // 
            // DescriptionLabel1
            // 
            DescriptionLabel1.AutoSize = true;
            DescriptionLabel1.Location = new System.Drawing.Point(6, 49);
            DescriptionLabel1.Name = "DescriptionLabel1";
            DescriptionLabel1.Size = new System.Drawing.Size(50, 13);
            DescriptionLabel1.TabIndex = 2;
            DescriptionLabel1.Text = "Account:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new System.Drawing.Point(6, 22);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(39, 13);
            DescriptionLabel.TabIndex = 0;
            DescriptionLabel.Text = "Terms:";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new System.Drawing.Point(230, 120);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new System.Drawing.Size(52, 13);
            ZipCodeLabel.TabIndex = 25;
            ZipCodeLabel.Text = "Zip code:";
            // 
            // StateNameLabel
            // 
            StateNameLabel.AutoSize = true;
            StateNameLabel.Location = new System.Drawing.Point(14, 120);
            StateNameLabel.Name = "StateNameLabel";
            StateNameLabel.Size = new System.Drawing.Size(35, 13);
            StateNameLabel.TabIndex = 23;
            StateNameLabel.Text = "State:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new System.Drawing.Point(14, 94);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new System.Drawing.Size(27, 13);
            CityLabel.TabIndex = 21;
            CityLabel.Text = "City:";
            // 
            // Address1Label
            // 
            Address1Label.AutoSize = true;
            Address1Label.Location = new System.Drawing.Point(14, 42);
            Address1Label.Name = "Address1Label";
            Address1Label.Size = new System.Drawing.Size(48, 13);
            Address1Label.TabIndex = 17;
            Address1Label.Text = "Address:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(14, 16);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(38, 13);
            NameLabel.TabIndex = 16;
            NameLabel.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(17, 392);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 29;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(ContactLNameLabel);
            this.GroupBox2.Controls.Add(this.txtLastName);
            this.GroupBox2.Controls.Add(ContactFNameLabel);
            this.GroupBox2.Controls.Add(this.txtFirstName);
            this.GroupBox2.Controls.Add(PhoneLabel);
            this.GroupBox2.Controls.Add(this.txtPhone);
            this.GroupBox2.Location = new System.Drawing.Point(17, 268);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(351, 108);
            this.GroupBox2.TabIndex = 28;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Contact information";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(71, 71);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 20);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Tag = "Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(71, 45);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(225, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Tag = "First name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(71, 19);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(140, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Tag = "Phone";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(DescriptionLabel1);
            this.GroupBox1.Controls.Add(this.cboAccounts);
            this.GroupBox1.Controls.Add(DescriptionLabel);
            this.GroupBox1.Controls.Add(this.cboTerms);
            this.GroupBox1.Location = new System.Drawing.Point(17, 163);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(351, 83);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Defaults";
            // 
            // cboAccounts
            // 
            this.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(62, 46);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(180, 21);
            this.cboAccounts.TabIndex = 3;
            this.cboAccounts.Tag = "Account";
            // 
            // cboTerms
            // 
            this.cboTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerms.FormattingEnabled = true;
            this.cboTerms.Location = new System.Drawing.Point(62, 19);
            this.cboTerms.Name = "cboTerms";
            this.cboTerms.Size = new System.Drawing.Size(180, 21);
            this.cboTerms.TabIndex = 1;
            this.cboTerms.Tag = "Terms";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(288, 117);
            this.txtZipCode.MaxLength = 20;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(80, 20);
            this.txtZipCode.TabIndex = 26;
            this.txtZipCode.Tag = "Zip code";
            // 
            // cboStates
            // 
            this.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(68, 117);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(150, 21);
            this.cboStates.TabIndex = 24;
            this.cboStates.Tag = "State";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(68, 91);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(300, 20);
            this.txtCity.TabIndex = 22;
            this.txtCity.Tag = "City";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(68, 65);
            this.txtAddress2.MaxLength = 50;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(300, 20);
            this.txtAddress2.TabIndex = 20;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(68, 39);
            this.txtAddress1.MaxLength = 50;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(300, 20);
            this.txtAddress1.TabIndex = 19;
            this.txtAddress1.Tag = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 13);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 20);
            this.txtName.TabIndex = 18;
            this.txtName.Tag = "Name";
            // 
            // frmAddModifyVendor
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(382, 428);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(ZipCodeLabel);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(StateNameLabel);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(CityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(Address1Label);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(NameLabel);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddModifyVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Modify Vendor";
            this.Load += new System.EventHandler(this.frmAddModifyVendor_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnAccept;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cboAccounts;
        internal System.Windows.Forms.ComboBox cboTerms;
        internal System.Windows.Forms.TextBox txtZipCode;
        internal System.Windows.Forms.ComboBox cboStates;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress2;
        internal System.Windows.Forms.TextBox txtAddress1;
        internal System.Windows.Forms.TextBox txtName;
    }
}