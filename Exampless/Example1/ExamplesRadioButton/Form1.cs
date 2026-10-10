using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamplesRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //creating variable
            string name, gender;
            string faculty = "";
            int age, validation;
            if(int.TryParse(txtAge.Text, out validation))
            {
                if(radioMale.Checked)
                {
                    gender = "Male";
                    Output_Data.Items.Add("\nName: " + txtName.Text + ",   \nAge: " + txtAge.Text + ",    \n Gender: " + gender);
                }
                else if (radioFemale.Checked)
                {
                    gender = "Female";
                    Output_Data.Items.Add("\nName: " + txtName.Text + ",        \nAge: " + txtAge.Text + ",     \n Gender: " + gender);
                }
                else
                {
                    MessageBox.Show("Please select a gender.");
                }

                if(computerChecbox.Checked & businessCheckBox.Checked & ITCheckBox.Checked)
                {
                    faculty = "Computer Science, Business, IT";
                    Output_Data.Items.Add("\nFaculty: " + faculty);

                }
                else if (computerChecbox.Checked & businessCheckBox.Checked)
                {
                    faculty = "Computer Science, Business";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }
                else if (computerChecbox.Checked & ITCheckBox.Checked)
                {
                    faculty = "Computer Science, IT";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }
                else if (businessCheckBox.Checked & ITCheckBox.Checked)
                {
                    faculty = "Business, IT";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }
                else if(businessCheckBox.Checked && computerChecbox.Checked)
                {
                    faculty = "Business, Computer Science";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }

                else if (ITCheckBox.Checked && computerChecbox.Checked)
                {
                    faculty = "IT, Computer Science";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }
                else if (ITCheckBox.Checked && businessCheckBox.Checked)
                {
                    faculty = "IT, Business";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }
                else if (computerChecbox.Checked)
                {
                    faculty = "Computer Science";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }
                else if (businessCheckBox.Checked)
                {
                    faculty = "Business";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }
                else if (ITCheckBox.Checked)
                {
                    faculty = "IT";
                    Output_Data.Items.Add("\nFaculty: " + faculty);
                }
                else
                {
                    MessageBox.Show("Please select a faculty.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid integer for age.");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtName.Clear();
            Output_Data.Items.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            computerChecbox.Checked = false;
            businessCheckBox.Checked = false;
            ITCheckBox.Checked = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
