using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolTechInventoryManagementSystem
{
    public partial class viewItemsForm : Form
    {
        public viewItemsForm()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemDataSet);

        }

        private void viewItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.systemDataSet.Items);

        }

        private void addButtton_Click(object sender, EventArgs e)
        {
            addItemForm aIF = new addItemForm();
            aIF.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
