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
    public partial class Store : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        public Store()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void Form_Store_Load(object sender, EventArgs e)
        {

        }
        public void LoadRecords()
        {
            cn.Open();
            cm = new SqlCommand("select * from tblStore", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                txtAddress.Text = dr["address"].ToString();
                txtStore.Text = dr["store"].ToString();

            }else
            {
                txtStore.Clear();
                txtAddress.Clear();
            }
            dr.Close();
            cn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               if( MessageBox.Show("Czy napewno chcesz zapisac zmiany?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int count;
                    cn.Open();
                    cm = new SqlCommand("select count(*) from tblStore", cn);
                    count = int.Parse(cm.ExecuteScalar().ToString());
                    cn.Close();
                    if(count > 0)
                    {
                        cn.Open();
                        cm = new SqlCommand("update tblStore set store=@store, address=@address", cn);
                        cm.Parameters.AddWithValue("@store", txtStore.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.ExecuteNonQuery();

                        cn.Close();
                    }else
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into tblStore (store,address)values(@store, @address)", cn);
                        cm.Parameters.AddWithValue("@store", txtStore.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.ExecuteNonQuery();

                        cn.Close();
                    }
                    MessageBox.Show("Zapisano pomyślnie");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
