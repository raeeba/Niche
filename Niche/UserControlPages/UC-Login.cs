using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Niche.UserControlPages
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Labib\Dropbox\My PC (DESKTOP-L554P2E)\Documents\APP DEV\NicheFinal\Niche\Niche\NicheDB.mdf"";Integrated Security=True");
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //this.usersTableAdapter.Login(this.usersDataSet.Users, usernameTextbox.Text, passwordTextBox.Text);
            //MessageBox.Show("Welcome " + usernameTextbox.Text);
            String Username, Password;

            Username= usernameTextbox.Text;
            Password = passwordTextBox.Text;

            try
            {
                String query = "SELECT * FROM Users WHERE Username = '" + usernameTextbox.Text + "' AND Password = '" + passwordTextBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    Username = usernameTextbox.Text;
                    Password = passwordTextBox.Text;

                    // page that needed to be loaded next
                    UC_Home uC_Home = new UC_Home();
                    uC_Home.Show();
                    this.Hide();
                    /*HomeForm home = new HomeForm();
                    home.addUserControl(uC_Home);
                    this.Hide();*/
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextbox.Clear();
                    passwordTextBox.Clear();

                    // to focus username
                    usernameTextbox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
