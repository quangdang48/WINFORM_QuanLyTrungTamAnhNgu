
namespace QuanLyTrungTamAnhNgu
{
    partial class frmNhapDiemThi
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonComboBox_KhoaHoc = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblTenHocVien = new System.Windows.Forms.Label();
            this.lblMaHocVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxHocLuc = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDiemThi = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.MaHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox_KhoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHocLuc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kryptonComboBox_KhoaHoc);
            this.panel1.Controls.Add(this.lblTenHocVien);
            this.panel1.Controls.Add(this.lblMaHocVien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxHocLuc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiem);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 152);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.label2.Location = new System.Drawing.Point(411, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Khóa học";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonComboBox_KhoaHoc
            // 
            this.kryptonComboBox_KhoaHoc.DropDownWidth = 276;
            this.kryptonComboBox_KhoaHoc.Location = new System.Drawing.Point(397, 71);
            this.kryptonComboBox_KhoaHoc.Name = "kryptonComboBox_KhoaHoc";
            this.kryptonComboBox_KhoaHoc.Size = new System.Drawing.Size(172, 40);
            this.kryptonComboBox_KhoaHoc.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.kryptonComboBox_KhoaHoc.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonComboBox_KhoaHoc.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox_KhoaHoc.StateCommon.ComboBox.Border.Rounding = 10;
            this.kryptonComboBox_KhoaHoc.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("SVN-Helves", 12.5F);
            this.kryptonComboBox_KhoaHoc.TabIndex = 28;
            // 
            // lblTenHocVien
            // 
            this.lblTenHocVien.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.lblTenHocVien.Location = new System.Drawing.Point(30, 61);
            this.lblTenHocVien.Name = "lblTenHocVien";
            this.lblTenHocVien.Size = new System.Drawing.Size(347, 50);
            this.lblTenHocVien.TabIndex = 27;
            this.lblTenHocVien.Text = "-";
            this.lblTenHocVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenHocVien.Click += new System.EventHandler(this.lblTenHocVien_Click);
            // 
            // lblMaHocVien
            // 
            this.lblMaHocVien.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.lblMaHocVien.Location = new System.Drawing.Point(30, 23);
            this.lblMaHocVien.Name = "lblMaHocVien";
            this.lblMaHocVien.Size = new System.Drawing.Size(80, 38);
            this.lblMaHocVien.TabIndex = 26;
            this.lblMaHocVien.Text = "-";
            this.lblMaHocVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.label1.Location = new System.Drawing.Point(805, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Học lực";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxHocLuc
            // 
            this.cbxHocLuc.DropDownWidth = 276;
            this.cbxHocLuc.Location = new System.Drawing.Point(791, 71);
            this.cbxHocLuc.Name = "cbxHocLuc";
            this.cbxHocLuc.Size = new System.Drawing.Size(191, 40);
            this.cbxHocLuc.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbxHocLuc.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbxHocLuc.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxHocLuc.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbxHocLuc.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("SVN-Helves", 12.5F);
            this.cbxHocLuc.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("SVN-Helves", 12F);
            this.label4.Location = new System.Drawing.Point(631, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Điểm thi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(597, 70);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(166, 47);
            this.txtDiem.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtDiem.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtDiem.StateCommon.Border.ColorAngle = 0F;
            this.txtDiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDiem.StateCommon.Border.Rounding = 15;
            this.txtDiem.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txtDiem.TabIndex = 17;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.Location = new System.Drawing.Point(1010, 80);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 58);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.White;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.Location = new System.Drawing.Point(1010, 17);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 57);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDiemThi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 431);
            this.panel2.TabIndex = 1;
            // 
            // dgvDiemThi
            // 
            this.dgvDiemThi.AllowUserToAddRows = false;
            this.dgvDiemThi.AllowUserToDeleteRows = false;
            this.dgvDiemThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocVien,
            this.TenHocVien,
            this.DiemThi,
            this.HocLuc});
            this.dgvDiemThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemThi.Location = new System.Drawing.Point(0, 0);
            this.dgvDiemThi.Name = "dgvDiemThi";
            this.dgvDiemThi.ReadOnly = true;
            this.dgvDiemThi.RowHeadersWidth = 51;
            this.dgvDiemThi.RowTemplate.Height = 24;
            this.dgvDiemThi.Size = new System.Drawing.Size(1089, 431);
            this.dgvDiemThi.TabIndex = 0;
            this.dgvDiemThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemThi_CellClick);
            // 
            // MaHocVien
            // 
            this.MaHocVien.DataPropertyName = "MaHocVien";
            this.MaHocVien.HeaderText = "Mã Học Viên";
            this.MaHocVien.MinimumWidth = 6;
            this.MaHocVien.Name = "MaHocVien";
            this.MaHocVien.ReadOnly = true;
            // 
            // TenHocVien
            // 
            this.TenHocVien.DataPropertyName = "TenHocVien";
            this.TenHocVien.HeaderText = "Tên Học Viên";
            this.TenHocVien.MinimumWidth = 6;
            this.TenHocVien.Name = "TenHocVien";
            this.TenHocVien.ReadOnly = true;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.MinimumWidth = 6;
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.ReadOnly = true;
            // 
            // HocLuc
            // 
            this.HocLuc.DataPropertyName = "HocLuc";
            this.HocLuc.HeaderText = "Học Lực";
            this.HocLuc.MinimumWidth = 6;
            this.HocLuc.Name = "HocLuc";
            this.HocLuc.ReadOnly = true;
            // 
            // frmNhapDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapDiemThi";
            this.Text = "frmNhapDiemThi";
            this.Load += new System.EventHandler(this.frmNhapDiemThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox_KhoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHocLuc)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public FontAwesome.Sharp.IconButton btnThoat;
        public FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.Label label4;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDiem;
        private System.Windows.Forms.Label label1;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxHocLuc;
        public System.Windows.Forms.Label lblTenHocVien;
        public System.Windows.Forms.Label lblMaHocVien;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDiemThi;
        public System.Windows.Forms.DataGridViewTextBoxColumn MaHocVien;
        public System.Windows.Forms.DataGridViewTextBoxColumn TenHocVien;
        public System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        public System.Windows.Forms.DataGridViewTextBoxColumn HocLuc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox_KhoaHoc;
    }
}