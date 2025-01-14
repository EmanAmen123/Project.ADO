using bussnise_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado.presentation
{
    public partial class adminCategories : Form
    {
        CategoriesServices categories;

        public adminCategories()
        {
            InitializeComponent();
            categories = new CategoriesServices();

        }

        private void adminCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = categories.GetCategories();
            dgv_products.DataSource = dt;
            guna2Button1.Visible = false;
            guna2Button2.Visible = false;

        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            string categoryName = categoryInput.Text;



            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a categoryName.");
                return;
            }



            int result = categories.AddCategory(categoryName);


            if (result > 0)
            {
                categoryInput.Text = null;
                DataTable dt = categories.GetCategories();
                dgv_products.DataSource = dt;
                MessageBox.Show("category Added successful.");

            }
            else
            {
                MessageBox.Show("Adding failed. Please try again.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_products.CurrentRow.Cells[0].Value;

            try
            {
                int result = categories.Delete(id);
                if (result > 0)
                {
                    DataTable dt = categories.GetCategories();
                    dgv_products.DataSource = dt;
                    MessageBox.Show("category Deleted Successfully");

                }
                else
                    MessageBox.Show("Deletion process failed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deletion process failed {ex.Message}.");

            }
        }

        private void dgv_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guna2Button1.Visible = true;
            guna2Button2.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}

