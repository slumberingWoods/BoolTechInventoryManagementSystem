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
    public partial class Selection : Form
    {
        public string password;
        public string userPassword { get { return password; } set { password = value; } }
        public Selection(String password)
        {
            InitializeComponent();
            password = userPassword;
        }
        private void viewItemButton_Click(object sender, EventArgs e)
        {
            viewItemsForm vI = new viewItemsForm(); 
            vI.ShowDialog();
        }

        private void logButton_Click(object sender, EventArgs e)
        {

        }

        private void financeButton_Click(object sender, EventArgs e)
        {

        }

        private void viewUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
