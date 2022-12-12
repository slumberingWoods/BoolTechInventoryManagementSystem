using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BoolTechInventoryManagementSystem.SystemDataSetTableAdapters;
using System.Media;
using System.Runtime.ConstrainedExecution;

namespace BoolTechInventoryManagementSystem
{
    public partial class loginScreenForm : Form
    {
        public loginScreenForm()
        {
            InitializeComponent();
        }

        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("click.wav");
            simpleSound.Play();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectionStringClass.ConnectionString;
                con.Open();
                bool passwordCheck = false;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from [User]";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd[1].ToString() == username && rd[2].ToString() == password)
                    {
                        int id = Convert.ToInt32(rd[0].ToString());
                        passwordCheck = true;
                        Selection sl = new Selection(id, username, password);
                        sl.FormClosed += delegate
                        {
                            this.Show();
                            this.usernameTextbox.Text = string.Empty;
                            this.passwordTextbox.Text = string.Empty;
                        };
                        sl.Show();
                        this.Hide();
                        break;
                    }
                }
                if (passwordCheck == false && (!username.Equals("") || !password.Equals("")))
                {
                    DialogResult res = MessageBox.Show("User or password is incorrect");
                } else if (passwordCheck == false && (username.Equals("") || password.Equals("")))
                {
                    DialogResult res = MessageBox.Show("User or password is empty");
                }
            } catch(Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.ToString());
            }
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            int clear = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectionStringClass.ConnectionString;
                con.Open();
                bool passwordCheck = false;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from [User]";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd[1].ToString() == username && rd[2].ToString() == password)
                    {
                        if (rd[3].ToString() == "admin")
                        {
                            adminForm ad = new adminForm();
                            ad.FormClosed += delegate
                            {
                                this.Show();
                                this.usernameTextbox.Text = string.Empty;
                                this.passwordTextbox.Text = string.Empty;
                            };
                            ad.Show();
                            this.Hide();
                            passwordCheck = true;
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
                if (clear == 0 && passwordCheck == false && (!username.Equals("") || !password.Equals("")))
                {
                    DialogResult res = MessageBox.Show("User or password is incorrect");
                }
                else if (clear == 0 && passwordCheck == false && (username.Equals("") || password.Equals("")))
                {
                    DialogResult res = MessageBox.Show("User or password is empty");
                }
            }
            catch(Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.ToString());
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch(languageComboBox.SelectedIndex)
            {
                case 0: changeLanguage.UpdateConfig("language", "en-Ca");
                        Application.Restart();
                        break;
                case 1:
                    changeLanguage.UpdateConfig("language", "fr");
                    Application.Restart();
                    break;
                case 2:
                    changeLanguage.UpdateConfig("language", "ru");
                    Application.Restart();
                    break;
            }
        }
    }
  }

