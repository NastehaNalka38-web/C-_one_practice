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

namespace FilesAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateFileBtn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

            StreamWriter writer = File.CreateText(path);

            writer.Close();
        }


        private void appendFileBtn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

            string name = "Nalka";
            int age = 20;
            string course = "data structure";

            string info = name + " \n" + age + " \n" + course;

            File.WriteAllText(path, info);
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

            string content = File.ReadAllText(path);

            listBox1.Items.Add(content);
        }




        private void deleteItemFile_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

            File.WriteAllText(path, "");

            MessageBox.Show("File content deleted successfully!");
            listBox1.Items.Clear();
        }


        private void deleteFileBtn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

            if (File.Exists(path))
            {
                File.Delete(path);

                MessageBox.Show("File deleted successfully!");
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("File does not exist.");
            }
        }
    }
}
