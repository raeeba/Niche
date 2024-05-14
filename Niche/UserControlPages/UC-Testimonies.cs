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
    public partial class UC_Testimonies : UserControl
    {
        public UC_Testimonies()
        {
            InitializeComponent();
        }

        private void testimonialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testimonialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testimonialsDataSet);

        }

        public void LoadData()
        {
            try
            {
                // Your code to populate the dataset with data from the database
                // For example:
                this.testimonialsTableAdapter.Fill(this.testimonialsDataSet.Testimonials);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.testimonialsTableAdapter.SearchTestimonial(this.testimonialsDataSet.Testimonials, searchTextBox.Text);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.testimonialsTableAdapter.Fill(this.testimonialsDataSet.Testimonials);
        }
    }
}
