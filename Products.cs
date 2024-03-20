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
    public partial class Products : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        ProductList flist;
        public Products( ProductList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            flist = frm;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCategory( )
        {
            cmbCategory.Items.Clear();
            cn.Open();
            cm = new SqlCommand("select category from tblCategory", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadBrand( )
        {
            cmbBrand.Items.Clear();
            cn.Open();
            cm = new SqlCommand("select brand from tblBrand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbBrand.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void Form_Products_Load(object sender, EventArgs e)
        {

        }

        public void Clear( )
        {
            txtPrice.Clear();
            txtPdesc.Clear();
            txtPcode.Clear();
            txtBarcode.Clear();
            cmbBrand.Text = "";
            cmbCategory.Text = "";
            txtPcode.Focus();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;


        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Jesteś pewny czy napewno chcesz to zapisać?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bid = "";
                    string cid = "";
                    cn.Open();
                    cm = new SqlCommand("select id from tblBrand where brand like'"+cmbBrand.Text+"'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if(dr.HasRows)
                    {
                        bid = dr[0].ToString();
                    }
                    dr.Close();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("select id from tblCategory where category like'" + cmbCategory.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cid = dr[0].ToString();
                    }
                    dr.Close();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("insert into tblProduct(pcode,barcode,pdesc,bid,cid,price,reorder )values(@pcode,@barcode,@pdesc,@bid,@cid,@price,@reorder)", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@bid", bid);
                    cm.Parameters.AddWithValue("@cid", cid);
                    cm.Parameters.AddWithValue("@price", (txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));

                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Zapisono pomyślnie.");
                    Clear();
                    flist.LoadRecords();


                }


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Jesteś pewny czy napewno chcesz to zmienić?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bid = "";
                    string cid = "";
                    cn.Open();
                    cm = new SqlCommand("select id from tblBrand where brand like'" + cmbBrand.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        
                        bid = dr[0].ToString();
                    }
                    dr.Close();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("select id from tblCategory where category like'" + cmbCategory.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cid = dr[0].ToString();
                    }
                    dr.Close();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("update  tblProduct set barcode = @barcode,pdesc = @pdesc,bid= @bid,cid = @cid,price = @price, reorder = @reorder  where pcode like @pcode", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@bid", bid);
                    cm.Parameters.AddWithValue("@cid", cid);
                    cm.Parameters.AddWithValue("@price",double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));

                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Zmieniono pomyślnie.");
                    Clear();
                    flist.LoadRecords();
                    this.Dispose();


                }


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar == 46)
            {

            }else if(e.KeyChar ==8)
            {

            }

            else if((e.KeyChar < 48) || (e.KeyChar> 57))
            {
                e.Handled = true;
            }
        }
    }
 }

