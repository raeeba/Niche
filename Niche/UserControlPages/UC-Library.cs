using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

            // program called as if in run 
            // menu and full path not needed
            Process.Start("about.html");
        }
    }
}
