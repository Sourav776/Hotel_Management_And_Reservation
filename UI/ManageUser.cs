using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_managemnet_and_reservation_system.UI
{
    public partial class ManageUser : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public ManageUser()
        {
            InitializeComponent();
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            if (userName1TB.Text == "")
            {
                MessageBox.Show("please enter user name for searching");
                return;
            }

            else
            {
                con.Open();
                string query = "select * from user_table where userName ='" + userName1TB.Text + "';";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userName2TB.Text = reader.GetString(0);
                        passwordTB.Text = reader.GetString(1);
                    }
                    else
                    {
                        MessageBox.Show("User Name is incorrect.plz enter correct User Name");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message:" + ex);
                    con.Close();
                }
            }
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            if (userName2TB.Text == "" || passwordTB.Text== "")
            {
                MessageBox.Show("UserName or Password is empty.Please enter UserName and Password");
                return;
            }
            con.Open();
            string query = "insert into user_table values('" + userName2TB.Text + "','" + passwordTB.Text + "');";
            try
            {
                DialogResult d = MessageBox.Show("Dou you want to really save these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    userName1TB.Text = "";
                    userName2TB.Text = "";
                    passwordTB.Text = "";
                    MessageBox.Show("Successfully saved data", "success");

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            if (userName2TB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("UserName or Password is empty.Please enter UserName and Password");
                return;
            }
            else
            {
                con.Open();
                string query = "update user_table set userName ='" + userName2TB.Text + "',password='" + passwordTB.Text + "' where userName ='" + userName1TB.Text + "';";
                try
                {
                    DialogResult d = MessageBox.Show("Dou you want to really update these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        userName1TB.Text = "";
                        userName2TB.Text = "";
                        passwordTB.Text = "";
                        MessageBox.Show("Successfully updated data", "success");

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message:" + ex.Message);
                    con.Close();
                }
            }
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if (userName2TB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("UserName or Password is empty.Please enter UserName and Password");
                return;
            }
            con.Open();
            string query = "delete from user_table where userName ='" + userName1TB.Text + "';";
            try
            {
                DialogResult d = MessageBox.Show("Dou you want to really delete these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    userName1TB.Text = "";
                    userName2TB.Text = "";
                    passwordTB.Text = "";
                    MessageBox.Show("Successfully deleted data", "success");

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            AdminPage ap = new AdminPage();
            this.Visible = false;
            ap.Visible = true;

        }
    }
}
