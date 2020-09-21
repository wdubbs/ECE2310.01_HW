using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sale = Convert.ToDouble(saleIn.Text);
            sales.Text = String.Format("${0:0.00}", sale);

            double profitRate = .045;
            if (sale < 1000.01)
            {
                profitRate = .03;
            }
            else if (sale < 5000.01)
            {
                profitRate = .035;
            }
            else if (sale < 10000.01)
            {
                profitRate = .04;
            }

            Ratio.Text = Convert.ToString(Math.Round(profitRate * 100,1)) + "%";
            Profit.Text = String.Format("${0:0.00}", profitRate*sale);
        }
    }
}
