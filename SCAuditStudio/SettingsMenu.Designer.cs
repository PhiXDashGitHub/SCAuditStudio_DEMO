namespace SCAuditStudio
{
    partial class SettingsMenu
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
            splitContainer1 = new SplitContainer();
            buttonAISettings = new Button();
            buttonThemeSettings = new Button();
            buttonOpenProjectProperties = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonAISettings);
            splitContainer1.Panel1.Controls.Add(buttonThemeSettings);
            splitContainer1.Panel1.Controls.Add(buttonOpenProjectProperties);
            splitContainer1.Panel1.Padding = new Padding(0, 70, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(768, 607);
            splitContainer1.SplitterDistance = 189;
            splitContainer1.TabIndex = 0;
            // 
            // buttonAISettings
            // 
            buttonAISettings.Dock = DockStyle.Top;
            buttonAISettings.Location = new Point(0, 170);
            buttonAISettings.Name = "buttonAISettings";
            buttonAISettings.Size = new Size(189, 60);
            buttonAISettings.TabIndex = 2;
            buttonAISettings.Text = "AI and Automation Settings";
            buttonAISettings.UseVisualStyleBackColor = true;
            buttonAISettings.Click += buttonAISettings_Click;
            // 
            // buttonThemeSettings
            // 
            buttonThemeSettings.Dock = DockStyle.Top;
            buttonThemeSettings.Location = new Point(0, 120);
            buttonThemeSettings.Name = "buttonThemeSettings";
            buttonThemeSettings.Size = new Size(189, 50);
            buttonThemeSettings.TabIndex = 1;
            buttonThemeSettings.Text = "Color and Theme";
            buttonThemeSettings.UseVisualStyleBackColor = true;
            buttonThemeSettings.Click += button2_Click;
            // 
            // buttonOpenProjectProperties
            // 
            buttonOpenProjectProperties.Dock = DockStyle.Top;
            buttonOpenProjectProperties.Location = new Point(0, 70);
            buttonOpenProjectProperties.Name = "buttonOpenProjectProperties";
            buttonOpenProjectProperties.Size = new Size(189, 50);
            buttonOpenProjectProperties.TabIndex = 0;
            buttonOpenProjectProperties.Text = "Project Properties";
            buttonOpenProjectProperties.UseVisualStyleBackColor = true;
            buttonOpenProjectProperties.Click += buttonOpenProjectProperties_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 607);
            panel1.TabIndex = 0;
            // 
            // SettingsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 607);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsMenu";
            Text = "SettingsMenu";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button buttonAISettings;
        private Button buttonThemeSettings;
        private Button buttonOpenProjectProperties;
        private Panel panel1;
    }
}