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
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        Brand_List frmlist;


        public Brand(Brand_List flist)
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.MyConnection());

            frmlist = flist;

        }

        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrandName.Clear();
            txtBrandName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Jesteś pewny czy napewno chcesz to zapisać?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("insert into tblBrand(brand)values(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrandName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Zapisono pomyślnie");
                    Clear();
                    frmlist.LoadRecords();


                }
             

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Czy napewno chcesz zmienić ten rekord?", "Zmień rekord",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("update tblBrand set brand = @brand where id like'" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrandName.Text);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Marka została zmieniona pomyślnie.");
                    Clear();
                    frmlist.LoadRecords();
                    this.Dispose();


                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}
