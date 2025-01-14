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

    public partial class favurates : Form

    {
        FavuratesServices fav;
        User user;


        public favurates()
        {
            InitializeComponent();
            fav = new FavuratesServices();
            //// Name of the column you want to access
            //string columnName = "userid"; // Replace with your actual column name

            //// Check if the column exists in the DataGridView
            //if (dgv_fav.Columns.Contains(columnName))
            //{
            //    // Loop through each row in the DataGridView
            //    foreach (DataGridViewRow row in dgv_fav.Rows)
            //    {
            //        // Access the value of the column by column name
            //        int columnValue = (int)row.Cells[columnName].Value;

            //        // Optionally, process the value, for example:
            //        if (columnValue >0)
            //        {
            //            userid = columnValue;
            //            // Here, you can convert the value to the desired type if needed

            //        }
            //        else
            //        {
            //            MessageBox.Show("Column value is null.");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Column not found.");
            //}
            //user = new User(userid);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void favurates_Load(object sender, EventArgs e)
        {
            DataTable dt = fav.GetFavurates();
            dgv_fav.DataSource = dt;
            guna2Button2.Visible = false;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int productid = (int)dgv_fav.CurrentRow.Cells[1].Value;
            fav.Delete(productid);
            DataTable dt = fav.GetFavurates();
            dgv_fav.DataSource = dt;
        }

        private void dgv_fav_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guna2Button2.Visible = true;
        }
    }
}
