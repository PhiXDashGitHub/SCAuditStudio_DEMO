namespace SCAuditStudio.SettingsMenuTabs
{
    partial class AISettingsTab
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
            label1 = new Label();
            textBoxOpenAIApiKey = new TextBox();
            label2 = new Label();
            textBoxOpenAIUrl = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 70);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "OpenAI API key";
            // 
            // textBoxOpenAIApiKey
            // 
            textBoxOpenAIApiKey.Location = new Point(74, 88);
            textBoxOpenAIApiKey.Name = "textBoxOpenAIApiKey";
            textBoxOpenAIApiKey.Size = new Size(296, 23);
            textBoxOpenAIApiKey.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 114);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Open AI URL";
            // 
            // textBoxOpenAIUrl
            // 
            textBoxOpenAIUrl.Location = new Point(74, 132);
            textBoxOpenAIUrl.Name = "textBoxOpenAIUrl";
            textBoxOpenAIUrl.Size = new Size(296, 23);
            textBoxOpenAIUrl.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(74, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // AISettingsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxOpenAIUrl);
            Controls.Add(label2);
            Controls.Add(textBoxOpenAIApiKey);
            Controls.Add(label1);
            Name = "AISettingsTab";
            Text = "AISettingsTab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxOpenAIApiKey;
        private Label label2;
        private TextBox textBoxOpenAIUrl;
        private Button button1;
    }
}