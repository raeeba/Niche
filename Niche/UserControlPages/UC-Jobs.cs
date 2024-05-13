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
    public partial class UC_Jobs : UserControl
    {
        public UC_Jobs()
        {
            InitializeComponent();
        }

        private void jobsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nicheDataSet);

        }

        private void jobsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.jobsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nicheDataSet);

        }
        public void LoadData()
        {
            try
            {
                // Your code to populate the dataset with data from the database
                // For example:
                this.jobsTableAdapter.Fill(this.nicheDataSet.Jobs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

    }
}
