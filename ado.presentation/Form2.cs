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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            adminUsers users = new adminUsers();
            users.Show();
            this.Hide();

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            adminProducts products = new adminProducts();
            products.Show();
            this.Hide();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            adminCategories categories = new adminCategories();
            categories.Show();
            this.Hide();
        }
    }
}
