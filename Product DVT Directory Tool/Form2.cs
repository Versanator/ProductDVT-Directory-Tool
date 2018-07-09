using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_DVT_Directory_Tool
{
    public partial class Form2 : Form
    {

        public static string Level = "";
        public static string Path = "";
        public static int Index;
        public Form2()
        {
            InitializeComponent();

            Level = Form1.Level;
            Path = Form1.Path;
            Index = Form1.Index;
            string[] names = PathParse();

            //debug_label.Text = Index.ToString();


            if (Index == 1)
            {
                board_textBox.Enabled = false;
                board_textBox.Text = names[0];
            }
            else if (Index == 2)
            {
                board_textBox.Enabled = false;
                revision_textBox.Enabled = false;
                
                board_textBox.Text = names[0];
                revision_textBox.Text = names[1];
            }
            else
            {

            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Process.Start(Path);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }




        public string[] PathParse()
        {
            string[] names = new string[2];
            string path = Path.Substring(35);
            if(Index == 2)
            {
                names = path.Split('\\');
            }
            else
            {
                names[0] = path;
            }
            return names;
        }
    }
}
