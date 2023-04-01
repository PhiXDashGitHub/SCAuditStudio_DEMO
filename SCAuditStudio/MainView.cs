using Microsoft.Web.WebView2.WinForms;

namespace SCAuditStudio
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        /* PUBLIC FUNCTIONS */
        public void PopulateMDFileView(string directory)
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
                TreeNode folderNode = new(folderName);

                string[] subFiles = Directory.GetFiles(folder);
                foreach (string subFile in subFiles)
                {
                    string? fileName = Path.GetFileName(subFile);
                    TreeNode fileNode = new(fileName);

                    folderNode.Nodes.Add(fileNode);
                }

                MDFileList.Nodes.Add(folderNode);
            }

            //Load all files and add into treeview
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                string? fileName = Path.GetFileName(file);
                TreeNode fileNode = new(fileName);

                MDFileList.Nodes.Add(fileNode);
            }
        }
        public async Task ViewMDFileFromView(TabPage page, string directory, string fileName)
        {
            //Check for .md file first
            if (!fileName.EndsWith(".md")) { return; }

            //Read MD file raw
            MDReader mdReader = new(directory);
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
            PopulateMDFileView(@"C:\Users\Phillip\Downloads\2023-02-gmx-judging-Oot2k\2023-02-gmx-judging-Oot2k");
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
        public async void MDFileList_ViewElement(object sender, TreeNodeMouseClickEventArgs e)
        {
            string fileName = MDFileList.Nodes[MDFileList.SelectedNode.Index].Text;

            //Return if Tab already opened
            if (TabInCollection(fileName)) return;

            //Create Tab and add WebView
            TabPage page = new(fileName);
            await ViewMDFileFromView(page, @"C:\Users\Phillip\Downloads\2023-02-gmx-judging-Oot2k\2023-02-gmx-judging-Oot2k", fileName);

            //Add TabPage to list
            MDFileViewTabs.TabPages.Add(page);

            MDFileViewTabs.SelectedTab = page;
        }
    }
}
