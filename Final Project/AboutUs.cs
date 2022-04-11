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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();

            User_Hazel ae = new User_Hazel();
            string dev1 = ae.ViewRecs("Hazel", "Pontilla", "T.");
            listBox1.Items.Add(dev1);

            User_Karen ee = new User_Karen();
            string dev2 = ee.ViewRecs("Karen", "Gerez", "V.");
            listBox1.Items.Add(dev2);
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            AddNew b = new AddNew();
            string DEV2 = b.DEV1(txt_Firstname.Text, txt_Lastname.Text, txt_MiddleInitial.Text);

            listBox1.Items.Add(DEV2);
        }
    }
}
