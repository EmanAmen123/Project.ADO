using bussnise_layer;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;

namespace ado.presentation
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //int age = 0;
            string name = nameInput.Text;
            string email = emailInput.Text;
            string password = passInput.Text;
            string address = addInput.Text;
            int age = (int)ageInput.Value;
            //string role = roleInput.Text;
            string role = "user";
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
                MessageBox.Show("Registration successful.");
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 signin = new Form1();
            signin.Show();
            this.Hide();

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
    }
}

