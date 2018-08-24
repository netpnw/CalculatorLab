using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {

        private float val = 0;
        private float x;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            val = val * 10 + 4;
            lblDisplay.Text = val.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            val = val * 10 + 7;
            lblDisplay.Text = val.ToString();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            val = val * 10;
            lblDisplay.Text = val.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            val = val * 10 + 1;
            lblDisplay.Text = val.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            val = val * 10 + 2;
            lblDisplay.Text = val.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            val = val * 10 + 3;
            lblDisplay.Text = val.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            val = val * 10 + 5;
            lblDisplay.Text = val.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            val = val * 10 + 6;
            lblDisplay.Text = val.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            val = val * 10 + 8;
            lblDisplay.Text = val.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            val = val * 10 + 9;
            lblDisplay.Text = val.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            val = val * 0;
            lblDisplay.Text = val.ToString();

        }
        private int num = 0;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (num == 0) val = x - val;
            else if (num == 1) val = x + val;
            else if (num == 2) val = x * val;
            else val = x / val;


            lblDisplay.Text = val.ToString();
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            x = val;
            val = 0;
         

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            x = val;
            val = 0;
            num = 1;
     
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            x = val;
            val = 0;
            num = 2;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            x = val;
            val = 0;
            num = 3;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            
        }

		double p1 = 0;
		double p2 = 0;
		double p3 = 0;
		private void btnPercent_Click(object sender, EventArgs e)
		{
			p = double.Parse(lblDisplay.Text);
			if(p1 == 0)
			{
				p = p / 100;
			}
			else
			{
				p = (p / 100) * p1;
			}
			if (n % 1 == 0)
			{
				countDot = 0;
			}
			else countDot = 1;
			lblDisplay.Text = p.ToString();
		}
	}
}
