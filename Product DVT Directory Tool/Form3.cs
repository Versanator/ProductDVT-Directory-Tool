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
    public partial class Form3 : Form
    {
        public static string Error = Form1.Error;
        public Form3()
        {
            Error = Form1.Error;
            InitializeComponent();
            error_richTextBox.Text = "                     !!!ERROR!!!";
            error_richTextBox.AppendText(Error);


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}