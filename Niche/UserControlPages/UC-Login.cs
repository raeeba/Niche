using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niche.UserControlPages
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Login(this.usersDataSet.Users, usernameTextbox.Text, passwordTextBox.Text);
        }
    }
}
