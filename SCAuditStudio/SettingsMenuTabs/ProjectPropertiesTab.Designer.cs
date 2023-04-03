namespace SCAuditStudio.SettingsMenuTabs
{
    partial class ProjectPropertiesTab
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 65);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "ProjectPath";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(426, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 109);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Project Context Path";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 153);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 4;
            label3.Text = "Blacklist Path";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(71, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(426, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(71, 244);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 197);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 7;
            label4.Text = "Sherlock Judging Criteria";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(71, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(426, 23);
            textBox4.TabIndex = 8;
            // 
            // ProjectPropertiesTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ProjectPropertiesTab";
            Text = "ProjectPropertiesTab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
        private TextBox textBox4;
    }
}