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
using System.Configuration;

namespace QuanLyNhapHang
{
    public partial class NhaCungCapform : Form
    {
        public NhaCungCapform()
        {
            InitializeComponent();
        }
        SqlConnection con_NhaCC;
       
        SqlDataAdapter adapter = new SqlDataAdapter();
        
        private void NhaCungCapform_Load(object sender, EventArgs e)
        {
            cbxNhaCC.SelectedIndex = 0;
            string constring = ConfigurationManager.ConnectionStrings["QLNhapHang"].ConnectionString.ToString();
            con_NhaCC = new SqlConnection(constring);
            con_NhaCC.Open();
            Hienthi();
        }
        private void NhaCungCapform_FormClosing(object sender, FormClosingEventArgs e)
        {
            con_NhaCC.Close();
        }
        public void Hienthi()
        {
            string sqlSelect = "select * from NhaCungCap";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_NhaCC);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvNhaCC.DataSource = dt;
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                txtMaNhaCC.Text = dgvNhaCC.Rows[i].Cells[0].Value.ToString();
                txtTenNhaCC.Text = dgvNhaCC.Rows[i].Cells[1].Value.ToString();
                txtDiaChiNhaCC.Text = dgvNhaCC.Rows[i].Cells[2].Value.ToString();
                txtFaxNhaCC.Text = dgvNhaCC.Rows[i].Cells[3].Value.ToString();
                txtLoaiHoaNhaCC.Text = dgvNhaCC.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void btnXoaNhaCC_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM NhaCungCap where maNCC =@maNCC";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con_NhaCC);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNhaCC.Text);
            cmd.Parameters.AddWithValue("TenNCC", txtTenNhaCC.Text);
            cmd.Parameters.AddWithValue("DChiNCC", txtDiaChiNhaCC.Text);
            cmd.Parameters.AddWithValue("FAX", txtFaxNhaCC.Text);
            cmd.Parameters.AddWithValue("LoaiHoa", txtLoaiHoaNhaCC.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnSuaNhaCC_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE NhaCungCap SET tenNCC = @tenNCC,DChiNCC = @DChiNCC,FAX = @FAX,LoaiHoa = @LoaiHoa where maNCC =@maNCC";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con_NhaCC);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNhaCC.Text);
            cmd.Parameters.AddWithValue("TenNCC", txtTenNhaCC.Text);
            cmd.Parameters.AddWithValue("DChiNCC", txtDiaChiNhaCC.Text);
            cmd.Parameters.AddWithValue("FAX", txtFaxNhaCC.Text);
            cmd.Parameters.AddWithValue("LoaiHoa", txtLoaiHoaNhaCC.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnThemNhaCC_Click(object sender, EventArgs e)
        {
            string sqlAdd = "INSERT INTO NhaCungCap VALUES (@MaNCC , @TenNCC, @DChiNCC, @FAX, @LoaiHoa)";
            SqlCommand cmd = new SqlCommand(sqlAdd, con_NhaCC);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNhaCC.Text);
            cmd.Parameters.AddWithValue("TenNCC", txtTenNhaCC.Text);
            cmd.Parameters.AddWithValue("DChiNCC", txtDiaChiNhaCC.Text);
            cmd.Parameters.AddWithValue("FAX", txtFaxNhaCC.Text);
            cmd.Parameters.AddWithValue("LoaiHoa", txtLoaiHoaNhaCC.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnLamMoiNhaCC_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnTimKiemNhaCC_Click(object sender, EventArgs e)
        {
            string searchField = "";
            switch (cbxNhaCC.SelectedItem.ToString())
            {
                case "Mã nhà cung cấp":
                    searchField = "MaNCC";
                    break;
                case "Tên nhà cung cấp":
                    searchField = "TenNCC";
                    break;
                case "Địa chỉ":
                    searchField = "DChiNCC";
                    break;
                case "Fax":
                    searchField = "FAX";
                    break;
                case "Loại hoa":
                    searchField = "LoaiHoa";
                    break;
            }
            string sqlSearch = "select * from NhaCungCap where " + searchField + " LIKE @value ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_NhaCC);
            cmd.Parameters.AddWithValue("@value", "%" + txtInputTimKiem_NhaCC.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvNhaCC.DataSource = dt;
        }
    }        
}

        
    
