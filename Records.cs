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
    public partial class Records : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        public Records()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

        }
        public void LoadRecords()
        {
            int i = 0;
            cn.Open();
            dataGridView2.Rows.Clear();
            cm = new SqlCommand("select top 10 pcode, pdesc, sum(qty) as qty from vwSoldItems where sdate between '" +dt1.Value.ToString("yyyy-MM-dd")+ "' and  '" + dt2.Value.ToString("yyyy-MM-dd") + "' and status like 'Gotowy' group by pcode, pdesc order by qty desc", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dataGridView2.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString());
            }
            dr.Close();
            cn.Close(); 
        }
        public void CancelledOrders()
        {
            int i = 0;
            dataGridView5.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from vwCancelledOrder where sdate between '"+dt5.Value.ToString("yyyy-MM-dd")+"' and '"+dt6.Value.ToString("yyyy-MM-dd")+"'",cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dataGridView5.Rows.Add(i, dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["total"].ToString(), dr["sdate"].ToString(), dr["voidby"].ToString(), dr["cancelledby"].ToString(), dr["reason"].ToString(), dr["action"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        public void LoadInventory()
        {
            int i = 0;
            dataGridView7.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder from tblProduct as p inner join tblBrand as b on p.bid = b.id inner join tblCategory as c on p.cid=c.id ", cn);


            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dataGridView7.Rows.Add(i, dr["pcode"].ToString(), dr["barcode"].ToString(), dr["pdesc"].ToString(), dr["brand"].ToString(), dr["category"].ToString(), dr["price"].ToString(), dr["reorder"].ToString(), dr["qty"].ToString());
            }
            dr.Close();
            cn.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("select c.pcode, p.pdesc, c.price, sum(c.qty) as tot_qty, sum(c.disc) as tot_disc, sum(c.total) as total from tblCart as c inner join tblProduct as p on c.pcode = p.pcode where status like 'Gotowy' and sdate between '" + dt3.Value.ToString("yyyy-MM-dd") + "' and  '" + dt4.Value.ToString("yyyy-MM-dd") + "' group by c.pcode, p.pdesc, c.price ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), Double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["tot_qty"].ToString(), dr["tot_disc"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();


                String x;
                cn.Open();
                cm = new SqlCommand("select isnull(sum(total),0) from tblCart where status like 'Gotowy' and sdate between '" + dt3.Value.ToString("yyyy-MM-dd") + "' and  '" + dt4.Value.ToString("yyyy-MM-dd") + "' ", cn);
                lblTotal.Text = Double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
                cn.Close();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show("Złe");
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadCriticalItems()
        {
            try
            {
                dataGridView3.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("select * from vwCriticalitems", cn);
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    dataGridView3.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Złe");
                MessageBox.Show(ex.Message);
                
            }
        }
        public void LoadCtockInHistory()
        {
            int i = 0;
            dataGridView6.Rows.Clear();

            cn.Open();
            cm = new SqlCommand("select * from vwStockIn where sdate between '" + dt7.Value.ToString("yyyy-MM-dd") + "' and  '" + dt8.Value.ToString("yyyy-MM-dd") + "' and status like'Gotowy'", cn);
            cm = new SqlCommand("select * from vwStockIn", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView6.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CancelledOrders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadCtockInHistory();
        }

 

        private void button4_Click(object sender, EventArgs e)
        {
            InventoryReport_form frm = new InventoryReport_form();
            frm.LoadReportt();
            frm.ShowDialog();

        }

   

     

        private void button5_Click(object sender, EventArgs e)
        {
            InventoryReport_form frm = new InventoryReport_form();
            frm.LoadReportt();
            frm.ShowDialog();
        }
    }
}
