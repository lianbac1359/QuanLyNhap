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
using Microsoft.Reporting.WinForms;

namespace QuanLyNhapHang
{
    public partial class PrintPhieu : Form
    {
        public PrintPhieu()
        {
            InitializeComponent();
        }
        string strCon1 = System.Configuration.ConfigurationManager.ConnectionStrings["QLNhapHang"].ConnectionString;
        SqlConnection sqlCon1 = null;

        private void PrintPhieu_Load(object sender, EventArgs e)
        {
            if (sqlCon1 == null)
            {
                sqlCon1 = new SqlConnection();
                sqlCon1.ConnectionString = strCon1;
            }
            string sql = "select * from PhieuNhapKho";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon1);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Phieu");
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyNhapHang.ReportPhieu.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetPhieu";
            rds.Value = ds.Tables["Phieu"];
            this.reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.RefreshReport();
        }
    }
}
