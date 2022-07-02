using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
           label1.ResetText();
        }



        private void button16_Click(object sender, EventArgs e)
        {
            oprator_lable.Text = "%";
            ShowTop();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            oprator_lable.Text = "*";
            ShowTop();
        }



        private void button11_Click(object sender, EventArgs e)
        {
            oprator_lable.Text = "-";
            ShowTop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oprator_lable.Text = "+";
            ShowTop();
        }


        private void AddNumber(object sender, EventArgs e)
        {
            Button num = sender as Button;
            label1.Text += num.Text;
        }

        private void ShowTop()
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                first_num_lable.Text = label1.Text;
            }
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double.TryParse(first_num_lable.Text, out double fn);
            double.TryParse(label1.Text, out double sn);
            double res = 0;


            switch (oprator_lable.Text)
            {
                case "+":
                    res = fn + sn;
                    break;
                case "-":
                    res = fn - sn;
                    break;
                case "*":
                    res = fn * sn;
                    break;
                case "%":
                    res = fn / sn;
                    break;
            }

            label1.Text = res.ToString();
            oprator_lable.Text = string.Empty;
            first_num_lable.ResetText();
            ShowTop();
        }


    }
}
