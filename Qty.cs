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
    public partial class Qty : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();
        POS fpos;
        private int qty;
        private String pcode;
        private double price;
        private String transno;

        public Qty(POS frmpos )
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fpos = frmpos;
        }

        public void ProductDetails(String pcode, double price, String transno, int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void Forrm_Qty_Load(object sender, EventArgs e)
        {
            txtQty.Text = "0";
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
 
        }
 
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
                
            if((e.KeyChar==13) && (txtQty.Text != String.Empty))
            {
               String  id="";
                int cart_qty = 0;
                bool found = false;
          
                cn.Open();cm = new SqlCommand("select * from tblCart where transno = @transno and pcode  = @pcode", cn);
                cm.Parameters.AddWithValue("@transno", fpos.lblTransNo.Text);
                cm.Parameters.AddWithValue("@pcode", pcode);
                dr = cm.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
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
                if(found == true)
                {


                    if (qty < (int.Parse(txtQty.Text)+ qty))
                    {
                        MessageBox.Show("Nie można kontynuować Pozostała ilośc to: " + qty);
                        return;
                    }






                    cn.Open();
                    cm = new SqlCommand("update tblCart set qty = (qty+ "+int.Parse(txtQty.Text)+") where id = '"+id+"')", cn);
              

                    cm.ExecuteNonQuery();
                    cn.Close();

                    fpos.txtSearch.Clear();
                    fpos.txtSearch.Focus();
                    fpos.LoadCart();
                    this.Dispose();
                }
                else
                {
                    if (qty < int.Parse(txtQty.Text))
                    {
                        MessageBox.Show("Nie można kontynuować Pozostała ilośc to: " + qty);
                        return;
                    }

                    cn.Open();
                    cm = new SqlCommand("insert into tblCart(transno, pcode,price,qty, sdate, cashier) values(@transno, @pcode,@price,@qty, @sdate, @cashier)", cn);
                    cm.Parameters.AddWithValue("@transno", transno);
                    cm.Parameters.AddWithValue("@pcode", pcode);
                    cm.Parameters.AddWithValue("@price", price);
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.Parameters.AddWithValue("@cashier", fpos.lblUser.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();

                    fpos.txtSearch.Clear();
                    fpos.txtSearch.Focus();
                    fpos.LoadCart();
                    this.Dispose();
                }
            }
        }
    }
}
