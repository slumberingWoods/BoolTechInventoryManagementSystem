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
    public partial class userViewForm : Form
    {
        private string userName { get; set; }
        private string pwd { get; set; }
        private int id { get; set; }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        public userViewForm(int id, string uiUsername, string uiPassword)
        {
            InitializeComponent();
            this.id = id;
            this.userName = uiUsername;
            this.pwd = uiPassword;
        }

        private void userViewForm_Load(object sender, EventArgs e)
        {
            displayUserLabel.Text = userName;
        }

        private void lightButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            darkButton.ForeColor = Color.Black;
            lightButton.ForeColor = Color.Black;
            currentUserLable.BackColor = Color.WhiteSmoke;
            currentUserLable.ForeColor = Color.Black;
            displayUserLabel.BackColor = Color.WhiteSmoke;
            displayUserLabel.ForeColor = Color.Black;
            
        }

        private void darkButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            darkButton.ForeColor = Color.White;
            lightButton.ForeColor = Color.White;
            currentUserLable.BackColor = Color.DimGray;
            currentUserLable.ForeColor = Color.White;
            displayUserLabel.BackColor = Color.DimGray;
            displayUserLabel.ForeColor = Color.White;
        }

        private void changeUser_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            changeUsernameForm cUF = new changeUsernameForm(id, userName); 
            cUF.FormClosed += delegate
            {
                userName = cUF.returnUsername();
                displayUserLabel.Text = userName;
            };
            cUF.ShowDialog();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            changePasswordForm cPF = new changePasswordForm(id, pwd);
            cPF.FormClosed += delegate
            {
                pwd = cPF.returnpassword();
            };
            cPF.ShowDialog();
        }
    }
}
