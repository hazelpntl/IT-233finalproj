using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project
{
    public partial class Adding_Form : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        
        public string my_id;

        public Adding_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection);
        }

        #region Buttons
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txt_Firstname.Clear();
            txt_Lastname.Clear();
            txt_MiddleInitial.Clear();
            cbnCandidacy.Text = "";
            btn_Update.Enabled = false;
            btn_Save.Enabled = true;
            cbnCandidacy.Focus();
        }

        private void cbn_Candidacy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save this data?", var._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("insert into tblcandidate (firstname, lastname, middleinitial, candidacy)values(@firstname, @lastname, @middleinitial, @candidacy)", cn);
                    cm.Parameters.AddWithValue("@firstname", txt_Firstname.Text);
                    cm.Parameters.AddWithValue("@lastname", txt_Lastname.Text);
                    cm.Parameters.AddWithValue("@middleinitial", txt_MiddleInitial.Text);
                    cm.Parameters.AddWithValue("@candidacy", cbnCandidacy.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data has been saved succesfully!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, var._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to update this data?", var._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("insert into tblcandidate (firstname, lastname, middleinitial, candidacy)values(@firstname, @lastname, @middleinitial, @candidacy)", cn);
                    cm.Parameters.AddWithValue("@firstname", txt_Firstname.Text);
                    cm.Parameters.AddWithValue("@lastname", txt_Lastname.Text);
                    cm.Parameters.AddWithValue("@middleinitial", txt_MiddleInitial.Text);
                    cm.Parameters.AddWithValue("@candidacy", cbnCandidacy.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data has been updated succesfully!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, var._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void Adding_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
