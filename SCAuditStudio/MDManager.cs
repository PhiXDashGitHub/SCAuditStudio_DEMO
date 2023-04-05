using Markdig.Extensions.NonAsciiNoEscape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SCAuditStudio
{
    public class MDManager
    {
        readonly string directory = @"C:\";
        readonly string invalidFolder = "invalid";

        public enum MDFileIssue { Medium, High }

        public MDFile[] mdFiles = Array.Empty<MDFile>();
        
        public MDManager(string directory)
        {
            this.directory = directory;
        }

        /* INTERNAL FUNCTIONS */
        void IMoveFileTo(string name, string subPath)
        {
            //Only move .md files
            if (!name.EndsWith(".md")) return;

            //Get file
            MDFile? mdFile = GetFile(name);
            if (mdFile == null) return;
            if (mdFile.subPath == subPath) return;

            //Create subdirectory if necessary
            string dir = Path.Combine(directory, subPath);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            //Move file to location
            string oldPath = Path.GetDirectoryName(mdFile.path) ?? "";
            string path = Path.Combine(dir, name);
            File.Move(mdFile.path, path);
            mdFile.subPath = subPath;
            mdFile.path = path;

            //Try remove folder if empty
            if (Directory.GetFiles(oldPath).Length == 0)
            {
                Directory.Delete(oldPath);
            }
        }
        string IRenameFileTo(string name, string newName)
        {
            //Only rename .md files
            if (!name.EndsWith(".md")) return name;

            //Get file
            MDFile? mdFile = GetFile(name);
            if (mdFile == null) return name;

            string? dir = Path.GetDirectoryName(mdFile.path);
            if (dir == null) return name;

            //Rename file
            string path = Path.Combine(dir, newName);
            File.Move(mdFile.path, path);
            mdFile.path = path;

            return newName;
        }

        /* PUBLIC FUNCTIONS */
        public MDFile? GetFile(string name)
        {
            foreach (MDFile mdFile in mdFiles)
            {
                if (Path.GetFileName(mdFile.path) == name)
                {
                    return mdFile;
                }
            }

            return null;
        }
        public void SetFileTree(TreeNodeCollection nodes)
        {
            Dictionary<MDTreeNode, bool> expandedNodes = new();
            MDTreeNode? selectedNode = nodes.Count > 0 ? (MDTreeNode)nodes[0].TreeView.SelectedNode : null;

            for (int i = 0; i < nodes.Count; i++)
            {
                expandedNodes.Add((MDTreeNode)nodes[i], nodes[i].IsExpanded);
            }

            //Clear nodes first
            nodes.Clear();

            //Load files in subdirectories
            string[] subDirs = Directory.GetDirectories(directory);
            foreach (string subDir in subDirs)
            {
                string[] subFiles = Directory.GetFiles(subDir);
                string subName = Path.GetFileName(subDir);
                MDTreeNode subNode = new(subName, "untitled", 0);

                string previewTitle = "untitled";

                foreach (string file in subFiles)
                {
                    string fileName = Path.GetFileName(file);
                    MDTreeNode fileNode = new(fileName, "untitled", 0);
                    fileNode.Text = $"{fileNode.name}";

                    if (file.EndsWith(".md"))
                    {
                        MDFile? mDFile = GetFile(fileName);
                        fileNode.title = mDFile?.title[..Math.Min(30,mDFile.title.Length)] ?? "untitled";
                        fileNode.score = mDFile?.score ?? 0;
                        previewTitle = fileNode.title.TrimEnd() + (mDFile?.title.Length > 30 ? "..." : "");
                        fileNode.Text += $" - {fileNode.title.TrimEnd() + (mDFile?.title.Length > 30 ? "..." : "")} - {fileNode.score}";
                    }

                    subNode.Nodes.Add(fileNode);
                }

                subNode.title = previewTitle;
                subNode.Text = $"{subNode.name}";
                if (IsIssue(subNode.name)) subNode.Text += $" - {subNode.title}";

                nodes.Add(subNode);
            }

            //Load files in root directory
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                MDTreeNode fileNode = new(fileName, "untitled", 0);
                fileNode.Text = $"{fileNode.name}";

                if (file.EndsWith(".md"))
                {
                    MDFile? mDFile = GetFile(fileName);
                    fileNode.title = mDFile?.title[..Math.Min(30, mDFile.title.Length)] ?? "untitled";
                    fileNode.score = mDFile?.score ?? 0;
                    fileNode.Text += $" - {fileNode.title.TrimEnd() + (mDFile?.title.Length > 30 ? "..." : "")} - {fileNode.score}";
                }

                nodes.Add(fileNode);
            }

            //Expand all previously expanded nodes
            for (int n = 0; n < nodes.Count; n++)
            {
                for (int e = 0; e < expandedNodes.Count; e++)
                {
                    if (((MDTreeNode)nodes[n]).name == expandedNodes.ElementAt(e).Key.name && expandedNodes.ElementAt(e).Value)
                    {
                        nodes[n].Expand();
                    }
                }

                //Select previously selected node
                if (selectedNode == null) continue;
                if (((MDTreeNode)nodes[n]).name == selectedNode.name)
                {
                    nodes[0].TreeView.SelectedNode = nodes[n];
                }
            }
        }
        public string[] GetIssues(MDFileIssue severity)
        {
            char severityLetter = severity == MDFileIssue.Medium ? 'M' : 'H';
            string[] issues = Directory.GetDirectories(directory, $"*-{severityLetter}");
            for (int i = 0; i < issues.Length; i++)
            {
                issues[i] = Path.GetFileName(issues[i]);
            }

            return issues;
        }
        public bool IssueExists(MDFileIssue severity, int index)
        {
            char severityLetter = severity == MDFileIssue.Medium ? 'M' : 'H';
            string issue = Path.Combine(directory, $"{index:000}-{severityLetter}");
            
            return Directory.Exists(issue);
        }
        public bool IssueExists(string issue)
        {
            if (!IsIssue(issue)) return false;
            return Directory.Exists(Path.Combine(directory, issue));
        }
        public int GetMDFileCountInSubPath(string subPath)
        {
            string dir = Path.Combine(directory, subPath);
            if (!Directory.Exists(dir)) return 0;

            return Directory.GetFiles(dir).Length;
        }
        public int GetIssueIndex(MDFileIssue severity)
        {
            for (int i = 1; i < 999; i++)
            {
                if (!IssueExists(severity, i)) return i;
            }

            return 999;
        }
        public void MoveFileToRoot(string name)
        {
            IMoveFileTo(name, "");
        }
        public void MoveFileToInvalid(string name)
        {
            IMoveFileTo(name, invalidFolder);
        }
        public void MoveFileToIssue(string name, string issue, bool createNew)
        {
            //Check if Issue exists, if not - return
            if (!createNew && !IssueExists(issue)) return;

            IMoveFileTo(name, issue);
        }
        public void MoveFileToIssue(string name, MDFileIssue severity, int index, bool createNew)
        {
            //Check if Issue exists, if not - return
            if (!createNew && !IssueExists(severity, index)) return;

            char severityLetter = severity == MDFileIssue.Medium ? 'M' : 'H';
            string issue = $"{index:000}-{severityLetter}";

            IMoveFileTo(name, issue);
        }
        public string MarkFileAsBest(string name)
        {
            return IRenameFileTo(name, name.Replace(".md", "-best.md"));
        }
        public string UnmarkFile(string name)
        {
            return IRenameFileTo(name, name.Replace("-best.md", ".md"));
        }

        /* STATIC FUNCTIONS */
        public static bool IsIssue(string name)
        {
            return (name.EndsWith("-M") || name.EndsWith("-H")) && char.IsDigit(name[0]) && char.IsDigit(name[1]) && char.IsDigit(name[2]);
        }
        public static void UpdateFileTreeNode(MDTreeNode node)
        {
            node.Text = $"{node.name}";
            if (node.name.EndsWith(".md")) node.Text += $" - {node.title} - {node.score}";
            else node.Text += $" - {node.title}";
        }

        public async Task LoadFilesAsync()
        {
            List<MDFile> mdFileList = new();

            //Load files in root directory
            string[] files = Directory.GetFiles(directory, "*.md");
            foreach (string file in files)
            {
                MDFile mdFile = await MDReader.ReadFileAsync(file, true);
                mdFileList.Add(mdFile);
            }

            //Load files in subdirectories
            string[] subDirs = Directory.GetDirectories(directory);
            foreach (string subDir in subDirs)
            {
                files = Directory.GetFiles(subDir, "*.md");

                foreach (string file in files)
                {
                    MDFile mdFile = await MDReader.ReadFileAsync(file, true);
                    mdFile.subPath = Path.GetFileName(subDir);
                    mdFileList.Add(mdFile);
                }
            }

            mdFiles = mdFileList.OrderBy(f => Path.GetFileName(f.path)).ToArray();
        }
    }
}
