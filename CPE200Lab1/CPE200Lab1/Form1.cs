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

        private double val = 0;
        private double x;
		

        public Form1()
        {
            InitializeComponent();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
			if(lblDisplay.Text == "0")
			{
				lblDisplay.Text = "";
			}
			lblDisplay.Text = lblDisplay.Text + "4";
		}

        private void btn7_Click(object sender, EventArgs e)
        {
			if (lblDisplay.Text == "0")
			{
				lblDisplay.Text = "";
			}
			lblDisplay.Text = lblDisplay.Text + "7";

		}

        private void btn0_Click(object sender, EventArgs e)
        {
			if (lblDisplay.Text == "0")
			{
				lblDisplay.Text = "";
			}
			lblDisplay.Text = lblDisplay.Text + "0";
		}

        private void btn1_Click(object sender, EventArgs e)
        {
			if (lblDisplay.Text == "0")
			{
				lblDisplay.Text = "";
			}
			lblDisplay.Text = lblDisplay.Text + "1";
		}

        private void btn2_Click(object sender, EventArgs e)
        {
			if (lblDisplay.Text == "0")
			{
				lblDisplay.Text = "";
			}
			lblDisplay.Text = lblDisplay.Text + "2";
		}

        private void btn3_Click(object sender, EventArgs e)
        {
			if (lblDisplay.Text == "0")
			{
				lblDisplay.Text = "";
			}
			lblDisplay.Text = lblDisplay.Text + "3";
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
			if (lblDisplay.Text.Contains("."))
			{
				return;
			}
			else
			{
				lblDisplay.Text = lblDisplay.Text + ".";
			}
        }
		
		
		private void btnPercent_Click(object sender, EventArgs e)
		{
			x = double.Parse(lblDisplay.Text);
			if (val == 0)
			{
				x = x / 100;
			}
			else
			{
				x = (x / 100) * val;
			}
			if (val % 1 == 0)
			{
				
			}
			

			lblDisplay.Text = x.ToString();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			int a = lblDisplay.Text.Length;
			if(lblDisplay.Text == "")
			{
				lblDisplay.Text = "";
			}
			else
			{
				lblDisplay.Text = lblDisplay.Text.Remove(a - 1);
			}
			
		}
	}
}
