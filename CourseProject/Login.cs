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
    public partial class Login : Form
    {
        public static string first_name;
        public static string last_name;
        public static string user_name;
        public static string e_mail;
        public static string pass_word;

        public Login()
        {
            InitializeComponent();
        }

        string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog = Dairy; Integrated Security = True; Pooling = False";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please enter all details");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from LoginTable where UserName = @username and Email = @email and Password = @password", con);
                cmd.Parameters.AddWithValue("@username", UserName.Text);
                cmd.Parameters.AddWithValue("@password", Password.Text);
                cmd.Parameters.AddWithValue("@email", Email.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    SqlCommand cmd1 = new SqlCommand("Select firstname, lastname from LoginTable where Username = @username", con);
                    cmd1.Parameters.AddWithValue("@username", UserName.Text);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if(dr.HasRows)
                    {
                        while(dr.Read())
                        {
                            first_name = dr["firstname"].ToString();
                            last_name = dr["lastname"].ToString();
                        }
                    }
                    user_name = UserName.Text;
                    e_mail = Email.Text;
                    pass_word = Password.Text;
                    this.Hide();
                    MainPage main_page = new MainPage();
                    main_page.Show();
                    dr.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

    }
}
