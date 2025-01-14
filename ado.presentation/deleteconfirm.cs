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
    public partial class deleteconfirm : Form
    {
        UsersServices users;
        int id;
        adminUsers admin;
        public deleteconfirm(int id)
        {
            InitializeComponent();
            users = new UsersServices();

            this.id = id;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int result = users.Delete(id);
            this.Close();
            if (result > 0)
            {
                MessageBox.Show("deleted sucess");
                admin = new adminUsers();
                
            }
            else
                MessageBox.Show("deleted failed.");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
