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

    public partial class User : Form
    {
        ProductsServices products;
        FavuratesServices favurate;
        int userid;
        public User(int userid)
        {
            InitializeComponent();
            products = new ProductsServices();
            favurate = new FavuratesServices();
            this.userid = userid;

        }

        private void User_Load(object sender, EventArgs e)
        {
            DataTable dt = products.GetProducts();
            dgv_products.DataSource = dt;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int productid = (int)dgv_products.CurrentRow.Cells[0].Value;
            string productname = dgv_products.CurrentRow.Cells[1].Value.ToString();

            try
            {
                int result = favurate.AddToFavurite(userid, productid);
                if (result > 0)
                {
                    MessageBox.Show($"{productname} added  Successfully");


                }
                else
                    MessageBox.Show("adding process failed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Adding process failed. Error: {ex.Message}.");

            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            favurates fav = new favurates();
            fav.Show();
            this.Hide();
          
        }
        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 signin = new Form1();
            signin.Show();
            this.Hide();
            
        }
    }
}
