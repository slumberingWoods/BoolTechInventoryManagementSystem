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
    public partial class deleteSalesLog : Form
    {
        public deleteSalesLog()
        {
            InitializeComponent();
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            try
            { 
                int id = int.Parse(logTextBox.Text);
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"DELETE FROM [Sales] WHERE SalesId = '{id}'";
                cmd.Connection = con;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                logTextBox.Text = string.Empty;
                SystemDataSetTableAdapters.SalesTableAdapter salesTableAdapter = new SystemDataSetTableAdapters.SalesTableAdapter();
                salesTableAdapter.DeleteQuery(id);
                DialogResult res = MessageBox.Show("Log Removed " + i);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message);
            }
        }
    }
}
