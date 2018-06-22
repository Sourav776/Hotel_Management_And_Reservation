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
    public partial class Calculator : Form
    {
        double value;
        string operation;
        bool pressed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void offBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            dotBT.Enabled = true;
            resultTB.Text = "0";
        }

        private void signBT_Click(object sender, EventArgs e)
        {
            double res = Double.Parse(resultTB.Text);
            res = -res;
            resultTB.Text = res.ToString();
        }
        private void oneBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text=resultTB.Text+'1';
        }

        private void twoBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '2';
        }

        private void threeBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '3';
        }

        private void fourBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '4';
        }

        private void fiveBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '5';
        }

        private void sixBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '6';
        }

        private void sevenBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '7';
        }

        private void eightBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '8';
        }

        private void nineBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '9';
        }

        private void zeroBT_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '0';
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            dotBT.Enabled = true;
            pressed=true;
            operation = "+";
            value = Double.Parse(resultTB.Text);
        }

        private void subBT_Click(object sender, EventArgs e)
        {
            dotBT.Enabled = true;
            pressed=true;
            operation = "-";
            value = Double.Parse(resultTB.Text);
        }

        private void mulBT_Click(object sender, EventArgs e)
        {
            dotBT.Enabled = true;
            pressed=true;
            operation = "*";
            value = Double.Parse(resultTB.Text);
        }

        private void divBT_Click(object sender, EventArgs e)
        {
            dotBT.Enabled = true;
            pressed=true;
            operation = "/";
            value = Double.Parse(resultTB.Text);
        }

        private void equalBT_Click(object sender, EventArgs e)
        {
            dotBT.Enabled = true;
            switch(operation)
            {
                case "+":
                    resultTB.Text=(value+Double.Parse(resultTB.Text)).ToString();
                    break;
                case "-":
                    resultTB.Text=(value-Double.Parse(resultTB.Text)).ToString();
                    break;
                case "*":
                    resultTB.Text=(value*Double.Parse(resultTB.Text)).ToString();
                    break;
                case "/":
                    resultTB.Text=(value/Double.Parse(resultTB.Text)).ToString();
                    break;
                default:
                    break;
                
            }
        }

        private void dotBT_Click(object sender, EventArgs e)
        {
            dotBT.Enabled = false;
            
            if (resultTB.Text == "0"||pressed==true)
                resultTB.Clear();
            pressed = false;
            resultTB.Text = resultTB.Text + '.';
        }

        private void percentBT_Click(object sender, EventArgs e)
        {
            double p = Double.Parse(resultTB.Text);
            resultTB.Text = (value * p / 100).ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void resultTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
