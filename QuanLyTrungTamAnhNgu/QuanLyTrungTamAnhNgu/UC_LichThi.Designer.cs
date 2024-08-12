
namespace QuanLyTrungTamAnhNgu
{
    partial class UC_LichThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaLichThi = new System.Windows.Forms.Label();
            this.lblTenDotThi = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNgayThi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhapDiem = new FontAwesome.Sharp.IconButton();
            this.btnDangKy = new FontAwesome.Sharp.IconButton();
            this.btnXoaHV = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lịch thi:";
            // 
            // lblMaLichThi
            // 
            this.lblMaLichThi.BackColor = System.Drawing.Color.SkyBlue;
            this.lblMaLichThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaLichThi.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.lblMaLichThi.Location = new System.Drawing.Point(133, 10);
            this.lblMaLichThi.Name = "lblMaLichThi";
            this.lblMaLichThi.Size = new System.Drawing.Size(45, 35);
            this.lblMaLichThi.TabIndex = 4;
            this.lblMaLichThi.Text = "-";
            // 
            // lblTenDotThi
            // 
            this.lblTenDotThi.Font = new System.Drawing.Font("SVN-Helves", 14F, System.Drawing.FontStyle.Bold);
            this.lblTenDotThi.Location = new System.Drawing.Point(10, 58);
            this.lblTenDotThi.Name = "lblTenDotThi";
            this.lblTenDotThi.Size = new System.Drawing.Size(472, 43);
            this.lblTenDotThi.TabIndex = 5;
            this.lblTenDotThi.Text = "Tên";
            this.lblTenDotThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenDotThi.Click += new System.EventHandler(this.lblTenDotThi_Click);
            // 
            // lbLop
            // 
            this.lbLop.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.lbLop.Location = new System.Drawing.Point(81, 116);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(401, 35);
            this.lbLop.TabIndex = 7;
            this.lbLop.Text = "-";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lớp:";
            // 
            // lblNgayThi
            // 
            this.lblNgayThi.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.lblNgayThi.Location = new System.Drawing.Point(368, 10);
            this.lblNgayThi.Name = "lblNgayThi";
            this.lblNgayThi.Size = new System.Drawing.Size(132, 35);
            this.lblNgayThi.TabIndex = 9;
            this.lblNgayThi.Text = "-";
            this.lblNgayThi.Click += new System.EventHandler(this.lblNgayThi_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.label5.Location = new System.Drawing.Point(279, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNhapDiem);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.btnXoaHV);
            this.panel1.Location = new System.Drawing.Point(-15, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 93);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(178)))), ((int)(((byte)(224)))));
            this.btnNhapDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapDiem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNhapDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapDiem.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhapDiem.ForeColor = System.Drawing.Color.White;
            this.btnNhapDiem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNhapDiem.IconColor = System.Drawing.Color.Black;
            this.btnNhapDiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapDiem.Location = new System.Drawing.Point(39, 7);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(133, 46);
            this.btnNhapDiem.TabIndex = 14;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(228)))), ((int)(((byte)(61)))));
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDangKy.IconColor = System.Drawing.Color.Black;
            this.btnDangKy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangKy.Location = new System.Drawing.Point(371, 7);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(133, 46);
            this.btnDangKy.TabIndex = 13;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoaHV.FlatAppearance.BorderSize = 0;
            this.btnXoaHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHV.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnXoaHV.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaHV.IconColor = System.Drawing.Color.OrangeRed;
            this.btnXoaHV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaHV.Location = new System.Drawing.Point(234, 9);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(68, 44);
            this.btnXoaHV.TabIndex = 12;
            this.btnXoaHV.UseVisualStyleBackColor = true;
            this.btnXoaHV.Click += new System.EventHandler(this.btnXoaHV_Click);
            // 
            // UC_LichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblMaLichThi);
            this.Controls.Add(this.lblNgayThi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenDotThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_LichThi";
            this.Size = new System.Drawing.Size(513, 223);
            this.Load += new System.EventHandler(this.UC_LichThi_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblMaLichThi;
        public System.Windows.Forms.Label lblTenDotThi;
        public System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblNgayThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnXoaHV;
        private FontAwesome.Sharp.IconButton btnNhapDiem;
        private FontAwesome.Sharp.IconButton btnDangKy;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
