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
    public partial class ViewRoomDetails : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public ViewRoomDetails()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomNoLB_SelectedItemChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "";
            query = "select * from reservaiton_table where room_no='" + roomNoLB.SelectedItem + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                roomLB.Text = reader.GetString(9);
                cnameLB.Text = reader.GetString(1);
                sexLB.Text= reader.GetString(2);
                contactLB.Text= reader.GetString(3);
                addressLB.Text= reader.GetString(4);
                arrivalLB.Text= reader.GetString(6);
                durationLB.Text= reader.GetString(8);
                departureLB.Text = reader.GetString(7);
                
            }
            else
            {
                roomLB.Text = "";
                cnameLB.Text = "";
                sexLB.Text = "";
                contactLB.Text = "";
                addressLB.Text = "";
                arrivalLB.Text = "";
                durationLB.Text = "";
                departureLB.Text = "";
            }
            con.Close();
        }

        private void ViewRoomDetails_Load(object sender, EventArgs e)
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
                    roomNoLB.Items.Add(room_number);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
