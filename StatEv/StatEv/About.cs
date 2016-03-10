using StatEv.Classes;
using System;
using System.Windows.Forms;

namespace StatEv
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            InitAbout();
        }

        private void InitAbout()
        {
            versionLb.Text = Messages.AppVersion + GlobalHelper.GetVersion(2);
            int year = DateTime.Now.Year;
            authorLb.Text = (year > 2016 ? "2016-" + DateTime.Now.Year : "2016") + " © " + Messages.AppAuthor;
        }
    }
}
