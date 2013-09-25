using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mockup {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            string text=this.textBox1.Text;

            double n;
            if (!double.TryParse(text,out n))
            {
                this.textBox1.Text = "Error:Invalid Number";
            }
            this.textBox1.Text = Math.Sqrt(n).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "/";
        }

        private double total1 = 0;
        private double total2 = 0;

        private bool plusButtonClicked;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(textBox1.Text);
            textBox1.Clear();

            plusButtonClicked = true;
        }

        private bool btnMultiplyClicked;
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 *= double.Parse(textBox1.Text);
            textBox1.Clear();

            btnMultiplyClicked = true;
        }

        private bool btnSubtractClicked;
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            total1 -= double.Parse(textBox1.Text);
            textBox1.Clear();

            btnSubtractClicked = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked)
            {
                total2 = total1 + double.Parse(textBox1.Text);
                textBox1.Text = total2.ToString();
                total1 = 0;
            }
        }
    }
}
