using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showInfoBtn_Click(object sender, EventArgs e)
        {
            //declaring variables
            string stdName, stdId, department, semester, fullInformation;

            //initializing values from the user
            stdName = txtStudentName.Text;
            stdId = txtStudentId.Text;
            department = txtDepartment.Text;
            semester = txtStudentSem.Text;

            fullInformation = "Name: " + stdName + ",      " + "ID: " + stdId + "    " +

                "  "+ "  \n\nDepartment: " + department + ",            " + "Semester: " + semester;


            //displaying output 
            lblOutput.Text = fullInformation;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // to clear info use clear() methos or empty string ""
            txtStudentSem.Clear();
            txtStudentName.Clear();
            txtStudentId.Clear();
            txtDepartment.Clear();
            lblOutput.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //to exit the whole application use Exit() method
            Application.Exit();
        }
    }
}
