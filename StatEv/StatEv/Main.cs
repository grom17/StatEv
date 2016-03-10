using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StatEv
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FormInit();
        }

        private void FormInit()
        {
            Text = Messages.AppTitle;
            fileToolStripMenuItem.Text = Messages.MenuItem_File;
            loadToolStripMenuItem.Text = Messages.MenuItem_Load;
            saveToolStripMenuItem.Text = Messages.MenuItem_Save;
            exitToolStripMenuItem.Text = Messages.MenuItem_Exit;
            settingsToolStripMenuItem.Text = Messages.MenuItem_Settings;
            languageToolStripMenuItem.Text = Messages.MenuItem_Language;
            statsRangeToolStripMenuItem.Text = Messages.MenuItem_StatsRange;
            aboutToolStripMenuItem.Text = Messages.MenuItem_About;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "EN";
            FormInit();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "RU";
            FormInit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
