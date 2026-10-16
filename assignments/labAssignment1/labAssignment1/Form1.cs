
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

        // Declare variables
        double totalCost = 0;
        string roomType, guestName;
        int guestAge, numOfNights, numOfGuests;

        double breakfastCost, discountAmount, DiscountRate;

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNumOfNights.Clear();
            txtNumOfGuests.Clear();
            rStandard.Checked = false;
            rNormal.Checked = false;
            rHight.Checked = false;
            checkBreakFast.Checked = false;
            listBox1.Items.Clear();
        }

        double RoomCost, Rate, serviceCharge, seniorDiscount;

        const int STANDAR_RATE = 50;
        const int NORMAL_RATE = 80;
        const int HIGH_RATE = 130;

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Reset variables for every new calculation
            totalCost = 0;
            breakfastCost = 0;
            discountAmount = 0;
            DiscountRate = 0;
            RoomCost = 0;
            Rate = 0;
            serviceCharge = 0;
            seniorDiscount = 0;

            guestAge = 0;
            numOfNights = 0;
            numOfGuests = 0;

            roomType = "";
            guestName = txtGuestName.Text.Trim();

            // Bool flag: determine whether booking is approved
            bool isApproved = true;


            // 1. Validate Guest Name
            if (txtGuestName.Text == "")
            {
                MessageBox.Show("Guest Name cannot be empty.");
                isApproved = false;
            }
            else
            {
                guestName = txtGuestName.Text.Trim();

                // 2. Validate Guest Age
                if (!int.TryParse(txtGuestAge.Text, out guestAge))
                {
                    MessageBox.Show("Please enter a valid Guest Age.");
                    isApproved = false;
                }
                else if (guestAge < 18 || guestAge > 90)
                {
                    MessageBox.Show("Guest age must be between 18 and 90.");
                    isApproved = false;
                }
                else
                {
                    // 3. Validate Number of Nights
                    if (!int.TryParse(txtNumOfNights.Text, out numOfNights))
                    {
                        MessageBox.Show("Please enter a valid Number of Nights.");
                        isApproved = false;
                    }
                    else if (numOfNights < 1 || numOfNights > 30)
                    {
                        MessageBox.Show("Number of nights must be between 1 and 30.");
                        isApproved = false;
                    }
                    else
                    {
                        // 4. Validate Number of Guests
                        if (!int.TryParse(txtNumOfGuests.Text, out numOfGuests))
                        {
                            MessageBox.Show("Please enter a valid Number of Guests.");
                            isApproved = false;
                        }
                        else if (numOfGuests < 1 || numOfGuests > 6)
                        {
                            MessageBox.Show("Number of guests must be between 1 and 6.");
                            isApproved = false;
                        }
                        else
                        {
                            // 5. Check Room Type
                            if (rStandard.Checked)
                            {
                                roomType = "Standard";

                                if (numOfGuests > 2)
                                {
                                    MessageBox.Show(
                                        "Standard room can accommodate a maximum of 2 guests.");
                                    isApproved = false;
                                }
                            }
                            else if (rNormal.Checked)
                            {
                                roomType = "Normal";

                                if (numOfGuests > 4)
                                {
                                    MessageBox.Show(
                                        "Normal room can accommodate a maximum of 4 guests.");
                                    isApproved = false;
                                }
                            }
                            else if (rHight.Checked)
                            {
                                roomType = "High";

                                if (numOfGuests > 6)
                                {
                                    MessageBox.Show(
                                        "High room can accommodate a maximum of 6 guests.");
                                    isApproved = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select a room type.");
                                isApproved = false;
                            }

                            // 6. Calculation only if validation is passed
                            if (isApproved)
                            {
                                // Determine Room Rate
                                switch (roomType)
                                {
                                    case "Standard":
                                        Rate = STANDAR_RATE;
                                        break;

                                    case "Normal":
                                        Rate = NORMAL_RATE;
                                        break;

                                    case "High":
                                        Rate = HIGH_RATE;
                                        break;
                                }

                                // Calculate Room Cost
                                RoomCost = numOfGuests * numOfNights * Rate;

                                // 7. Calculate Night Discount using if else
                                if (numOfNights >= 1 && numOfNights <= 4)
                                {
                                    DiscountRate = 0;
                                }
                                else if (numOfNights >= 5 && numOfNights <= 9)
                                {
                                    DiscountRate = 0.05;
                                }
                                else
                                {
                                    DiscountRate = 0.12;
                                }

                                // Calculate Discount Amount
                                discountAmount = RoomCost * DiscountRate;

                                // 8. Calculate Breakfast Cost
                                if (checkBreakFast.Checked)
                                {
                                    breakfastCost = 10 * numOfGuests * numOfNights;
                                }
                                else
                                {
                                    breakfastCost = 0;
                                }

                                // 9. Calculate Total after Night Discount
                                totalCost = RoomCost - discountAmount + breakfastCost;

                                // 10. Calculate Service Charge (5% for more than 4 guests)
                                if (numOfGuests > 4)
                                {
                                    serviceCharge = totalCost * 0.05;
                                    totalCost = totalCost + serviceCharge;
                                }
                                else
                                {
                                    serviceCharge = 0;
                                }

                                // 11. Calculate Senior Discount (5% for age 60+)
                                if (guestAge >= 60)
                                {
                                    seniorDiscount = totalCost * 0.05;
                                    totalCost = totalCost - seniorDiscount;
                                }
                                else
                                {
                                    seniorDiscount = 0;
                                }
                            }
                        }
                    }
                }
            }

            // 12. Display Booking Result
            if (isApproved)
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("=========================");
                listBox1.Items.Add("Guest Name: " + guestName);
                listBox1.Items.Add("Guest Age: " + guestAge);
                listBox1.Items.Add("Room Type: " + roomType);
                listBox1.Items.Add("Rate Per Night: $" + Rate.ToString("F2"));
                listBox1.Items.Add("Number of Nights: " + numOfNights);
                listBox1.Items.Add("Number of Guests: " + numOfGuests);

                listBox1.Items.Add("-------------------------");
                listBox1.Items.Add("Room Cost: $" + RoomCost.ToString("F2"));
                listBox1.Items.Add("Discount Rate: " + DiscountRate.ToString("P0"));
                listBox1.Items.Add("Discount Amount: $" + discountAmount.ToString("F2"));
                listBox1.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("F2"));
                listBox1.Items.Add("Service Charge: $" + serviceCharge.ToString("F2"));
                listBox1.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));

                listBox1.Items.Add("-------------------------");
                listBox1.Items.Add("Total Cost: $" + totalCost.ToString("F2"));
                listBox1.Items.Add("=========================");

                listBox1.Items.Add("");
                listBox1.Items.Add("==========================");
                listBox1.Items.Add("Booking Status: APPROVED");

                //if (numOfNights >= 4)
                //{
                //    listBox1.Items.Add("Booking Status: APPROVED");

                //}
                //else
                //{
                //    listBox1.Items.Add("Booking Status: REJECTED");
                //}
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("");
                listBox1.Items.Add("==========================");
                listBox1.Items.Add("Booking Status: REJECTED");
            }

        }
    }
}
