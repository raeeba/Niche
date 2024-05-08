using Niche.UserControlPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niche
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            UC_Home uC_Home = new UC_Home();
            addUserControl(uC_Home);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void clearButtonChecked()
        {
            homeBtn.Checked = false;
            jobsBtn.Checked = false ;
            testimoniesBtn.Checked = false ;
            libraryBtn.Checked = false;
            aboutBtn.Checked = false;

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            UC_Home uC_Home = new UC_Home();   
            addUserControl(uC_Home);

        }

        private void jobsBtn_Click(object sender, EventArgs e)
        {
            UC_Jobs uC_Jobs = new UC_Jobs();
            addUserControl(uC_Jobs);
        }

        private void testimoniesBtn_Click(object sender, EventArgs e)
        {
            UC_Testimonies uC_Testimonies = new UC_Testimonies();
            addUserControl(uC_Testimonies);
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            UC_Library uC_Library = new UC_Library();
            addUserControl(uC_Library);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            UC_About uC_About = new UC_About();
            addUserControl(uC_About);
        }

        private void profileImageButton_Click(object sender, EventArgs e)
        {
            UC_Profile uC_Profile = new UC_Profile();
            addUserControl(uC_Profile);
            clearButtonChecked();
        }
    }
}
