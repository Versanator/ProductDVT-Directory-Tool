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
        public static string Path = @"\\hun-fs-sc\Engineering\ProductDVT";
        public static int Index = -999;
        public static string Error = "";
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

            if (comboBoxLevel.SelectedIndex == 0 || folderBrowserDialog1.SelectedPath.Length > 34 && Path.Substring(35).Contains(@"\") || comboBoxLevel.SelectedIndex == 1)
            {
                new Form2().ShowDialog();
            }
            else
            {
                if (comboBoxLevel.SelectedIndex == -999)
                    Error = "\n\n\tPlease select what level of the ProductDVT hierarchy you would like to create.";
                else if (folderBrowserDialog1.SelectedPath.Length <= 34)
                    Error = "\n\n\t Please select a subdirectory of ProductDVT\n\t\tTHIS TOOL IS ONLY APPLICABLE TO ProductDVT!!";
                else if (!Path.Substring(35).Contains(@"\") && comboBoxLevel.SelectedIndex == 2)
                    Error = "\n\nYou have chosen to create a new software configuration for a product." +
                        "\nThis requires the board/system in question to have a valid revision." +
                        "\n\tYou have selected a file path that doesn't include a board/system revision. Please select one." +
                        "\n\nEg:\\DCM6111\\B3";
                SystemSounds.Exclamation.Play();
                SystemSounds.Exclamation.Play();
                new Form3().ShowDialog();
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = comboBoxLevel.SelectedIndex;
            Path = @"\\hun-fs-sc\Engineering\ProductDVT";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void productDVTHierarchyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"\\hun-fs-sc\Engineering\ProductDVT\ProductDVT Folder Hierarchy Template and Usage Guide.pdf");
        }

        private void productDVTFileListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"\\hun-fs-sc\Engineering\ProductDVT\ProductDVT File Hierarchy.xlsx");
        }
    }
}
