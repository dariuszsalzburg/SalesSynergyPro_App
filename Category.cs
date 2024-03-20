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

    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        CategoryList flist;
        public Category(CategoryList frm )
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;

            txtCategory.Clear();
            txtCategory.Focus();
                
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Jesteś pewny czy napewno chcesz to zapisać?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("insert into tblCategory(category) Values(@category)", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Zapisono pomyślnie");
                    Clear();
                    flist.LoadCategory();

                }
            }
            catch(Exception ex)
            {
                cn.Open();
                MessageBox.Show(ex.Message);
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void Form_Category_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy napewno chcesz zmienić ten rekord?", "Zmień rekord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("update tblCategory set category = @category where id like'" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Kategoria została zmieniona pomyślnie.");
                    Clear();
                    flist.LoadCategory();
                    this.Dispose();


                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
