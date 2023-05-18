using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TermsMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payablesDataSet.Terms' table.
            // You can move, or remove it, as needed.
            this.termsTableAdapter.Fill(this.payablesDataSet.Terms);
        }

        private void termsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.termsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet);
        }

        private void termsDataGridView_DataError(object sender, 
            DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = "A data error occurred.\n" +
                "Row: " + row + "\n" +
                "Error: " + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error");
        }
    }
}
