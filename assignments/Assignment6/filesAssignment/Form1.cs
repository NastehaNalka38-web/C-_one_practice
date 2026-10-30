using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace filesExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            StreamWriter reads;
            
            reads = File.CreateText("C:\\Users\\Wireless\\Documents\\assignmentFile\\ca244.txt");

            reads.WriteLine("Welcome to C#");
            reads.WriteLine("This is my first file.");
            reads.WriteLine("That is Nasteha Nalka");
            reads.WriteLine("She is web designer & developer! you know😎");

            reads.Close();
            MessageBox.Show("File created successfuly!");
        }

        private void createInputFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader Reads;

                string line;

                Reads = File.OpenText("C:\\Users\\Wireless\\Documents\\assignmentFile\\ca244.txt");

                while (Reads.EndOfStream == false)
                {
                    line = Reads.ReadToEnd();
                    listBox1.Items.Add(line);
                }

                Reads.Close();
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            File.Delete("C:\\Users\\Wireless\\Documents\\assignmentFile\\ca244.txt");
            MessageBox.Show("File Deleted Successfuly!");
        }
    }
}
