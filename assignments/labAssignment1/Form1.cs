using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labAssignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //string guestName;
            int guestAge, numOfNights, numOfGuests;


            if (!int.TryParse(txtGuestAge.Text, out guestAge) || !int.TryParse(txtNumOfNights.Text, out numOfNights) || !int.TryParse(txtNumOfGuests.Text, out numOfGuests))
            {
                MessageBox.Show("Please enter valid numbers for all fields");
                return;
            }

            const int STANDAR_RATE = 50;
            const int NORMAR_RATE = 80;
            const int HIGH_RATE = 130;

            guestAge = int.Parse(txtGuestAge.Text);
            numOfNights = int.Parse(txtNumOfNights.Text);
            numOfGuests = int.Parse(txtNumOfGuests.Text);

            if (guestAge >= 18)
            {
                if (numOfNights > 1 & numOfNights < 30)
                {
                    if (numOfGuests > 1 & numOfGuests < 6)
                    {
                        // check if room type is selected
                        if (!rStandard.Checked && !rNormal.Checked && !rHight.Checked)
                        {
                            MessageBox.Show("Please select a room type");
                            return;
                        }
                        listBox1.Items.Add("===========");
                        listBox1.Items.Add("Guest Name: " + txtGuestName.Text);
                        listBox1.Items.Add("Guest Age: " + guestAge);
                        listBox1.Items.Add("Number of Guest: " + numOfGuests);
                        listBox1.Items.Add("Number of Nights: " + numOfNights);
                        if (rStandard.Checked)
                        {
                            listBox1.Items.Add("room Type: Standard");
                            if (numOfNights >= 1 && numOfNights <= 4)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (STANDAR_RATE * numOfNights * numOfGuests));
                            }
                            else if (numOfNights >= 5 && numOfNights <= 9)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (STANDAR_RATE * numOfNights * numOfGuests * 0.95));
                            }
                            else if (numOfNights >= 10 && numOfNights <= 30)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (STANDAR_RATE * numOfNights * numOfGuests * 0.88));
                            }
                            //check if breakfaast is selected to add 10% per night per guest
                            double totalCost = STANDAR_RATE * numOfNights * numOfGuests;
                            if (checkBreakFast.Checked)
                            {
                                listBox1.Items.Add("Breakfast: Yes");

                                double breakfastCost = STANDAR_RATE * numOfNights * numOfGuests + 10;

                                listBox1.Items.Add("Total Cost with Breakfast: " +
                                    (totalCost + breakfastCost));
                            }
                            else
                            {
                                listBox1.Items.Add("Breakfast: No");
                                listBox1.Items.Add("Total Cost: " + totalCost);
                            }

                        }
                        else if (rNormal.Checked)
                        {
                            listBox1.Items.Add("room Type: Normal");
                            if (numOfNights >= 1 && numOfNights <= 4)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (NORMAR_RATE * numOfNights * numOfGuests));
                            }
                            else if (numOfNights >= 5 && numOfNights <= 9)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (NORMAR_RATE * numOfNights * numOfGuests * 0.95));
                            }
                            else if (numOfNights >= 10 && numOfNights <= 30)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (NORMAR_RATE * numOfNights * numOfGuests * 0.88));
                            }
                            //check if breakfaast is selected to add 10% per night per guest
                            double totalCost = NORMAR_RATE * numOfNights * numOfGuests;
                            if (checkBreakFast.Checked)
                            {
                                listBox1.Items.Add("Breakfast: Yes");

                                double breakfastCost = NORMAR_RATE * numOfNights * numOfGuests + 10;

                                listBox1.Items.Add("Total Cost with Breakfast: " +
                                    (totalCost + breakfastCost));
                            }
                            else
                            {
                                listBox1.Items.Add("Breakfast: No");
                                listBox1.Items.Add("Total Cost: " + totalCost);
                            }
                        }

                        else if (rHight.Checked)
                        {
                            listBox1.Items.Add("room Type: Hight");
                            if (numOfNights >= 1 && numOfNights <= 4)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (HIGH_RATE * numOfNights * numOfGuests));
                            }
                            else if (numOfNights >= 5 && numOfNights <= 9)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (HIGH_RATE * numOfNights * numOfGuests * 0.95));
                            }
                            else if (numOfNights >= 10 && numOfNights <= 30)
                            {
                                listBox1.Items.Add("Total Cost: " +
                                    (HIGH_RATE * numOfNights * numOfGuests * 0.88));
                                
                            }
                            //check if breakfaast is selected to add 10% per night per guest
                            double totalCost = HIGH_RATE * numOfNights * numOfGuests;
                            if (checkBreakFast.Checked)
                            {
                                listBox1.Items.Add("Breakfast: Yes");

                                double breakfastCost = HIGH_RATE * numOfNights * numOfGuests + 10;

                                listBox1.Items.Add("Total Cost with Breakfast: " +
                                    (totalCost + breakfastCost));
                            }
                            else
                            {
                                listBox1.Items.Add("Breakfast: No");
                                listBox1.Items.Add("Total Cost: " + totalCost.ToString("0.00"));
                            }

                        }
                       

                    }

                    else
                    {
                        MessageBox.Show("Number of guests must be between 1 and 6");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Number of nights must be between 1 and 30");
                    }

                }
                else
                {
                    MessageBox.Show("Guest must be at least 18 years old");
                }





            
        }
    }
}
