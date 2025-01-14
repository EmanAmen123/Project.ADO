using bussnise_layer;
using Guna.UI2.WinForms;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ado.presentation
{
    public partial class adminUsers : Form
    {
        UsersServices users;
        int updateid;
        public adminUsers()
        {
            InitializeComponent();
            users = new UsersServices();
            DataTable dt = users.GetUsers();
            dgv_users.DataSource = dt;

        }

        private void adminUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = users.GetUsers();
            dgv_users.DataSource = dt;
            guna2Button2.Visible = false;
            guna2Button1.Visible = false;
            updatevalues.Visible = false;

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //int age = 0;
            string name = nameInput.Text;
            string email = emailInput.Text;
            string password = passInput.Text;
            string address = addInput.Text;
            int age = (int)ageInput.Value;
            string role = roleInput.Text;
            //string role = "user";

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a email.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter a address.");
                return;
            }
            //if (int.MaxValue(age))
            //{
            //    MessageBox.Show("Please enter a age.");
            //    return;
            //}
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter a role.");
                return;
            }


            //if (!int.TryParse(ageInput.Value, out age))
            //{
            //    MessageBox.Show("Please enter a valid age.");
            //    return;
            //}


            UsersServices usersService = new UsersServices();


            int result = usersService.AddUser(name, email, password, age, address, role);


            if (result > 0)
            {
                nameInput.Text = null;
                emailInput.Text = null;
                passInput.Text = null;
                addInput.Text = null;
                ageInput.Value = 0;
                roleInput.Text = null;
                DataTable dt = users.GetUsers();
                dgv_users.DataSource = dt;
                MessageBox.Show("User Added successful.");

            }
            else
            {
                MessageBox.Show("Adding failed. Please try again.");
            }
        }


        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passInput.PasswordChar = '\0';

            }
            else
            {
                passInput.PasswordChar = '*';

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_users.CurrentRow.Cells[0].Value;

            //deleteconfirm confirmdelete = new deleteconfirm(id);
            //confirmdelete.Show();
            try
            {
                int result = users.Delete(id);
                if (result > 0)
                {
                    DataTable dt = users.GetUsers();
                    dgv_users.DataSource = dt;
                    MessageBox.Show("User Deleted Successfully");

                }
                else
                    MessageBox.Show("Deletion process failed.");
            }
            catch
            {
                MessageBox.Show("Deletion process failed.");

            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }
        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
            updatevalues.Visible = true;
            guna2Button3.Visible = false;
            guna2Button1.Visible = false;
            updatevalues.Show();
            updateid = (int)dgv_users.CurrentRow.Cells[0].Value;
            if (updateid > 0)
            {
                nameInput.Text = dgv_users.CurrentRow.Cells["name"].Value?.ToString();
                emailInput.Text = dgv_users.CurrentRow.Cells["email"].Value?.ToString();
                passInput.Text = dgv_users.CurrentRow.Cells["password"].Value?.ToString();
                ageInput.Value = (int)dgv_users.CurrentRow.Cells["age"].Value;
                addInput.Text = dgv_users.CurrentRow.Cells["address"].Value?.ToString();
                roleInput.SelectedItem = dgv_users.CurrentRow.Cells["role"].Value?.ToString();




            }
        }

        private void updatevalues_Click(object sender, EventArgs e)
        {
            updatevalues.Visible = false;
            guna2Button2.Visible = true;
            guna2Button1.Visible = true;
            guna2Button3.Visible = true;
            string name = nameInput.Text;
            string email = emailInput.Text;
            string password = passInput.Text;
            string address = addInput.Text;
            int age = (int)ageInput.Value;
            string role = roleInput.Text;


            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a email.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter a address.");
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter a role.");
                return;
            }


            int result = users.updateUser(updateid, name, email, password, age, address, role);


            if (result > 0)
            {
                nameInput.Text = null;
                emailInput.Text = null;
                passInput.Text = null;
                addInput.Text = null;
                ageInput.Value = 0;
                roleInput.Text = null;
                DataTable dt = users.GetUsers();
                dgv_users.DataSource = dt;
                MessageBox.Show("User Updated successful.");

            }
            else
            {
                MessageBox.Show("Update failed. Please try again.");
            }

        }

        private void showPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passInput.PasswordChar = '\0';

            }
            else
            {
                passInput.PasswordChar = '*';


            }
        }

        private void dgv_users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guna2Button2.Visible = true;
            guna2Button1.Visible = true;
            guna2Button3.Visible = false;
        }
    }
}
