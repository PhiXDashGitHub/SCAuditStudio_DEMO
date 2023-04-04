using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCAuditStudio.SettingsMenuTabs
{
    public partial class ProjectPropertiesTab : Form
    {
        public ProjectPropertiesTab()
        {
            InitializeComponent();
            textBoxBlackList.Text = ConfigFile.Read<string>("BlackList");
            textBoxJudgingCriteria.Text = ConfigFile.Read<string>("JudgingCriteria");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxJudgingCriteria.Text = ofd.FileName;
                ConfigFile.Write("JudgingCriteria", ofd.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxBlackList.Text = ofd.FileName;
                ConfigFile.Write("BlackList", ofd.FileName);

            }
        }
    }
}
