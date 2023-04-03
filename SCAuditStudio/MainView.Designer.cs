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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.MDFileListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invalidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asBestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.automationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aISortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MDFileList = new System.Windows.Forms.TreeView();
            this.MDFileViewTabs = new System.Windows.Forms.TabControl();
            this.MDFileListContext.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MDFileListContext
            // 
            this.MDFileListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToToolStripMenuItem,
            this.generateIssueToolStripMenuItem,
            this.markIssueToolStripMenuItem,
            this.highlightToolStripMenuItem});
            this.MDFileListContext.Name = "contextMenuStrip1";
            resources.ApplyResources(this.MDFileListContext, "MDFileListContext");
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootToolStripMenuItem,
            this.invalidToolStripMenuItem,
            this.issueToolStripMenuItem});
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            resources.ApplyResources(this.moveToToolStripMenuItem, "moveToToolStripMenuItem");
            // 
            // rootToolStripMenuItem
            // 
            this.rootToolStripMenuItem.Name = "rootToolStripMenuItem";
            resources.ApplyResources(this.rootToolStripMenuItem, "rootToolStripMenuItem");
            this.rootToolStripMenuItem.Click += new System.EventHandler(this.MDFileListMoveToRoot);
            // 
            // invalidToolStripMenuItem
            // 
            this.invalidToolStripMenuItem.Name = "invalidToolStripMenuItem";
            resources.ApplyResources(this.invalidToolStripMenuItem, "invalidToolStripMenuItem");
            this.invalidToolStripMenuItem.Click += new System.EventHandler(this.MDFileListMoveToInvalid);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            resources.ApplyResources(this.issueToolStripMenuItem, "issueToolStripMenuItem");
            // 
            // generateIssueToolStripMenuItem
            // 
            this.generateIssueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediumToolStripMenuItem,
            this.highToolStripMenuItem});
            this.generateIssueToolStripMenuItem.Name = "generateIssueToolStripMenuItem";
            resources.ApplyResources(this.generateIssueToolStripMenuItem, "generateIssueToolStripMenuItem");
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            resources.ApplyResources(this.mediumToolStripMenuItem, "mediumToolStripMenuItem");
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.MDFileListGenerateMediumIssue);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            resources.ApplyResources(this.highToolStripMenuItem, "highToolStripMenuItem");
            this.highToolStripMenuItem.Click += new System.EventHandler(this.MDFileListGenerateHighIssue);
            // 
            // markIssueToolStripMenuItem
            // 
            this.markIssueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unmarkToolStripMenuItem,
            this.asBestToolStripMenuItem});
            this.markIssueToolStripMenuItem.Name = "markIssueToolStripMenuItem";
            resources.ApplyResources(this.markIssueToolStripMenuItem, "markIssueToolStripMenuItem");
            // 
            // unmarkToolStripMenuItem
            // 
            this.unmarkToolStripMenuItem.Name = "unmarkToolStripMenuItem";
            resources.ApplyResources(this.unmarkToolStripMenuItem, "unmarkToolStripMenuItem");
            this.unmarkToolStripMenuItem.Click += new System.EventHandler(this.MDFileListUnmark);
            // 
            // asBestToolStripMenuItem
            // 
            this.asBestToolStripMenuItem.Name = "asBestToolStripMenuItem";
            resources.ApplyResources(this.asBestToolStripMenuItem, "asBestToolStripMenuItem");
            this.asBestToolStripMenuItem.Click += new System.EventHandler(this.MDFileListMarkAsBest);
            // 
            // highlightToolStripMenuItem
            // 
            this.highlightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.redToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.yellowToolStripMenuItem1,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.magentaToolStripMenuItem});
            this.highlightToolStripMenuItem.Name = "highlightToolStripMenuItem";
            resources.ApplyResources(this.highlightToolStripMenuItem, "highlightToolStripMenuItem");
            this.highlightToolStripMenuItem.Click += new System.EventHandler(this.MDFileListHighlight);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.MDFileListHighlight);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            resources.ApplyResources(this.redToolStripMenuItem, "redToolStripMenuItem");
            this.redToolStripMenuItem.Click += new System.EventHandler(this.MDFileListHighlight);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.orangeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            resources.ApplyResources(this.orangeToolStripMenuItem, "orangeToolStripMenuItem");
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.MDFileListHighlight);
            // 
            // yellowToolStripMenuItem1
            // 
            this.yellowToolStripMenuItem1.BackColor = System.Drawing.Color.Yellow;
            this.yellowToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.yellowToolStripMenuItem1.Name = "yellowToolStripMenuItem1";
            resources.ApplyResources(this.yellowToolStripMenuItem1, "yellowToolStripMenuItem1");
            this.yellowToolStripMenuItem1.Click += new System.EventHandler(this.MDFileListHighlight);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            resources.ApplyResources(this.greenToolStripMenuItem, "greenToolStripMenuItem");
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.MDFileListHighlight);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.blueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            resources.ApplyResources(this.blueToolStripMenuItem, "blueToolStripMenuItem");
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.MDFileListHighlight);
            // 
            // magentaToolStripMenuItem
            // 
            this.magentaToolStripMenuItem.BackColor = System.Drawing.Color.Magenta;
            this.magentaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.magentaToolStripMenuItem.Name = "magentaToolStripMenuItem";
            resources.ApplyResources(this.magentaToolStripMenuItem, "magentaToolStripMenuItem");
            this.magentaToolStripMenuItem.Click += new System.EventHandler(this.MDFileListHighlight);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.automationToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            resources.ApplyResources(this.optionsToolStripMenuItem1, "optionsToolStripMenuItem1");
            // 
            // automationToolStripMenuItem
            // 
            this.automationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aISortToolStripMenuItem,
            this.aIScoreToolStripMenuItem,
            this.staticSortToolStripMenuItem,
            this.staticScoreToolStripMenuItem});
            this.automationToolStripMenuItem.Name = "automationToolStripMenuItem";
            resources.ApplyResources(this.automationToolStripMenuItem, "automationToolStripMenuItem");
            // 
            // aISortToolStripMenuItem
            // 
            this.aISortToolStripMenuItem.Name = "aISortToolStripMenuItem";
            resources.ApplyResources(this.aISortToolStripMenuItem, "aISortToolStripMenuItem");
            // 
            // aIScoreToolStripMenuItem
            // 
            this.aIScoreToolStripMenuItem.Name = "aIScoreToolStripMenuItem";
            resources.ApplyResources(this.aIScoreToolStripMenuItem, "aIScoreToolStripMenuItem");
            // 
            // staticSortToolStripMenuItem
            // 
            this.staticSortToolStripMenuItem.Name = "staticSortToolStripMenuItem";
            resources.ApplyResources(this.staticSortToolStripMenuItem, "staticSortToolStripMenuItem");
            // 
            // staticScoreToolStripMenuItem
            // 
            this.staticScoreToolStripMenuItem.Name = "staticScoreToolStripMenuItem";
            resources.ApplyResources(this.staticScoreToolStripMenuItem, "staticScoreToolStripMenuItem");
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MDFileList_MouseDown);
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.MDFileList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MDFileViewTabs);
            this.splitContainer2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MDFileList_MouseDown);
            // 
            // MDFileList
            // 
            this.MDFileList.ContextMenuStrip = this.MDFileListContext;
            resources.ApplyResources(this.MDFileList, "MDFileList");
            this.MDFileList.Name = "MDFileList";
            this.MDFileList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MDFileList_ViewElement);
            this.MDFileList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MDFileList_MouseDown);
            // 
            // MDFileViewTabs
            // 
            resources.ApplyResources(this.MDFileViewTabs, "MDFileViewTabs");
            this.MDFileViewTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MDFileViewTabs.Name = "MDFileViewTabs";
            this.MDFileViewTabs.SelectedIndex = 0;
            this.MDFileViewTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MDFileViewTabs_DrawItem);
            this.MDFileViewTabs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MDFileViewTabs_MouseClick);
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.MDFileListContext.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}