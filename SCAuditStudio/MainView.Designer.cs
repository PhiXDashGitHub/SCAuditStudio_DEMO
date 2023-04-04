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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            MDFileListContext = new ContextMenuStrip(components);
            moveToToolStripMenuItem = new ToolStripMenuItem();
            rootToolStripMenuItem = new ToolStripMenuItem();
            invalidToolStripMenuItem = new ToolStripMenuItem();
            issueToolStripMenuItem = new ToolStripMenuItem();
            generateIssueToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            highToolStripMenuItem = new ToolStripMenuItem();
            markIssueToolStripMenuItem = new ToolStripMenuItem();
            unmarkToolStripMenuItem = new ToolStripMenuItem();
            asBestToolStripMenuItem = new ToolStripMenuItem();
            highlightToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            orangeToolStripMenuItem = new ToolStripMenuItem();
            yellowToolStripMenuItem1 = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            magentaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem1 = new ToolStripMenuItem();
            automationToolStripMenuItem = new ToolStripMenuItem();
            aISortToolStripMenuItem = new ToolStripMenuItem();
            aIScoreToolStripMenuItem = new ToolStripMenuItem();
            staticSortToolStripMenuItem = new ToolStripMenuItem();
            staticScoreToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            MDFileList = new TreeView();
            MDFileViewTabs = new TabControl();
            MDFileListContext.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // MDFileListContext
            // 
            MDFileListContext.Items.AddRange(new ToolStripItem[] { moveToToolStripMenuItem, generateIssueToolStripMenuItem, markIssueToolStripMenuItem, highlightToolStripMenuItem });
            MDFileListContext.Name = "contextMenuStrip1";
            resources.ApplyResources(MDFileListContext, "MDFileListContext");
            // 
            // moveToToolStripMenuItem
            // 
            moveToToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rootToolStripMenuItem, invalidToolStripMenuItem, issueToolStripMenuItem });
            moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            resources.ApplyResources(moveToToolStripMenuItem, "moveToToolStripMenuItem");
            // 
            // rootToolStripMenuItem
            // 
            rootToolStripMenuItem.Name = "rootToolStripMenuItem";
            resources.ApplyResources(rootToolStripMenuItem, "rootToolStripMenuItem");
            rootToolStripMenuItem.Click += MDFileListMoveToRoot;
            // 
            // invalidToolStripMenuItem
            // 
            invalidToolStripMenuItem.Name = "invalidToolStripMenuItem";
            resources.ApplyResources(invalidToolStripMenuItem, "invalidToolStripMenuItem");
            invalidToolStripMenuItem.Click += MDFileListMoveToInvalid;
            // 
            // issueToolStripMenuItem
            // 
            issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            resources.ApplyResources(issueToolStripMenuItem, "issueToolStripMenuItem");
            // 
            // generateIssueToolStripMenuItem
            // 
            generateIssueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mediumToolStripMenuItem, highToolStripMenuItem });
            generateIssueToolStripMenuItem.Name = "generateIssueToolStripMenuItem";
            resources.ApplyResources(generateIssueToolStripMenuItem, "generateIssueToolStripMenuItem");
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            resources.ApplyResources(mediumToolStripMenuItem, "mediumToolStripMenuItem");
            mediumToolStripMenuItem.Click += MDFileListGenerateMediumIssue;
            // 
            // highToolStripMenuItem
            // 
            highToolStripMenuItem.Name = "highToolStripMenuItem";
            resources.ApplyResources(highToolStripMenuItem, "highToolStripMenuItem");
            highToolStripMenuItem.Click += MDFileListGenerateHighIssue;
            // 
            // markIssueToolStripMenuItem
            // 
            markIssueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unmarkToolStripMenuItem, asBestToolStripMenuItem });
            markIssueToolStripMenuItem.Name = "markIssueToolStripMenuItem";
            resources.ApplyResources(markIssueToolStripMenuItem, "markIssueToolStripMenuItem");
            // 
            // unmarkToolStripMenuItem
            // 
            unmarkToolStripMenuItem.Name = "unmarkToolStripMenuItem";
            resources.ApplyResources(unmarkToolStripMenuItem, "unmarkToolStripMenuItem");
            unmarkToolStripMenuItem.Click += MDFileListUnmark;
            // 
            // asBestToolStripMenuItem
            // 
            asBestToolStripMenuItem.Name = "asBestToolStripMenuItem";
            resources.ApplyResources(asBestToolStripMenuItem, "asBestToolStripMenuItem");
            asBestToolStripMenuItem.Click += MDFileListMarkAsBest;
            // 
            // highlightToolStripMenuItem
            // 
            highlightToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, redToolStripMenuItem, orangeToolStripMenuItem, yellowToolStripMenuItem1, greenToolStripMenuItem, blueToolStripMenuItem, magentaToolStripMenuItem });
            highlightToolStripMenuItem.Name = "highlightToolStripMenuItem";
            resources.ApplyResources(highlightToolStripMenuItem, "highlightToolStripMenuItem");
            highlightToolStripMenuItem.Click += MDFileListHighlight;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(clearToolStripMenuItem, "clearToolStripMenuItem");
            clearToolStripMenuItem.Click += MDFileListHighlight;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.BackColor = Color.OrangeRed;
            redToolStripMenuItem.ForeColor = Color.White;
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            resources.ApplyResources(redToolStripMenuItem, "redToolStripMenuItem");
            redToolStripMenuItem.Click += MDFileListHighlight;
            // 
            // orangeToolStripMenuItem
            // 
            orangeToolStripMenuItem.BackColor = Color.Orange;
            orangeToolStripMenuItem.ForeColor = Color.White;
            orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            resources.ApplyResources(orangeToolStripMenuItem, "orangeToolStripMenuItem");
            orangeToolStripMenuItem.Click += MDFileListHighlight;
            // 
            // yellowToolStripMenuItem1
            // 
            yellowToolStripMenuItem1.BackColor = Color.YellowGreen;
            yellowToolStripMenuItem1.ForeColor = Color.White;
            yellowToolStripMenuItem1.Name = "yellowToolStripMenuItem1";
            resources.ApplyResources(yellowToolStripMenuItem1, "yellowToolStripMenuItem1");
            yellowToolStripMenuItem1.Click += MDFileListHighlight;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.BackColor = Color.MediumSeaGreen;
            greenToolStripMenuItem.ForeColor = Color.White;
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            resources.ApplyResources(greenToolStripMenuItem, "greenToolStripMenuItem");
            greenToolStripMenuItem.Click += MDFileListHighlight;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.BackColor = Color.SlateBlue;
            blueToolStripMenuItem.ForeColor = Color.White;
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            resources.ApplyResources(blueToolStripMenuItem, "blueToolStripMenuItem");
            blueToolStripMenuItem.Click += MDFileListHighlight;
            // 
            // magentaToolStripMenuItem
            // 
            magentaToolStripMenuItem.BackColor = Color.HotPink;
            magentaToolStripMenuItem.ForeColor = Color.White;
            magentaToolStripMenuItem.Name = "magentaToolStripMenuItem";
            resources.ApplyResources(magentaToolStripMenuItem, "magentaToolStripMenuItem");
            magentaToolStripMenuItem.Click += MDFileListHighlight;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, automationToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem1 });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // optionsToolStripMenuItem1
            // 
            optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            resources.ApplyResources(optionsToolStripMenuItem1, "optionsToolStripMenuItem1");
            optionsToolStripMenuItem1.Click += optionsToolStripMenuItem1_Click;
            // 
            // automationToolStripMenuItem
            // 
            automationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aISortToolStripMenuItem, aIScoreToolStripMenuItem, staticSortToolStripMenuItem, staticScoreToolStripMenuItem });
            automationToolStripMenuItem.Name = "automationToolStripMenuItem";
            resources.ApplyResources(automationToolStripMenuItem, "automationToolStripMenuItem");
            // 
            // aISortToolStripMenuItem
            // 
            aISortToolStripMenuItem.Name = "aISortToolStripMenuItem";
            resources.ApplyResources(aISortToolStripMenuItem, "aISortToolStripMenuItem");
            // 
            // aIScoreToolStripMenuItem
            // 
            aIScoreToolStripMenuItem.Name = "aIScoreToolStripMenuItem";
            resources.ApplyResources(aIScoreToolStripMenuItem, "aIScoreToolStripMenuItem");
            // 
            // staticSortToolStripMenuItem
            // 
            staticSortToolStripMenuItem.Name = "staticSortToolStripMenuItem";
            resources.ApplyResources(staticSortToolStripMenuItem, "staticSortToolStripMenuItem");
            // 
            // staticScoreToolStripMenuItem
            // 
            staticScoreToolStripMenuItem.Name = "staticScoreToolStripMenuItem";
            resources.ApplyResources(staticScoreToolStripMenuItem, "staticScoreToolStripMenuItem");
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.MouseDown += MDFileList_MouseDown;
            // 
            // splitContainer2
            // 
            resources.ApplyResources(splitContainer2, "splitContainer2");
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(MDFileList);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(MDFileViewTabs);
            splitContainer2.MouseDown += MDFileList_MouseDown;
            // 
            // MDFileList
            // 
            MDFileList.ContextMenuStrip = MDFileListContext;
            resources.ApplyResources(MDFileList, "MDFileList");
            MDFileList.Name = "MDFileList";
            MDFileList.NodeMouseDoubleClick += MDFileList_ViewElement;
            MDFileList.MouseDown += MDFileList_MouseDown;
            // 
            // MDFileViewTabs
            // 
            resources.ApplyResources(MDFileViewTabs, "MDFileViewTabs");
            MDFileViewTabs.DrawMode = TabDrawMode.OwnerDrawFixed;
            MDFileViewTabs.Name = "MDFileViewTabs";
            MDFileViewTabs.SelectedIndex = 0;
            MDFileViewTabs.DrawItem += MDFileViewTabs_DrawItem;
            MDFileViewTabs.MouseClick += MDFileViewTabs_MouseClick;
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "MainView";
            Load += MainView_Load;
            MDFileListContext.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip MDFileListContext;
        private ToolStripMenuItem moveToToolStripMenuItem;
        private ToolStripMenuItem rootToolStripMenuItem;
        private ToolStripMenuItem invalidToolStripMenuItem;
        private ToolStripMenuItem generateIssueToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem highToolStripMenuItem;
        private ToolStripMenuItem markIssueToolStripMenuItem;
        private ToolStripMenuItem unmarkToolStripMenuItem;
        private ToolStripMenuItem asBestToolStripMenuItem;
        private ToolStripMenuItem issueToolStripMenuItem;
        private ToolStripMenuItem highlightToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem orangeToolStripMenuItem;
        private ToolStripMenuItem yellowToolStripMenuItem1;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem magentaToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem automationToolStripMenuItem;
        private ToolStripMenuItem aISortToolStripMenuItem;
        private ToolStripMenuItem aIScoreToolStripMenuItem;
        private ToolStripMenuItem staticSortToolStripMenuItem;
        private ToolStripMenuItem staticScoreToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TreeView MDFileList;
        private TabControl MDFileViewTabs;
        private ToolStripMenuItem openToolStripMenuItem;
    }
}