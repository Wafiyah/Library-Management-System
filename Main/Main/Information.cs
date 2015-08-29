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
    public partial class Information : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=SADIA-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
        SqlCommand cmd;

        public Information()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administration_Menu frm = new Administration_Menu();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            comboBox.SelectedIndex = -1;

            foreach (Control c in this.Controls)
            {
                if (c.GetType().ToString().Contains("TextBox"))
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                sc.Open();

                if (comboBox.Text == "Teacher" || comboBox.Text == "Student" )
                {
                    using (SqlDataAdapter a = new SqlDataAdapter("select * from Member where ( mem_id='" + txt_id.Text + "' or Name='" + txt_name.Text + "') ", sc))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView1.DataSource = t;
                    }

                }

                else
                {
                    using (SqlDataAdapter a = new SqlDataAdapter("select * from Librarian where ( (Librarian_Id='" + txt_id.Text + "') or (Name='" + txt_name.Text + "') ) ", sc))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView1.DataSource = t;
                    }

                }

                sc.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
