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
    public partial class addItemForm : Form
    {
         public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        public addItemForm()
        {
            InitializeComponent();
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            clearBoxes();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
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
                cmd.CommandText = $"INSERT INTO Items VALUES ('{name}', '{type}', '{quantity}', '{aisle}', '{status}', '{cost}', '{price}')";
                cmd.Connection = con;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                SystemDataSetTableAdapters.ItemsTableAdapter itemTableAdapter = new SystemDataSetTableAdapters.ItemsTableAdapter();
                itemTableAdapter.Insert(name, type, quantity, aisle, status, cost, price);
                playSimpleSound();
                DialogResult res = MessageBox.Show("Item Added");
            } catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.ToString());
            }
        }
        public void clearBoxes()
        {
            nametextBox.Text = string.Empty;
            typetextBox.Text = string.Empty;
            quantitytextBox.Text = string.Empty;
            aisletextBox.Text = string.Empty;
            statustextBox.Text = string.Empty;
            costtextBox.Text = string.Empty;
            pricetextBox.Text = string.Empty;
        }
    }
}
