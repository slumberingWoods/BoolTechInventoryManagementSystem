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
    public partial class modifyUserForm : Form
    {
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        public modifyUserForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            int id = int.Parse(IdTextBox.Text);
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"SELECT * FROM [User] WHERE Id = '{id}'";
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userNameTextBox.Text = reader["Username"].ToString();
                        passwordTextBox.Text = reader["Password"].ToString();
                        userTypeTextBox.Text = reader["Usertype"].ToString();
                        userNameTextBox.ReadOnly = false;
                        passwordTextBox.ReadOnly = false;
                        userTypeTextBox.ReadOnly = false;
                    }
                }
                if (!userNameTextBox.Text.Equals("") && !passwordTextBox.Text.Equals("") && !userTypeTextBox.Text.Equals(""))
                {
                    modify.Enabled = true;
                }
                else
                {
                    DialogResult res = MessageBox.Show("User Doesn't exist");
                }
            } catch(Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message);
            }
        }
        private void modify_Click(object sender, EventArgs e)
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
                cmd.CommandText = $"UPDATE [User]" +
                $"SET Username = '{userName}', Password = '{password}', Usertype = '{userType}' WHERE Id = '{id}';";
                cmd.Connection = con;
                con.Open();
                int result = cmd.ExecuteNonQuery();
                SystemDataSetTableAdapters.UserTableAdapter userTableAdapter = new SystemDataSetTableAdapters.UserTableAdapter();
                userTableAdapter.UpdateQuery(userName, password, userType, id);
                playSimpleSound();
                DialogResult res = MessageBox.Show("User Modified");
            } catch(Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            IdTextBox.Text = string.Empty;
            userNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            userTypeTextBox.Text = string.Empty;
            modify.Enabled = false;
            userNameTextBox.ReadOnly = true;
            passwordTextBox.ReadOnly = true;
            userTypeTextBox.ReadOnly = true;
        }
    }
}
