using Microsoft.Reporting.WinForms;
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
    public partial class Food : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public string customer_id;
        public Food()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            if (cIdCB.Text == "")
            {
                MessageBox.Show("No amount to save");
                return;
            }
            con.Open();
            string query = "update cost_table set food_cost=food_cost+" + Convert.ToDouble(billTB.Text) + ",temp_food_cost=0 where c_id='" + cIdCB.Text + "';";
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
                MessageBox.Show("Error Message: " + ex);
                con.Close();
            }
            this.Close();
        }

        private void billBT_Click(object sender, EventArgs e)
        {
            if(cIdCB.Text=="")
            {
                MessageBox.Show("Please select Customer id!","Error");
                return;
            }
            billPanel.Visible = true;
            exitBT.Visible = true;;
            reportBT.Visible = true;
            nameTB.Text = cNameTB.Text;
            idTB.Text = cIdCB.SelectedItem.ToString();
            con.Open();
            string query = "select temp_food_cost from cost_table where c_id='" + idTB.Text + "';";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    billTB.Text = reader["temp_food_cost"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void soupBT_Click(object sender, EventArgs e)
        {
            if (cIdCB.Text == "")
            {
                MessageBox.Show("Please select Customer id!", "Error");
                return;
            }
            Soups f = new Soups(cIdCB.SelectedItem.ToString());
            f.Visible = true;
        }

        private void drinkBT_Click(object sender, EventArgs e)
        {
            if (cIdCB.Text == "")
            {
                MessageBox.Show("Please select Customer id!", "Error");
                return;
            }
            Drinks f = new Drinks(cIdCB.SelectedItem.ToString());
            f.Visible = true;
        }

        private void riceBT_Click(object sender, EventArgs e)
        {
            if (cIdCB.Text == "")
            {
                MessageBox.Show("Please select Customer id!", "Error");
                return;
            }
            Rice f = new Rice(cIdCB.SelectedItem.ToString());
            f.Visible = true;
        }

        private void fishBT_Click(object sender, EventArgs e)
        {
            if (cIdCB.Text == "")
            {
                MessageBox.Show("Please select Customer id!", "Error");
                return;
            }
            Fishes f = new Fishes(cIdCB.SelectedItem.ToString());
            f.Visible = true;
        }

        private void meatBT_Click(object sender, EventArgs e)
        {
            if (cIdCB.Text == "")
            {
                MessageBox.Show("Please select Customer id!", "Error");
                return;
            }
            Meats f = new Meats(cIdCB.SelectedItem.ToString());
            f.Visible = true;
        }

        private void otherBT_Click(object sender, EventArgs e)
        {
            if (cIdCB.Text == "")
            {
                MessageBox.Show("Please select Customer id!", "Error");
                return;
            }
            Others f = new Others(cIdCB.SelectedItem.ToString());
            f.Visible = true;
        }

        private void Food_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from reservaiton_table ;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customer_id = reader.GetString("c_id");
                    cIdCB.Items.Add(customer_id);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you confirm to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
        private void saveBT_Click(object sender, EventArgs e)
        {
            
        }

        private void printBT_Click(object sender, EventArgs e)
        {

        }

        private void cIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            con.Open();
            string query = "select * from reservaiton_table where c_id='" + cIdCB.SelectedItem + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cNameTB.Text = reader.GetString(1);
                    roomTB.Text = reader.GetString(9);

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void backKBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void reportBT_Click(object sender, EventArgs e)
        {
            Food_Report f = new Food_Report(dateTP.Text, idTB.Text, nameTB.Text, billTB.Text);
            f.Show();  
        }
        private void exitBT_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "update cost_table set food_cost=food_cost+temp_food_cost, temp_food_cost=0 where c_id='"+idTB.Text+"';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Successfully Done.");
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}