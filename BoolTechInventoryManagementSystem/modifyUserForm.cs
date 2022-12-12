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

namespace BoolTechInventoryManagementSystem
{
    public partial class modifyUserForm : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Irman\BoolTechInventoryManagementSystem\BoolTechInventoryManagementSystem\System.mdf;Integrated Security=True";
        public modifyUserForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextBox.Text);
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            SqlConnection con = new SqlConnection(connection);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"Select * from Items where id = '{id}'";
            cmd.Connection = con;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if(reader.Read())
                {
                    userNameTextBox.Text = reader["UserName"].ToString();
                    passwordTextBox.Text = reader["Password"].ToString();
                    userTypeTextBox.Text = reader["UserType"].ToString();
                    userNameTextBox.ReadOnly = false;
                    passwordTextBox.ReadOnly = false;
                    userTypeTextBox.ReadOnly = false;
                }
            }
            if (!userNameTextBox.Text.Equals(""))
            {
                modify.Enabled = true;
            }
            else
            {
                DialogResult res = MessageBox.Show("User Doesn't exist");
            }
        }

        private void userTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modify_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextBox.Text);
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string userType = userTypeTextBox.Text;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            SqlConnection con = new SqlConnection(connection);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"UPDATE User " +
            $"SET UserName = '{userName}', Password = '{password}', UserType = '{userType}' WHERE id = '{id}';";
            cmd.Connection = con;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            SystemDataSetTableAdapters.UserTableAdapter userTableAdapter = new SystemDataSetTableAdapters.UserTableAdapter();
            userTableAdapter.UpdateQuery(userName, password, userType, id);
            DialogResult res = MessageBox.Show("User Modified");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = string.Empty;
            userName.Text = string.Empty;
            password.Text = string.Empty;
            userType.Text = string.Empty;
        }
    }
}
