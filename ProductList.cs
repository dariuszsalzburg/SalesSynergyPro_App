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
    public partial class ProductList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        public ProductList( )
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button1_Click(object sender, EventArgs e   )
        {
            Products frm = new Products(this);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.LoadBrand();
            frm.LoadCategory();
            frm.ShowDialog();


        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select p.pcode,p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder from tblProduct as p inner join tblBrand as b on b.id = p.bid inner join tblCategory as c on c.id = p.cid where p.pdesc like '"+txtSearch.Text+"%'", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            cn.Close();
            
        }
        string stxtPcode;
        string stxtBarcode;
        string stxtPdesc;
        string stxtPrice;
        string scmbBrand;
        string scmbCategory;
        string stxtReorder;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                Products frm = new Products(this);
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.txtPcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtBarcode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtPdesc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.cmbBrand.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.cmbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtReorder.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Czy napewno chcesz usunąć ten rekord?", "Usuwanie rekordu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblProduct where pcode like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Usunięto pomyślnie.");
                    LoadRecords();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                stxtPcode = item.Cells[1].Value.ToString();
                stxtBarcode = item.Cells[2].Value.ToString();
                stxtPdesc = item.Cells[3].Value.ToString();
                stxtPrice = item.Cells[6].Value.ToString();
                scmbBrand = item.Cells[4].Value.ToString();
                scmbCategory = item.Cells[5].Value.ToString();
                stxtReorder = item.Cells[7].Value.ToString();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!stxtPcode.Equals(string.Empty))
            {
                if (MessageBox.Show("Czy napewno chcesz usunąć ten rekord?", "Usuwanie rekordu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblProduct where pcode like '" +stxtPcode + "' ", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Usunięto pomyślnie.");
                    LoadRecords();
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products frm = new Products(this);
            frm.btnSave.Enabled = false;
            frm.btnUpdate.Enabled = true;
            frm.txtPcode.Text = stxtPcode;
            frm.txtBarcode.Text = stxtBarcode;
            frm.txtPdesc.Text = stxtPdesc;
            frm.txtPrice.Text = stxtPrice;
            frm.cmbBrand.Text = scmbBrand;
            frm.cmbCategory.Text = scmbCategory;
            frm.txtReorder.Text = stxtReorder;
            frm.ShowDialog();
        }
    }

    }

