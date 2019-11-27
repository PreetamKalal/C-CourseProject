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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog = Dairy; Integrated Security = True; Pooling = False";

        private void MainPage_Load(object sender, EventArgs e)
        {
            UserName.Text = Login.user_name;
            FirstName.Text = Login.first_name;
            LastName.Text = Login.last_name;
            Email.Text = Login.e_mail;
            Password.Text = Login.pass_word;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string s = "update LoginTable set firstname = @firstname, lastname = @lastname, email = @email, password = @password where username = @username";
                con.Open();
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@firstname", FirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", LastName.Text);
                cmd.Parameters.AddWithValue("@email", Email.Text);
                cmd.Parameters.AddWithValue("@password", Password.Text);
                cmd.Parameters.AddWithValue("@username", UserName.Text);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Data Updated Successfully");
                    while (dr.Read())
                    {
                        FirstName.Text = dr["firstname"].ToString();
                        LastName.Text = dr["lastname"].ToString();
                        Email.Text = dr["email"].ToString();
                        Password.Text = dr["password"].ToString();
                    }
                }
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoToDairy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit();
            edit.Show();
        }
    }
}
