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
    public partial class myHelp : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public myHelp()
        {
            InitializeComponent();
        }

        private void checkInBT_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Visible = true;
        }

        private void foodMenuBT_Click(object sender, EventArgs e)
        {

        }

        private void checkOutBT_Click(object sender, EventArgs e)
        {

        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCustomerBT_Click(object sender, EventArgs e)
        {
            int book=0;
            con.Open();
            string query = "";
            query = "SELECT COUNT(book) FROM reservaiton_table where book='1';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                book=int.Parse(reader.GetString(0));
                MessageBox.Show("Total number of Booked rooms:  "+book.ToString());
            }
            reader.Close();
            con.Close();
        }
    }
}
