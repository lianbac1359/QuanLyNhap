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
using Microsoft.Reporting.WinForms;

namespace QuanLyNhapHang
{
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }
        string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["QLNhapHang"].ConnectionString;
        SqlConnection sqlCon = null;

        private void PrintBill_Load(object sender, EventArgs e)
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection();
                sqlCon.ConnectionString = strCon;
            }
            string sql = "select * from HoaDon";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlCon);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"HoaDon");
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhapHang.ReportBill.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetHoaDon";
            rds.Value = ds.Tables["HoaDon"];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
