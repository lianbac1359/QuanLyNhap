using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;

namespace QuanLyNhapHang
{
    public partial class PhieuNhapKhoform : Form
    {
        public PhieuNhapKhoform()
        {
            InitializeComponent();
        }
        SqlConnection con_Phieu;

        SqlDataAdapter adapter = new SqlDataAdapter();

        private void PhieuNhapKhoform_Load(object sender, EventArgs e)
        {
            cbxPhieu.SelectedIndex = 0; 
            string constring = ConfigurationManager.ConnectionStrings["QLNhapHang"].ConnectionString.ToString();
            con_Phieu = new SqlConnection(constring);
            con_Phieu.Open();
            Hienthi();
        }

        private void PhieuNhapKhoform_FormClosing(object sender, FormClosingEventArgs e)
        {
            con_Phieu.Close();
        }
        public void Hienthi()
        {
            string sqlSelect = "select * from PhieuNhapKho";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_Phieu);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvPhieu.DataSource = dt;
        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                txtSoPhieu.Text = dgvPhieu.Rows[i].Cells[0].Value.ToString();
                dtpdayNhap.Text = dgvPhieu.Rows[i].Cells[1].Value.ToString();
                txtTrangThai.Text = dgvPhieu.Rows[i].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvPhieu.Rows[i].Cells[3].Value.ToString();
                txtThanhTien.Text = dgvPhieu.Rows[i].Cells[4].Value.ToString();
                txtMaHang.Text = dgvPhieu.Rows[i].Cells[5].Value.ToString();
                txtMaNV.Text = dgvPhieu.Rows[i].Cells[6].Value.ToString();
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM PhieuNhapKho where SoPhieuNhap =@SoPhieuNhap";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con_Phieu);
            cmd.Parameters.AddWithValue("SoPhieuNhap", txtSoPhieu.Text);
            cmd.Parameters.AddWithValue("NgayNhap", dtpdayNhap.Text);
            cmd.Parameters.AddWithValue("TrangthaiSP", txtTrangThai.Text);
            cmd.Parameters.AddWithValue("DiaChiSP", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("ThanhTien", txtThanhTien.Text);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnLamMoiPhieu_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE PhieuNhapKho SET NgayNhap = @NgayNhap,TrangthaiSP = @TrangthaiSP,DiaChiSP = @DiaChiSP,ThanhTien = @ThanhTien,MaHang =@MaHang,MaNV = @MaNV where SoPhieuNhap =@SoPhieuNhap";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con_Phieu);
            cmd.Parameters.AddWithValue("SoPhieuNhap", txtSoPhieu.Text);
            cmd.Parameters.AddWithValue("NgayNhap", dtpdayNhap.Text);
            cmd.Parameters.AddWithValue("TrangthaiSP", txtTrangThai.Text);
            cmd.Parameters.AddWithValue("DiaChiSP", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("ThanhTien", txtThanhTien.Text);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            string sqlAdd = "INSERT INTO PhieuNhapKho VALUES (@SoPhieuNhap, @NgayNhap, @TrangthaiSP, @DiaChiSP, @ThanhTien, @MaHang, @MaNV)";
            SqlCommand cmd = new SqlCommand(sqlAdd, con_Phieu);
            cmd.Parameters.AddWithValue("SoPhieuNhap", txtSoPhieu.Text);
            cmd.Parameters.AddWithValue("NgayNhap", dtpdayNhap.Text);
            cmd.Parameters.AddWithValue("TrangthaiSP", txtTrangThai.Text);
            cmd.Parameters.AddWithValue("DiaChiSP", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("ThanhTien", txtThanhTien.Text);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnTimKiemNhaCC_Click(object sender, EventArgs e)
        {
            string searchField = "";
            switch (cbxPhieu.SelectedItem.ToString())
            {
                case "Số phiếu nhập":
                    searchField = "SoPhieuNhap";
                    break;
                case "Ngày nhập":
                    searchField = "NgayNhap";
                    break;
                case "Trạng thái":
                    searchField = "TrangthaiSP";
                    break;
                case "Địa chỉ":
                    searchField = "DiaChiSP";
                    break;
                case "Thành tiền":
                    searchField = "ThanhTien";
                    break;
                case "Mã hàng":
                    searchField = "MaHang";
                    break;
                case "Mã nhân viên":
                    searchField = "MaNV";
                    break;
            }
            string sqlSearch = "select * from NhanVien where " + searchField + " LIKE @value ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_Phieu);
            cmd.Parameters.AddWithValue("@value", "%" + txtInputTimKiem_Phieu.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvPhieu.DataSource = dt;
        }

        private void btnPrintPhieu_Click(object sender, EventArgs e)
        {
            PrintPhieu frm1 = new PrintPhieu();
            frm1.ShowDialog();
        }
    }
}
