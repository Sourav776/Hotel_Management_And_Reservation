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
    public partial class CheckOut : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from reservaiton_table ;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string customer_id = reader.GetString("c_id");
                    customerId1CB.Items.Add(customer_id);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void checkOutBT_Click(object sender, EventArgs e)
        {
            if (customerId1CB.Text == "")
            {
                MessageBox.Show("please enter customer id ");
            }
            else
            {
                con.Open();
                string query = "select * from reservaiton_table where c_id='" + customerId1CB.Text + "';";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        customerName1TB.Text = reader.GetString(1);
                        gender1CB.Text = reader.GetString(2);
                        contactTB.Text = reader.GetString(3);
                        checkInDateTP.Text = reader.GetString(6);
                        checkOutDateTP.Text = reader.GetString(7);
                        reservedDaysTB.Text = reader.GetString(8);
                        roomNumberCB.Text = reader.GetString(9);
                        roomTypeCB.Text = reader.GetString(11);
                        priceTB.Text = reader.GetString(12);

                    }
                    else
                    {
                        MessageBox.Show("System Error");
                    }
                    con.Close();
                    calculateRoomCost();
                    cost();
                    calculateTotalCost();
                    saveBT.Enabled = true;
                    deleteBT.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid values exist!");
                    con.Close();
                }

               
            }
        }
        private void calculateRoomCost()
        {
            double duration = Convert.ToDouble(reservedDaysTB.Text);
            double price_per_day = Convert.ToDouble(priceTB.Text);
            double room_cost = duration * price_per_day;
            roomCostTB.Text = Convert.ToString(room_cost);
            
        }
        private void cost()
        {
            con.Open();
            string query = "select * from cost_table where c_id='" + customerId1CB.Text + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                   foodCostTB.Text = reader["food_cost"].ToString();
                    advanceTB.Text = reader["advance"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("System Error");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex);
                con.Close();
            }
        }

        private void calculateTotalCost()
        {
            double room_cost = Convert.ToDouble(roomCostTB.Text);
            double food_cost = Convert.ToDouble(foodCostTB.Text);
            double advance = Convert.ToDouble(advanceTB.Text);
            double total_cost = room_cost + food_cost - advance;
            totalCostTB.Text = Convert.ToString(total_cost);
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into report_table values('" + customerId1CB.Text + "','" + customerName1TB.Text + "','" + gender1CB.Text + "','" + contactTB.Text + "','" + checkInDateTP.Text + "','" + checkOutDateTP.Text + "','" + reservedDaysTB.Text + "','" + roomNumberCB.Text + "','" + roomTypeCB.Text + "','" + priceTB.Text + "','" + roomCostTB.Text + "','" + foodCostTB.Text + "','" + advanceTB.Text + "','" + totalCostTB.Text + "');";
            try
            {
                DialogResult d = MessageBox.Show("Dou you want to really save these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
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

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from cost_table where c_id ='" + customerId1CB.Text + "';";
            try
            {
                DialogResult d = MessageBox.Show("Dou you want to really delete these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    delete_data();
                    customerId1CB.Text = "";
                    customerName1TB.Text = "";
                    gender1CB.Text = "";
                    contactTB.Text = "";
                    checkInDateTP.Text="";
                    checkOutDateTP.Text = "";
                    reservedDaysTB.Text = "";
                    roomNumberCB.Text = "";
                    priceTB.Text = "";
                    roomCostTB.Text = "";
                    foodCostTB.Text = "";
                    advanceTB.Text = "";
                    totalCostTB.Text = "";

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }

            
        }

        private void delete_data()
        {
            con.Open();
            string query = "delete from reservaiton_table where c_id = '" + customerId1CB.Text + "';";
            try
            {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted data", "success");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message:" + ex.Message);
                con.Close();
            }
        }

        private void billBT_Click(object sender, EventArgs e)
        {
            checkoutReport f = new checkoutReport(customerId1CB.SelectedItem.ToString());
            f.Show();
        }
    }
}
