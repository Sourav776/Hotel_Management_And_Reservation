using Microsoft.Reporting.WinForms;
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
    public partial class Food_Report : Form
    {
        string date, id, name, bill;
        public Food_Report(string d, string cid, string cname, string cbill)
        {
            InitializeComponent();
            date = d;
            id = cid;
            name = cname;
            bill = cbill;
        }

        private void backKBT_Click(object sender, EventArgs e)
        {
            Food f=new Food();
            this.Close();
        }

        private void showBT_Click(object sender, EventArgs e)
        {
          
            List<ReportParameter> rptPara = new List<ReportParameter>();
            rptPara.Add(new ReportParameter("date", date));
            rptPara.Add(new ReportParameter("id", id));
            rptPara.Add(new ReportParameter("name", name));
            rptPara.Add(new ReportParameter("total", bill));
            reportViewer1.LocalReport.SetParameters(rptPara);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
