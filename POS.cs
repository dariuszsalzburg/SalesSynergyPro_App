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
    public partial class POS : Form
    {

        String id;
        String price;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        Security f;
        int qty;


        public POS(Security frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            lblDate.Text = DateTime.Now.ToLongDateString();
            this.KeyPreview = true;
            f = frm;

        }

        public POS()
        {
        }

        private void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("select top 1 transno from tblCart where transno like '" + sdate + "%' order by id desc ", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransNo.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransNo.Text = transno;
                }
                dr.Close();
                cn.Close();


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }





        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void GetCartTotal()
        {
            double discount = Double.Parse(lblDiscount.Text);
            double sales = Double.Parse(lblTotal.Text);
            double vat = sales * dbcon.GetVal();
            double vatable = sales - vat;
            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblVatable2.Text = vatable.ToString("#,##0.00");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                return;
            }
            GetTransNo();
            txtSearch.Enabled = true;
            txtSearch.Focus();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        public void LoadCart()
        {
            try
            {
                Boolean hasrecord = false;
                dataGridView1.Rows.Clear();
                int i = 0;
                double total = 0;
                double discount = 0;
                cn.Open();
                cm = new SqlCommand("select c.id, c.pcode,p.pdesc,c.price, c.qty, c.disc, c.total from tblCart as c inner join tblProduct as p on c.pcode = p.pcode where transno like '" + lblTransNo.Text + "' and status like 'Oczekuje' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["total"].ToString());
                    discount += Double.Parse(dr["disc"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"), "[ + ]", "[ - ]");

                    hasrecord = true;
                }
                dr.Close();

                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00");

                lblDiscount.Text = discount.ToString("#,##0.00");

                GetCartTotal();
                if (hasrecord == true)
                {
                    btnSettlePayment.Enabled = true;
                    btnDiscount.Enabled = true;
                    btnCancelSales.Enabled = true;
                }
                else
                {
                    btnSettlePayment.Enabled = false;
                    btnDiscount.Enabled = false;
                    btnCancelSales.Enabled = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    return;
                }
                else
                {
                 int _qty;
                 String _pcode;
                 double _price;
                    cn.Open();
                    cm = new SqlCommand("select * from tblProduct where barcode like '" + txtSearch.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        qty = int.Parse(dr["qty"].ToString());
                        Qty frm = new Qty(this);
                        frm.ProductDetails(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), lblTransNo.Text, qty);
                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);
                        dr.Close();
                        cn.Close();
                        frm.ShowDialog();
                        AddtoCart(_pcode, _price,_qty );
                    }
                    else
                    {
                        dr.Close();
                        cn.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void AddtoCart(String _pcode, double _price,int _qty )
        {
            String id = "";
            bool found = false;
            int cart_qty =0;
            cn.Open(); cm = new SqlCommand("select * from tblCart where transno = @transno and pcode  = @pcode", cn);
            cm.Parameters.AddWithValue("@transno",lblTransNo.Text);
            cm.Parameters.AddWithValue("@pcode", _pcode);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                found = true;
                id = dr["id"].ToString();
                cart_qty = int.Parse(dr["qty"].ToString());
            }
            else
            {
                found = false;
            }
            dr.Close();
            cn.Close();
            if (found == true)
            {


                if (qty < (int.Parse(txtQty.Text) + cart_qty))
                {
                    MessageBox.Show("wewewewNie można kontynuować Pozostała ilośc to: " + qty);
                    return;
                }


                cn.Open();
                cm = new SqlCommand("update tblCart set qty = (qty+ " +  _qty + ") where id = '" + id + "'", cn);


                cm.ExecuteNonQuery();
                cn.Close();

                txtSearch.SelectionStart = 0;
                txtSearch.SelectionLength = txtSearch.Text.Length;
                LoadCart();
                //this.Dispose();
            }
            else
            {
                if (qty < int.Parse(txtQty.Text))
                {
                    MessageBox.Show("rerereNie można kontynuować Pozostała ilośc to: " + qty);
                    return;
                }

                cn.Open();
                cm = new SqlCommand("insert into tblCart (transno, pcode,price,qty, sdate, cashier) values(@transno, @pcode,@price,@qty, @sdate, @cashier)", cn);
                cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
                cm.Parameters.AddWithValue("@price", _price);
                cm.Parameters.AddWithValue("@qty", _qty);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashier", lblUser.Text);

                cm.ExecuteNonQuery();
                cn.Close();

                txtSearch.SelectionStart = 0;
                txtSearch.SelectionLength = txtSearch.Text.Length;
                LoadCart();
                this.Dispose();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lblTransNo.Text == "00000000")
            {
                return;
            }
            LookUp frm = new LookUp(this);
            frm.LoadRecords();
            frm.txtSearch.Enabled = true;
            frm.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {


            Discount frm = new Discount(this);
            frm.lblID.Text = id;
            frm.txtPricee.Text = price;
            frm.ShowDialog();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1[1, i].Value.ToString();
            price = dataGridView1[4, i].Value.ToString();
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            txtCash.Focus();
            txtSale.Text = lblVatable2.Text;

        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = Double.Parse(txtSale.Text);
                double cash = Double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                txtChange.Text = "0.00";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn9.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            txtCash.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn6.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn3.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn00.Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(txtChange.Text) < 0) || (txtCash.Text == String.Empty))
                {
                    MessageBox.Show("haloooo");
                    return;

                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {



                        cn.Open();
                        cm = new SqlCommand("update tblProduct  set qty = qty - " + int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) + " where pcode = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();


                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("update tblCart set status = 'Gotowy' where id ='" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "' ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                    }
                    Receipt frmm = new Receipt(this);
                    frmm.LoadReport(txtCash.Text, txtChange.Text);
                    frmm.ShowDialog();

                    MessageBox.Show("Płatność zrealizowana pomyślnie.");
                    GetTransNo();
                    LoadCart();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niewystarczająca ilość pieniędzy.");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword(this);
            frm.ShowDialog();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            SoldItem frm = new SoldItem();
            frm.user = lblUser.Text;

            frm.cmbCashier.Text = lblUser.Text;
            frm.ShowDialog();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Security frm = new Security();
            frm.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_POS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNewTransaction_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnDiscount_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSettlePayment_Click(sender, e);
            }
        }

        private void btnCancelSales_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy napewno chcesz anulować tą sprzedaż?" ,"", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("delete from tblCart where transno like '" + lblTransNo.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Usunięto pomyślnie");
                LoadCart();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Czy napewno chcesz usunąć ten rekord?", "Usuwanie rekordu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblCart where id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Usunięto pomyślnie.");
                    LoadCart();

                }

            }
            else if (colName == "colAdd")

            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("select sum(qty) as qty from tblProduct where pcode like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'group by pcode  ", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
                if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {
                    cn.Open();
                    cm = new SqlCommand("update tblCart set qty = qty + '" + int.Parse(txtQty.Text) + "' where transno like '" + lblTransNo.Text + "' and pcode like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Pozostała ilość pod ręką to: " + i);
                    return;
                }
            }
            else if (colName == "colRemove")

            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("select sum(qty) as qty from tblCart where pcode like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' and transno like '" + lblTransNo.Text + "'group by transno, pcode  ", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
                if (i > 1)
                {
                    cn.Open();
                    cm = new SqlCommand("update tblCart set qty = qty - '" + int.Parse(txtQty.Text) + "' where transno like '" + lblTransNo.Text + "' and pcode like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Pozostała ilość pod ręką to: " + i);
                    return;
                }
            }
        }
    }
}

