namespace QuanLyTrungTamAnhNgu
{
    partial class FormThemKhoaHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton_KhoaHoc = new FontAwesome.Sharp.IconButton();
            this.btnThemKhoaHoc = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.comboBox_MaLoaiKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_MaKhoaHoc = new System.Windows.Forms.Label();
            this.iconButton_Cancel = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_TenKhoaHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_GiaTien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_SoBuoiHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên khóa học:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Giá Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số buổi học:";
            // 
            // iconButton_KhoaHoc
            // 
            this.iconButton_KhoaHoc.BackColor = System.Drawing.Color.Cyan;
            this.iconButton_KhoaHoc.BackgroundImage = global::QuanLyTrungTamAnhNgu.Properties.Resources.online_course;
            this.iconButton_KhoaHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconButton_KhoaHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_KhoaHoc.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_KhoaHoc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_KhoaHoc.IconColor = System.Drawing.Color.Black;
            this.iconButton_KhoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_KhoaHoc.Location = new System.Drawing.Point(0, 0);
            this.iconButton_KhoaHoc.Name = "iconButton_KhoaHoc";
            this.iconButton_KhoaHoc.Size = new System.Drawing.Size(628, 163);
            this.iconButton_KhoaHoc.TabIndex = 19;
            this.iconButton_KhoaHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton_KhoaHoc.UseVisualStyleBackColor = false;
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThemKhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnThemKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoaHoc.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnThemKhoaHoc.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemKhoaHoc.IconColor = System.Drawing.Color.SpringGreen;
            this.btnThemKhoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(343, 589);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(97, 70);
            this.btnThemKhoaHoc.TabIndex = 31;
            this.btnThemKhoaHoc.UseVisualStyleBackColor = false;
            this.btnThemKhoaHoc.Click += new System.EventHandler(this.btnXoaHV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mã loại khóa học:";
            // 
            // dateTimePicker_NgayBatDau
            // 
            this.dateTimePicker_NgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_NgayBatDau.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayBatDau.Location = new System.Drawing.Point(239, 493);
            this.dateTimePicker_NgayBatDau.Name = "dateTimePicker_NgayBatDau";
            this.dateTimePicker_NgayBatDau.Size = new System.Drawing.Size(127, 22);
            this.dateTimePicker_NgayBatDau.TabIndex = 34;
            this.dateTimePicker_NgayBatDau.ValueChanged += new System.EventHandler(this.dateTimePicker_NgayBatDau_ValueChanged);
            // 
            // comboBox_MaLoaiKhoaHoc
            // 
            this.comboBox_MaLoaiKhoaHoc.FormattingEnabled = true;
            this.comboBox_MaLoaiKhoaHoc.Location = new System.Drawing.Point(239, 184);
            this.comboBox_MaLoaiKhoaHoc.Name = "comboBox_MaLoaiKhoaHoc";
            this.comboBox_MaLoaiKhoaHoc.Size = new System.Drawing.Size(191, 24);
            this.comboBox_MaLoaiKhoaHoc.TabIndex = 36;
            this.comboBox_MaLoaiKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaLoaiKhoaHoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mã khóa học:";
            // 
            // label_MaKhoaHoc
            // 
            this.label_MaKhoaHoc.AutoSize = true;
            this.label_MaKhoaHoc.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaKhoaHoc.Location = new System.Drawing.Point(235, 233);
            this.label_MaKhoaHoc.Name = "label_MaKhoaHoc";
            this.label_MaKhoaHoc.Size = new System.Drawing.Size(121, 24);
            this.label_MaKhoaHoc.TabIndex = 38;
            this.label_MaKhoaHoc.Text = "Mã khóa học:";
            // 
            // iconButton_Cancel
            // 
            this.iconButton_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButton_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton_Cancel.FlatAppearance.BorderSize = 0;
            this.iconButton_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Cancel.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconButton_Cancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton_Cancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton_Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Cancel.Location = new System.Drawing.Point(159, 589);
            this.iconButton_Cancel.Name = "iconButton_Cancel";
            this.iconButton_Cancel.Size = new System.Drawing.Size(97, 70);
            this.iconButton_Cancel.TabIndex = 39;
            this.iconButton_Cancel.UseVisualStyleBackColor = false;
            this.iconButton_Cancel.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBox_TenKhoaHoc
            // 
            this.textBox_TenKhoaHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TenKhoaHoc.HideSelection = false;
            this.textBox_TenKhoaHoc.Location = new System.Drawing.Point(239, 280);
            this.textBox_TenKhoaHoc.Name = "textBox_TenKhoaHoc";
            this.textBox_TenKhoaHoc.Size = new System.Drawing.Size(353, 47);
            this.textBox_TenKhoaHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_TenKhoaHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_TenKhoaHoc.StateCommon.Border.ColorAngle = 0F;
            this.textBox_TenKhoaHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_TenKhoaHoc.StateCommon.Border.Rounding = 15;
            this.textBox_TenKhoaHoc.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_TenKhoaHoc.TabIndex = 69;
            this.textBox_TenKhoaHoc.TextChanged += new System.EventHandler(this.textBox_TenKhoaHoc_TextChanged);
            // 
            // textBox_GiaTien
            // 
            this.textBox_GiaTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_GiaTien.HideSelection = false;
            this.textBox_GiaTien.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBox_GiaTien.Location = new System.Drawing.Point(239, 342);
            this.textBox_GiaTien.Name = "textBox_GiaTien";
            this.textBox_GiaTien.Size = new System.Drawing.Size(181, 47);
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
            this.textBox_SoBuoiHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SoBuoiHoc.HideSelection = false;
            this.textBox_SoBuoiHoc.Location = new System.Drawing.Point(239, 409);
            this.textBox_SoBuoiHoc.Name = "textBox_SoBuoiHoc";
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
            // FormThemKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 785);
            this.Controls.Add(this.textBox_SoBuoiHoc);
            this.Controls.Add(this.textBox_GiaTien);
            this.Controls.Add(this.textBox_TenKhoaHoc);
            this.Controls.Add(this.iconButton_Cancel);
            this.Controls.Add(this.label_MaKhoaHoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_MaLoaiKhoaHoc);
            this.Controls.Add(this.dateTimePicker_NgayBatDau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThemKhoaHoc);
            this.Controls.Add(this.iconButton_KhoaHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemKhoaHoc";
            this.Load += new System.EventHandler(this.FormThemKhoaHoc_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public FontAwesome.Sharp.IconButton iconButton_KhoaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
/*        private QuanLyPhongTro.ModifyUI.DateTimePickerYearMonth dateTimePickerYearMonth_NgayBatDau;
        private QuanLyPhongTro.ModifyUI.DateTimePickerYearMonth dateTimePickerYearMonth_NgayKetThuc;*/
        private FontAwesome.Sharp.IconButton btnThemKhoaHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBatDau;
        private System.Windows.Forms.ComboBox comboBox_MaLoaiKhoaHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_MaKhoaHoc;
        private FontAwesome.Sharp.IconButton iconButton_Cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_TenKhoaHoc;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_GiaTien;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_SoBuoiHoc;
    }
}