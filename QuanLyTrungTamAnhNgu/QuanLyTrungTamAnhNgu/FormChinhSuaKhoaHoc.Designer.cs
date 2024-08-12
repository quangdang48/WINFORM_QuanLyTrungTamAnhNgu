namespace QuanLyTrungTamAnhNgu
{
    partial class FormChinhSuaKhoaHoc
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
            this.btnChinhSuaKhoaHoc = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton_Cancel = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_MaKhoaHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_TenKhoaHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_GiaTien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_SoBuoiHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_TrangThai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.btnChinhSuaKhoaHoc.Location = new System.Drawing.Point(457, 460);
            this.btnChinhSuaKhoaHoc.Name = "btnChinhSuaKhoaHoc";
            this.btnChinhSuaKhoaHoc.Size = new System.Drawing.Size(76, 55);
            this.btnChinhSuaKhoaHoc.TabIndex = 32;
            this.btnChinhSuaKhoaHoc.UseVisualStyleBackColor = false;
            this.btnChinhSuaKhoaHoc.Click += new System.EventHandler(this.btnChinhSuaKhoaHoc_Click);
            // 
            // dateTimePicker_NgayBatDau
            // 
            this.dateTimePicker_NgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_NgayBatDau.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_NgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayBatDau.Location = new System.Drawing.Point(402, 291);
            this.dateTimePicker_NgayBatDau.Name = "dateTimePicker_NgayBatDau";
            this.dateTimePicker_NgayBatDau.Size = new System.Drawing.Size(174, 27);
            this.dateTimePicker_NgayBatDau.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 31);
            this.label6.TabIndex = 44;
            this.label6.Text = "Mã khóa học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tên khóa học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 31);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Giá Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Số buổi học:";
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
            this.iconButton_Cancel.Location = new System.Drawing.Point(300, 460);
            this.iconButton_Cancel.Name = "iconButton_Cancel";
            this.iconButton_Cancel.Size = new System.Drawing.Size(76, 55);
            this.iconButton_Cancel.TabIndex = 48;
            this.iconButton_Cancel.UseVisualStyleBackColor = false;
            this.iconButton_Cancel.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBox_MaKhoaHoc
            // 
            this.textBox_MaKhoaHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MaKhoaHoc.HideSelection = false;
            this.textBox_MaKhoaHoc.Location = new System.Drawing.Point(402, 22);
            this.textBox_MaKhoaHoc.Name = "textBox_MaKhoaHoc";
            this.textBox_MaKhoaHoc.ReadOnly = true;
            this.textBox_MaKhoaHoc.Size = new System.Drawing.Size(181, 47);
            this.textBox_MaKhoaHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_MaKhoaHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_MaKhoaHoc.StateCommon.Border.ColorAngle = 0F;
            this.textBox_MaKhoaHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_MaKhoaHoc.StateCommon.Border.Rounding = 15;
            this.textBox_MaKhoaHoc.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_MaKhoaHoc.TabIndex = 49;
            this.textBox_MaKhoaHoc.TextChanged += new System.EventHandler(this.textBoxSoCCCD_TextChanged);
            // 
            // textBox_TenKhoaHoc
            // 
            this.textBox_TenKhoaHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TenKhoaHoc.HideSelection = false;
            this.textBox_TenKhoaHoc.Location = new System.Drawing.Point(402, 87);
            this.textBox_TenKhoaHoc.Name = "textBox_TenKhoaHoc";
            this.textBox_TenKhoaHoc.ReadOnly = true;
            this.textBox_TenKhoaHoc.Size = new System.Drawing.Size(265, 47);
            this.textBox_TenKhoaHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_TenKhoaHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_TenKhoaHoc.StateCommon.Border.ColorAngle = 0F;
            this.textBox_TenKhoaHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_TenKhoaHoc.StateCommon.Border.Rounding = 15;
            this.textBox_TenKhoaHoc.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_TenKhoaHoc.TabIndex = 50;
            // 
            // textBox_GiaTien
            // 
            this.textBox_GiaTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_GiaTien.HideSelection = false;
            this.textBox_GiaTien.Location = new System.Drawing.Point(402, 149);
            this.textBox_GiaTien.Name = "textBox_GiaTien";
            this.textBox_GiaTien.ReadOnly = true;
            this.textBox_GiaTien.Size = new System.Drawing.Size(181, 47);
            this.textBox_GiaTien.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_GiaTien.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_GiaTien.StateCommon.Border.ColorAngle = 0F;
            this.textBox_GiaTien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_GiaTien.StateCommon.Border.Rounding = 15;
            this.textBox_GiaTien.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_GiaTien.TabIndex = 51;
            this.textBox_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGiaTien_KeyPress);
            // 
            // textBox_SoBuoiHoc
            // 
            this.textBox_SoBuoiHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SoBuoiHoc.HideSelection = false;
            this.textBox_SoBuoiHoc.Location = new System.Drawing.Point(402, 219);
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
            this.textBox_SoBuoiHoc.TabIndex = 52;
            this.textBox_SoBuoiHoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoBuoiHoc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 31);
            this.label5.TabIndex = 53;
            this.label5.Text = "Trạng thái:";
            // 
            // comboBox_TrangThai
            // 
            this.comboBox_TrangThai.FormattingEnabled = true;
            this.comboBox_TrangThai.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox_TrangThai.Location = new System.Drawing.Point(402, 356);
            this.comboBox_TrangThai.Name = "comboBox_TrangThai";
            this.comboBox_TrangThai.Size = new System.Drawing.Size(96, 24);
            this.comboBox_TrangThai.TabIndex = 54;
            // 
            // FormChinhSuaKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 576);
            this.Controls.Add(this.comboBox_TrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_SoBuoiHoc);
            this.Controls.Add(this.textBox_GiaTien);
            this.Controls.Add(this.textBox_TenKhoaHoc);
            this.Controls.Add(this.textBox_MaKhoaHoc);
            this.Controls.Add(this.iconButton_Cancel);
            this.Controls.Add(this.dateTimePicker_NgayBatDau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChinhSuaKhoaHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChinhSuaKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChinhSuaKhoaHoc";
            this.Load += new System.EventHandler(this.FormChinhSuaKhoaHoc_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnChinhSuaKhoaHoc;
        public System.Windows.Forms.DateTimePicker dateTimePicker_NgayBatDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton_Cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_MaKhoaHoc;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_TenKhoaHoc;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_GiaTien;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_SoBuoiHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_TrangThai;
    }
}