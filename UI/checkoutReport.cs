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
    public partial class checkoutReport : Form
    {
        MySqlConnection con = DAL.DatabaseConnect.Initialize();
        string id, name, inDate, outDate, roomNo, roomCost, foodCost, advance, due;
        public checkoutReport(string customer_id)
        {
            InitializeComponent();
            cIdTB.Text = customer_id;
        }

        private void showBT_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "";
            query = "select * from report_table where c_id='" + cIdTB.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                id = reader.GetString(0);
                name = reader.GetString(1);
                inDate = reader.GetString(4);
                outDate = reader.GetString(5);
                roomNo = reader.GetString(7);
                roomCost = reader.GetString(10);
                foodCost = reader.GetString(11);
                advance = reader.GetString(12);
                due = reader.GetString(13);
                con.Close();
            }
            else
                MessageBox.Show("No value");
            
            List<ReportParameter> rptPara = new List<ReportParameter>();
            rptPara.Add(new ReportParameter("id", id));
            rptPara.Add(new ReportParameter("name", name));
            rptPara.Add(new ReportParameter("inDate", inDate));
            rptPara.Add(new ReportParameter("outDate", outDate));
            rptPara.Add(new ReportParameter("roomNo", roomNo));
            rptPara.Add(new ReportParameter("roomCost", roomCost));
            rptPara.Add(new ReportParameter("foodCost", foodCost));
            rptPara.Add(new ReportParameter("advance", advance));
            rptPara.Add(new ReportParameter("due", due));
            reportViewer1.LocalReport.SetParameters(rptPara);
            this.reportViewer1.RefreshReport();
        }

        private void backKBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void checkoutReport_Load(object sender, EventArgs e)
        {
            
        }
    }
}
