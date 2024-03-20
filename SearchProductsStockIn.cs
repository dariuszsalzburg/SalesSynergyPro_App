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
    public partial class SearchProductsStockIn : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        StockIn slist;
        public SearchProductsStockIn(StockIn flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            slist = flist;
        }
        public void LoadProduct( )
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select pcode,pdesc,qty from tblProduct where pdesc like '%"+txtSearch.Text+"%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            cn.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colname == "colSelect")
            {
               
                if (MessageBox.Show("Jesteś pewny czy napewno chcesz to zapisać?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("insert into tblStockIn(refno,pcode,sdate,stockinby) values(@refno,@pcode,@sdate,@stockinby)", cn);
                    cm.Parameters.AddWithValue("@refno", slist.txtRefNo.Text);
                    cm.Parameters.AddWithValue("@pcode", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.Parameters.AddWithValue("@sdate", slist.dt1.Value);
                    cm.Parameters.AddWithValue("@stockinby", slist.txtBy.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Zapisono pomyślnie");
                    slist.LoadStockIn();
                }


            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
    
}
