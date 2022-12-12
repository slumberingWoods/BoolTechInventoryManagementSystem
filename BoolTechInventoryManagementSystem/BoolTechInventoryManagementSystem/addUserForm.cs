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
    public partial class addUserForm : Form
    {
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        public addUserForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextBox.Text);
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string userType = userTypeTextBox.Text;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"INSERT INTO [User] VALUES('{id}', '{userName}', '{password}', '{userType}')";
                cmd.Connection = con;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                SystemDataSetTableAdapters.UserTableAdapter userTableAdapter = new SystemDataSetTableAdapters.UserTableAdapter();
                userTableAdapter.Insert(id, userName, password, userType);
                playSimpleSound();
                DialogResult res = MessageBox.Show("User Added");
            } catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.ToString());
            }

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            clearBoxes();
        }
        public void clearBoxes()
        {
            IdTextBox.Text = string.Empty;
            userNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            userTypeTextBox.Text = string.Empty;
        }
    }
}
