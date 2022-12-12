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
    public partial class addSalesLog : Form
    {

        public addSalesLog()
        {
            InitializeComponent();
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        private void addItem_Click(object sender, EventArgs e)
        {
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            userTextBox.Text = string.Empty;
            itemTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            dateTextBox.Text = string.Empty;
        }

        private void addItem_Click_1(object sender, EventArgs e)
        {
            playSimpleSound();
            int userId = int.Parse(userTextBox.Text);
            int itemId = int.Parse(itemTextBox.Text);
            decimal price = decimal.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);
            DateTime date = DateTime.Parse(dateTextBox.Text);
            try
            {
                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = (System.IO.Path.GetDirectoryName(executable));
                AppDomain.CurrentDomain.SetData("DataDirectory", path);
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"INSERT INTO [Sales] VALUES ('{userId}', '{itemId}', '{price}', '{quantity}', '{date.ToString("dd-MMM-yyyy")}')";
                cmd.Connection = con;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                SystemDataSetTableAdapters.SalesTableAdapter salesTableAdapter = new SystemDataSetTableAdapters.SalesTableAdapter();
                salesTableAdapter.Insert(userId, itemId, price, quantity, date);
                DialogResult res = MessageBox.Show("Item Added");
            } catch(Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message);
            }
        }
        private void lightButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            darkButton.ForeColor = Color.Black;
            lightButton.ForeColor = Color.Black;
        }

        private void darkButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            darkButton.ForeColor = Color.White;
            lightButton.ForeColor = Color.White;
        }
    }
}
