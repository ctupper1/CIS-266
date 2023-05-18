namespace TransferPayment
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetToInvoice = new System.Windows.Forms.Button();
            this.txtToBalanceDue = new System.Windows.Forms.TextBox();
            this.txtToInvoiceTotal = new System.Windows.Forms.TextBox();
            this.txtToInvoiceDate = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtToInvoiceNo = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFromPaymentTotal = new System.Windows.Forms.TextBox();
            this.txtFromInvoiceTotal = new System.Windows.Forms.TextBox();
            this.txtFromInvoiceDate = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnGetFromInvoice = new System.Windows.Forms.Button();
            this.txtFromInvoiceNo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(587, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(232, 185);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(90, 23);
            this.btnTransfer.TabIndex = 10;
            this.btnTransfer.Text = "Make Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(104, 187);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTransferAmount.TabIndex = 9;
            this.txtTransferAmount.Tag = "Transfer Amount";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 190);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 13);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Transfer Amount:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnGetToInvoice);
            this.GroupBox2.Controls.Add(this.txtToBalanceDue);
            this.GroupBox2.Controls.Add(this.txtToInvoiceTotal);
            this.GroupBox2.Controls.Add(this.txtToInvoiceDate);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.txtToInvoiceNo);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Location = new System.Drawing.Point(352, 11);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(310, 148);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Transfer To:";
            // 
            // btnGetToInvoice
            // 
            this.btnGetToInvoice.Location = new System.Drawing.Point(220, 15);
            this.btnGetToInvoice.Name = "btnGetToInvoice";
            this.btnGetToInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnGetToInvoice.TabIndex = 21;
            this.btnGetToInvoice.Text = "Get Invoice";
            this.btnGetToInvoice.UseVisualStyleBackColor = true;
            this.btnGetToInvoice.Click += new System.EventHandler(this.btnGetToInvoice_Click);
            // 
            // txtToBalanceDue
            // 
            this.txtToBalanceDue.Location = new System.Drawing.Point(92, 109);
            this.txtToBalanceDue.Name = "txtToBalanceDue";
            this.txtToBalanceDue.ReadOnly = true;
            this.txtToBalanceDue.Size = new System.Drawing.Size(100, 20);
            this.txtToBalanceDue.TabIndex = 19;
            this.txtToBalanceDue.TabStop = false;
            // 
            // txtToInvoiceTotal
            // 
            this.txtToInvoiceTotal.Location = new System.Drawing.Point(92, 83);
            this.txtToInvoiceTotal.Name = "txtToInvoiceTotal";
            this.txtToInvoiceTotal.ReadOnly = true;
            this.txtToInvoiceTotal.Size = new System.Drawing.Size(100, 20);
            this.txtToInvoiceTotal.TabIndex = 18;
            this.txtToInvoiceTotal.TabStop = false;
            // 
            // txtToInvoiceDate
            // 
            this.txtToInvoiceDate.Location = new System.Drawing.Point(92, 57);
            this.txtToInvoiceDate.Name = "txtToInvoiceDate";
            this.txtToInvoiceDate.ReadOnly = true;
            this.txtToInvoiceDate.Size = new System.Drawing.Size(100, 20);
            this.txtToInvoiceDate.TabIndex = 17;
            this.txtToInvoiceDate.TabStop = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 112);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(72, 13);
            this.Label7.TabIndex = 15;
            this.Label7.Text = "Balance Due:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(5, 86);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 13);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Invoice Total:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 60);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(71, 13);
            this.Label9.TabIndex = 13;
            this.Label9.Text = "Invoice Date:";
            // 
            // txtToInvoiceNo
            // 
            this.txtToInvoiceNo.Location = new System.Drawing.Point(74, 19);
            this.txtToInvoiceNo.Name = "txtToInvoiceNo";
            this.txtToInvoiceNo.Size = new System.Drawing.Size(130, 20);
            this.txtToInvoiceNo.TabIndex = 12;
            this.txtToInvoiceNo.Tag = "To Invoice Number";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 21);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(62, 13);
            this.Label10.TabIndex = 11;
            this.Label10.Text = "Invoice No:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtFromPaymentTotal);
            this.GroupBox1.Controls.Add(this.txtFromInvoiceTotal);
            this.GroupBox1.Controls.Add(this.txtFromInvoiceDate);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnGetFromInvoice);
            this.GroupBox1.Controls.Add(this.txtFromInvoiceNo);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(310, 148);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Transfer From:";
            // 
            // txtFromPaymentTotal
            // 
            this.txtFromPaymentTotal.Location = new System.Drawing.Point(92, 110);
            this.txtFromPaymentTotal.Name = "txtFromPaymentTotal";
            this.txtFromPaymentTotal.ReadOnly = true;
            this.txtFromPaymentTotal.Size = new System.Drawing.Size(100, 20);
            this.txtFromPaymentTotal.TabIndex = 9;
            this.txtFromPaymentTotal.TabStop = false;
            // 
            // txtFromInvoiceTotal
            // 
            this.txtFromInvoiceTotal.Location = new System.Drawing.Point(92, 84);
            this.txtFromInvoiceTotal.Name = "txtFromInvoiceTotal";
            this.txtFromInvoiceTotal.ReadOnly = true;
            this.txtFromInvoiceTotal.Size = new System.Drawing.Size(100, 20);
            this.txtFromInvoiceTotal.TabIndex = 8;
            this.txtFromInvoiceTotal.TabStop = false;
            // 
            // txtFromInvoiceDate
            // 
            this.txtFromInvoiceDate.Location = new System.Drawing.Point(92, 58);
            this.txtFromInvoiceDate.Name = "txtFromInvoiceDate";
            this.txtFromInvoiceDate.ReadOnly = true;
            this.txtFromInvoiceDate.Size = new System.Drawing.Size(100, 20);
            this.txtFromInvoiceDate.TabIndex = 7;
            this.txtFromInvoiceDate.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 113);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Payment Total:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 87);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Invoice Total:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Invoice Date:";
            // 
            // btnGetFromInvoice
            // 
            this.btnGetFromInvoice.Location = new System.Drawing.Point(220, 17);
            this.btnGetFromInvoice.Name = "btnGetFromInvoice";
            this.btnGetFromInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnGetFromInvoice.TabIndex = 2;
            this.btnGetFromInvoice.Text = "Get Invoice";
            this.btnGetFromInvoice.UseVisualStyleBackColor = true;
            this.btnGetFromInvoice.Click += new System.EventHandler(this.btnGetFromInvoice_Click);
            // 
            // txtFromInvoiceNo
            // 
            this.txtFromInvoiceNo.Location = new System.Drawing.Point(74, 20);
            this.txtFromInvoiceNo.Name = "txtFromInvoiceNo";
            this.txtFromInvoiceNo.Size = new System.Drawing.Size(130, 20);
            this.txtFromInvoiceNo.TabIndex = 1;
            this.txtFromInvoiceNo.Tag = "From Invoice Number";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Invoice No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(675, 219);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Payment";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnTransfer;
        internal System.Windows.Forms.TextBox txtTransferAmount;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnGetToInvoice;
        internal System.Windows.Forms.TextBox txtToBalanceDue;
        internal System.Windows.Forms.TextBox txtToInvoiceTotal;
        internal System.Windows.Forms.TextBox txtToInvoiceDate;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtToInvoiceNo;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtFromPaymentTotal;
        internal System.Windows.Forms.TextBox txtFromInvoiceTotal;
        internal System.Windows.Forms.TextBox txtFromInvoiceDate;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnGetFromInvoice;
        internal System.Windows.Forms.TextBox txtFromInvoiceNo;
        internal System.Windows.Forms.Label Label1;
    }
}

