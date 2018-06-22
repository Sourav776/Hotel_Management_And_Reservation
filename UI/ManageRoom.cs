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
    public partial class ManageRoom : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public ManageRoom()
        {
            InitializeComponent();
        }

        private void addBT_Click(object sender, EventArgs e)
        {
             if (roomNumber2TB.Text == "" || roomTypeTB.Text== "" || pricePerDay.Text == "" )
            {
                MessageBox.Show("Please Fill Up each field properly");
                return;
            }
            con.Open();
            string query = "insert into room_information values('" + roomNumber2TB.Text + "','" + roomTypeTB.Text + "','"+ pricePerDay.Text+"');";
            try
            {
                DialogResult d = MessageBox.Show("Dou you want to really add these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    roomNumber1TB.Text = "";
                    roomNumber2TB.Text = "";
                    roomTypeTB.Text = "";
                    pricePerDay.Text="";
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

        private void searchBT_Click(object sender, EventArgs e)
        {
             if (roomNumber1TB.Text == "")
            {
                MessageBox.Show("please enter room number for searching");
                return;
            }

            else
            {
                con.Open();
                string query = "select * from room_information where room_no ='" + roomNumber1TB.Text + "';";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        roomNumber2TB.Text = reader.GetString(0);
                        roomTypeTB.Text = reader.GetString(1);
                        pricePerDay.Text = reader.GetString(2);
                    }
                    else
                    {
                        MessageBox.Show("Room Number is incorrect.plz enter correct Room number");
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

        private void closeBT_Click(object sender, EventArgs e)
        {
            AdminPage ap = new AdminPage();
            this.Visible = false;
            ap.Visible = true;
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            if (roomNumber2TB.Text == "" || roomTypeTB.Text == "" || pricePerDay.Text == "")
            {
                MessageBox.Show("Please fill up each field properly");
                return;
            }
            else
            {
                con.Open();
                string query = "update room_information set room_no ='" + roomNumber2TB.Text + "',room_type ='" + roomTypeTB.Text + "',price_per_day ='" + pricePerDay.Text + "' where room_no ='" + roomNumber1TB.Text + "';";
                try
                {
                    DialogResult d = MessageBox.Show("Dou you want to really update these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        roomNumber1TB.Text = "";
                        roomNumber2TB.Text = "";
                        roomTypeTB.Text = "";
                        pricePerDay.Text = "";
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
            if (roomNumber2TB.Text == "" || roomTypeTB.Text == "" || pricePerDay.Text == "")
            {
                MessageBox.Show("Please search room number and delete.");
                return;
            }
            con.Open();
            string query = "delete from room_information where room_no ='" + roomNumber1TB.Text + "';";
            try
            {
                DialogResult d = MessageBox.Show("Dou you want to really delete these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    roomNumber1TB.Text = "";
                    roomNumber2TB.Text = "";
                    roomTypeTB.Text = "";
                    pricePerDay.Text = "";
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
    }
}
