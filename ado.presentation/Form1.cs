using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace ado.presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = emailInput.Text;
            string password = passInput.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a emailInput.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            string connectionString = "server=DESKTOP-AFGBK7M\\SQLEXPRESS01;Database=adoDatabase;Trusted_Connection=true;Trust Server Certificate =true";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string command = "select role,userid from Users where email = @email and password = @Password";
                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                object role = reader[0]; // First column (role)
                                object userid = reader[1]; // Second column (userid)
                              
                                
                                    if (role.ToString() == "admin")
                                    {
                                        Admin adminform = new Admin();
                                        adminform.Show();
                                        this.Hide();
                                    }
                                    else if (role.ToString() == "user")
                                    {
                                        //MessageBox.Show("user1");

                                        User userform = new User((int)userid);
                                        userform.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                         MessageBox.Show("invalid password or username");

                                    }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("invalid password or username");
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
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