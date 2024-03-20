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
    public partial class Brand_List : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();
        public Brand_List()
        {
            InitializeComponent();


            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();

        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from tblBrand order by brand", cn);
            dr= cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());

            }

            dr.Close();
            cn.Close();
            
        }//koniec


        private void button1_Click(object sender, EventArgs e)
        {
            Brand frm = new Brand(this);
            frm.ShowDialog();
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
            if (MessageBox.Show("Czy napewno chcesz usunąć ten rekord?", "Usuwanie rekordu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("delete from tblBrand where id like '" +contractorId+ "'", cn);
                cm.ExecuteNonQuery();

                cn.Close();
                MessageBox.Show("Usunięto pomyślnie.");
                LoadRecords();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Brand frm = new Brand(this);
            frm.lblID.Text = contractorId;
            frm.txtBrandName.Text = updatee;
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
