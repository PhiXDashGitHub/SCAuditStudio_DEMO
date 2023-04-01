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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MDFileList = new System.Windows.Forms.TreeView();
            this.MDFileViewTabs = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1181, 725);
            this.splitContainer1.SplitterDistance = 669;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.MDFileList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MDFileViewTabs);
            this.splitContainer2.Size = new System.Drawing.Size(1181, 669);
            this.splitContainer2.SplitterDistance = 393;
            this.splitContainer2.TabIndex = 0;
            // 
            // MDFileList
            // 
            this.MDFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDFileList.Location = new System.Drawing.Point(0, 0);
            this.MDFileList.Name = "MDFileList";
            this.MDFileList.Size = new System.Drawing.Size(393, 669);
            this.MDFileList.TabIndex = 0;
            this.MDFileList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MDFileList_ViewElement);
            // 
            // MDFileViewTabs
            // 
            this.MDFileViewTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDFileViewTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MDFileViewTabs.Location = new System.Drawing.Point(0, 0);
            this.MDFileViewTabs.Name = "MDFileViewTabs";
            this.MDFileViewTabs.Padding = new System.Drawing.Point(20, 4);
            this.MDFileViewTabs.SelectedIndex = 0;
            this.MDFileViewTabs.Size = new System.Drawing.Size(784, 669);
            this.MDFileViewTabs.TabIndex = 0;
            this.MDFileViewTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MDFileViewTabs_DrawItem);
            this.MDFileViewTabs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MDFileViewTabs_MouseClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 725);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TreeView MDFileList;
        private TabControl MDFileViewTabs;
    }
}