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
    public partial class Return_List : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=HP-PC;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;

        public Return_List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
                sc.Open();
                cmd = new SqlCommand("update Book set availability=availability+1 where ISBN='" + txt_isbn.Text + "'", sc);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Update Retrn Set Retrn_date='" + txt_retrn.Text + "' Where mem_Id='" + txt_id.Text + "'", sc);
                cmd.ExecuteNonQuery();
               
                using (SqlDataAdapter a = new SqlDataAdapter("select * from Retrn where (mem_Id='" + txt_id.Text + "' and ISBN='" + txt_isbn.Text + "') ", sc))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    dataGridView1.DataSource = t;
                }

                using (SqlDataAdapter q = new SqlDataAdapter("select datediff(d,Due_date,Retrn_date) as Delay from Retrn", sc)) 
                {
                    DataTable m = new DataTable();
                    q.Fill(m);
                    dataGridView2.DataSource = m;
                }

                using (SqlDataAdapter q = new SqlDataAdapter("select datediff(d,Due_date,Retrn_date)*10 as Delay_Fine from Retrn", sc))
                {
                    DataTable m = new DataTable();
                    q.Fill(m);
                    dataGridView3.DataSource = m;
                }
             

               

                sc.Close();

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administration_Menu frm = new Administration_Menu();
            frm.Show();
        }

        private void txt_retrn_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();

                cmd = new SqlCommand("delete from Retrn where mem_Id='" + txt_id.Text + "' and ISBN='" + txt_isbn.Text + "' ", sc);
                cmd.ExecuteNonQuery();

                sc.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;

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
