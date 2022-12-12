using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolTechInventoryManagementSystem
{
    public partial class Selection : Form
    {
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        private string userName { get; set; }
        private string pwd { get; set; }
        private int id { get; set; }

        public Selection(int id, string uiUserName, string uiPassword)
        {
            InitializeComponent();
            this.id = id;
            this.userName = uiUserName;
            this.pwd = uiPassword;
        }

        public string password;
        public string userPassword { get { return password; } set { password = value; } }
        private void viewItemButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            viewItemsForm vI = new viewItemsForm(); 
            vI.ShowDialog();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            SalesLog sl = new SalesLog();
            sl.ShowDialog();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            FinancialsForm ff = new FinancialsForm();
            ff.ShowDialog();
        }

        private void viewUserButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            userViewForm uvF = new userViewForm(id, userName, pwd);
            uvF.ShowDialog();
        }

        private void Selection_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
