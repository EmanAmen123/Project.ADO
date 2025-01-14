using bussnise_layer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class adminProducts : Form
    {
        ProductsServices products;
        CategoriesServices categories;
        int updateid;

        public adminProducts()
        {
            InitializeComponent();
            products = new ProductsServices();
            categories = new CategoriesServices();
        }

        private void adminProducts_Load(object sender, EventArgs e)
        {
            DataTable dt = products.GetProducts();
            dgv_products.DataSource = dt;

            DataTable dt2 = categories.GetCategories();
            categories_comp.DataSource = dt2;
            categories_comp.DisplayMember = "CategoryName";
            categories_comp.ValueMember = "CategoryId";

            updatevalues.Visible = false;
            guna2Button2.Visible = false;
            guna2Button1.Visible = false;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int category = 0;
            string productname = nameInput.Text;
            int price = (int)priceInput.Value;
            category = (int)categories_comp.SelectedValue;


            if (string.IsNullOrEmpty(productname))
            {
                MessageBox.Show("Please enter a productname.");
                return;
            }

            if (category == 0)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            int result = products.AddProduct(productname, price, category);


            if (result > 0)
            {
                nameInput.Text = null;
                priceInput.Value = 0;
                categories_comp.Text = null;

                DataTable dt = products.GetProducts();
                dgv_products.DataSource = dt;
                MessageBox.Show("product Added successful.");


            }
            else
            {
                MessageBox.Show("Adding failed. Please try again.");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_products.CurrentRow.Cells[0].Value;

            //deleteconfirm confirmdelete = new deleteconfirm(id);
            //confirmdelete.Show();
            try
            {
                int result = products.Delete(id);
                if (result > 0)
                {
                    DataTable dt = products.GetProducts();
                    dgv_products.DataSource = dt;
                    MessageBox.Show("product Deleted Successfully");

                }
                else
                    MessageBox.Show("Deletion process failed.");
            }
            catch
            {
                MessageBox.Show("Deletion process failed.");

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            updatevalues.Visible = true;

            guna2Button2.Visible = false;
            updatevalues.Visible = true;
            guna2Button3.Visible = false;
            guna2Button1.Visible = false;
            updatevalues.Show();
            updateid = (int)dgv_products.CurrentRow.Cells[0].Value;
            if (updateid > 0)
            {
                nameInput.Text = dgv_products.CurrentRow.Cells["productname"].Value?.ToString();
                priceInput.Value = (int)dgv_products.CurrentRow.Cells["price"].Value;
                categories_comp.SelectedItem = dgv_products.CurrentRow.Cells["CategoryId"].Value;

            }
        }

        private void updatevalues_Click(object sender, EventArgs e)
        {
            updatevalues.Visible = false;
            guna2Button2.Visible = true;
            guna2Button1.Visible = true;
            guna2Button3.Visible = true;
            string name = nameInput.Text;
            int price = (int)priceInput.Value;
            object category = (int)categories_comp.SelectedValue;


            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (price == 0)
            {
                MessageBox.Show("Please enter a price.");
                return;
            }
            if ((int)category < 0)
            {
                MessageBox.Show("Please enter a category.");
                return;
            }


            int result = products.updateProducts(updateid, name, price, (int)category);


            if (result > 0)
            {
                nameInput.Text = null;
                priceInput.Value = 0;
                categories_comp.Text = null;
                DataTable dt = products.GetProducts();
                dgv_products.DataSource = dt;
                MessageBox.Show("product Updated successful.");

            }
            else
            {
                MessageBox.Show("Update failed. Please try again.");
            }
        }

        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void dgv_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guna2Button2.Visible = true;
            guna2Button1.Visible = true;
            guna2Button3.Visible = false; //add
        }
    }
}
