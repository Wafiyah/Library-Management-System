using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Main
{
    public partial class Administration_Login : Form
    {
       
        public Administration_Login()
        {
 
            InitializeComponent();
            textBox2.PasswordChar = '*';
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home a = new Home();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string u = ("Admin");
            string p = ("12345");

            if (textBox1.Text == u & textBox2.Text == p)
            {
                this.Hide();
                Administration_Menu frm = new Administration_Menu();
                frm.Show();
            }

            else
            {
                MessageBox.Show("In valid user name or passward please try again !!!");

                foreach (Control c in this.Controls)
                {
                    if (c.GetType().ToString().Contains("TextBox"))
                    {
                        ((TextBox)c).Text = "";
                    }
                }
            }




            //this.Hide();
            //Administration_Menu frm = new Administration_Menu();
            //frm.Show();
        }

        private void Administration_Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
