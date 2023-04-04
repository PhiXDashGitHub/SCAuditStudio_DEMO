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
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
            OpenChildForm(new SettingsMenuTabs.ProjectPropertiesTab());
        }

        private void buttonOpenProjectProperties_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsMenuTabs.ProjectPropertiesTab());
        }
        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAISettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsMenuTabs.AISettingsTab());
        }
    }
}
