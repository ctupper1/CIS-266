namespace VendorsInformation
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
            this.btnXmlAndSchema = new System.Windows.Forms.Button();
            this.btnSchema = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXmlAndSchema
            // 
            this.btnXmlAndSchema.Location = new System.Drawing.Point(55, 152);
            this.btnXmlAndSchema.Margin = new System.Windows.Forms.Padding(2);
            this.btnXmlAndSchema.Name = "btnXmlAndSchema";
            this.btnXmlAndSchema.Size = new System.Drawing.Size(138, 47);
            this.btnXmlAndSchema.TabIndex = 8;
            this.btnXmlAndSchema.Text = "XML + Schema";
            this.btnXmlAndSchema.UseVisualStyleBackColor = true;
            this.btnXmlAndSchema.Click += new System.EventHandler(this.btnXmlAndSchema_Click);
            // 
            // btnSchema
            // 
            this.btnSchema.Location = new System.Drawing.Point(55, 88);
            this.btnSchema.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchema.Name = "btnSchema";
            this.btnSchema.Size = new System.Drawing.Size(138, 47);
            this.btnSchema.TabIndex = 7;
            this.btnSchema.Text = "Write Schema Only";
            this.btnSchema.UseVisualStyleBackColor = true;
            this.btnSchema.Click += new System.EventHandler(this.btnSchema_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(55, 26);
            this.btnXML.Margin = new System.Windows.Forms.Padding(2);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(138, 47);
            this.btnXML.TabIndex = 6;
            this.btnXML.Text = "Write XML Only";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 255);
            this.Controls.Add(this.btnXmlAndSchema);
            this.Controls.Add(this.btnSchema);
            this.Controls.Add(this.btnXML);
            this.Name = "Form1";
            this.Text = "Vendors Information";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnXmlAndSchema;
        internal System.Windows.Forms.Button btnSchema;
        internal System.Windows.Forms.Button btnXML;
    }
}

