using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private List<InvItem> invItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();
            LoadComboBox();
            FillItemListBox();
        }

        private void LoadComboBox()
        {
            cboFilterBy.DataSource = new string[] {
                "All", "Under $10", "$10 to $50", "Over $50"
            };
        }

        private void FillItemListBox()
        { 
            lstItems.Items.Clear();
            
            string filter = cboFilterBy.SelectedValue.ToString();
            IEnumerable<InvItem> filteredItems = null;

            // add items to the filteredItems collection based on FilterBy value
            if (filter == "All")
            {
                filteredItems = invItems.OrderBy(i => i.Description);
            }
            else if (filter == "Under $10")
            {
                filteredItems = invItems.Where(i => i.Price < 10).OrderBy(i => i.Description);
            }
            else if (filter == "$10 to $50")
            {
                filteredItems = invItems.Where(i => i.Price >= 10 && i.Price <= 50).OrderBy(i => i.Description);
            }
            else if (filter == "Over $50")
            {
                filteredItems = invItems.Where(i => i.Price > 50).OrderBy(i => i.Description);
            }
            
            // change code to loop the filteredItems collection
            foreach (InvItem item in filteredItems)
            {
                lstItems.Items.Add(item.DisplayText);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItems.Add(invItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                // InvItem invItem = (InvItem)invItems[i];

                // Add code that uses that selected index value to retrieve the display text
                // of the selected item from the Items collection of the ListView control.
                string displayText = lstItems.Items[i].ToString();
                
                // Identify the item in the invItems collection that has the same display text.
                InvItem itemToRemove = invItems.Where(i => i.DisplayText == displayText).FirstOrDefault();

                // Add code that displays a message box with the item description and asks the user
                // to confirm the delete.
                string message = $"Are you sure you want to delete {itemToRemove.Description}?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                // If the user clicks Yes, remove the item from the invItems collection and save the
                // updated collection to the file.
                if (button == DialogResult.Yes)
                {
                    invItems.Remove(itemToRemove);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillItemListBox();
        }
    }
}
