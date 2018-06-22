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
    public partial class Meats : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public Meats(string customer_id)
        {
            InitializeComponent();
            cIdCB.Text = customer_id;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void billBT_Click_1(object sender, EventArgs e)
        {
            
        }

        private void soupBT_Click_1(object sender, EventArgs e)
        {
            Soups f = new Soups(cIdCB.Text);
            f.Visible = true;
            this.Close();
        }

        private void drinkBT_Click_1(object sender, EventArgs e)
        {
            Drinks f = new Drinks(cIdCB.Text);
            f.Visible = true;
            this.Close();
        }

        private void riceBT_Click_1(object sender, EventArgs e)
        {
            Rice f = new Rice(cIdCB.Text);
            f.Visible = true;
            this.Close();
        }

        private void fishBT_Click_1(object sender, EventArgs e)
        {
            Fishes f = new Fishes(cIdCB.Text);
            f.Visible = true;
            this.Close();
        }

        private void otherBT_Click_1(object sender, EventArgs e)
        {
            Others f = new Others(cIdCB.Text);
            f.Visible = true;
            this.Close();
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB1_CheckedChanged(object sender, EventArgs e)
        {
            if (quantity1.Text == "")
            {
                MessageBox.Show("Select Quantity", "Error");
                return;
            }
            total1.Text = (int.Parse(quantity1.Text) * 80).ToString();
            save_cost(total1.Text);
        }
        private void save_cost(string total)
        {
            con.Open();
            string query = "update cost_table set temp_food_cost=temp_food_cost+" + total + " where c_id='" + cIdCB.Text + "';";
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
        }

        private void CB2_CheckedChanged(object sender, EventArgs e)
        {
            if (quantity2.Text == "")
            {
                MessageBox.Show("Select Quantity", "Error");
                return;
            }
            total2.Text = (int.Parse(quantity2.Text) * 70).ToString();
            save_cost(total2.Text);
        }

        private void CB3_CheckedChanged(object sender, EventArgs e)
        {
            if (quantity3.Text == "")
            {
                MessageBox.Show("Select Quantity", "Error");
                return;
            }
            total3.Text = (int.Parse(quantity3.Text) * 100).ToString();
            save_cost(total3.Text);
        }

        private void CB4_CheckedChanged(object sender, EventArgs e)
        {
            if (quantity4.Text == "")
            {
                MessageBox.Show("Select Quantity", "Error");
                return;
            }
            total4.Text = (int.Parse(quantity4.Text) * 90).ToString();
            save_cost(total4.Text);
        }

        private void CB5_CheckedChanged(object sender, EventArgs e)
        {
            if (quantity5.Text == "")
            {
                MessageBox.Show("Select Quantity", "Error");
                return;
            }
            total5.Text = (int.Parse(quantity5.Text) * 120).ToString();
            save_cost(total5.Text);
        }
    }
}
