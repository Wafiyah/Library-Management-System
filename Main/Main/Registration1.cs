using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main
{
    public partial class Registration1 : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=HP-PC;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        public Registration1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
               sc.Open();
               cmd = new SqlCommand("insert into Member (Name,Catagory,Address,Phone_Number,Date_of_birth,Department,Qualification,Designation,Joining_date,Expire_date) values ('" + txtname.Text + "','" + cmbcatagory.Text + "','" +txtadd.Text + "','" + txtphn.Text + "','" + txtbirth.Text + "','"  + cmbdept.Text + "','" + cmbqua.Text + "','" + cmbdesig.Text + "','" + txtjoin.Text + "','" + txtexp.Text + "' )", sc);
               cmd.ExecuteNonQuery();
               MessageBox.Show("Registration Successfull .");
               sc.Close();

           }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           // MessageBox.Show("Registration is Successfull.");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administration_Menu a = new Administration_Menu();
            a.Show();
        }

        private void Registration1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType().ToString().Contains("TextBox"))
                {
                    ((TextBox)c).Text = "";
                }
            }
        }
    }
}
