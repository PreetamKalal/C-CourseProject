using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseProject
{
    public partial class Edit : Form
    {
        string file_loc = @"F:\7th Sem\C#\Dairy\";
        public Edit()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(Title.Text == "" || Content.Text == "")
            {
                MessageBox.Show("Enter Both Title and Content");
                return;
            }
            else
            {
                string file_name = Title.Text;
                file_loc = file_loc + file_name + ".txt";
                try
                {
                    if (!File.Exists(file_loc))
                    {
                        File.CreateText(file_loc).Close();
                        TextWriter txt = new StreamWriter(file_loc);
                        txt.WriteLine(Content.Text);
                        MessageBox.Show("Dairy Updated");
                        txt.Close();
                        if (Reminder.Checked == true)
                        {
                            if (StartDate.Value == DateTime.Now)
                            {
                                MessageBox.Show("Reminder : {0}", Title.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dairy Updated");
                        TextWriter txt = new StreamWriter(file_loc);
                        txt.WriteLine(Content.Text);
                        txt.Close();
                        if (Reminder.Checked == true)
                        {
                            if (StartDate.Value == DateTime.Now)
                            {
                                MessageBox.Show("Reminder : {0}", Title.Text);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }          
        }

        private void GoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage main_page = new MainPage();
            main_page.Show();
        }
    }
}
