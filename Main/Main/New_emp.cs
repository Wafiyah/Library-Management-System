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
    public partial class New_emp : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=HP-PC;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;

        public New_emp()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

                cmd = new SqlCommand("insert into Librarian (Name, Librarian_Id,Address,Qualification,Designation,Phone_Number) values ('" + txt_name.Text + "', '" + txt_id.Text + "','" + txt_add.Text + "','" + txt_qua.Text + "','" + txt_desig.Text + "','" + txt_phn.Text + "')", sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Successfull ");

                sc.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
