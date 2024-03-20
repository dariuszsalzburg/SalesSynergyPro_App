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
    public partial class LookUp : Form
    {
        POS f;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        public LookUp( POS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
            this.KeyPreview = true;
        }


        public void LoadRecords( )
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select p.pcode,p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty from tblProduct as p inner join tblBrand as b on b.id = p.bid inner join tblCategory as c on c.id = p.cid where p.pdesc like '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            cn.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "Select")
            {
                Qty frm = new Qty(f);
                frm.ProductDetails( dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),Double.Parse( dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()), f.lblTransNo.Text, int.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()));

                frm.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void Form_LookUp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}
