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
using MySql.Data.MySqlClient;

namespace hotel_managemnet_and_reservation_system.UI
{
    
    public partial class CheckInDetails : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        public CheckInDetails()
        {
            InitializeComponent();
        }

        private void CheckInDetails_Load(object sender, EventArgs e)
        {
          
            con.Open();
            string query = "select * from reservaiton_table where c_id = (SELECT MAX(c_id) FROM reservaiton_table) ;";
            MySqlCommand cmnd = new MySqlCommand(query, con);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmnd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message" + ex);
                con.Close();
            }
        }
      

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
