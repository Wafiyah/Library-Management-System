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
    public partial class Delete_info : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=HP-PC;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;

        public Delete_info()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administration_Menu frm = new Administration_Menu();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
      
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

                if (comboBox1.Text == "Teacher" || comboBox1.Text == "Student")
                {
                    cmd = new SqlCommand("Delete from Member Where mem_Id='" + txt_id.Text + "'", sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully.");
                    sc.Close();
                }

                else
                {
                    cmd = new SqlCommand("Delete from Librarian Where Librarian_Id='" + txt_id.Text + "'", sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Sucessfully.");
                    sc.Close();

                }
                sc.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_info_Load(object sender, EventArgs e)
        {

        }
    }
}
