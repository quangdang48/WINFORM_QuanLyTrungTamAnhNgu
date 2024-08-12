namespace QuanLyTrungTamAnhNgu
{
    partial class FormChinhSuaLopHoc
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChinhSuaKhoaHoc = new FontAwesome.Sharp.IconButton();
            this.cbxGiangVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton_Cancel = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_MaLopHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_TenLopHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 27);
            this.label6.TabIndex = 57;
            this.label6.Text = "Mã lớp học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tên lớp học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 50;
            this.label2.Text = "Giảng viên";
            // 
            // btnChinhSuaKhoaHoc
            // 
            this.btnChinhSuaKhoaHoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChinhSuaKhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChinhSuaKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnChinhSuaKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSuaKhoaHoc.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnChinhSuaKhoaHoc.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnChinhSuaKhoaHoc.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChinhSuaKhoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChinhSuaKhoaHoc.Location = new System.Drawing.Point(407, 341);
            this.btnChinhSuaKhoaHoc.Name = "btnChinhSuaKhoaHoc";
            this.btnChinhSuaKhoaHoc.Size = new System.Drawing.Size(76, 55);
            this.btnChinhSuaKhoaHoc.TabIndex = 48;
            this.btnChinhSuaKhoaHoc.UseVisualStyleBackColor = false;
            this.btnChinhSuaKhoaHoc.Click += new System.EventHandler(this.btnChinhSuaKhoaHoc_Click_1);
            // 
            // cbxGiangVien
            // 
            this.cbxGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGiangVien.FormattingEnabled = true;
            this.cbxGiangVien.Location = new System.Drawing.Point(277, 203);
            this.cbxGiangVien.Name = "cbxGiangVien";
            this.cbxGiangVien.Size = new System.Drawing.Size(207, 33);
            this.cbxGiangVien.TabIndex = 61;
            this.cbxGiangVien.SelectedIndexChanged += new System.EventHandler(this.cbxGiangVien_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 27);
            this.label4.TabIndex = 65;
            this.label4.Text = "Giảng viên";
            // 
            // cbxPhong
            // 
            this.cbxPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhong.FormattingEnabled = true;
            this.cbxPhong.Location = new System.Drawing.Point(275, 275);
            this.cbxPhong.Name = "cbxPhong";
            this.cbxPhong.Size = new System.Drawing.Size(207, 33);
            this.cbxPhong.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 64;
            this.label3.Text = "Phòng";
            // 
            // iconButton_Cancel
            // 
            this.iconButton_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButton_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton_Cancel.FlatAppearance.BorderSize = 0;
            this.iconButton_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Cancel.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconButton_Cancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton_Cancel.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton_Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Cancel.Location = new System.Drawing.Point(249, 341);
            this.iconButton_Cancel.Name = "iconButton_Cancel";
            this.iconButton_Cancel.Size = new System.Drawing.Size(76, 55);
            this.iconButton_Cancel.TabIndex = 66;
            this.iconButton_Cancel.UseVisualStyleBackColor = false;
            this.iconButton_Cancel.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBox_MaLopHoc
            // 
            this.textBox_MaLopHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MaLopHoc.HideSelection = false;
            this.textBox_MaLopHoc.Location = new System.Drawing.Point(275, 59);
            this.textBox_MaLopHoc.Name = "textBox_MaLopHoc";
            this.textBox_MaLopHoc.ReadOnly = true;
            this.textBox_MaLopHoc.Size = new System.Drawing.Size(181, 47);
            this.textBox_MaLopHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_MaLopHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_MaLopHoc.StateCommon.Border.ColorAngle = 0F;
            this.textBox_MaLopHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_MaLopHoc.StateCommon.Border.Rounding = 15;
            this.textBox_MaLopHoc.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_MaLopHoc.TabIndex = 67;
            // 
            // textBox_TenLopHoc
            // 
            this.textBox_TenLopHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TenLopHoc.HideSelection = false;
            this.textBox_TenLopHoc.Location = new System.Drawing.Point(275, 129);
            this.textBox_TenLopHoc.Name = "textBox_TenLopHoc";
            this.textBox_TenLopHoc.ReadOnly = true;
            this.textBox_TenLopHoc.Size = new System.Drawing.Size(332, 47);
            this.textBox_TenLopHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_TenLopHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_TenLopHoc.StateCommon.Border.ColorAngle = 0F;
            this.textBox_TenLopHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_TenLopHoc.StateCommon.Border.Rounding = 15;
            this.textBox_TenLopHoc.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_TenLopHoc.TabIndex = 68;
            // 
            // FormChinhSuaLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(776, 528);
            this.Controls.Add(this.textBox_TenLopHoc);
            this.Controls.Add(this.textBox_MaLopHoc);
            this.Controls.Add(this.iconButton_Cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPhong);
            this.Controls.Add(this.cbxGiangVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChinhSuaKhoaHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChinhSuaLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChinhSuaLopHoc";
            this.Load += new System.EventHandler(this.FormChinhSuaLopHoc_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconButton btnChinhSuaKhoaHoc;
        public System.Windows.Forms.ComboBox cbxGiangVien;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbxPhong;
        private System.Windows.Forms.Label label3;
        public FontAwesome.Sharp.IconButton iconButton_Cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_MaLopHoc;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_TenLopHoc;
    }
}