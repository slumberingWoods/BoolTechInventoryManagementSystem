using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Irman\BoolTechInventoryManagementSystem\BoolTechInventoryManagementSystem\System.mdf;Integrated Security=True";
                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = (System.IO.Path.GetDirectoryName(executable));
                AppDomain.CurrentDomain.SetData("DataDirectory", path);
                int id = int.Parse(idtextBox.Text);
                SqlConnection con = new SqlConnection(ConnectionString);
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
