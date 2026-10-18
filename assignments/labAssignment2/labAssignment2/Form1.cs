using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labAssignment2
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


        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //declare variable
            int caloriesFromFat, fatGram, numOfCalories, percentage;

            //chect if its numeric
            if (int.TryParse(txtNumOfColories.Text, out numOfCalories) &&
                int.TryParse(txtFatGram.Text, out fatGram))
            {
                //calories cannot less than 0
                if (numOfCalories < 0)
                {
                    MessageBox.Show("Number of colories must be greater than 0");
                    txtNumOfColories.Focus();
                }
                //fat gram cannot less than 0
                else if (fatGram < 0)
                {
                    MessageBox.Show("Fat gram cannot less than 0");
                    txtFatGram.Focus();
                }
                else if (fatGram * 9 > numOfCalories)
                {
                    MessageBox.Show("Colories from fat cannot exceed total colories");
                    txtFatGram.Focus();
                }
                else
                {
                    //calculate
                    caloriesFromFat = fatGram * 9;
                    percentage = (caloriesFromFat * 100) / numOfCalories;

                    //display
                    listBox1.Items.Clear();
                    listBox1.Items.Add(numOfCalories +" colories,   " + fatGram + " Fat grams");
                    listBox1.Items.Add("Percentage of colories from fat: " + percentage + "%");

                    //check if persentage < 36%
                    if (percentage < 36)
                    {
                        ckLowFat.Checked = true;
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers");
                txtNumOfColories.Focus();
            }
        }

    }
}
