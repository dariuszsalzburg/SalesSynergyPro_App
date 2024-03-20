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
using MetroFramework.Forms;

namespace POS_Inventory_System
{
    public partial class Form1 : Form

    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();




            
        }


        private void btnBrand_Click(object sender, EventArgs e)
        {
            Brand_List frm = new Brand_List();
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

    

   

    

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryList frm = new CategoryList();
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadCategory();
            frm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductList frm = new ProductList();
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadRecords();
            frm.Show();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {




            StockIn frm = new StockIn();
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadProduct();
            frm.LoadStockIn();

            frm.Show();



        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            UserAccount frm = new UserAccount();
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Security frm = new Security();
            frm.ShowDialog();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            SoldItem frm = new SoldItem();
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Records frm = new Records();
            frm.TopLevel = false;
            frm.LoadCriticalItems();
            frm.LoadInventory();
            frm.CancelledOrders();
            frm.LoadCtockInHistory();
   
            CenterPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Store frm = new Store();
           
            frm.TopLevel = false;
            frm.LoadRecords();
            CenterPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
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

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
