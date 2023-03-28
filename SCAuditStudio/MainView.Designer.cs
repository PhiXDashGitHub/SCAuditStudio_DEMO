namespace SCAuditStudio
{
    partial class MainView
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            button6 = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(1, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(367, 619);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(374, 33);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(187, 619);
            listBox2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(567, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 31);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(525, 3);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 2;
            button3.Text = "View Raw";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(637, 3);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 1;
            button2.Text = "Open in explorer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(749, 3);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 0;
            button1.Text = "Move to Invalid";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(1, 682);
            panel2.Name = "panel2";
            panel2.Size = new Size(1424, 31);
            panel2.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(1315, 3);
            button4.Name = "button4";
            button4.Size = new Size(106, 23);
            button4.TabIndex = 2;
            button4.Text = "AI Invalidator";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1203, 3);
            button6.Name = "button6";
            button6.Size = new Size(106, 23);
            button6.TabIndex = 0;
            button6.Text = "AI Sort";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 664);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 3;
            label1.Text = "Call AI functions for whole project";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(567, 70);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(858, 582);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 15);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 15);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Issue Title";
            label3.Click += label3_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 725);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "MainView";
            Text = "MainView";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Button button4;
        private Button button6;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label3;
    }
}