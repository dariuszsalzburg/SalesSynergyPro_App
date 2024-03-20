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
    public partial class SoldItem : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        //Form_POS fp;
       public string user;

        public SoldItem()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            dt1.Value = DateTime.Now;
            dt2.Value = DateTime.Now;
            LoadRecords();
            LoadCashier();


        }
        public void LoadRecords()
        {
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                cn.Open();
                if (cmbCashier.Text == "Wszyscy")
                {
                    cm = new SqlCommand("select c.id ,c.transno, c.pcode, p.pdesc, c.price,c.qty,c.disc,c.total from tblCart as c inner join tblProduct as p on c.pcode = p.pcode where status like 'gotowy'  and sdate between '" + dt1.Value.ToString("yyyy-MM-dd") + "' and '" + dt2.Value.ToString("yyyy-MM-dd") + "' ", cn);
                    // and cashier like '"+cmbCashier.Text+"' and sdate between '"+dt1.Value+"' and '"+dt2.Value+"'
                }
                else
                {
                    cm = new SqlCommand("select c.id ,c.transno, c.pcode, p.pdesc, c.price,c.qty,c.disc,c.total from tblCart as c inner join tblProduct as p on c.pcode = p.pcode where status like 'gotowy'  and sdate between '" + dt1.Value.ToString("yyyy-MM-dd") + "' and '" + dt2.Value.ToString("yyyy-MM-dd") + "' and cashier like '" + cmbCashier.Text + "'", cn);
                }
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView1.Rows.Add(1, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());

                }



                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }


        private void cmbCashier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void LoadCashier()
        {

            cmbCashier.Items.Clear();
            cmbCashier.Items.Add("Wszyscy");
            cn.Open();
            cm = new SqlCommand("select * from tblUser where role like 'user'", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                cmbCashier.Items.Add(dr["username"].ToString());
            }
            dr.Close();
            cn.Close(); 
        }

        private void cmbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "colCancel")
            {
                CancelDetails f = new CancelDetails(this);
                f.txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtTransno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtPCode.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.txtQty.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.txtDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.txtTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                f.txtCancel.Text = user;

                f.ShowDialog();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
