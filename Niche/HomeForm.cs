﻿using Niche.UserControlPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Niche
{
    public partial class HomeForm : Form
    {
        private bool isToggled = false; // toggle button
        public HomeForm()
        {
            InitializeComponent();
            UC_Home uC_Home = new UC_Home();
            addUserControl(uC_Home);
            //UC_Login uC_Login = new UC_Login();
            //addUserControl(uC_Login);
            // LoadData();
        }
        
        public void addUserControl(UserControl userControl)
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

        public void OpenLibrary()
        {
            UC_Library uC_Library = new UC_Library();
            addUserControl(uC_Library);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            UC_About uC_About = new UC_About();
            addUserControl(uC_About);
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

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch (languageComboBox.SelectedIndex)
            {
                case 0 :    changeLanguage.UpdateConfig("language", "en");
                            Application.Restart();
                            break;

                case 1:     changeLanguage.UpdateConfig("language", "fr-CA");
                            Application.Restart();
                            break;

                case 2:     changeLanguage.UpdateConfig("language", "es");
                            Application.Restart();
                            break;
            }
        }

        private void themeToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            isToggled = !isToggled;

            // update the appearance of the form
            UpdateFormAppearance();
        }

        private void UpdateFormAppearance()
        {
            if (isToggled)
            {
                // light mode
                upperPanel.BackColor = Color.LightSteelBlue;
                footerPanel.BackColor = Color.LightSteelBlue;
                headerLabel.ForeColor = Color.BlueViolet;
                footerLabel.ForeColor = Color.BlueViolet;
            }
            else
            {
                // dark mode
                upperPanel.BackColor = SystemColors.ControlDarkDark;
                footerPanel.BackColor = SystemColors.ControlDarkDark;
                headerLabel.ForeColor = Color.Salmon;
                footerLabel.ForeColor = Color.Salmon;
            }
        }
    }
}
