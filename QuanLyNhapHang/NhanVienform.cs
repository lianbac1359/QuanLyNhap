using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhapHang
{
    public partial class NhanVienform : Form
    {
        public NhanVienform()
        {
            InitializeComponent();
        }
        SqlConnection con_NhanVien;

        SqlDataAdapter adapter = new SqlDataAdapter();
        private void NhanVienform_Load(object sender, EventArgs e)
        {
            cbxNhanVien.SelectedIndex = 0;
            string constring = ConfigurationManager.ConnectionStrings["QLNhapHang"].ConnectionString.ToString();
            con_NhanVien = new SqlConnection(constring);
            con_NhanVien.Open();
            Hienthi();
        }
        private void NhanVienform_FormClosing(object sender, FormClosingEventArgs e)
        {
            con_NhanVien.Close();
        }
        public void Hienthi()
        {
            string sqlSelect = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_NhanVien);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvnhanvien1.DataSource = dt;
        }
        private void dgvnhanvien1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                txtMaNhanVien.Text = dgvnhanvien1.Rows[i].Cells[0].Value.ToString();
                txtTenNhanvien.Text = dgvnhanvien1.Rows[i].Cells[1].Value.ToString();
                txtChucVu.Text = dgvnhanvien1.Rows[i].Cells[2].Value.ToString();
                txtPhone.Text = dgvnhanvien1.Rows[i].Cells[3].Value.ToString();
                dtpdate.Text = dgvnhanvien1.Rows[i].Cells[4].Value.ToString();
                txtDiaChi_NhanVien.Text = dgvnhanvien1.Rows[i].Cells[5].Value.ToString();
                txtLuong_NhanVien.Text = dgvnhanvien1.Rows[i].Cells[6].Value.ToString();
            }
        }


        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM NhanVien where MaNV =@MaNV";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con_NhanVien);
            cmd.Parameters.AddWithValue("MaNV", txtMaNhanVien.Text);
            cmd.Parameters.AddWithValue("TenNV", txtTenNhanvien.Text);
            cmd.Parameters.AddWithValue("ChucVu", txtChucVu.Text);
            cmd.Parameters.AddWithValue("SDT", txtPhone.Text);
            cmd.Parameters.AddWithValue("Nsinh", dtpdate.Text);
            cmd.Parameters.AddWithValue("DChiNV", txtDiaChi_NhanVien.Text);
            cmd.Parameters.AddWithValue("Luong", txtLuong_NhanVien.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnLamMoiNhanVien_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE NhanVien SET TenNV = @TenNV,ChucVu = @ChucVu,SDT = @SDT,Nsinh = @Nsinh,DChiNV = @DChiNV,Luong =@Luong where MaNV =@MaNV";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con_NhanVien);
            cmd.Parameters.AddWithValue("MaNV", txtMaNhanVien.Text);
            cmd.Parameters.AddWithValue("TenNV", txtTenNhanvien.Text);
            cmd.Parameters.AddWithValue("ChucVu", txtChucVu.Text);
            cmd.Parameters.AddWithValue("SDT", txtPhone.Text);
            cmd.Parameters.AddWithValue("Nsinh", dtpdate.Text);
            cmd.Parameters.AddWithValue("DChiNV", txtDiaChi_NhanVien.Text);
            cmd.Parameters.AddWithValue("Luong", txtLuong_NhanVien.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            string sqlAdd = "INSERT INTO NhanVien VALUES (@MaNV , @TenNV, @ChucVu, @SDT, @Nsinh, @DChiNV, @Luong)";
            SqlCommand cmd = new SqlCommand(sqlAdd, con_NhanVien);
            cmd.Parameters.AddWithValue("MaNV", txtMaNhanVien.Text);
            cmd.Parameters.AddWithValue("TenNV", txtTenNhanvien.Text);
            cmd.Parameters.AddWithValue("ChucVu", txtChucVu.Text);
            cmd.Parameters.AddWithValue("SDT", txtPhone.Text);
            cmd.Parameters.AddWithValue("Nsinh", dtpdate.Text);
            cmd.Parameters.AddWithValue("DChiNV", txtDiaChi_NhanVien.Text);
            cmd.Parameters.AddWithValue("Luong", txtLuong_NhanVien.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            string searchField = "";
            switch (cbxNhanVien.SelectedItem.ToString())
            {
                case "Mã nhân viên":
                    searchField = "MaNV";
                    break;
                case "Tên nhân viên":
                    searchField = "TenNV";
                    break;
                case "Chức vụ":
                    searchField = "ChucVu";
                    break;
                case "Số điện thoại":
                    searchField = "SDT";
                    break;
                case "Ngày sinh":
                    searchField = "Nsinh";
                    break;
                case "Địa chỉ":
                    searchField = "DChiNV";
                    break;
                case "Lương":
                    searchField = "Luong";
                    break;
            }
            string sqlSearch = "select * from NhanVien where " + searchField + " LIKE @value ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_NhanVien);
            cmd.Parameters.AddWithValue("@value", "%" + txtInputTimKiem_NhanVien.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvnhanvien1.DataSource = dt;
        }

        
    }
}
