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
using System.CodeDom;
using System.Media;

namespace BoolTechInventoryManagementSystem
{
    public partial class modifyItems : Form
    {
         public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        public modifyItems()
        {
            InitializeComponent();
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            int id = int.Parse(idtextBox.Text);
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"Select * from Items where id = '{id}'";
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nametextBox.Text = reader["Name"].ToString();
                        typetextBox.Text = reader["Type"].ToString();
                        quantitytextBox.Text = reader["Quantity"].ToString();
                        aisletextBox.Text = reader["Aisle"].ToString();
                        statustextBox.Text = reader["Status"].ToString();
                        costtextBox.Text = reader["Cost"].ToString();
                        pricetextBox.Text = reader["Price"].ToString();
                        nametextBox.ReadOnly = false;
                        typetextBox.ReadOnly = false;
                        quantitytextBox.ReadOnly = false;
                        aisletextBox.ReadOnly = false;
                        statustextBox.ReadOnly = false;
                        costtextBox.ReadOnly = false;
                        pricetextBox.ReadOnly = false;
                    }
                }
                if (!nametextBox.Text.Equals(""))
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
            int id = int.Parse(idtextBox.Text);
            string name = nametextBox.Text;
            string type = typetextBox.Text;
            int quantity = int.Parse(quantitytextBox.Text);
            string aisle = aisletextBox.Text;
            string status = statustextBox.Text;
            decimal cost = decimal.Parse(costtextBox.Text);
            decimal price = decimal.Parse(pricetextBox.Text);
            try
            {
                SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"UPDATE Items " +
                    $"SET Name = '{name}', Type = '{type}', Quantity = '{quantity}', Aisle = '{aisle}', Status = '{status}', Cost = '{cost}', Price = '{price}'  WHERE id = '{id}';";
                cmd.Connection = con;
                con.Open();
                int result = cmd.ExecuteNonQuery();
                SystemDataSetTableAdapters.ItemsTableAdapter itemTableAdapter = new SystemDataSetTableAdapters.ItemsTableAdapter();
                itemTableAdapter.UpdateQuery(name, type, quantity, aisle, status, cost, price, id);
                DialogResult res = MessageBox.Show("Item Modified");
            } catch(Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.ToString());
            }
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            idtextBox.Text = string.Empty;
            nametextBox.Text = string.Empty;
            typetextBox.Text = string.Empty;
            quantitytextBox.Text = string.Empty;
            aisletextBox.Text = string.Empty;
            statustextBox.Text = string.Empty;
            costtextBox.Text = string.Empty;
            pricetextBox.Text = string.Empty;
            nametextBox.ReadOnly = true;
            typetextBox.ReadOnly = true;
            quantitytextBox.ReadOnly = true;
            aisletextBox.ReadOnly = true;
            statustextBox.ReadOnly = true;
            costtextBox.ReadOnly = true;
            pricetextBox.ReadOnly = true;
        }
    }
}
