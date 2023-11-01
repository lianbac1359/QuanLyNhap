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

namespace QuanLyNhapHang
{
    public partial class HangHoaform : Form
    {
        public HangHoaform()
        {
            InitializeComponent();
        }
        SqlConnection con_HangHoa;

        SqlDataAdapter adapter = new SqlDataAdapter();

        private void HangHoaform_Load(object sender, EventArgs e)
        {
            cbxHangHoa.SelectedIndex = 0;
            string constring = ConfigurationManager.ConnectionStrings["QLNhapHang"].ConnectionString.ToString();
            con_HangHoa = new SqlConnection(constring);
            con_HangHoa.Open();
            Hienthi();
        }

        private void HangHoaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            con_HangHoa.Close();
        }
        public void Hienthi()
        {
            string sqlSelect = "select * from HangHoa";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_HangHoa);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvHangHoa.DataSource = dt;
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                txtMaHang.Text = dgvHangHoa.Rows[i].Cells[0].Value.ToString();
                txtTenHang.Text = dgvHangHoa.Rows[i].Cells[1].Value.ToString();
                txtDonGia.Text = dgvHangHoa.Rows[i].Cells[2].Value.ToString();
                txtMaNhaCC_HangHoa.Text = dgvHangHoa.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM HangHoa where MaHang =@MaHang";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con_HangHoa);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("TenHang", txtTenHang.Text);
            cmd.Parameters.AddWithValue("Don_gia", txtDonGia.Text);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNhaCC_HangHoa.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnLamMoiHangHoa_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            string sqlAdd = "INSERT INTO HangHoa VALUES (@MaHang , @TenHang, @Don_gia, @MaNCC)";
            SqlCommand cmd = new SqlCommand(sqlAdd, con_HangHoa);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("TenHang", txtTenHang.Text);
            cmd.Parameters.AddWithValue("Don_gia", txtDonGia.Text);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNhaCC_HangHoa.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE HangHoa SET TenHang = @TenHang,Don_gia = @Don_gia,MaNCC = @MaNCC where MaHang =@MaHang";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con_HangHoa);
            cmd.Parameters.AddWithValue("MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("TenHang", txtTenHang.Text);
            cmd.Parameters.AddWithValue("Don_gia", txtDonGia.Text);
            cmd.Parameters.AddWithValue("MaNCC", txtMaNhaCC_HangHoa.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnTimKiemHangHoa_Click(object sender, EventArgs e)
        {
            string searchField = "";
            switch (cbxHangHoa.SelectedItem.ToString())
            {
                case "Mã hàng":
                    searchField = "MaHang";
                    break;
                case "Tên hàng":
                    searchField = "TenHang";
                    break;
                case "Đơn giá":
                    searchField = "Don_gia";
                    break;
                case "Mã nhà cung cấp":
                    searchField = "MaNCC";
                    break;
            }
            string sqlSearch = "select * from HangHoa where " + searchField + " LIKE @value ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_HangHoa);
            cmd.Parameters.AddWithValue("@value", "%" + txtInputTimKiem_HangHoa.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvHangHoa.DataSource = dt;
        }
    }

    
  }
    

