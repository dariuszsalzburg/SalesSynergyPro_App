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
    public partial class Void : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        CancelDetails f;
        public Void(CancelDetails frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }
        public void SaveCancelOrder(string user)
        {
            cn.Open();
            cm = new SqlCommand("insert into tblCancel (transno, pcode,price,qty,sdate, voidby, cancelledby, reason, action) values (@transno, @pcode,@price,@qty,@sdate, @voidby, @cancelledby, @reason, @action)", cn);
            cm.Parameters.AddWithValue("@transno", f.txtTransno.Text);
            cm.Parameters.AddWithValue("@pcode", f.txtPCode.Text);
            cm.Parameters.AddWithValue("@price", double.Parse(f.txtPrice.Text));
            cm.Parameters.AddWithValue("@qty", int.Parse(f.txtCancelQty.Text));
            cm.Parameters.AddWithValue("@sdate", DateTime.Now);
            cm.Parameters.AddWithValue("@voidby", user);
            cm.Parameters.AddWithValue("@cancelledby", f.txtCancel.Text);
            cm.Parameters.AddWithValue("@reason", f.txtReason.Text);
            cm.Parameters.AddWithValue("@action", f.cmbAction.Text);
            cm.ExecuteNonQuery();
            cn.Close();
          
        }
        public void UpdateData(string sql)
        {
            cn.Open();
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPassword.Text != String.Empty)
                {
                    string user;
                    cn.Open();
                    cm = new SqlCommand("select * from tblUser where username = @username and password = @password", cn);
                    cm.Parameters.AddWithValue("@username", txtUserName.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if(dr.HasRows)
                    {
                        user = dr["username"].ToString();
                        dr.Close();
                        cn.Close();

                        SaveCancelOrder(user);
                        if(f.cmbAction.Text == "Tak")
                        {
                            UpdateData("update tblProduct set qty = qty + " + int.Parse(f.txtCancelQty.Text) + " where pcode = '" + f.txtPCode.Text + "'");
                        }
                        UpdateData("update tblCart set qty = qty - " + int.Parse(f.txtCancelQty.Text) + " where id like '" + f.txtID.Text + "'");

                        MessageBox.Show("Pomyślnie anulowanno tą transakcję");
                        this.Dispose();
                        f.RefreshList();
                        f.Dispose();
                    }
                    dr.Close();
                    cn.Close();
                }
            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
