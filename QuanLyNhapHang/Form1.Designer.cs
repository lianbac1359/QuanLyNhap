namespace QuanLyNhapHang
{
    partial class Form1
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
            this.pnlside = new System.Windows.Forms.Panel();
            this.btnPhieu = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.pcBheader = new System.Windows.Forms.PictureBox();
            this.btnNhaCC = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblmain = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pnlside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBheader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlside
            // 
            this.pnlside.BackColor = System.Drawing.Color.DimGray;
            this.pnlside.Controls.Add(this.btnPhieu);
            this.pnlside.Controls.Add(this.btnNhanVien);
            this.pnlside.Controls.Add(this.btnHangHoa);
            this.pnlside.Controls.Add(this.pcBheader);
            this.pnlside.Controls.Add(this.btnNhaCC);
            this.pnlside.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlside.Location = new System.Drawing.Point(0, 0);
            this.pnlside.Name = "pnlside";
            this.pnlside.Size = new System.Drawing.Size(200, 651);
            this.pnlside.TabIndex = 1;
            this.pnlside.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // btnPhieu
            // 
            this.btnPhieu.BackColor = System.Drawing.Color.DimGray;
            this.btnPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhieu.FlatAppearance.BorderSize = 0;
            this.btnPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieu.ForeColor = System.Drawing.Color.White;
            this.btnPhieu.Image = global::QuanLyNhapHang.Properties.Resources.记事本_notepad__1_;
            this.btnPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieu.Location = new System.Drawing.Point(0, 370);
            this.btnPhieu.Name = "btnPhieu";
            this.btnPhieu.Size = new System.Drawing.Size(200, 49);
            this.btnPhieu.TabIndex = 3;
            this.btnPhieu.Text = "PHIẾU NHẬP KHO";
            this.btnPhieu.UseVisualStyleBackColor = false;
            this.btnPhieu.Click += new System.EventHandler(this.btnPhieu_Click);
            this.btnPhieu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.DimGray;
            this.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::QuanLyNhapHang.Properties.Resources.人员_people_1_;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 297);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(200, 49);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            this.btnNhanVien.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackColor = System.Drawing.Color.DimGray;
            this.btnHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.Image = global::QuanLyNhapHang.Properties.Resources.广告产品_ad_product_1_;
            this.btnHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.Location = new System.Drawing.Point(0, 220);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(200, 49);
            this.btnHangHoa.TabIndex = 3;
            this.btnHangHoa.Text = "HÀNG HÓA";
            this.btnHangHoa.UseVisualStyleBackColor = false;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            this.btnHangHoa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // pcBheader
            // 
            this.pcBheader.Location = new System.Drawing.Point(21, 12);
            this.pcBheader.Name = "pcBheader";
            this.pcBheader.Size = new System.Drawing.Size(135, 111);
            this.pcBheader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBheader.TabIndex = 4;
            this.pcBheader.TabStop = false;
            this.pcBheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.BackColor = System.Drawing.Color.DimGray;
            this.btnNhaCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhaCC.FlatAppearance.BorderSize = 0;
            this.btnNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCC.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCC.ForeColor = System.Drawing.Color.White;
            this.btnNhaCC.Image = global::QuanLyNhapHang.Properties.Resources.众多用户_every_user_1_;
            this.btnNhaCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaCC.Location = new System.Drawing.Point(0, 147);
            this.btnNhaCC.Name = "btnNhaCC";
            this.btnNhaCC.Size = new System.Drawing.Size(203, 49);
            this.btnNhaCC.TabIndex = 0;
            this.btnNhaCC.Text = "NHÀ CUNG CẤP";
            this.btnNhaCC.UseVisualStyleBackColor = false;
            this.btnNhaCC.Click += new System.EventHandler(this.btnNhaCC_Click);
            this.btnNhaCC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Controls.Add(this.lblmain);
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.btnclose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(899, 35);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // lblmain
            // 
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmain.Location = new System.Drawing.Point(350, 1);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(165, 35);
            this.lblmain.TabIndex = 0;
            this.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(845, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.DimGray;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(1042, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(54, 36);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 35);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(899, 616);
            this.mainpanel.TabIndex = 3;
            this.mainpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 651);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlside);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBheader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlside;
        private System.Windows.Forms.Button btnPhieu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.PictureBox pcBheader;
        private System.Windows.Forms.Button btnNhaCC;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label lblmain;
    }
}

