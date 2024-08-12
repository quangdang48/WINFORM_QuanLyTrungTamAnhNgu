namespace QuanLyTrungTamAnhNgu
{
    partial class FormThemLopHocChoHocVien
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
            this.textBox_TenLopHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.iconButton_Cancel = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_MaLopHoc = new System.Windows.Forms.ComboBox();
            this.txt_GiangVien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemLopHocVien = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker_NgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.label_NgayKetThuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_TenLopHoc
            // 
            this.textBox_TenLopHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TenLopHoc.HideSelection = false;
            this.textBox_TenLopHoc.Location = new System.Drawing.Point(412, 118);
            this.textBox_TenLopHoc.Name = "textBox_TenLopHoc";
            this.textBox_TenLopHoc.ReadOnly = true;
            this.textBox_TenLopHoc.Size = new System.Drawing.Size(294, 47);
            this.textBox_TenLopHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_TenLopHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_TenLopHoc.StateCommon.Border.ColorAngle = 0F;
            this.textBox_TenLopHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_TenLopHoc.StateCommon.Border.Rounding = 15;
            this.textBox_TenLopHoc.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_TenLopHoc.TabIndex = 64;
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
            this.iconButton_Cancel.Location = new System.Drawing.Point(284, 375);
            this.iconButton_Cancel.Name = "iconButton_Cancel";
            this.iconButton_Cancel.Size = new System.Drawing.Size(76, 55);
            this.iconButton_Cancel.TabIndex = 62;
            this.iconButton_Cancel.UseVisualStyleBackColor = false;
            this.iconButton_Cancel.Click += new System.EventHandler(this.iconButton_Cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "Mã lớp học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tên lớp học:";
            // 
            // comboBox_MaLopHoc
            // 
            this.comboBox_MaLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaLopHoc.FormattingEnabled = true;
            this.comboBox_MaLopHoc.Location = new System.Drawing.Point(412, 57);
            this.comboBox_MaLopHoc.Name = "comboBox_MaLopHoc";
            this.comboBox_MaLopHoc.Size = new System.Drawing.Size(204, 28);
            this.comboBox_MaLopHoc.TabIndex = 67;
            this.comboBox_MaLopHoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaLopHoc_SelectedIndexChanged);
            // 
            // txt_GiangVien
            // 
            this.txt_GiangVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_GiangVien.HideSelection = false;
            this.txt_GiangVien.Location = new System.Drawing.Point(412, 196);
            this.txt_GiangVien.Name = "txt_GiangVien";
            this.txt_GiangVien.ReadOnly = true;
            this.txt_GiangVien.Size = new System.Drawing.Size(294, 47);
            this.txt_GiangVien.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txt_GiangVien.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txt_GiangVien.StateCommon.Border.ColorAngle = 0F;
            this.txt_GiangVien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_GiangVien.StateCommon.Border.Rounding = 15;
            this.txt_GiangVien.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txt_GiangVien.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 69;
            this.label2.Text = "Tên giảng viên";
            // 
            // btnThemLopHocVien
            // 
            this.btnThemLopHocVien.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThemLopHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemLopHocVien.FlatAppearance.BorderSize = 0;
            this.btnThemLopHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLopHocVien.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnThemLopHocVien.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemLopHocVien.IconColor = System.Drawing.Color.SpringGreen;
            this.btnThemLopHocVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemLopHocVien.Location = new System.Drawing.Point(412, 375);
            this.btnThemLopHocVien.Name = "btnThemLopHocVien";
            this.btnThemLopHocVien.Size = new System.Drawing.Size(78, 55);
            this.btnThemLopHocVien.TabIndex = 70;
            this.btnThemLopHocVien.UseVisualStyleBackColor = false;
            this.btnThemLopHocVien.Click += new System.EventHandler(this.btnThemLopHocVien_Click);
            // 
            // dateTimePicker_NgayDangKy
            // 
            this.dateTimePicker_NgayDangKy.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_NgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayDangKy.Location = new System.Drawing.Point(412, 278);
            this.dateTimePicker_NgayDangKy.Name = "dateTimePicker_NgayDangKy";
            this.dateTimePicker_NgayDangKy.Size = new System.Drawing.Size(174, 27);
            this.dateTimePicker_NgayDangKy.TabIndex = 72;
            // 
            // label_NgayKetThuc
            // 
            this.label_NgayKetThuc.AutoSize = true;
            this.label_NgayKetThuc.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayKetThuc.Location = new System.Drawing.Point(148, 273);
            this.label_NgayKetThuc.Name = "label_NgayKetThuc";
            this.label_NgayKetThuc.Size = new System.Drawing.Size(177, 31);
            this.label_NgayKetThuc.TabIndex = 71;
            this.label_NgayKetThuc.Text = "Ngày đăng ký:";
            // 
            // FormThemLopHocChoHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.dateTimePicker_NgayDangKy);
            this.Controls.Add(this.label_NgayKetThuc);
            this.Controls.Add(this.btnThemLopHocVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_GiangVien);
            this.Controls.Add(this.comboBox_MaLopHoc);
            this.Controls.Add(this.textBox_TenLopHoc);
            this.Controls.Add(this.iconButton_Cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FormThemLopHocChoHocVien";
            this.Text = "FormThemLopHocChoHocVien";
            this.Load += new System.EventHandler(this.FormThemLopHocChoHocVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_TenLopHoc;
        private FontAwesome.Sharp.IconButton iconButton_Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_MaLopHoc;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_GiangVien;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnThemLopHocVien;
        public System.Windows.Forms.DateTimePicker dateTimePicker_NgayDangKy;
        public System.Windows.Forms.Label label_NgayKetThuc;
    }
}