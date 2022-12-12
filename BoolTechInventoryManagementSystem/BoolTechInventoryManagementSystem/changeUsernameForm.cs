using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Media;

namespace BoolTechInventoryManagementSystem
{
    public partial class changeUsernameForm : Form
    {
        private string userName { get; set; }
        private int id { get; set; }
        public changeUsernameForm(int id, string uiUsername)
        {
            InitializeComponent();
            this.id = id;
            this.userName = uiUsername;
            nametextBox.Text = uiUsername;
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        private void changebutton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            string newName = newNametextBox.Text;
            string password = passwordtextBox.Text;
            string password2 = passwordtextBox2.Text;
            if (password.Equals(password2))
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"UPDATE [User] SET Username = '{newName}' WHERE id = '{id}'";
                    cmd.Connection = con;
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    SystemDataSetTableAdapters.UserTableAdapter userTableAdapter = new SystemDataSetTableAdapters.UserTableAdapter();
                    userTableAdapter.UpdateUsername(newName, id);
                    DialogResult res = MessageBox.Show("Username changed");
                    userName = newName;
                    nametextBox.Text = newName;
                    newNametextBox.Text = string.Empty;
                    passwordtextBox.Text = string.Empty;
                    passwordtextBox2.Text = string.Empty;
                } catch (Exception ex) 
                {
                    DialogResult res = MessageBox.Show(ex.Message);
                }
            } else
            {
                DialogResult res = MessageBox.Show("Passwords don't match");
            }
        }
        public string returnUsername()
        {
            return userName;
        }
    }
}
