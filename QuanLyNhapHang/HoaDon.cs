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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        SqlConnection con_HoaDon;

        SqlDataAdapter adapter = new SqlDataAdapter();

        private void HoaDon_Load(object sender, EventArgs e)
        {
            cbxHoaDon.SelectedIndex = 0;
            string constring = ConfigurationManager.ConnectionStrings["QLNhapHang"].ConnectionString.ToString();
            con_HoaDon = new SqlConnection(constring);
            con_HoaDon.Open();
            Hienthi();
        }

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            con_HoaDon.Close();
        }
        public void Hienthi()
        {
            string sqlSelect = "select * from HoaDon";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_HoaDon);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvHoaDon1.DataSource = dt;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                txtSoHoaDon.Text = dgvHoaDon1.Rows[i].Cells[0].Value.ToString();
                dtpdaygui.Text = dgvHoaDon1.Rows[i].Cells[1].Value.ToString();
                txtsoluong.Text = dgvHoaDon1.Rows[i].Cells[2].Value.ToString();
                txttongtien.Text = dgvHoaDon1.Rows[i].Cells[3].Value.ToString();
                txtMaNCC.Text = dgvHoaDon1.Rows[i].Cells[4].Value.ToString();
                txtMaHang.Text = dgvHoaDon1.Rows[i].Cells[4].Value.ToString();
                txtMaNV.Text = dgvHoaDon1.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM HangHoa where SoHoaDon =@SoHoaDon";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con_HoaDon);
            cmd.Parameters.AddWithValue("SoHoaDon", txtSoHoaDon.Text);
            cmd.Parameters.AddWithValue("NgayGui", dtpdaygui.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtsoluong.Text);
            cmd.Parameters.AddWithValue("Tongtien", txttongtien.Text);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnLamMoiHoaDon_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE HangHoa SET NgayGui = @NgayGui,SoLuong = @SoLuong,Tongtien = @Tongtien,MaNCC = @MaNCC,MaHang =@MaHang,MaNV =@MaNV where SoHoaDon =@SoHoaDon";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con_HoaDon);
            cmd.Parameters.AddWithValue("SoHoaDon", txtSoHoaDon.Text);
            cmd.Parameters.AddWithValue("NgayGui", dtpdaygui.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtsoluong.Text);
            cmd.Parameters.AddWithValue("Tongtien", txttongtien.Text);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            string sqlAdd = "INSERT INTO HoaDon VALUES (@SoHoaDon , @NgayGui, @SoLuong, @Tongtien, @MaNCC, @MaHang, @MaNV)";
            SqlCommand cmd = new SqlCommand(sqlAdd, con_HoaDon);
            cmd.Parameters.AddWithValue("SoHoaDon", txtSoHoaDon.Text);
            cmd.Parameters.AddWithValue("NgayGui", dtpdaygui.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtsoluong.Text);
            cmd.Parameters.AddWithValue("Tongtien", txttongtien.Text);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnTimKiem_HoaDon_Click(object sender, EventArgs e)
        {
            string searchField = "";
            switch (cbxHoaDon.SelectedItem.ToString())
            {
                case "Số hóa đơn":
                    searchField = "SoHoaDon";
                    break;
                case "Ngày gửi":
                    searchField = "NgayGui";
                    break;
                case "Số lượng":
                    searchField = "SoLuong";
                    break;
                case "Tổng tiền":
                    searchField = "Tongtien";
                    break;
                case "Mã nhà cung cấp":
                    searchField = "MaNCC";
                    break;
                case "Mã hàng":
                    searchField = "MaHang";
                    break;
                case "Mã nhân viên":
                    searchField = "MaNV";
                    break;
            }
            string sqlSearch = "select * from HoaDon where " + searchField + " LIKE @value ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_HoaDon);
            cmd.Parameters.AddWithValue("@value", "%" + txtInputTimKiem_HoaDon.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvHoaDon1.DataSource = dt;
        }

        private void btnPrintHoaDon_Click(object sender, EventArgs e)
        {
            PrintBill frm2 = new PrintBill();
            frm2.ShowDialog(this);  
        }
    }
}
