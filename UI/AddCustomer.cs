using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_managemnet_and_reservation_system;
using MySql.Data.MySqlClient;

namespace hotel_managemnet_and_reservation_system.UI
{
    public partial class AddCustomer : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
           
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            customerIdTB.Enabled = true;
            customerNameTB.Enabled = true;
            genderCB.Enabled = true;
            contactTB.Enabled = true;
            addressTB.Enabled = true;
            saveBT.Enabled = true;
            con.Open();
            string query = "SELECT MAX(c_id) FROM reservaiton_table";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int incrementID = reader.GetInt32(0)+1;
                    string value = incrementID.ToString();
                    customerIdTB.Text = value;
                   

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

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            if (customerNameTB.Text == "" || genderCB.Text == "" ||contactTB.Text=="" || addressTB.Text == "")
            {
                MessageBox.Show("Empty field is not allowed.try again");
                return;
            }
            con.Open();
            string query = "insert into reservaiton_table values('" + customerIdTB.Text + "','" + customerNameTB.Text + "','" + genderCB.Text + "','" + contactTB.Text + "','" + addressTB.Text + "','','','','','','','','');";
            try
            {
                DialogResult d = MessageBox.Show("Dou you want to really insert these values ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    int id = Int32.Parse(customerIdTB.Text)+1;
                    customerIdTB.Text = id.ToString();
                    customerNameTB.Text = "";
                    genderCB.Text = "";
                    contactTB.Text = "";
                    addressTB.Text = "";
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
    }
}
