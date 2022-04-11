using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project

{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        #region Buttons

        private void btn_ViewCandidacy_Click(object sender, EventArgs e)
        {
            Viewing_Form c = new Viewing_Form();
            c.TopLevel = false;
            panel2.Controls.Add(c);
            c.BringToFront();
            c.LoadRecord();
            c.Show();
        }

        private void btn_AddCandidacy_Click(object sender, EventArgs e)
        {
            Adding_Form b = new Adding_Form();
            b.TopLevel = false;
            panel2.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void btn_out_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            MainWel cd = new MainWel();
            cd.TopLevel = false;
            panel2.Controls.Add(cd);
            cd.BringToFront();
            cd.Show();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            AboutUs ea = new AboutUs();
            ea.TopLevel = false;
            panel2.Controls.Add(ea);
            ea.BringToFront();
            ea.Show();
            
        }
    }
}
