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
    public partial class modifySalesLog : Form
    {
        public modifySalesLog()
        {
            InitializeComponent();
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        private void searchItem_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            int id = int.Parse(logTextBox.Text);
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"Select * from [Sales] where id = '{id}'";
                cmd.Connection = con;
                con.Open();
                int result = cmd.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userTextBox.Text = reader[1].ToString();
                        itemTextBox.Text = reader[2].ToString();
                        priceTextBox.Text = reader[3].ToString();
                        quantityTextBox.Text = reader[4].ToString();
                        dateTextBox.Text = reader[5].ToString();
                        userTextBox.ReadOnly = false;
                        itemTextBox.ReadOnly = false;
                        priceTextBox.ReadOnly = false;
                        quantityTextBox.ReadOnly = false;
                        dateTextBox.ReadOnly = false;
                    }
                }
                if (!userTextBox.Text.Equals(""))
                {
                    modifyButton.Enabled = true;
                }
                else
                {
                    DialogResult res = MessageBox.Show("Item Doesn't exist");
                }
            } catch(Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.ToString());
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            int id = int.Parse(logTextBox.Text);
            int userId = int.Parse(userTextBox.Text);
            int itemId = int.Parse(itemTextBox.Text);
            decimal price = decimal.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);
            DateTime date = DateTime.Parse(dateTextBox.Text);
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"UPDATE [Sales] " +
                    $"SET userId = '{userId}', itemId = '{itemId}', Price = '{price}', Quantity = '{quantity}', Date = '{date.ToString("dd-MMM-yyyy")}'  WHERE salesId = '{id}';";
                cmd.Connection = con;
                con.Open();
                SystemDataSetTableAdapters.SalesTableAdapter salesTableAdapter = new SystemDataSetTableAdapters.SalesTableAdapter();
                salesTableAdapter.UpdateQuery(userId, itemId, price, quantity, date.ToString(), id);
                DialogResult res = MessageBox.Show("Log Modified");
            } catch(Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message);
            }
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            logTextBox.Text = string.Empty;
            userTextBox.Text = string.Empty;
            itemTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            dateTextBox.Text = string.Empty;
            userTextBox.ReadOnly = true;
            itemTextBox.ReadOnly = true;
            priceTextBox.ReadOnly = true;
            quantityTextBox.ReadOnly = true;
            dateTextBox.ReadOnly = true;
        }
    }
}
