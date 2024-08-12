namespace QuanLyTrungTamAnhNgu
{
    partial class FormChonKhoaHocKhiThemLop
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
            this.comboBox_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.label_KhoaHoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton_BuocTiep = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton_Cancel = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_SoLopDangMo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_TenKhoaHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_GiaTien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_SoBuoiHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // comboBox_KhoaHoc
            // 
            this.comboBox_KhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_KhoaHoc.FormattingEnabled = true;
            this.comboBox_KhoaHoc.Location = new System.Drawing.Point(301, 118);
            this.comboBox_KhoaHoc.Name = "comboBox_KhoaHoc";
            this.comboBox_KhoaHoc.Size = new System.Drawing.Size(204, 28);
            this.comboBox_KhoaHoc.TabIndex = 0;
            this.comboBox_KhoaHoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_KhoaHoc_SelectedIndexChanged);
            // 
            // label_KhoaHoc
            // 
            this.label_KhoaHoc.AutoSize = true;
            this.label_KhoaHoc.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KhoaHoc.Location = new System.Drawing.Point(62, 114);
            this.label_KhoaHoc.Name = "label_KhoaHoc";
            this.label_KhoaHoc.Size = new System.Drawing.Size(107, 27);
            this.label_KhoaHoc.TabIndex = 1;
            this.label_KhoaHoc.Text = "Khóa học";
            this.label_KhoaHoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn khóa học mà bạn muốn thêm lớp";
            // 
            // iconButton_BuocTiep
            // 
            this.iconButton_BuocTiep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButton_BuocTiep.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconButton_BuocTiep.IconColor = System.Drawing.Color.Black;
            this.iconButton_BuocTiep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_BuocTiep.Location = new System.Drawing.Point(320, 494);
            this.iconButton_BuocTiep.Name = "iconButton_BuocTiep";
            this.iconButton_BuocTiep.Size = new System.Drawing.Size(92, 52);
            this.iconButton_BuocTiep.TabIndex = 3;
            this.iconButton_BuocTiep.UseVisualStyleBackColor = false;
            this.iconButton_BuocTiep.Click += new System.EventHandler(this.iconButton_BuocTiep_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lớp đang mở";
            // 
            // iconButton_Cancel
            // 
            this.iconButton_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton_Cancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton_Cancel.IconColor = System.Drawing.Color.Black;
            this.iconButton_Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Cancel.Location = new System.Drawing.Point(179, 494);
            this.iconButton_Cancel.Name = "iconButton_Cancel";
            this.iconButton_Cancel.Size = new System.Drawing.Size(86, 52);
            this.iconButton_Cancel.TabIndex = 6;
            this.iconButton_Cancel.UseVisualStyleBackColor = false;
            this.iconButton_Cancel.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tên khóa học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "Giá Tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 27);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số buổi học:";
            // 
            // textBox_SoLopDangMo
            // 
            this.textBox_SoLopDangMo.HideSelection = false;
            this.textBox_SoLopDangMo.Location = new System.Drawing.Point(301, 178);
            this.textBox_SoLopDangMo.Name = "textBox_SoLopDangMo";
            this.textBox_SoLopDangMo.ReadOnly = true;
            this.textBox_SoLopDangMo.Size = new System.Drawing.Size(181, 47);
            this.textBox_SoLopDangMo.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_SoLopDangMo.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_SoLopDangMo.StateCommon.Border.ColorAngle = 0F;
            this.textBox_SoLopDangMo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_SoLopDangMo.StateCommon.Border.Rounding = 15;
            this.textBox_SoLopDangMo.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_SoLopDangMo.TabIndex = 68;
            this.textBox_SoLopDangMo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SoLopDangMo_KeyPress);
            // 
            // textBox_TenKhoaHoc
            // 
            this.textBox_TenKhoaHoc.HideSelection = false;
            this.textBox_TenKhoaHoc.Location = new System.Drawing.Point(301, 252);
            this.textBox_TenKhoaHoc.Name = "textBox_TenKhoaHoc";
            this.textBox_TenKhoaHoc.ReadOnly = true;
            this.textBox_TenKhoaHoc.Size = new System.Drawing.Size(324, 47);
            this.textBox_TenKhoaHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_TenKhoaHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_TenKhoaHoc.StateCommon.Border.ColorAngle = 0F;
            this.textBox_TenKhoaHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_TenKhoaHoc.StateCommon.Border.Rounding = 15;
            this.textBox_TenKhoaHoc.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_TenKhoaHoc.TabIndex = 69;
            // 
            // textBox_GiaTien
            // 
            this.textBox_GiaTien.HideSelection = false;
            this.textBox_GiaTien.Location = new System.Drawing.Point(301, 328);
            this.textBox_GiaTien.Name = "textBox_GiaTien";
            this.textBox_GiaTien.ReadOnly = true;
            this.textBox_GiaTien.Size = new System.Drawing.Size(231, 47);
            this.textBox_GiaTien.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_GiaTien.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_GiaTien.StateCommon.Border.ColorAngle = 0F;
            this.textBox_GiaTien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_GiaTien.StateCommon.Border.Rounding = 15;
            this.textBox_GiaTien.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_GiaTien.TabIndex = 70;
            this.textBox_GiaTien.TextChanged += new System.EventHandler(this.textBox_GiaTien_TextChanged);
            this.textBox_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_GiaTien_KeyPress);
            // 
            // textBox_SoBuoiHoc
            // 
            this.textBox_SoBuoiHoc.HideSelection = false;
            this.textBox_SoBuoiHoc.Location = new System.Drawing.Point(301, 412);
            this.textBox_SoBuoiHoc.Name = "textBox_SoBuoiHoc";
            this.textBox_SoBuoiHoc.ReadOnly = true;
            this.textBox_SoBuoiHoc.Size = new System.Drawing.Size(181, 47);
            this.textBox_SoBuoiHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_SoBuoiHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_SoBuoiHoc.StateCommon.Border.ColorAngle = 0F;
            this.textBox_SoBuoiHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_SoBuoiHoc.StateCommon.Border.Rounding = 15;
            this.textBox_SoBuoiHoc.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_SoBuoiHoc.TabIndex = 71;
            this.textBox_SoBuoiHoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SoBuoiHoc_KeyPress);
            // 
            // FormChonKhoaHocKhiThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(673, 591);
            this.Controls.Add(this.textBox_SoBuoiHoc);
            this.Controls.Add(this.textBox_GiaTien);
            this.Controls.Add(this.textBox_TenKhoaHoc);
            this.Controls.Add(this.textBox_SoLopDangMo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iconButton_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButton_BuocTiep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_KhoaHoc);
            this.Controls.Add(this.comboBox_KhoaHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChonKhoaHocKhiThemLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonKhoaHocKhiThemLop";
            this.Load += new System.EventHandler(this.FormChonKhoaHocKhiThemLop_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_KhoaHoc;
        private System.Windows.Forms.Label label_KhoaHoc;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton_BuocTiep;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton_Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_SoLopDangMo;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_TenKhoaHoc;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_GiaTien;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_SoBuoiHoc;
    }
}