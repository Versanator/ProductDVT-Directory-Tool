using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace Product_DVT_Directory_Tool
{
    public partial class Form1 : Form
    {
        public static string Level = "";
        public static string Path = @"\\hun-fs-sc\Engineering\ProductDVT";
        public static int Index = -999;
        public Form1()
        {
            InitializeComponent();
            folderBrowserDialog1.SelectedPath =Path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxLevel.SelectedIndex == 1)
            {
                folderBrowserDialog1.Description = "Select the parent board/system.";
                folderBrowserDialog1.ShowDialog();
                Path = folderBrowserDialog1.SelectedPath;
            }
            else if(comboBoxLevel.SelectedIndex == 2)
            {
                folderBrowserDialog1.Description = "Select parent board/system and revision number\nfor the new Software Configuration.";
                folderBrowserDialog1.ShowDialog();
                Path = folderBrowserDialog1.SelectedPath;
            }
            if (comboBoxLevel.SelectedIndex == 0 || Path.Length > 34)
            {
                new Form2().ShowDialog();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                SystemSounds.Exclamation.Play();
                new Form3().ShowDialog();
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Level = comboBoxLevel.Text;
            Index = comboBoxLevel.SelectedIndex;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
