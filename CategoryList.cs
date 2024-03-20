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

namespace POS_Inventory_System
{
    public partial class CategoryList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        public CategoryList( )
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void LoadCategory()
        {
            int i = 0;
       
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from tblCategory order by category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i,dr[0].ToString(), dr[1].ToString());

            }

            dr.Close();
            cn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category frm = new Category(this);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        string contractorId;
        string updatee;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                contractorId = item.Cells[1].Value.ToString();
                updatee = item.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy chcesz usunąć kategorię?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (!contractorId.Equals(string.Empty))
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblCategory where id like '" + contractorId + "'", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Usunięto pomyślnie.");
                    LoadCategory();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category frm = new Category(this);
            frm.txtCategory.Text = updatee;
            frm.lblID.Text = contractorId;
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
        }
    }
}
