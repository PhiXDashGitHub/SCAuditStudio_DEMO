using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                TreeNode folderNode = new TreeNode(folderName);

                string[] subFiles = Directory.GetFiles(folder);
                foreach (string subFile in subFiles)
                {
                    string? fileName = Path.GetFileName(subFile);
                    TreeNode fileNode = new TreeNode(fileName);

                    folderNode.Nodes.Add(fileNode);
                }

                MDFileList.Nodes.Add(folderNode);
            }

            //Load all files and add into treeview
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                string? fileName = Path.GetFileName(file);
                TreeNode fileNode = new TreeNode(fileName);

                MDFileList.Nodes.Add(fileNode);
            }
        }

        /* EVENTS */
        void MainView_Load(object sender, EventArgs e)
        {
            PopulateMDFileView(@"C:\Users\Phillip\Downloads\2023-02-gmx-judging-Oot2k\2023-02-gmx-judging-Oot2k");
        }
    }
}
