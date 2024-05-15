using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niche.UserControlPages
{
    public partial class UC_Library : UserControl
    {
        public UC_Library()
        {
            InitializeComponent();
        }

        private void libraryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // change LinkColor after it has been clicked
            libraryLinkLabel.LinkVisited = true;

            // open the html file
            // write path of the file
            string htmlFileName = "library.html"; // html file
            string htmlFilePath = Path.Combine(Application.StartupPath, htmlFileName); // full path to html file

            try
            {
                Process.Start(htmlFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening HTML file: " + ex.Message);
            }
        }
    }
}
