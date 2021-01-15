using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek15_WarungBuDewi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int total1 = Form1.total;
            labelSubtotal.Text = Form1.total.ToString();
            int tax = total1 / 10;
            labelTax.Text = tax.ToString();
            int afterdiscount = total1 * discount / 100;
            labelDiscount.Text = afterdiscount.ToString();
            int totalbeneran = total1 + tax - discount;
            labelTotal.Text = totalbeneran.ToString();
        }

        private void labelSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public static int discount = 0;
        private void checkBoxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiscount.Checked == true)
            {
                labelInput.Visible = true;
                textBox1.Visible = true;
                labelpersen.Visible = true;
            }
            else if (checkBoxDiscount.Checked == false)
            {
                labelInput.Visible = false;
                labelpersen.Visible = false;
                textBox1.Visible = false;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            discount = Convert.ToInt32(textBox1.Text);
        }

        private void labelInput_Click(object sender, EventArgs e)
        {

        }
    }
}
