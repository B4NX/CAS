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
            total1 += double.Parse(textBox1.Text);
            textBox1.Clear();

            btnMultiplyClicked = true;
        }

        private bool btnSubtractClicked;
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            total1 += double.Parse(textBox1.Text);
            textBox1.Clear();

            btnSubtractClicked = true;
        }
        private bool btnDivideClicked;
        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(textBox1.Text);
            textBox1.Clear();

            btnDivideClicked = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double output=0;
            double.TryParse(textBox1.Text, out output);

            if (plusButtonClicked)
            {
                total2 = output+total1;
                textBox1.Text = total2.ToString();
                total1 = 0;
                plusButtonClicked = false;
            }
            else if (btnSubtractClicked)
            {
                total2 = total1-output;
                textBox1.Text = total2.ToString();
                total1 = 0;
                btnSubtractClicked = false;
            } 
            else if (btnMultiplyClicked)
            {
                total2 = total1 * output;
                textBox1.Text = total2.ToString();
                total1 = 0;
                btnMultiplyClicked = false;
            } 
            else if (btnDivideClicked)
            {
                total2 = total1 / output;
                textBox1.Text = total2.ToString();
                total1 = 0;
                btnDivideClicked = false;
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = temp.Text;
            } else textBox1.Text += temp.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.total1 = 0;
            this.total2 = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ulong n;
            ulong.TryParse(textBox1.Text, out n);
            try
            {
                textBox1.Text = Factorial(n).ToString();
            } catch (StackOverflowException er)
            {
                System.Diagnostics.Debug.WriteLine(er);
            }
        }
        private static double Factorial(ulong d)
        {
            System.Diagnostics.Debug.WriteLine(d);
            if (d == 1 || d == 0)
            {
                return 1;
            }
            return d * Factorial(d - 1);
        }

        private long Factorial_Func(long n){
            if (n==0||n==1){ return 1;}
            
            long temp=n;
            long holder=1;

            while (temp != 0)
            {
                holder = holder * temp;
                temp--;
            }

            return 0;
        }
    }
}
