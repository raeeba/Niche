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
           // LoadData();
        }
        
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            if (userControl is UC_Jobs)
            {
                UC_Jobs uC_Jobs = userControl as UC_Jobs;
                uC_Jobs.LoadData();
            }
        }
        private void clearChecked()
        {
            homeBtn.Checked = false;
            jobsBtn.Checked = false;
            testimoniesBtn.Checked = false;
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
            uC_Jobs.Dock = DockStyle.Fill;
            // Call the LoadData method to load data into the dataset
            uC_Jobs.LoadData();
        }

        private void testimoniesBtn_Click(object sender, EventArgs e)
        {
            UC_Testimonies uC_Testimonies = new UC_Testimonies();
            addUserControl(uC_Testimonies);
            // Call the LoadData method to load data into the dataset
            uC_Testimonies.LoadData();
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
            MessageBox.Show("Niche created by Janna Lomibao & Raeeba Rahman, 2024.", "About Niche", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void loginRegisterBtn_Click(object sender, EventArgs e)
        {
            UC_Login uC_Login = new UC_Login();
            addUserControl(uC_Login);
            clearChecked();

        }

        private void jobsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.jobsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.nicheDataSet);

        }
    }
}
