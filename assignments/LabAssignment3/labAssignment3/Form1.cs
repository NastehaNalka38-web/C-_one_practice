using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //declaring variables
            int numOfPackage, Age;
            double pricePerPackage, discountAmount,discountRate, subTotal, totalAmount;

            if(int.TryParse(txtNumOfPackage.Text, out numOfPackage) & double.TryParse(txtPrice.Text, out pricePerPackage) & int.TryParse(txtAge.Text, out Age))
            {
                if (numOfPackage > 0 & pricePerPackage > 0 & Age >0)
                {
                    if(Age > 25)
                    {
                        //Calculate Subtotal
                        subTotal = numOfPackage * pricePerPackage;

                        if (numOfPackage >= 10 & numOfPackage <= 19)
                        {
                            discountRate = 20;
                            discountAmount = (subTotal * 0.2);

                        }
                        else if (numOfPackage >= 20 & numOfPackage <= 49)
                        {
                            discountRate = 30;
                            discountAmount = (subTotal * 0.3);
                        }
                        else if (numOfPackage >= 50 & numOfPackage <= 99)
                        {
                            discountRate = 40;
                            discountAmount = (subTotal * 0.4);
                        }
                        else if (numOfPackage >= 100)
                        {
                            discountRate = 50;
                            discountAmount = (subTotal * 0.5);
                        }
                        else
                        {
                            discountRate = 0;
                            discountAmount = 0;
                        }

                        //CALCULATE TOTAL AMOUNT
                        totalAmount = subTotal - discountAmount;

                        //DISPLAY THE RESULTS
                        listBox1.Items.Clear();
                        listBox1.Items.Add("---Sotfware sales results-----");
                        listBox1.Items.Add("");
                        listBox1.Items.Add("Number of Package : " + numOfPackage);
                        listBox1.Items.Add("");
                        listBox1.Items.Add("Price per package : $" + pricePerPackage.ToString("f2"));
                        listBox1.Items.Add("");
                        listBox1.Items.Add("Subtotal (Before discount) : $" + subTotal.ToString("f2"));
                        listBox1.Items.Add("");
                        listBox1.Items.Add("Discount Rate : " + discountRate + "%");
                        listBox1.Items.Add("");
                        listBox1.Items.Add("Discount Amount : $" + discountAmount.ToString("f2"));
                        listBox1.Items.Add("");
                        listBox1.Items.Add("Total Amount (After Discount) : $" + totalAmount.ToString("f2"));
                    }
                    else
                    {
                        MessageBox.Show("Age must be gratear 25");
                    }
                }
                else
                {
                    MessageBox.Show("number of pacckage and price number caanot less than 0");
                }

            }
            else
            {
                MessageBox.Show("Enter valid number");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtNumOfPackage.Clear();
            txtPrice.Clear();
            listBox1.Items.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
