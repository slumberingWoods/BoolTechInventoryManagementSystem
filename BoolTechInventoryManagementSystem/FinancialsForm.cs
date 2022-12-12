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
    public partial class FinancialsForm : Form
    {
        public int i { get; set; }
        public FinancialsForm()
        {
            this.i = -1;
            InitializeComponent();
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }
        private void selectioncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(selectioncomboBox.SelectedIndex)
            {
                case 0:
                    monthSelect.Enabled = true;
                    yearSelect.Enabled = false;
                    i = 0;
                    break;
                case 1:
                    monthSelect.Enabled = false;
                    yearSelect.Enabled = true;
                    i= 1;
                    break;
                case 2:
                    monthSelect.Enabled = true;
                    yearSelect.Enabled = true;
                    i = 2;
                    break;
                default:
                    break;
            }
        }

        private void getData_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            switch(i)
            {
                case 0:
                    int month = (int)monthSelect.Value;
                    returnMonth(month);
                    break;
                case 1:
                    int year = (int)yearSelect.Value;
                    returnYear(year);
                    break;
                case 2:
                    int month2 = (int)monthSelect.Value;
                    int year2 = (int)yearSelect.Value;
                    returnMonthYear(month2, year2);
                    break;
                default:
                    DialogResult res = MessageBox.Show("Nothing selected");
                    break;
            }
        }
        public void returnMonth(int month)
        {
            decimal profit;
            SystemDataSetTableAdapters.SalesTableAdapter salesTableAdapter = new SystemDataSetTableAdapters.SalesTableAdapter();
            finanaceChart.Series["Chart"].Points.Clear();
            try
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"SELECT MONTH(s.Date) AS Month, SUM(s.Price * s.Quantity - i.Cost * s.Quantity) AS Revenue FROM Sales AS s INNER JOIN Items AS i ON s.ItemId = i.Id GROUP BY MONTH(s.Date)";
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string monthReader = reader[0].ToString();
                            decimal revenueReader = decimal.Parse(reader[1].ToString());
                            finanaceChart.Series[0].Points.AddXY(monthReader, revenueReader);
                        }
                    }
                    con.Close();
                } catch(Exception ex)
                {
                    DialogResult res1 = MessageBox.Show(ex.Message);
                }
                profit = (decimal)salesTableAdapter.ProfitOfMonthQuery(month);
                resultText.Text = profit.ToString("C");
            } 
            catch 
            {
                DialogResult res = MessageBox.Show("There is no sales of the month");
                resultText.Text = "$0.00";
            }
        }
        public void returnYear(int year)
        {
            decimal profit;
            SystemDataSetTableAdapters.SalesTableAdapter salesTableAdapter = new SystemDataSetTableAdapters.SalesTableAdapter();
            finanaceChart.Series["Chart"].Points.Clear();
            try
            {   
                try { 
                    SqlConnection con = new SqlConnection(ConnectionStringClass.ConnectionString);
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"SELECT YEAR(s.Date) AS YEAR, SUM(s.Price * s.Quantity - i.Cost * s.Quantity) AS Revenue FROM Sales AS s INNER JOIN Items AS i ON s.ItemId = i.Id GROUP BY YEAR(s.Date)";
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string yearReader = reader[0].ToString();
                            decimal revenueReader = decimal.Parse(reader[1].ToString());
                            finanaceChart.Series[0].Points.AddXY(yearReader, revenueReader);
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    DialogResult res1 = MessageBox.Show(ex.Message);
                }
            profit = (decimal)salesTableAdapter.ProfitOfYearQuery(year);
                resultText.Text = profit.ToString("C");
            }
            catch
            {
                DialogResult res = MessageBox.Show("There is no sales of the year");
                resultText.Text = "$0.00";
            }
        }
        public void returnMonthYear(int month, int year)
        {
            decimal profit;
            SystemDataSetTableAdapters.SalesTableAdapter salesTableAdapter = new SystemDataSetTableAdapters.SalesTableAdapter();
            try
            {
                profit = (decimal)salesTableAdapter.ProfitOfMonthYearQuery(month, year);
                resultText.Text = profit.ToString("C");
            }
            catch
            {
                DialogResult res = MessageBox.Show("There is no sales of the month and year");
                resultText.Text = "$0.00";
            }
        }
    }
}
