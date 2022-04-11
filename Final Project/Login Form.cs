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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string resultValue = "";

            LoginC b = new LoginC();
            resultValue = b.Log(txt_username.Text, txt_password.Text);

            User1 c = new User1();
            string Hazel = c.Log("hazel", "admin");

            User2 d = new User2();
            string Karen = d.Log("karen", "admin2");

            if (resultValue == Hazel)
            {
                this.Hide();
                Main_Form a = new Main_Form();
                a.Show();
            }
            else if (resultValue == Karen)
            {
                this.Hide();
                Main_Form a = new Main_Form();
                a.Show();
            }
            else
            {
                MessageBox.Show("Please Try Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
                txt_username.Clear();
            }
        }
    }
}
