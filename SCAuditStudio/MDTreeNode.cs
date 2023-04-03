using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAuditStudio
{
    public partial class MDTreeNode : TreeNode
    {
        public string name;
        public string title;
        public int score;

        public MDTreeNode(string name, string title, int score)
        {
            this.name = name;
            this.title = title;
            this.score = score;
        }
    }
}
