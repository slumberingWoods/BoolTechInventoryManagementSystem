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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BoolTechInventoryManagementSystem
{
    public partial class deleteUserForm : Form
    {
         public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }

        public deleteUserForm()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
               
                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = (System.IO.Path.GetDirectoryName(executable));
                AppDomain.CurrentDomain.SetData("DataDirectory", path);
                int id = int.Parse(idTextBox.Text);
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"DELETE FROM [User] WHERE Id = '{id}'";
                cmd.Connection = con;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                idTextBox.Text = string.Empty;
                SystemDataSetTableAdapters.UserTableAdapter userTableAdapter = new SystemDataSetTableAdapters.UserTableAdapter();
                userTableAdapter.DeleteQuery(id);
                playSimpleSound();
                DialogResult res = MessageBox.Show("User Removed");
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message);
            }
        }
    }
}
