using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolTechInventoryManagementSystem
{
    public partial class changePasswordForm : Form
    {
        private string pwd { get; set; }
        private int id { get; set; }
        public changePasswordForm(int id, string pwd)
        {
            InitializeComponent();
            this.pwd = pwd;
            this.id = id;
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        private void changebutton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            string password = oldpasswordtextBox.Text;
            string newpassword = passwordtextBox.Text;
            string newpassword2 = passwordtextBox2.Text;
            if(password == pwd && newpassword.Equals(newpassword2))
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"UPDATE [User] SET Password = '{newpassword}' WHERE id = '{id}'";
                    cmd.Connection = con;
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    SystemDataSetTableAdapters.UserTableAdapter userTableAdapter = new SystemDataSetTableAdapters.UserTableAdapter();
                    userTableAdapter.UpdatePassword(newpassword, id);
                    DialogResult res = MessageBox.Show("Password updated");
                    oldpasswordtextBox.Text = string.Empty;
                    passwordtextBox.Text = string.Empty;
                    passwordtextBox2.Text = string.Empty;
                } catch(Exception ex) {
                    DialogResult res = MessageBox.Show(ex.Message);
                }
            } else if(password != pwd && newpassword.Equals(newpassword2))
            {
                DialogResult res = MessageBox.Show("Incorrect password");
            } else if(password == pwd && !newpassword.Equals(newpassword2))
            {
                DialogResult res = MessageBox.Show("Password not equal");
            }
        }
        public string returnpassword()
        {
            return pwd;
        }
    }
}
