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
    public partial class CheckinCustomer : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public CheckinCustomer()
        {
            InitializeComponent();
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void CheckinCustomer_Load(object sender, EventArgs e)
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
                    customerIdCB.Items.Add(customer_id);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            room_load();
        }
        private void room_load()
        {
            con.Open();
            string query = "select * from room_information ;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string room_number = reader.GetString("room_no");
                    roomNumberCB.Items.Add(room_number);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void customerIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from reservaiton_table where c_id='" + customerIdCB.SelectedItem + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customerNameTB.Text = reader.GetString(1);
                    genderCB.Text = reader.GetString(2);
                    contactTB.Text = reader.GetString(3);
                    addressTB.Text = reader.GetString(4);

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

        private void roomNumberCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from room_information where room_no='" + roomNumberCB.SelectedItem + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    roomTypeCB.Text = reader.GetString(1);
                    priceCB.Text = reader.GetString(2);

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

        private void checkInBT_Click(object sender, EventArgs e)
        {
            if (roomNumberCB.Text == "")
            {
                MessageBox.Show("Room number is empty.please enter room number");
            }
            else
            {
                con.Open();
                string query = "select room_no from reservaiton_table where room_no='" + roomNumberCB.Text + "';";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Room is already reserved");
                        
                    }
                    else
                    {
                        reader.Close();
                        save_info();
                        saveAdvance();
                        customerIdCB.Text = "";
                        customerNameTB.Text = "";
                        genderCB.Text = "";
                        contactTB.Text = "";
                        addressTB.Text = "";
                        checkInDateTP.Text = "";
                        checkOutDateTP.Text = "";
                        reservedDaysTB.Text = "";
                        roomNumberCB.Text = "";
                        roomTypeCB.Text = "";
                        priceCB.Text = "";
                        advanceTB.Text = "";

                    }
                    
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error HASAN"+ex);
                    con.Close();
                }
            }
            
        }
        private void save_info()
        {
            if (customerIdCB.Text == "" || reservedDaysTB.Text == "")
            {
                MessageBox.Show("Please fill up empty field properly");
            }
            else
            {

                string query = "update reservaiton_table set checkIN_date='"+ checkInDateTP.Text + "',checkOut_date='" + checkOutDateTP.Text +"',no_of_day_reserved='" + reservedDaysTB.Text +"',room_no='" + roomNumberCB.Text + "',room_type='" + roomTypeCB.Text + "',price_per_day='" + priceCB.Text +"' where c_id='"+ customerIdCB.Text +"';";
                try
                {
                    DialogResult d = MessageBox.Show("Dou you want to really save these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        
                    }
                    //con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex);
                   //con.Close();
                }
            }
        }

        private void saveAdvance()
        {
            if (advanceTB.Text == "")
            {
                advanceTB.Text = "0.00";
            }

            string query = "insert into cost_table values('" + customerIdCB.Text + "',0,0," + Convert.ToDouble(advanceTB.Text) + ");";
            try
            {
                DialogResult d = MessageBox.Show("Dou you want to really insert these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void lastCheckInBT_Click(object sender, EventArgs e)
        {
            CheckInDetails cd = new CheckInDetails();
            cd.Visible = true;
        }
    }
}
