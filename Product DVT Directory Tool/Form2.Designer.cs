namespace Product_DVT_Directory_Tool
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.board_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.revision_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.swconfig_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.debug_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board/System ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // board_textBox
            // 
            this.board_textBox.Location = new System.Drawing.Point(108, 33);
            this.board_textBox.Name = "board_textBox";
            this.board_textBox.Size = new System.Drawing.Size(177, 20);
            this.board_textBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // revision_textBox
            // 
            this.revision_textBox.Location = new System.Drawing.Point(108, 59);
            this.revision_textBox.Name = "revision_textBox";
            this.revision_textBox.Size = new System.Drawing.Size(177, 20);
            this.revision_textBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Revison";
            // 
            // swconfig_textBox
            // 
            this.swconfig_textBox.Location = new System.Drawing.Point(108, 85);
            this.swconfig_textBox.Name = "swconfig_textBox";
            this.swconfig_textBox.Size = new System.Drawing.Size(177, 20);
            this.swconfig_textBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SW Configuration";
            // 
            // debug_label
            // 
            this.debug_label.AutoSize = true;
            this.debug_label.Cursor = System.Windows.Forms.Cursors.Cross;
            this.debug_label.Location = new System.Drawing.Point(15, 145);
            this.debug_label.Name = "debug_label";
            this.debug_label.Size = new System.Drawing.Size(0, 13);
            this.debug_label.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 169);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(721, 291);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 544);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.debug_label);
            this.Controls.Add(this.swconfig_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.revision_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.board_textBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Product DVT Directory Tool";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}