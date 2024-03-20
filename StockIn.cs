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
    public partial class StockIn : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        public StockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void LoadProduct()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select pcode,pdesc,qty from tblProduct", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dataGridView2.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            cn.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if(colName == "colDelete")
            {
                if (MessageBox.Show("Jesteś pewny czy napewno chcesz to usunąć?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblStockIn where id = '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Usunięto pomyślnie.");
                    LoadStockIn();
                }
    
            }

        }

        public void LoadStockIn()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from vwStockIn where refno like '"+txtRefNo.Text+"' and status like'Oczekuje'", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dataGridView2.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colname == "colSelect")
            {
                if(txtRefNo.Text == string.Empty)
                {
                    MessageBox.Show("Proszę wybrać referencję","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRefNo.Focus();
                    return;
                }
                if (txtBy.Text == string.Empty)
                {
                    MessageBox.Show("Proszę wybrać okres pobytu", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  txtBy.Focus();
                  return;
                }
                if (MessageBox.Show("Jesteś pewny czy napewno chcesz to zapisać?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                 
                    cn.Open();
                    cm = new SqlCommand("insert into tblStockIn(refno,pcode,sdate,stockinby) values(@refno,@pcode,@sdate,@stockinby)",cn);
                    cm.Parameters.AddWithValue("@refno", txtRefNo.Text);
                    cm.Parameters.AddWithValue("@pcode", dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.Parameters.AddWithValue("@sdate", dt1.Value);
                    cm.Parameters.AddWithValue("@stockinby", txtBy.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Zapisono pomyślnie");
                    LoadStockIn();
                }
               

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchProductsStockIn frm = new SearchProductsStockIn(this);
            frm.LoadProduct();
            frm.ShowDialog();
        }

        public void Clear()
        {
            txtBy.Clear();
            txtRefNo.Clear();
            dt1.Value = DateTime.Now;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if(dataGridView2.Rows.Count > 0)
                {
                    if (MessageBox.Show("Jesteś pewny czy napewno chcesz to zapisać?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        for (int i = 0; i<dataGridView2.Rows.Count; i++)
                        {
                            cn.Open();
                            cm = new SqlCommand("update tblProduct set qty = qty + " + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + " where pcode like '" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();

                            cn.Close();
                            cn.Open();
                            cm = new SqlCommand("update tblStockIn set qty = qty + " + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + ", status = 'Gotowy' where id like '" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "' ", cn);
                            cm.ExecuteNonQuery();


                            cn.Close();
                            MessageBox.Show("Zapisono pomyślnie");

                        }
                        Clear();
                        LoadStockIn();
                    }
                }
            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadCtockInHistory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
         
            cn.Open();
            cm = new SqlCommand("select * from vwStockIn where sdate between '"+date1.Value.ToString("yyyy-MM-dd")+ "' and  '" + date2.Value.ToString("yyyy-MM-dd") + "' and status like'Gotowy'", cn);
          
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCtockInHistory();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCtockInHistory();
            date1.Value = DateTime.Now;
            date2.Value = DateTime.Now;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LoadCtockInHistory();
            date1.Value = DateTime.Now;
            date2.Value = DateTime.Now;
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
