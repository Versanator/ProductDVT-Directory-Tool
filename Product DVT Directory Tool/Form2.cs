using System;
using System.IO;
using System.Windows.Forms;

namespace Product_DVT_Directory_Tool
{
    public partial class Form2 : Form
    {
        public static string Path = "";
        public static int Index;
        StreamWriter fs;
        public Form2()
        {
            InitializeComponent();
            /*
             Getting the Selected file path and usser selected directory level from Form1
             */
            Path = Form1.Path;
            Index = Form1.Index;
            string[] names;

            //debug_label.Text = Index.ToString();

            /*
                Choosing if parsing is necessary
                See line 135 for parseing algorithm
            */
            if (Index == 1)
            {
                names = PathParse();
                board_textBox.Enabled = false;
                board_textBox.Text = names[0];
            }
            else if (Index == 2)
            {
                names = PathParse();
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
            /*
             Setting up default subdirectories for creation
             */
            Path = Form1.Path;
            string[] defaultDirs = new string[12];
            defaultDirs[0] = @"\Air Flow\Tests\ExampleTEST_1\Results";
            defaultDirs[1] = @"\Air Flow\Diagnostics";
            defaultDirs[2] = @"\Air Flow\Firmware";
            defaultDirs[3] = @"\Air Flow\LabView";
            defaultDirs[4] = @"\Temperature Chamber\Tests\ExampleTEST_1\Results";
            defaultDirs[5] = @"\Temperature Chamber\Diagnostics";
            defaultDirs[6] = @"\Temperature Chamber\Firmware";
            defaultDirs[7] = @"\Temperature Chamber\LabView";
            defaultDirs[8] = @"\Open Air Chassis\Tests\ExampleTEST_1\Results";
            defaultDirs[9] = @"\Open Air Chassis\Diagnostics";
            defaultDirs[10] = @"\Open Air Chassis\Firmware";
            defaultDirs[11] = @"\Open Air Chassis\LabView";

            if (board_textBox.Text == "")
                board_textBox.Text = "New_Board";
            if (revision_textBox.Text == "")
                revision_textBox.Text = "B1";
            if (swconfig_textBox.Text == "")
                swconfig_textBox.Text = "PCXXXX";

            /*
             Creating dir based on user choice
             */
            switch (Index)
            {
                case 0:
                    {
                        Directory.CreateDirectory(Path + @"\" + board_textBox.Text + @"\" + revision_textBox.Text + @"\" + swconfig_textBox.Text);
                        Path = Path + @"\" + board_textBox.Text + @"\" + revision_textBox.Text + @"\" + swconfig_textBox.Text;
                        break;
                    }
                case 1:
                    {
                        Directory.CreateDirectory(Path + @"\" + revision_textBox.Text + @"\" + swconfig_textBox.Text);
                        Path = Path + @"\" + revision_textBox.Text + @"\" + swconfig_textBox.Text;
                        break;
                    }
                case 2:
                    {
                        Directory.CreateDirectory(Path + @"\" + swconfig_textBox.Text);
                        Path = Path + @"\" + swconfig_textBox.Text;
                        break;
                    }
                default:
                    break;
            }
            /*
             Creating all Default subdir and Test Description.txt file
             */
            foreach (string s in defaultDirs)
            {
                Directory.CreateDirectory(Path + s);
            }
            fs = File.CreateText(Path + defaultDirs[0] + @"\Test Description.txt");
            fs = File.CreateText(Path + defaultDirs[4] + @"\Test Description.txt");
            fs = File.CreateText(Path + defaultDirs[8] + @"\Test Description.txt");
            System.Diagnostics.Process.Start(Path);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        /*
             Parsing board name and/or revision name out of the selected path.
        */
        public string[] PathParse()
        {
            string[] names = new string[2];
            string path = Path.Substring(35);
            if(Index == 2)
            {
                names = path.Split('\\');
            }
            else if(Index == 1)
            {
                names[0] = path;
            }
            return names;
        }
    }
}
