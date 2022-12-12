using BoolTechInventoryManagementSystem.SystemDataSetTableAdapters;
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

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUserForm auF = new addUserForm();
            auF.FormClosed += delegate
            {
                userTableAdapter.Fill(this.systemDataSet.User);
            };
            auF.ShowDialog();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            modifyUserForm muF = new modifyUserForm();
            muF.FormClosed += delegate
            {
                userTableAdapter.Fill(this.systemDataSet.User);
            };
            muF.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteUserForm duF = new deleteUserForm();
            duF.FormClosed += delegate
            {
                userTableAdapter.Fill(this.systemDataSet.User);
            };
            duF.ShowDialog();
        }

        private void adminForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
