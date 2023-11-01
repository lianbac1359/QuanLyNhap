using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhapHang
{
    public partial class Form1 : Form
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();
        }
        
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            pcBheader.Visible = false;
            pcBheader.Image = Properties.Resources.user_96px;
            pcBheader.Visible = true;
            loadform(new NhaCungCapform());
            lblmain.Text = "Nhà Cung cấp";
            btnNhaCC.BackColor = Color.Chocolate;
            pnlHeader.BackColor = Color.Chocolate;
            btnHangHoa.BackColor = Color.DimGray;
            btnNhanVien.BackColor = Color.DimGray;
            btnPhieu.BackColor = Color.DimGray;
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            pcBheader.Visible = false;
            pcBheader.Image = Properties.Resources.product_96px; 
            pcBheader.Visible = true;
            loadform(new HangHoaform());
            lblmain.Text = "Hàng Hóa";
            btnNhaCC.BackColor = Color.DimGray;
            pnlHeader.BackColor = Color.Orange;
            btnHangHoa.BackColor = Color.Orange;
            btnNhanVien.BackColor = Color.DimGray;
            btnPhieu.BackColor = Color.DimGray;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pcBheader.Visible = false;
            pcBheader.Image = Properties.Resources.人员_people;
            pcBheader.Visible = true;
            loadform(new NhanVienform());
            lblmain.Text = "Nhân Viên";
            btnNhaCC.BackColor = Color.DimGray;
            pnlHeader.BackColor = Color.GreenYellow;
            btnHangHoa.BackColor = Color.DimGray;
            btnNhanVien.BackColor = Color.GreenYellow;
            btnPhieu.BackColor = Color.DimGray;
        }

        private void btnPhieu_Click(object sender, EventArgs e)
        {
            pcBheader.Visible = false;
            pcBheader.Image = Properties.Resources.notepad_96px;
            pcBheader.Visible = true;
            loadform(new PhieuNhapKhoform());
            lblmain.Text = "Phiếu Nhập Kho";
            btnNhaCC.BackColor = Color.DimGray;
            pnlHeader.BackColor = Color.LightSeaGreen;
            btnHangHoa.BackColor = Color.DimGray;
            btnNhanVien.BackColor = Color.DimGray;
            btnPhieu.BackColor = Color.LightSeaGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNhaCC_Click(sender, e);
        }

        
    }
}
