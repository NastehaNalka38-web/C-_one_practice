using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            //declaring constant for tax amount, fixed charge and initializing it
            const double TAX_AMOUNT = 0.07;
            const double FIXED_CHARGE = 5.00;


            //declaring variables 
            double previous, current, pricePerUnit, electricityUsage, taxAmount, totalBill;

    
            //initializing and getting user input
            previous = double.Parse(txtPrevious.Text);
            current = double.Parse(txtCurrent.Text);
            pricePerUnit = double.Parse(txtPrice.Text);

            //calculating electricity usage
            electricityUsage = current - previous;
            taxAmount = electricityUsage * pricePerUnit * TAX_AMOUNT;
            totalBill = (electricityUsage * pricePerUnit) + taxAmount + FIXED_CHARGE;

            //displaying the result using labels
            lblElectricityOutput.Text = electricityUsage.ToString("F2");
            lblTaxOutput.Text = ("$"+taxAmount.ToString("F2"));
            lblTotalBillOutput.Text = ("$"+totalBill.ToString("F2"));
        }
    }
}
