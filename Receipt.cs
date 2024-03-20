using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;



using System.Data.SqlClient;


namespace POS_Inventory_System
{
    public partial class Receipt : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        POS f;
        String store = "Sklep";
        String adress = "Nakło ul. Dzeirżonia 23";

        public Receipt(POS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }
        public void LoadReport(string pcash, string pchange)
        {
            ReportDataSource rptDataSource = new ReportDataSource();
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id, c.transno, c.pcode, c.price, c.qty, c.disc, c.total, c.sdate, c.status, p.pdesc from tblCart as c inner join tblProduct as p on p.pcode = c.pcode where transno like '" + f.lblTransNo.Text + "'", cn);
                da.Fill(ds.Tables["dtSold"]);
                cn.Close();

                ReportParameter pVatable = new ReportParameter("pVatable", f.lblVatable.Text);
                ReportParameter pVat = new ReportParameter("pVat", f.lblVat.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", f.lblDiscount.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", f.lblTotal.Text);
                ReportParameter pCash = new ReportParameter("pCash", pcash);
                ReportParameter pChange = new ReportParameter("pChange", pchange);
                ReportParameter pStore = new ReportParameter("pStore", store);
                ReportParameter pAddress = new ReportParameter("pAddress", adress);
                ReportParameter pTransaction = new ReportParameter("pTransaction", "Faktura VAT #: " + f.lblTransNo.Text);


                reportViewer1.LocalReport.SetParameters(pVatable);

                reportViewer1.LocalReport.SetParameters(pVat);

                reportViewer1.LocalReport.SetParameters(pDiscount);

                reportViewer1.LocalReport.SetParameters(pTotal);

                reportViewer1.LocalReport.SetParameters(pCash);

                reportViewer1.LocalReport.SetParameters(pChange);

                reportViewer1.LocalReport.SetParameters(pStore);

                reportViewer1.LocalReport.SetParameters(pAddress);


                reportViewer1.LocalReport.SetParameters(pTransaction);



                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtSold"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;


                //this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Report1.rdlc";
                //this.reportViewer1.LocalReport.DataSources.Clear();
                ////DataSet1 ds = new DataSet1();
                ////SqlDataAdapter da = new SqlDataAdapter();
                //cn.Open();
                //da.SelectCommand = new SqlCommand("select c.id, c.transno, c.pcode, c.price, c.qty, c.disc, c.total, c.sdate, c.status, p.pdesc from tblCartt as c inner join tblProducts as p on p.pcode = c.pcode where transno like '" + f.lblTransNo.Text + "'", cn);
                //da.Fill(ds.Tables["dtSold"]);
                //cn.Close();
                ////ReportParameter pVatable = new ReportParameter("pVatable", f.lblVatable.Text);
                //reportViewer1.LocalReport.SetParameters(pVatable);

            }
            catch (Exception ex)
            {
                cn.Close();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
