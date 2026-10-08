using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmrnt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateBtn_Click(object sender, EventArgs e)
        {
            string dayName, monthName, numericMonth, Year, fullInfoDate;

            dayName = txtDayOfWeek.Text;
            monthName = txtNameOfMonth.Text;
            numericMonth = txtNumricDay.Text;
            Year = txtYear.Text;

            fullInfoDate = dayName + ", " + monthName + " " + numericMonth + ", " + Year;

            dateOutput.Text = fullInfoDate;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dateOutput.Text = "";
            txtDayOfWeek.Text = "";
            txtNameOfMonth.Text = "";
            txtNumricDay.Text = "";
            txtYear.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
