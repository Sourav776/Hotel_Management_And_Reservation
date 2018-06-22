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
using hotel_managemnet_and_reservation_system.DAL;
using hotel_managemnet_and_reservation_system.UI;

namespace hotel_managemnet_and_reservation_system
{
    public partial class Home : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public Home()
        {
            InitializeComponent();
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Username or password is empty. try again.", "Error");
                return;
            }
            if (adminRB.Checked == false && userRB.Checked == false)
            {
                MessageBox.Show("Login Mode have to be selected.", "Error");
                return;
            }
            con.Open();
            string query = "";
            if (userRB.Checked)
                query = "select userName,password from user_table where userName='" + userNameTB.Text + "' and password='" + passwordTB.Text + "';";


            if (adminRB.Checked)
                query = "select userName,password from admin_table where userName='" + userNameTB.Text + "' and password='" + passwordTB.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (userNameTB.Text == reader.GetString(0) && passwordTB.Text == reader.GetString(1))
                {
                    if (userRB.Checked)
                    {
                        this.loginPanel.Visible = false;
                        this.informationPanel.Enabled = true;
                    }

                    if (adminRB.Checked)
                    {
                        
                        AdminPage admin = new AdminPage();
                        admin.Visible = true;
                        this.Visible = false;
                    }
                }

                else
                {
                    MessageBox.Show("Username or Password is Wrong");
                }



            }
            else
            {
                MessageBox.Show("username or password is worng");
            }
            reader.Close();
            con.Close();
        }

        private void addCustomerBT_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.Visible = true;
            
        }

        private void checkInBT_Click(object sender, EventArgs e)
        {
            CheckinCustomer cic = new CheckinCustomer();
            cic.Visible = true;
        }

        private void helpBT_Click(object sender, EventArgs e)
        {
            myHelp f = new myHelp();
            f.Visible = true;
        }

        private void viewRoomBT_Click(object sender, EventArgs e)
        {
            ViewRoomDetails vir = new ViewRoomDetails();
            vir.Visible = true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Visible = true;
            this.Close();
        }

        private void quitBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookingBT_Click(object sender, EventArgs e)
        {
            Booking bk = new Booking();
            bk.Visible = true;
        }

        private void foodMenuBT_Click(object sender, EventArgs e)
        {
            Food f = new Food();
            f.Visible = true;
        }

        private void checkOutBT_Click(object sender, EventArgs e)
        {
            CheckOut f = new CheckOut();
            f.Show();
        }
    }
}
