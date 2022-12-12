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
    public partial class deleteItemForm : Form
    {
         public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }

        public deleteItemForm()
        {
            InitializeComponent();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idtextBox.Text);
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"DELETE FROM Items WHERE Id = '{id}'";
                cmd.Connection = con;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                idtextBox.Text = string.Empty;
                SystemDataSetTableAdapters.ItemsTableAdapter itemTableAdapter = new SystemDataSetTableAdapters.ItemsTableAdapter();
                itemTableAdapter.DeleteQuery(id);
                playSimpleSound();
                DialogResult res = MessageBox.Show("Item Removed " + i);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message);
            }
        }

        private void deleteItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
