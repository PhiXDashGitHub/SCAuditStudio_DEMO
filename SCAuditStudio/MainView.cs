using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace SCAuditStudio
{
    public partial class MainView : Form
    {
        public string ProjectDirectory = @"C:\Users\Phillip\Downloads\2023-02-gmx-judging-Oot2k\2023-02-gmx-judging-Oot2k\";
        public MDManager mdManager;

        public MainView()
        {
            InitializeComponent();
        }

        /* PUBLIC FUNCTIONS */
        public void UpdateFileTree()
        {
            mdManager.SetFileTree(MDFileList.Nodes);
        }
        public void LoadContextIssues()
        {
            ToolStripItemCollection contextItems = MDFileListContext.Items;
            ToolStripMenuItem moveItem = (ToolStripMenuItem)contextItems[0];
            ToolStripMenuItem moveToIssueItem = (ToolStripMenuItem)moveItem.DropDownItems[2];
            moveToIssueItem.DropDownItems.Clear();

            string[] mediumIssues = mdManager.GetIssues(MDManager.MDFileIssue.Medium);
            string[] highIssues = mdManager.GetIssues(MDManager.MDFileIssue.High);
            string[] issues = highIssues.Concat(mediumIssues).ToArray();
            foreach (string currentIssue in issues)
            {
                ToolStripItem issueItem = moveToIssueItem.DropDownItems.Add(currentIssue);
                issueItem.Click += new EventHandler((sender, e) => MDFileListMoveToIssue(sender, e, currentIssue));
            }
        }
        public async Task ViewMDFileFromView(TabPage page, string fileName)
        {
            //Check for .md file first
            if (!fileName.EndsWith(".md")) { return; }

            //Read MD file raw
            string md = "PLEASE REPLACE ME";
            md = md.Split("\n").Skip(4).ToArray().ToSingle();

            //Convert to html and add some formatting
            string html = Markdig.Markdown.ToHtml(md);
            html = html.Insert(0, "<font face=\"Segoe UI\">\n");

            //Display as web page
            WebView2 webView = new()
            {
                Dock = DockStyle.Fill
            };

            await webView.EnsureCoreWebView2Async();
            webView.NavigateToString(html);

            page.Controls.Add(webView);
        }
        public bool TabInCollection(string tabName)
        {
            TabControl.TabPageCollection pages = MDFileViewTabs.TabPages;
            foreach (TabPage page in pages)
            {
                if (page.Text == tabName)
                {
                    return true;
                }
            }

            return false;
        }

        /* EVENTS */
        async void MainView_Load(object sender, EventArgs e)
        {
            mdManager = new(ProjectDirectory);
            await mdManager.LoadFilesAsync();

            UpdateFileTree();
            LoadContextIssues();
        }

        void MDFileViewTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = new Bitmap(Properties.Resources.CloseTabButton);
            Rectangle r = MDFileViewTabs.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = Font;
            string title = MDFileViewTabs.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (MDFileViewTabs.GetTabRect(e.Index).Width - 20), 8));
        }
        void MDFileViewTabs_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = MDFileViewTabs.GetTabRect(tabControl.SelectedIndex).Width - 18;
            Rectangle r = MDFileViewTabs.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, 8);
            r.Width = 10;
            r.Height = 10;
            if (r.Contains(p))
            {
                TabPage tabPage = tabControl.TabPages[tabControl.SelectedIndex];
                tabControl.TabPages.Remove(tabPage);
            }
        }
        void MDFileListMoveToInvalid(object sender, EventArgs e)
        {
            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            mdManager.MoveFileToInvalid(file);
            UpdateFileTree();
        }
        void MDFileListMoveToRoot(object sender, EventArgs e)
        {
            Console.WriteLine("Move file to root");

            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            mdManager.MoveFileToRoot(file);
            UpdateFileTree();
        }
        void MDFileListMoveToIssue(object? sender, EventArgs e, string currentIssue)
        {
            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            mdManager.MoveFileToIssue(file, currentIssue, false);

            UpdateFileTree();
            LoadContextIssues();
        }
        void MDFileListGenerateHighIssue(object sender, EventArgs e)
        {
            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            mdManager.MoveFileToIssue(file, MDManager.MDFileIssue.High, mdManager.GetIssueIndex(MDManager.MDFileIssue.High), true);

            UpdateFileTree();
            LoadContextIssues();
        }
        void MDFileListGenerateMediumIssue(object sender, EventArgs e)
        {
            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            mdManager.MoveFileToIssue(file, MDManager.MDFileIssue.Medium, mdManager.GetIssueIndex(MDManager.MDFileIssue.Medium), true);

            UpdateFileTree();
            LoadContextIssues();
        }
        void MDFileListHighlight(object sender, EventArgs e)
        {
            string? colorString = sender.ToString();
            if (colorString == null) return;

            Color color = colorString == "Clear" ? Color.FromKnownColor(KnownColor.Window) : Color.FromName(colorString);
            MDFileList.SelectedNode.BackColor = color;
        }
        void MDFileListUnmark(object sender, EventArgs e)
        {
            MDTreeNode node = (MDTreeNode)MDFileList.SelectedNode;
            string newName = mdManager.UnmarkFile(node.name);

            node.name = newName;
            mdManager.UpdateFileTreeNode(node);
        }
        void MDFileListMarkAsBest(object sender, EventArgs e)
        {
            //Check if in Issue Folder
            MDTreeNode node = (MDTreeNode)MDFileList.SelectedNode;
            MDFile? mdFile = mdManager.GetFile(node.name);
            if (mdFile == null) return;
            if (!mdManager.IssueExists(mdFile.subPath)) return;
            if (mdManager.GetMDFileCountInSubPath(mdFile.subPath) < 2) return;

            MDFile[] mdFilesInSubPath = mdManager.mdFiles.Where(f => f.subPath == mdFile.subPath && f != mdFile).ToArray();
            for (int i = 0; i < mdFilesInSubPath.Length; i++)
            {
                mdManager.UnmarkFile(mdFilesInSubPath[i].fileName);
            }

            mdManager.MarkFileAsBest(node.name);

            UpdateFileTree();
        }
        public async void MDFileList_ViewElement(object sender, TreeNodeMouseClickEventArgs e)
        {
            string fileName = ((MDTreeNode)MDFileList.SelectedNode).name;

            //Return if Tab already opened
            if (TabInCollection(fileName) || !fileName.EndsWith(".md")) return;

            //Create Tab and add WebView
            TabPage page = new(fileName);
            await ViewMDFileFromView(page, fileName);

            //Add TabPage to list
            MDFileViewTabs.TabPages.Add(page);

            MDFileViewTabs.SelectedTab = page;
        }
    }
}
