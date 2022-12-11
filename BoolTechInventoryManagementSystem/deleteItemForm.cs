using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolTechInventoryManagementSystem
{
    public partial class deleteItemForm : Form
    {
        public deleteItemForm()
        {
            InitializeComponent();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idtextBox.Text);
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                       new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hallo\\BoolTechInventoryManagementSystem\\BoolTechInventoryManagementSystem\\System.mdf;Integrated Security=True");
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"DELETE FROM Items WHERE Id = '{id}'";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                idtextBox.Text = string.Empty;
                DialogResult res = MessageBox.Show("Item Removed");
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message);
            }
        }
    }
}
