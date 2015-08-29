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
    public partial class New_entry_book : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=HP-PC;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        public New_entry_book()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administration_Menu frm = new Administration_Menu();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                cmd = new SqlCommand("insert into Book (Title,Author,ISBN,Catagory,Pub_Name,Quantity,Edition,availability) values ('" + txttitle.Text + "', '" + txtauthor.Text + "','" + txtISBN.Text + "','" +cmbgrp.Text + "','" + txtpub.Text + "','" + txtquantity.Text + "','" + txted.Text+ "' ,'" + txt_avail.Text+ "' )", sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Book Entry is Successfull .");
                sc.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
