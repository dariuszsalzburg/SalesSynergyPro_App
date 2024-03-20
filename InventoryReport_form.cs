using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Inventory_System
{
    public partial class InventoryReport_form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        public InventoryReport_form()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void LoadReportt()
        {
            ReportDataSource rptDataSource = new ReportDataSource();
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand("select p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty, p.reorder from tblProduct as p inner join tblBrand as b on p.bid = b.id inner join tblCategory as c on p.cid=c.id", cn);
                da.Fill(ds.Tables["dtInventory"]);
             
                cn.Close();

               



                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtInventory"]);    
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;


         

            }
            catch (Exception ex)
            {
                cn.Close();

            }
        }





        private void InventoryReport_form_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
