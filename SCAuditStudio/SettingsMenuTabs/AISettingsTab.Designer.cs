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
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            button2 = new Button();
            textBoxChatGPTUrl = new TextBox();
            label5 = new Label();
            textBoxOpenAIApi = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(textBoxChatGPTUrl);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(textBoxOpenAIApi);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Padding = new Padding(5);
            splitContainer1.Size = new Size(559, 568);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 0;
            label3.Text = "AI Settings";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(5, 81);
            button2.Margin = new Padding(0, 3, 3, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(549, 30);
            button2.TabIndex = 4;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBoxChatGPTUrl
            // 
            textBoxChatGPTUrl.Dock = DockStyle.Top;
            textBoxChatGPTUrl.Location = new Point(5, 58);
            textBoxChatGPTUrl.Margin = new Padding(5);
            textBoxChatGPTUrl.Name = "textBoxChatGPTUrl";
            textBoxChatGPTUrl.Size = new Size(549, 23);
            textBoxChatGPTUrl.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(5, 43);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 2;
            label5.Text = "Chat GPT URL";
            // 
            // textBoxOpenAIApi
            // 
            textBoxOpenAIApi.Dock = DockStyle.Top;
            textBoxOpenAIApi.Location = new Point(5, 20);
            textBoxOpenAIApi.Margin = new Padding(5);
            textBoxOpenAIApi.Name = "textBoxOpenAIApi";
            textBoxOpenAIApi.Size = new Size(549, 23);
            textBoxOpenAIApi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(5, 5);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 0;
            label4.Text = "Open AI API key ";
            // 
            // AISettingsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 568);
            Controls.Add(splitContainer1);
            Controls.Add(button1);
            Controls.Add(textBoxOpenAIUrl);
            Controls.Add(label2);
            Controls.Add(textBoxOpenAIApiKey);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AISettingsTab";
            Text = "AISettingsTab";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxOpenAIApiKey;
        private Label label2;
        private TextBox textBoxOpenAIUrl;
        private Button button1;
        private SplitContainer splitContainer1;
        private Label label3;
        private Button button2;
        private TextBox textBoxChatGPTUrl;
        private Label label5;
        private TextBox textBoxOpenAIApi;
        private Label label4;
    }
}