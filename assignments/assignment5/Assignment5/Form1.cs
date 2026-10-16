using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //declare variables
        string classType, reason;
        int passengerAge, numOfTickets, baggageWeight;
        double ticketCost, totalCost, travelInsuranceCost, discount, seniorDiscount, childDiscount;

        bool bookingAproved;
        double ticketPrice; 

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            bookingAproved = false;
            reason = "";
            ticketPrice = 0;
            ticketCost = 0;
            totalCost = 0;
            discount = 0;
            travelInsuranceCost = 0;
            childDiscount = 0;
            seniorDiscount = 0;


            //validation
            if (!int.TryParse(txtPassengerAge.Text, out passengerAge) ||
                !int.TryParse(txtNumOfTicket.Text, out numOfTickets) ||
                !int.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

    

            if(txtPassengerName.Text == "")
            {
                MessageBox.Show("Please enter the name.");
            }
            else
            {
                // check if valid age
                if (passengerAge < 1 || passengerAge > 100)
                {
                    MessageBox.Show("Please enter a valid age between 1 and 100.");
                    bookingAproved = false;
                    passengerAge = 0;
                    txtPassengerAge.Focus();
                    reason = "Do not enter valid age";
                }
                else
                {
                    //check number of tickets
                    if (numOfTickets < 1 || numOfTickets > 5)
                    {
                        MessageBox.Show("Please enter a valid number of tickets between 1 and 5.");
                        bookingAproved = false;
                        txtNumOfTicket.Focus();
                        reason = "Do not enter valid ticket number";
                    }
                    else
                    {
                        //check baggage weight
                        if (baggageWeight < 1 || baggageWeight > 50)
                        {
                            MessageBox.Show("Please enter a valid baggage weight between 1 and 50 kg.");
                            bookingAproved = false;
                            txtBaggageWeight.Focus();
                            reason = "Do not enter valid baggage weight";
                        }
                        else
                        {
                            //calculate ticket cost based on class
                            if (rFirstClass.Checked)
                            {
                                if (passengerAge < 12)
                                {
                                    MessageBox.Show("Passengers below 12 years cannot book First Class");
                                    bookingAproved = false;
                                    reason = "Passenger Age is less than 12 and selects first class";
                                }
                                else
                                {
                                    classType = "First Class";
                                    bookingAproved = true;
                                    ticketPrice = 300;
                                }
                            }
                            else if (rNormalClass.Checked)
                            {
                                classType = "Normal Class";
                                ticketPrice = 100;
                                bookingAproved = true;
                            }
                            else if (rBusinessClass.Checked)
                            {
                                classType = "Business Class";
                                ticketPrice = 200;
                                bookingAproved = true;
                            }
                            else
                            {
                                MessageBox.Show("please select travel classes");
                            }

                            //calculate ticket cost
                            ticketCost = ticketPrice * numOfTickets;

                            //calculate discount
                            if (numOfTickets >= 1 & numOfTickets <= 2)
                            {
                                discount = 0;
                            }

                            else if (numOfTickets >= 3 & numOfTickets <= 4)
                            {
                                discount = 0.05;
                            }
                            else
                            {
                                discount = 0.10;
                            }

                            //discount amount
                            double discountAmount = ticketCost * discount;

                            if (bookingAproved)
                            {
                                if (ckTravelInsurance.Checked)
                                {
                                    travelInsuranceCost = 25 * numOfTickets;
                                }
                                else
                                {
                                    travelInsuranceCost = 0;
                                }
                            }
                            else
                            {
                                travelInsuranceCost = 0;
                                ckTravelInsurance.Checked = false;
                            }

                            //total cost
                            totalCost = ticketCost - discountAmount + travelInsuranceCost;

                            //child discount
                            if (passengerAge < 12)
                            {
                                childDiscount = totalCost * 0.20;
                                totalCost -= childDiscount;
                            }
                            else
                            {
                                childDiscount = 0;
                            }

                            //senior discount
                            if (passengerAge >= 60)
                            {
                                seniorDiscount = 0.10 * totalCost;
                                totalCost -= seniorDiscount;
                            }
                            else
                            {
                                seniorDiscount = 0;
                            }
                        }
                    }
                }
            }

            listBox1.Items.Clear();

            listBox1.Items.Add("=========================");
            listBox1.Items.Add("Passenger Name: " + txtPassengerName.Text);
            listBox1.Items.Add("Passenger Age: " + passengerAge);
            listBox1.Items.Add("Travel Class: " + classType);
            listBox1.Items.Add("Baggage Weight: " + baggageWeight +"kg");

            listBox1.Items.Add("-------------------------");
            listBox1.Items.Add("Rate Per Ticket: $" + ticketPrice.ToString("F2"));
            listBox1.Items.Add("Discount Rate: " + discount.ToString("P0"));
            listBox1.Items.Add("Travel Insurance Cost: $" + travelInsuranceCost.ToString("F2"));
            listBox1.Items.Add("Child Discount: $" + childDiscount.ToString("F2"));
            listBox1.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));

            listBox1.Items.Add("-------------------------");
            listBox1.Items.Add("Total Cost: $" + totalCost.ToString("F2"));
            listBox1.Items.Add("=========================");

            listBox1.Items.Add("");
            listBox1.Items.Add("==========================");
            //check if aproved
            if (bookingAproved)
            {
                listBox1.Items.Add("Booking Status: APPROVED");

            }
            else
            {
                listBox1.Items.Add("Booking Status: REJECTED");
                listBox1.Items.Add("The Reason For That is, ");
                listBox1.Items.Add("" + reason);
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumOfTicket.Clear();
            txtBaggageWeight.Clear();
            rFirstClass.Checked = false;
            rNormalClass.Checked = false;
            rBusinessClass.Checked = false;
            ckTravelInsurance.Checked = false;
            listBox1.Items.Clear();
        }

        
    }
}
