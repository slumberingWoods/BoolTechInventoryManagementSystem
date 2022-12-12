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
    public partial class addUserForm : Form
    {
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Irman\\BoolTechInventoryManagementSystem\\BoolTechInventoryManagementSystem\\System.mdf;Integrated Security=True";
        public addUserForm()
        {
            InitializeComponent();
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
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
            cmd.CommandText = $"INSERT INTO User VALUES('{id}', '{userName}', '{password}', '{userType}')";
            cmd.Connection = con;
            con.Open(); 
            int i = cmd.ExecuteNonQuery();
            con.Close();
            SystemDataSetTableAdapters.UserTableAdapter userTableAdapter = new SystemDataSetTableAdapters.UserTableAdapter();
            userTableAdapter.Insert(id, userName, password, userType);
            DialogResult res = MessageBox.Show("User Added");

        }
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }

        private void userType_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

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
