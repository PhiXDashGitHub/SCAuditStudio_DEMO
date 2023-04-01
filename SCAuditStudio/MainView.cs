using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace SCAuditStudio
{
    public partial class MainView : Form
    {
        static string InValidFolder = "invalid";
        static string ProjectDirectory = @"C:\Users\Phillip\Downloads\2023-02-gmx-judging-Oot2k\2023-02-gmx-judging-Oot2k\";
        public enum Severity { Medium, High };

        public MainView()
        {
            InitializeComponent();
        }

        public string[] GetMediumIssues()
        {
            List<string> issues = new();

            TreeNodeCollection nodes = MDFileList.Nodes;
            foreach (MDTreeNode node in nodes)
            {
                if (node.name.EndsWith("-M"))
                {
                    issues.Add(node.name);
                }
            }

            return issues.ToArray();
        }
        public string[] GetHighIssues()
        {
            List<string> issues = new();

            TreeNodeCollection nodes = MDFileList.Nodes;
            foreach (MDTreeNode node in nodes)
            {
                if (node.name.EndsWith("-H"))
                {
                    issues.Add(node.name);
                }
            }

            return issues.ToArray();
        }
        public void TryRemoveParentNode(MDTreeNode? parentNode)
        {
            if (parentNode != null)
            {
                if (parentNode.Nodes.Count <= 1)
                {
                    RemoveSubFolder(parentNode.name);
                }
            }
        }
        public void MoveToSubFolder(string fileName, string folderName)
        {
            string? filePath = MDReader.SearchFile(ProjectDirectory, fileName);
            string subPath = Path.Combine(ProjectDirectory, folderName);
            string destFile = Path.Combine(subPath, fileName);
            if (string.IsNullOrEmpty(filePath)) return;
            if (!Directory.Exists(subPath)) Directory.CreateDirectory(subPath);
            if (Directory.Exists(subPath)) File.Move(filePath, destFile);
        }
        public void RemoveSubFolder(string folderName)
        {
            string subPath = Path.Combine(ProjectDirectory, folderName);
            if (Directory.Exists(subPath)) Directory.Delete(subPath, true);
        }
        public void MoveToRoot(string fileName)
        {
            MoveToSubFolder(fileName, "");
        }
        public void MoveToInvalid(string fileName)
        {
            MoveToSubFolder(fileName, InValidFolder);
        }
        public void MoveToNewIssue(string currentIssue, Severity severity)
        {
            //Find last issue in list
            string[] issues = severity == Severity.High ? GetHighIssues() : GetMediumIssues();
            string issueName = (issues.Length + 1).ToString("000");
            string folderName = $"{issueName}-{(severity == Severity.High ? 'H' : 'M')}";

            MoveToSubFolder(currentIssue, folderName);
        }
        public void MoveToIssue(string fileName, string issue)
        {
            MoveToSubFolder(fileName, issue);
        }
        public void UnmarkFile(string file)
        {
            string? path = Path.GetDirectoryName(file);
            string? fileName = Path.GetFileName(file);
            if (path == null || fileName == null) return;

            string newFile = Path.Combine(path, fileName.Replace("-best", ""));
            File.Move(file, newFile);
        }
        public void MarkFile(string file)
        {
            string? path = Path.GetDirectoryName(file);
            string? fileName = Path.GetFileName(file);
            if (path == null || fileName == null) return;

            string newFile = Path.Combine(path, fileName.Replace(".md", "-best.md"));
            File.Move(file, newFile);
        }

        /* PUBLIC FUNCTIONS */
        public async void PopulateMDFileView(string directory)
        {
            //Check if directory exists, if not - return
            if (!Directory.Exists(directory))
            {
                return;
            }

            //Clear Existing Nodes
            MDFileList.Nodes.Clear();

            //Load all folders and add them plus their subfiles into treeview
            string[] folders = Directory.GetDirectories(directory);
            foreach (string folder in folders)
            {
                string? folderName = Path.GetFileName(folder);
                if (folderName == null) continue;
                if (folderName == ".data") continue;

                MDTreeNode folderNode = new(folder, folderName, "", 0);

                string[] subFiles = Directory.GetFiles(folder);
                string firstTitle = "";
                foreach (string subFile in subFiles)
                {
                    string? fileName = Path.GetFileName(subFile);
                    MDReader mdReader = new(ProjectDirectory);
                    string title = await mdReader.ReadTitleAsync(fileName);
                    MDTreeNode fileNode = new(subFile, fileName, title, 0);
                    fileNode.Text = $"{fileName} - {title[..Math.Min(title.Length, 20)]} - {fileNode.score}";
                    firstTitle = title[..Math.Min(title.Length, 20)];

                    folderNode.Nodes.Add(fileNode);
                }

                folderNode.title = firstTitle;
                folderNode.Text = $"{folderName} - {firstTitle}";

                MDFileList.Nodes.Add(folderNode);
            }

            //Load all files and add into treeview
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                string? fileName = Path.GetFileName(file);
                MDReader mdReader = new(ProjectDirectory);
                string title = await mdReader.ReadTitleAsync(fileName);
                MDTreeNode fileNode = new(file, fileName, title, 0);
                fileNode.Text = $"{fileName} - {title[..Math.Min(title.Length, 20)]} - {fileNode.score}";

                MDFileList.Nodes.Add(fileNode);
            }

            //Reload Issue Context List
            LoadContextIssues();
        }
        public void LoadContextIssues()
        {
            ToolStripItemCollection contextItems = MDFileListContext.Items;
            ToolStripMenuItem moveItem = (ToolStripMenuItem)contextItems[0];
            ToolStripMenuItem moveToIssueItem = (ToolStripMenuItem)moveItem.DropDownItems[2];
            moveToIssueItem.DropDownItems.Clear();

            string[] issues = GetHighIssues().Concat(GetMediumIssues()).ToArray();
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
            MDReader mdReader = new(ProjectDirectory);
            string md = await mdReader.ReadFileContentAsync(fileName);
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
        void MainView_Load(object sender, EventArgs e)
        {
            PopulateMDFileView(ProjectDirectory);
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
            string file = MDFileList.SelectedNode.Text;
            if (!file.EndsWith(".md")) return;

            MDTreeNode? parentNode = (MDTreeNode)MDFileList.SelectedNode.Parent;
            if (parentNode != null) if (parentNode.name == InValidFolder) return;

            MoveToInvalid(file);
            TryRemoveParentNode(parentNode);
            PopulateMDFileView(ProjectDirectory);
        }
        void MDFileListMoveToRoot(object sender, EventArgs e)
        {
            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            MDTreeNode? parentNode = (MDTreeNode)MDFileList.SelectedNode.Parent;
            MoveToRoot(file);
            TryRemoveParentNode(parentNode);
            PopulateMDFileView(ProjectDirectory);
        }
        void MDFileListMoveToIssue(object? sender, EventArgs e, string currentIssue)
        {
            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            MDTreeNode? parentNode = (MDTreeNode)MDFileList.SelectedNode.Parent;
            if (parentNode != null) if (parentNode.name == currentIssue) return;

            MoveToIssue(file, currentIssue);
            TryRemoveParentNode(parentNode);
            PopulateMDFileView(ProjectDirectory);
        }
        void MDFileListGenerateHighIssue(object sender, EventArgs e)
        {
            MDTreeNode? parentNode = (MDTreeNode)MDFileList.SelectedNode.Parent;
            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            MoveToRoot(file);
            TryRemoveParentNode(parentNode);
            PopulateMDFileView(ProjectDirectory);
            MoveToNewIssue(file, Severity.High);
            PopulateMDFileView(ProjectDirectory);
        }
        void MDFileListGenerateMediumIssue(object sender, EventArgs e)
        {
            MDTreeNode? parentNode = (MDTreeNode)MDFileList.SelectedNode.Parent;
            string file = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!file.EndsWith(".md")) return;

            MoveToRoot(file);
            TryRemoveParentNode(parentNode);
            PopulateMDFileView(ProjectDirectory);
            MoveToNewIssue(file, Severity.Medium);
            PopulateMDFileView(ProjectDirectory);
        }
        void MDFileListUnmark(object sender, EventArgs e)
        {
            MDTreeNode? parentNode = (MDTreeNode)MDFileList.SelectedNode.Parent;
            if (parentNode == null) return;
            if (!parentNode.name.EndsWith("-H") && !parentNode.name.EndsWith("-M")) return;

            string fileName = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!fileName.EndsWith(".md")) return;

            string? file = MDReader.SearchFile(ProjectDirectory, fileName);
            if (file == null) return;

            UnmarkFile(file);

            PopulateMDFileView(ProjectDirectory);
        }
        void MDFileListMarkAsBest(object sender, EventArgs e)
        {
            MDTreeNode? parentNode = (MDTreeNode)MDFileList.SelectedNode.Parent;
            if (parentNode == null) return;
            if (parentNode.Nodes.Count < 2) return;
            if (!parentNode.name.EndsWith("-H") && !parentNode.name.EndsWith("-M")) return;

            string fileName = ((MDTreeNode)MDFileList.SelectedNode).name;
            if (!fileName.EndsWith(".md")) return;

            string? file = MDReader.SearchFile(ProjectDirectory, fileName);
            if (file == null) return;

            //Unmark all files in parent directory
            foreach (MDTreeNode node in parentNode.Nodes)
            {
                string? subFile = MDReader.SearchFile(ProjectDirectory, node.name);
                if (subFile == null) continue;

                UnmarkFile(subFile);
            }

            //Mark Selected File as best
            MarkFile(file);

            PopulateMDFileView(ProjectDirectory);
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
