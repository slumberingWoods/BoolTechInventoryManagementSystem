﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BoolTechInventoryManagementSystem
{
    public partial class loginScreenForm : Form
    {
        public loginScreenForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\BoolTechInventoryManagementSystem\BoolTechInventoryManagementSystem\System.mdf;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from [User]";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[1].ToString() == username && rd[2].ToString() == password)
                {
                    this.Close();
                    break;
                }
            }
            DialogResult res = MessageBox.Show("User or password is incorrect");
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            int clear = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\BoolTechInventoryManagementSystem\BoolTechInventoryManagementSystem\System.mdf;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from [User]";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[1].ToString() == username && rd[2].ToString() == password)
                {
                    if (rd[3].ToString() == "admin") {
                        this.Close();
                        break;
                    }
                    else
                    {
                        DialogResult res1 = MessageBox.Show("User does not have clearance");
                        clear++;
                        break;
                    }
                }
            }
            if (clear == 0)
            {
                DialogResult res = MessageBox.Show("User or password is incorrect");
            }
        }
    }
}