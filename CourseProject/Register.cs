using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog = Dairy; Integrated Security = True; Pooling = False";

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if(UserName.Text != "" && Email.Text != "" && Password.Text != "" && FirstName.Text != "" && LastName.Text != "" & ConfirmPassword.Text != "")
            {
                if(Password.Text == ConfirmPassword.Text)
                {
                    if(IsValidEmail(Email.Text))
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(cs);
                            string s = "insert into LoginTable (username, email, password, firstname, lastname) values (@username, @email, @password, @firstname, @lastname)";
                            con.Open();
                            SqlCommand cmd = new SqlCommand(s, con);
                            cmd.Parameters.AddWithValue("@username", UserName.Text);
                            cmd.Parameters.AddWithValue("@password", Password.Text);
                            cmd.Parameters.AddWithValue("@email", Email.Text);
                            cmd.Parameters.AddWithValue("@firstname", FirstName.Text);
                            cmd.Parameters.AddWithValue("@lastname", LastName.Text);
                            cmd.CommandType = CommandType.Text;
                            int i = cmd.ExecuteNonQuery();
                            if (i != 0)
                            {
                                MessageBox.Show("Registration Successful!");
                                this.Hide();
                                Login login = new Login();
                                login.Show();
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Registration Failed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid E-mail Address");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Do not match");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter all details");
                return;
            }          
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private bool IsValidEmail(string mail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
