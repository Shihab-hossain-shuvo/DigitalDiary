using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDiary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//create
        {
            {

                Myclass data = new Myclass();

                {
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dayeri"].ConnectionString);
                    connection.Open();
                    string query = "Select * from Users where Username='" + textBox1.Text + "'and UPassword='" + textBox2.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();


                    if (!reader.HasRows)
                    {

                        MessageBox.Show("Wrong Username or password");
                    }
                    else
                    {


                        textBox1.Text = null;
                        textBox2.Text = null;

                        Form2 f = new Form2();
                        f.Show();
                        this.Hide();

                        reader.Close();
                        connection.Close();

                    }
                }




            }

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}




