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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.error_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // error_richTextBox
            // 
            this.error_richTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.error_richTextBox.Location = new System.Drawing.Point(12, 12);
            this.error_richTextBox.Name = "error_richTextBox";
            this.error_richTextBox.ReadOnly = true;
            this.error_richTextBox.Size = new System.Drawing.Size(568, 124);
            this.error_richTextBox.TabIndex = 0;
            this.error_richTextBox.Text = "\t\t\t   \t\t     !!ERROR!!\n ";
            this.error_richTextBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(592, 148);
            this.Controls.Add(this.error_richTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.RichTextBox error_richTextBox;
    }
}