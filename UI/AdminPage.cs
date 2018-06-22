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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Visible = true;
            this.Close();
        }

        private void manageUserBT_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Visible = true;
            this.Visible = false;
        }

        private void roomManageBT_Click(object sender, EventArgs e)
        {
            ManageRoom mr = new ManageRoom();
            mr.Show();
            this.Visible = false;
        }
    }
}
