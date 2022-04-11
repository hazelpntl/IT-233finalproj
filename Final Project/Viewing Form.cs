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
    public partial class Viewing_Form : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        public Viewing_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection);
        }

        public void LoadRecord()
        {
            try
            {
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select * from tblCandidate", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"].ToString(), dr["firstname"].ToString(), dr["lastname"].ToString(), dr["middleinitial"].ToString(), dr["candidacy"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, var._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.ClearSelection();
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "btnEdit")
                {
                    Adding_Form d = new Adding_Form();
                    d.my_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    d.txt_Firstname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    d.txt_Lastname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    d.txt_MiddleInitial.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    d.ShowDialog();                
                }
                else if (colName == "btnDelete")
                {
                    if(MessageBox.Show("Do you want to delete this data?", var._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("delete from tblCandidate where id like '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully deleted!", var._title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRecord();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, var._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
