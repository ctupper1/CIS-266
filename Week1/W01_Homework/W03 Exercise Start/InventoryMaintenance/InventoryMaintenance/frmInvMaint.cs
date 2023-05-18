using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
	{

		public frmInvMaint()
		{
			InitializeComponent();
		}

        // Add a statement here that declares the list of items.
		private List<InvItem> invItems = null;

		private void frmInvMaint_Load(object sender, EventArgs e)
		{
			invItems = InvItemDB.GetItems();
            // Add a statement here that gets the list of items.
			FillItemListBox();
		}

		private void FillItemListBox()
		{
			lstItems.Items.Clear();
			foreach (InvItem item in invItems) { lstItems.Items.Add(item.GetDisplayText("\t"));}
            // Add code here that loads the list box with the items in the list.
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            // Add code here that creates an instance of the New Item form
            // and then gets a new item from that form.
			frmNewItem frmNewItem = new frmNewItem();
			InvItem item = frmNewItem.GetNewItem();

			if (item != null)
			{
                invItems.Add(item);
                // Add code here that adds the new item to the list,
                // saves the list of products, and refreshes the list box.
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int i = lstItems.SelectedIndex;
			if (i != -1)
			{
                DialogResult dialogResult = MessageBox.Show("Do you want to delete " + invItems[i].Description + "?", "Confirm Delete", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
				{
                    invItems.RemoveAt(i);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
				// Add code here that displays a dialog box to confirm
                // the deletion and then removes the item from the list,
                // saves the list of products, and refreshes the list box
                // if the deletion is confirmed.
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}