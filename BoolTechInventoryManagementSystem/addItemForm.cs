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
    public partial class addItemForm : Form
    {
        public addItemForm()
        {
            InitializeComponent();
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string type = typetextBox.Text;
            int Quantity = int.Parse(quantitytextBox.Text);
            string aisle = aisletextBox.Text;
            string status = statustextBox.Text;
            decimal cost = decimal.Parse(costtextBox.Text);
            decimal price = decimal.Parse(pricetextBox.Text);
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                    new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hallo\\BoolTechInventoryManagementSystem\\BoolTechInventoryManagementSystem\\System.mdf;Integrated Security=True");
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"INSERT Items (Name, Type, Quantity, Aisle, Status, Cost, Price) " +
                    $"VALUES ('{name}', '{type}', '{Quantity}', '{aisle}', '{status}', '{cost}', '{price}')";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                clearBoxes();
                DialogResult res = MessageBox.Show("Item Added");
            }
            catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Invalid Input");
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
