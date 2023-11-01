namespace QuanLyNhapHang
{
    partial class HangHoaform
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
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInputTimKiem_HangHoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhaCC_HangHoa = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxHangHoa = new System.Windows.Forms.ComboBox();
            this.btnTimKiemHangHoa = new System.Windows.Forms.Button();
            this.btnSuaHangHoa = new System.Windows.Forms.Button();
            this.btnThemHangHoa = new System.Windows.Forms.Button();
            this.btnXoaHangHoa = new System.Windows.Forms.Button();
            this.btnLamMoiHangHoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Controls.Add(this.dgvHangHoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // dgvHangHoa
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHangHoa.Location = new System.Drawing.Point(182, 32);
            this.dgvHangHoa.Name = "dgvHangHoa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.Size = new System.Drawing.Size(455, 236);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
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
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.txtInputTimKiem_HangHoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaNhaCC_HangHoa);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtMaHang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxHangHoa);
            this.groupBox2.Controls.Add(this.btnTimKiemHangHoa);
            this.groupBox2.Controls.Add(this.btnSuaHangHoa);
            this.groupBox2.Controls.Add(this.btnThemHangHoa);
            this.groupBox2.Controls.Add(this.btnXoaHangHoa);
            this.groupBox2.Controls.Add(this.btnLamMoiHangHoa);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtInputTimKiem_HangHoa
            // 
            this.txtInputTimKiem_HangHoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputTimKiem_HangHoa.Location = new System.Drawing.Point(668, 200);
            this.txtInputTimKiem_HangHoa.Name = "txtInputTimKiem_HangHoa";
            this.txtInputTimKiem_HangHoa.Size = new System.Drawing.Size(187, 27);
            this.txtInputTimKiem_HangHoa.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(7, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(7, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Đơn giá :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(7, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên hàng:";
            // 
            // txtMaNhaCC_HangHoa
            // 
            this.txtMaNhaCC_HangHoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhaCC_HangHoa.Location = new System.Drawing.Point(142, 214);
            this.txtMaNhaCC_HangHoa.Multiline = true;
            this.txtMaNhaCC_HangHoa.Name = "txtMaNhaCC_HangHoa";
            this.txtMaNhaCC_HangHoa.Size = new System.Drawing.Size(201, 28);
            this.txtMaNhaCC_HangHoa.TabIndex = 20;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(142, 157);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(201, 28);
            this.txtDonGia.TabIndex = 19;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(142, 103);
            this.txtTenHang.Multiline = true;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(201, 28);
            this.txtTenHang.TabIndex = 18;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(142, 53);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(201, 28);
            this.txtMaHang.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã hàng:";
            // 
            // cbxHangHoa
            // 
            this.cbxHangHoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHangHoa.FormattingEnabled = true;
            this.cbxHangHoa.Items.AddRange(new object[] {
            "Mã hàng",
            "Tên hàng",
            "Đơn giá",
            "Mã nhà cung cấp"});
            this.cbxHangHoa.Location = new System.Drawing.Point(402, 200);
            this.cbxHangHoa.Name = "cbxHangHoa";
            this.cbxHangHoa.Size = new System.Drawing.Size(200, 27);
            this.cbxHangHoa.TabIndex = 6;
            // 
            // btnTimKiemHangHoa
            // 
            this.btnTimKiemHangHoa.BackColor = System.Drawing.Color.DimGray;
            this.btnTimKiemHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemHangHoa.FlatAppearance.BorderSize = 0;
            this.btnTimKiemHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemHangHoa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemHangHoa.Image = global::QuanLyNhapHang.Properties.Resources.search_24px;
            this.btnTimKiemHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemHangHoa.Location = new System.Drawing.Point(668, 266);
            this.btnTimKiemHangHoa.Name = "btnTimKiemHangHoa";
            this.btnTimKiemHangHoa.Size = new System.Drawing.Size(187, 38);
            this.btnTimKiemHangHoa.TabIndex = 5;
            this.btnTimKiemHangHoa.Text = "Tim kiếm";
            this.btnTimKiemHangHoa.UseVisualStyleBackColor = false;
            this.btnTimKiemHangHoa.Click += new System.EventHandler(this.btnTimKiemHangHoa_Click);
            // 
            // btnSuaHangHoa
            // 
            this.btnSuaHangHoa.BackColor = System.Drawing.Color.DimGray;
            this.btnSuaHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaHangHoa.FlatAppearance.BorderSize = 0;
            this.btnSuaHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHangHoa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnSuaHangHoa.Image = global::QuanLyNhapHang.Properties.Resources.change_24px;
            this.btnSuaHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHangHoa.Location = new System.Drawing.Point(415, 104);
            this.btnSuaHangHoa.Name = "btnSuaHangHoa";
            this.btnSuaHangHoa.Size = new System.Drawing.Size(187, 38);
            this.btnSuaHangHoa.TabIndex = 4;
            this.btnSuaHangHoa.Text = "Sửa";
            this.btnSuaHangHoa.UseVisualStyleBackColor = false;
            this.btnSuaHangHoa.Click += new System.EventHandler(this.btnSuaHangHoa_Click);
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.BackColor = System.Drawing.Color.DimGray;
            this.btnThemHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemHangHoa.FlatAppearance.BorderSize = 0;
            this.btnThemHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHangHoa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnThemHangHoa.Image = global::QuanLyNhapHang.Properties.Resources.add_24px;
            this.btnThemHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHangHoa.Location = new System.Drawing.Point(668, 104);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(187, 38);
            this.btnThemHangHoa.TabIndex = 3;
            this.btnThemHangHoa.Text = "Thêm";
            this.btnThemHangHoa.UseVisualStyleBackColor = false;
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // btnXoaHangHoa
            // 
            this.btnXoaHangHoa.BackColor = System.Drawing.Color.DimGray;
            this.btnXoaHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaHangHoa.FlatAppearance.BorderSize = 0;
            this.btnXoaHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHangHoa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnXoaHangHoa.Image = global::QuanLyNhapHang.Properties.Resources.Delete_24px;
            this.btnXoaHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHangHoa.Location = new System.Drawing.Point(415, 46);
            this.btnXoaHangHoa.Name = "btnXoaHangHoa";
            this.btnXoaHangHoa.Size = new System.Drawing.Size(187, 38);
            this.btnXoaHangHoa.TabIndex = 2;
            this.btnXoaHangHoa.Text = "Xóa";
            this.btnXoaHangHoa.UseVisualStyleBackColor = false;
            this.btnXoaHangHoa.Click += new System.EventHandler(this.btnXoaHangHoa_Click);
            // 
            // btnLamMoiHangHoa
            // 
            this.btnLamMoiHangHoa.AutoSize = true;
            this.btnLamMoiHangHoa.BackColor = System.Drawing.Color.DimGray;
            this.btnLamMoiHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoiHangHoa.FlatAppearance.BorderSize = 0;
            this.btnLamMoiHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiHangHoa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiHangHoa.Image = global::QuanLyNhapHang.Properties.Resources.refresh_24px;
            this.btnLamMoiHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiHangHoa.Location = new System.Drawing.Point(668, 46);
            this.btnLamMoiHangHoa.Name = "btnLamMoiHangHoa";
            this.btnLamMoiHangHoa.Size = new System.Drawing.Size(187, 38);
            this.btnLamMoiHangHoa.TabIndex = 1;
            this.btnLamMoiHangHoa.Text = "Làm mới";
            this.btnLamMoiHangHoa.UseVisualStyleBackColor = false;
            this.btnLamMoiHangHoa.Click += new System.EventHandler(this.btnLamMoiHangHoa_Click);
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
            // HangHoaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HangHoaform";
            this.Text = "HangHoaform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HangHoaform_FormClosing);
            this.Load += new System.EventHandler(this.HangHoaform_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
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
        private System.Windows.Forms.TextBox txtInputTimKiem_HangHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNhaCC_HangHoa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxHangHoa;
        private System.Windows.Forms.Button btnTimKiemHangHoa;
        private System.Windows.Forms.Button btnSuaHangHoa;
        private System.Windows.Forms.Button btnThemHangHoa;
        private System.Windows.Forms.Button btnXoaHangHoa;
        private System.Windows.Forms.Button btnLamMoiHangHoa;
        private System.Windows.Forms.DataGridView dgvHangHoa;
    }
}