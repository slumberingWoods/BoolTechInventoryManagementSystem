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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemDataSet);

        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.systemDataSet.User);

        }
    }
}
