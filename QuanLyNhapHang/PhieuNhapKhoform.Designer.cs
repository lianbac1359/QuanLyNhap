namespace QuanLyNhapHang
{
    partial class PhieuNhapKhoform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrintPhieu = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.dtpdayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInputTimKiem_Phieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPhieu = new System.Windows.Forms.ComboBox();
            this.btnTimKiemNhaCC = new System.Windows.Forms.Button();
            this.btnSuaPhieu = new System.Windows.Forms.Button();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnLamMoiPhieu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.dgvPhieu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập kho";
            // 
            // dgvPhieu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieu.Location = new System.Drawing.Point(3, 30);
            this.dgvPhieu.Name = "dgvPhieu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieu.RowHeadersWidth = 51;
            this.dgvPhieu.RowTemplate.Height = 24;
            this.dgvPhieu.Size = new System.Drawing.Size(893, 241);
            this.dgvPhieu.TabIndex = 0;
            this.dgvPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieu_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 342);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.btnPrintPhieu);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.dtpdayNhap);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaNCC);
            this.groupBox2.Controls.Add(this.txtMaHang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtInputTimKiem_Phieu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtTrangThai);
            this.groupBox2.Controls.Add(this.txtSoPhieu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxPhieu);
            this.groupBox2.Controls.Add(this.btnTimKiemNhaCC);
            this.groupBox2.Controls.Add(this.btnSuaPhieu);
            this.groupBox2.Controls.Add(this.btnThemPhieu);
            this.groupBox2.Controls.Add(this.btnXoaPhieu);
            this.groupBox2.Controls.Add(this.btnLamMoiPhieu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 342);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnPrintPhieu
            // 
            this.btnPrintPhieu.BackColor = System.Drawing.Color.DimGray;
            this.btnPrintPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintPhieu.FlatAppearance.BorderSize = 0;
            this.btnPrintPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPhieu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPhieu.ForeColor = System.Drawing.Color.White;
            this.btnPrintPhieu.Image = global::QuanLyNhapHang.Properties.Resources.printer_24px;
            this.btnPrintPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintPhieu.Location = new System.Drawing.Point(415, 264);
            this.btnPrintPhieu.Name = "btnPrintPhieu";
            this.btnPrintPhieu.Size = new System.Drawing.Size(187, 38);
            this.btnPrintPhieu.TabIndex = 35;
            this.btnPrintPhieu.Text = "In phiếu";
            this.btnPrintPhieu.UseVisualStyleBackColor = false;
            this.btnPrintPhieu.Click += new System.EventHandler(this.btnPrintPhieu_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(138, 176);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(201, 28);
            this.txtThanhTien.TabIndex = 34;
            // 
            // dtpdayNhap
            // 
            this.dtpdayNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdayNhap.Location = new System.Drawing.Point(137, 66);
            this.dtpdayNhap.Name = "dtpdayNhap";
            this.dtpdayNhap.Size = new System.Drawing.Size(200, 27);
            this.dtpdayNhap.TabIndex = 33;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(136, 287);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(201, 28);
            this.txtMaNV.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(6, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 31;
            this.label8.Text = "Mã nhân viên:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(136, 208);
            this.txtMaNCC.Multiline = true;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(201, 28);
            this.txtMaNCC.TabIndex = 29;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(136, 250);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(201, 28);
            this.txtMaHang.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(6, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Mã nhà cung cấp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(6, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã Hàng:";
            // 
            // txtInputTimKiem_Phieu
            // 
            this.txtInputTimKiem_Phieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputTimKiem_Phieu.Location = new System.Drawing.Point(668, 200);
            this.txtInputTimKiem_Phieu.Name = "txtInputTimKiem_Phieu";
            this.txtInputTimKiem_Phieu.Size = new System.Drawing.Size(187, 27);
            this.txtInputTimKiem_Phieu.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Thành Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ngày nhập:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(136, 140);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(201, 28);
            this.txtDiaChi.TabIndex = 20;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(138, 105);
            this.txtTrangThai.Multiline = true;
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(201, 28);
            this.txtTrangThai.TabIndex = 19;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieu.Location = new System.Drawing.Point(138, 32);
            this.txtSoPhieu.Multiline = true;
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(201, 28);
            this.txtSoPhieu.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số phiếu nhập:";
            // 
            // cbxPhieu
            // 
            this.cbxPhieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhieu.FormattingEnabled = true;
            this.cbxPhieu.Items.AddRange(new object[] {
            "Số phiếu nhập",
            "Ngày nhập",
            "Trạng thái",
            "Địa chỉ",
            "Thành tiền",
            "Mã hàng",
            "Mã nhân viên"});
            this.cbxPhieu.Location = new System.Drawing.Point(415, 200);
            this.cbxPhieu.Name = "cbxPhieu";
            this.cbxPhieu.Size = new System.Drawing.Size(187, 27);
            this.cbxPhieu.TabIndex = 6;
            // 
            // btnTimKiemNhaCC
            // 
            this.btnTimKiemNhaCC.BackColor = System.Drawing.Color.DimGray;
            this.btnTimKiemNhaCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemNhaCC.FlatAppearance.BorderSize = 0;
            this.btnTimKiemNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNhaCC.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNhaCC.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemNhaCC.Image = global::QuanLyNhapHang.Properties.Resources.search_24px;
            this.btnTimKiemNhaCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemNhaCC.Location = new System.Drawing.Point(668, 264);
            this.btnTimKiemNhaCC.Name = "btnTimKiemNhaCC";
            this.btnTimKiemNhaCC.Size = new System.Drawing.Size(187, 38);
            this.btnTimKiemNhaCC.TabIndex = 5;
            this.btnTimKiemNhaCC.Text = "Tim kiếm";
            this.btnTimKiemNhaCC.UseVisualStyleBackColor = false;
            this.btnTimKiemNhaCC.Click += new System.EventHandler(this.btnTimKiemNhaCC_Click);
            // 
            // btnSuaPhieu
            // 
            this.btnSuaPhieu.BackColor = System.Drawing.Color.DimGray;
            this.btnSuaPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaPhieu.FlatAppearance.BorderSize = 0;
            this.btnSuaPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPhieu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnSuaPhieu.Image = global::QuanLyNhapHang.Properties.Resources.change_24px;
            this.btnSuaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPhieu.Location = new System.Drawing.Point(415, 104);
            this.btnSuaPhieu.Name = "btnSuaPhieu";
            this.btnSuaPhieu.Size = new System.Drawing.Size(187, 38);
            this.btnSuaPhieu.TabIndex = 4;
            this.btnSuaPhieu.Text = "Sửa";
            this.btnSuaPhieu.UseVisualStyleBackColor = false;
            this.btnSuaPhieu.Click += new System.EventHandler(this.btnSuaPhieu_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.BackColor = System.Drawing.Color.DimGray;
            this.btnThemPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemPhieu.FlatAppearance.BorderSize = 0;
            this.btnThemPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhieu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieu.ForeColor = System.Drawing.Color.White;
            this.btnThemPhieu.Image = global::QuanLyNhapHang.Properties.Resources.add_24px;
            this.btnThemPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhieu.Location = new System.Drawing.Point(668, 104);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(187, 38);
            this.btnThemPhieu.TabIndex = 3;
            this.btnThemPhieu.Text = "Thêm";
            this.btnThemPhieu.UseVisualStyleBackColor = false;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.BackColor = System.Drawing.Color.DimGray;
            this.btnXoaPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaPhieu.FlatAppearance.BorderSize = 0;
            this.btnXoaPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieu.Image = global::QuanLyNhapHang.Properties.Resources.Delete_24px;
            this.btnXoaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieu.Location = new System.Drawing.Point(415, 46);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(187, 38);
            this.btnXoaPhieu.TabIndex = 2;
            this.btnXoaPhieu.Text = "Xóa";
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // btnLamMoiPhieu
            // 
            this.btnLamMoiPhieu.AutoSize = true;
            this.btnLamMoiPhieu.BackColor = System.Drawing.Color.DimGray;
            this.btnLamMoiPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoiPhieu.FlatAppearance.BorderSize = 0;
            this.btnLamMoiPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiPhieu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiPhieu.Image = global::QuanLyNhapHang.Properties.Resources.refresh_24px;
            this.btnLamMoiPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiPhieu.Location = new System.Drawing.Point(668, 46);
            this.btnLamMoiPhieu.Name = "btnLamMoiPhieu";
            this.btnLamMoiPhieu.Size = new System.Drawing.Size(187, 38);
            this.btnLamMoiPhieu.TabIndex = 1;
            this.btnLamMoiPhieu.Text = "Làm mới";
            this.btnLamMoiPhieu.UseVisualStyleBackColor = false;
            this.btnLamMoiPhieu.Click += new System.EventHandler(this.btnLamMoiPhieu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 274);
            this.panel1.TabIndex = 2;
            // 
            // PhieuNhapKhoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuNhapKhoform";
            this.Text = "PhieuNhapKhoform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhieuNhapKhoform_FormClosing);
            this.Load += new System.EventHandler(this.PhieuNhapKhoform_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInputTimKiem_Phieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPhieu;
        private System.Windows.Forms.Button btnTimKiemNhaCC;
        private System.Windows.Forms.Button btnSuaPhieu;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnLamMoiPhieu;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DateTimePicker dtpdayNhap;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.Button btnPrintPhieu;
    }
}