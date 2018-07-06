namespace Product_DVT_Directory_Tool
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox2.Location = new System.Drawing.Point(12, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(281, 124);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "\t\t!!ERROR!!\n\nPlease Choose a Directory";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(305, 148);
            this.Controls.Add(this.richTextBox2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox board_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox revision_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox swconfig_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label debug_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}