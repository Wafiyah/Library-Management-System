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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

       
      

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search1 b = new Search1();
            b.Show();
            this.Hide();
        }

      

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration_Login c = new Administration_Login();
            c.Show();
            this.Hide();
        }

      


        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            About_us u = new About_us();
            u.Show();
        }

        private void libaryRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instruction i = new Instruction();
            i.Show();

        }

        private void ciculationServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Circulation_Service s = new Circulation_Service();
            s.Show();
        }

        private void basicInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_basic_info fr = new frm_basic_info();
            fr.Show();
        }

        private void objectiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_objective ob = new frm_objective();
            ob.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
