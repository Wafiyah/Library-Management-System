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
    public partial class Administration_Menu : Form
    {
        public Administration_Menu()
        {
            InitializeComponent();
        }

      

     

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home a = new Home();
            a.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration1 a = new Registration1();
            a.Show();
            
        }

       

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void newBookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

  

        private void returnListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

      

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void updateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void distributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_emp i = new New_emp();
            i.Show();

        }

        private void searchInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information i = new Information();
            i.Show();
        }

        private void updateInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_info i = new Update_info();
            i.Show();
        }

        private void deleteInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Delete_info de = new Delete_info();
            de.Show(); 
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Issue i = new Issue();
            i.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_List m = new Return_List();
            m.Show();
        }

        private void newBookEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_entry_book n = new New_entry_book();
            n.Show();
        }
    }
}
