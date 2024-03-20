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
    public partial class Discount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        POS f;
        public Discount(POS frm )
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Discount_Load(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double discount = Double.Parse(txtPricee.Text) * Double.Parse(txtPercent.Text);



                txtAmount.Text = discount.ToString("#,##0.00");
            }catch(Exception ex)
            {
                txtAmount.Text = "0.00";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy napewno chcesz dodać tą promocję?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("update tblCart set disc = @disc where id = @id", cn);
                    cm.Parameters.AddWithValue("@disc", Double.Parse(txtAmount.Text));
                    cm.Parameters.AddWithValue("@id", int.Parse(lblID.Text));
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Dodano promocję pomyślnie.");
                    f.LoadCart();

                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
