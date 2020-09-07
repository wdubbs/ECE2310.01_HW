using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e) //add
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double sum = num1 + num2;
            textBox3.Text = $"{num1} + {num2} = {sum}";
        }

        private void button2_Click(object sender, EventArgs e) //subtract
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double sum = num1 - num2;
            textBox3.Text = $"{num1} - {num2} = {sum}";
        }

        private void button3_Click(object sender, EventArgs e) //multiply
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double sum = num1 * num2;
            textBox3.Text = $"{num1} * {num2} = {sum}";
        }

        private void button4_Click(object sender, EventArgs e) //average
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double sum = (num1 + num2)/2;
            textBox3.Text = $"average of {num1} & {num2} is: {sum}";
        }

        private void button5_Click(object sender, EventArgs e) //clear
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) //exit
        {
            Application.Exit();
        }
    }
}
