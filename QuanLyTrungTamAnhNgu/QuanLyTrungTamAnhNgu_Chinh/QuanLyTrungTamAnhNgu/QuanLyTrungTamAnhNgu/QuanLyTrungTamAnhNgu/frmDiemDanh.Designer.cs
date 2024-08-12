
namespace QuanLyTrungTamAnhNgu
{
    partial class frmDiemDanh
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
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.cbxNgayHoc = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbxLopHoc = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dgvDsDiemDanh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.MaSoDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNgayHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.cbxNgayHoc);
            this.panel1.Controls.Add(this.cbxLopHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 132);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.Location = new System.Drawing.Point(951, 51);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(62, 48);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.label2.Location = new System.Drawing.Point(603, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ngày học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.label1.Location = new System.Drawing.Point(72, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên lớp học";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.White;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.Location = new System.Drawing.Point(1244, 34);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 53);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Save";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbxNgayHoc
            // 
            this.cbxNgayHoc.DropDownWidth = 276;
            this.cbxNgayHoc.Location = new System.Drawing.Point(595, 57);
            this.cbxNgayHoc.Name = "cbxNgayHoc";
            this.cbxNgayHoc.Size = new System.Drawing.Size(284, 42);
            this.cbxNgayHoc.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbxNgayHoc.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbxNgayHoc.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxNgayHoc.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbxNgayHoc.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.cbxNgayHoc.TabIndex = 1;
            // 
            // cbxLopHoc
            // 
            this.cbxLopHoc.DropDownWidth = 404;
            this.cbxLopHoc.Location = new System.Drawing.Point(60, 57);
            this.cbxLopHoc.Name = "cbxLopHoc";
            this.cbxLopHoc.Size = new System.Drawing.Size(410, 42);
            this.cbxLopHoc.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbxLopHoc.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbxLopHoc.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxLopHoc.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbxLopHoc.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.cbxLopHoc.TabIndex = 0;
            // 
            // dgvDsDiemDanh
            // 
            this.dgvDsDiemDanh.AllowUserToAddRows = false;
            this.dgvDsDiemDanh.AllowUserToDeleteRows = false;
            this.dgvDsDiemDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSoDiemDanh,
            this.MaHocVien,
            this.TenHocVien,
            this.TrangThai});
            this.dgvDsDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsDiemDanh.Location = new System.Drawing.Point(0, 132);
            this.dgvDsDiemDanh.Name = "dgvDsDiemDanh";
            this.dgvDsDiemDanh.RowHeadersWidth = 51;
            this.dgvDsDiemDanh.RowTemplate.Height = 24;
            this.dgvDsDiemDanh.Size = new System.Drawing.Size(1387, 567);
            this.dgvDsDiemDanh.StateCommon.Background.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.dgvDsDiemDanh.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDsDiemDanh.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.dgvDsDiemDanh.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDsDiemDanh.TabIndex = 1;
            this.dgvDsDiemDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsDiemDanh_CellContentClick);
            // 
            // MaSoDiemDanh
            // 
            this.MaSoDiemDanh.DataPropertyName = "MaDiemDanh";
            this.MaSoDiemDanh.HeaderText = "Mã số điểm danh";
            this.MaSoDiemDanh.MinimumWidth = 6;
            this.MaSoDiemDanh.Name = "MaSoDiemDanh";
            // 
            // MaHocVien
            // 
            this.MaHocVien.DataPropertyName = "MaHocVien";
            this.MaHocVien.HeaderText = "Mã học viên";
            this.MaHocVien.MinimumWidth = 6;
            this.MaHocVien.Name = "MaHocVien";
            // 
            // TenHocVien
            // 
            this.TenHocVien.DataPropertyName = "TenHocVien";
            this.TenHocVien.HeaderText = "Tên học viên";
            this.TenHocVien.MinimumWidth = 6;
            this.TenHocVien.Name = "TenHocVien";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Present";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 699);
            this.Controls.Add(this.dgvDsDiemDanh);
            this.Controls.Add(this.panel1);
            this.Name = "frmDiemDanh";
            this.Text = "frmDiemDanh";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNgayHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDiemDanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDsDiemDanh;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxLopHoc;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxNgayHoc;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}