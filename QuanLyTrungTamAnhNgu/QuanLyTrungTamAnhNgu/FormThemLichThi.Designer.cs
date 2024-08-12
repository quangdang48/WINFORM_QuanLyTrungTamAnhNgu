namespace QuanLyTrungTamAnhNgu
{
    partial class FormThemLichThi
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
            this.textBox_MaLichThi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_MaKhoaHoc = new System.Windows.Forms.ComboBox();
            this.checkedListBox_LopHoc = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_ThoiDiem = new System.Windows.Forms.DateTimePicker();
            this.txt_DotThi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.iconButton_Save = new FontAwesome.Sharp.IconButton();
            this.iconButton_Cancel = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // textBox_MaLichThi
            // 
            this.textBox_MaLichThi.HideSelection = false;
            this.textBox_MaLichThi.Location = new System.Drawing.Point(291, 33);
            this.textBox_MaLichThi.Name = "textBox_MaLichThi";
            this.textBox_MaLichThi.ReadOnly = true;
            this.textBox_MaLichThi.Size = new System.Drawing.Size(191, 47);
            this.textBox_MaLichThi.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_MaLichThi.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_MaLichThi.StateCommon.Border.ColorAngle = 0F;
            this.textBox_MaLichThi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_MaLichThi.StateCommon.Border.Rounding = 15;
            this.textBox_MaLichThi.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_MaLichThi.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 71;
            this.label1.Text = "Mã lịch thi";
            // 
            // comboBox_MaKhoaHoc
            // 
            this.comboBox_MaKhoaHoc.Font = new System.Drawing.Font("UTM Avo", 10.2F);
            this.comboBox_MaKhoaHoc.FormattingEnabled = true;
            this.comboBox_MaKhoaHoc.Location = new System.Drawing.Point(291, 108);
            this.comboBox_MaKhoaHoc.Name = "comboBox_MaKhoaHoc";
            this.comboBox_MaKhoaHoc.Size = new System.Drawing.Size(437, 31);
            this.comboBox_MaKhoaHoc.TabIndex = 72;
            this.comboBox_MaKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaKhoaHoc_SelectedIndexChanged);
            // 
            // checkedListBox_LopHoc
            // 
            this.checkedListBox_LopHoc.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_LopHoc.FormattingEnabled = true;
            this.checkedListBox_LopHoc.Location = new System.Drawing.Point(291, 170);
            this.checkedListBox_LopHoc.Name = "checkedListBox_LopHoc";
            this.checkedListBox_LopHoc.Size = new System.Drawing.Size(437, 160);
            this.checkedListBox_LopHoc.TabIndex = 73;
            this.checkedListBox_LopHoc.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_LopHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 74;
            this.label2.Text = "Khóa học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 75;
            this.label3.Text = "Lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.label4.Location = new System.Drawing.Point(39, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 31);
            this.label4.TabIndex = 76;
            this.label4.Text = "Đợt thi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.label5.Location = new System.Drawing.Point(39, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 31);
            this.label5.TabIndex = 77;
            this.label5.Text = "Thời điểm thi";
            // 
            // dateTimePicker_ThoiDiem
            // 
            this.dateTimePicker_ThoiDiem.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_ThoiDiem.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ThoiDiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ThoiDiem.Location = new System.Drawing.Point(291, 427);
            this.dateTimePicker_ThoiDiem.Name = "dateTimePicker_ThoiDiem";
            this.dateTimePicker_ThoiDiem.Size = new System.Drawing.Size(170, 31);
            this.dateTimePicker_ThoiDiem.TabIndex = 78;
            // 
            // txt_DotThi
            // 
            this.txt_DotThi.HideSelection = false;
            this.txt_DotThi.Location = new System.Drawing.Point(291, 366);
            this.txt_DotThi.Name = "txt_DotThi";
            this.txt_DotThi.Size = new System.Drawing.Size(437, 47);
            this.txt_DotThi.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txt_DotThi.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txt_DotThi.StateCommon.Border.ColorAngle = 0F;
            this.txt_DotThi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_DotThi.StateCommon.Border.Rounding = 15;
            this.txt_DotThi.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txt_DotThi.TabIndex = 79;
            // 
            // iconButton_Save
            // 
            this.iconButton_Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_Save.FlatAppearance.BorderSize = 0;
            this.iconButton_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Save.ForeColor = System.Drawing.Color.White;
            this.iconButton_Save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton_Save.IconColor = System.Drawing.Color.White;
            this.iconButton_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Save.Location = new System.Drawing.Point(453, 559);
            this.iconButton_Save.Name = "iconButton_Save";
            this.iconButton_Save.Size = new System.Drawing.Size(129, 62);
            this.iconButton_Save.TabIndex = 82;
            this.iconButton_Save.Text = "Lưu";
            this.iconButton_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Save.UseVisualStyleBackColor = false;
            this.iconButton_Save.Click += new System.EventHandler(this.iconButton_Save_Click);
            // 
            // iconButton_Cancel
            // 
            this.iconButton_Cancel.BackColor = System.Drawing.Color.Crimson;
            this.iconButton_Cancel.FlatAppearance.BorderSize = 0;
            this.iconButton_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Cancel.ForeColor = System.Drawing.Color.White;
            this.iconButton_Cancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton_Cancel.IconColor = System.Drawing.Color.White;
            this.iconButton_Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Cancel.Location = new System.Drawing.Point(161, 559);
            this.iconButton_Cancel.Name = "iconButton_Cancel";
            this.iconButton_Cancel.Size = new System.Drawing.Size(129, 62);
            this.iconButton_Cancel.TabIndex = 83;
            this.iconButton_Cancel.Text = "Hủy";
            this.iconButton_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Cancel.UseVisualStyleBackColor = false;
            this.iconButton_Cancel.Click += new System.EventHandler(this.iconButton_Cancel_Click);
            // 
            // FormThemLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 664);
            this.Controls.Add(this.iconButton_Save);
            this.Controls.Add(this.iconButton_Cancel);
            this.Controls.Add(this.txt_DotThi);
            this.Controls.Add(this.dateTimePicker_ThoiDiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox_LopHoc);
            this.Controls.Add(this.comboBox_MaKhoaHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MaLichThi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemLichThi";
            this.Load += new System.EventHandler(this.FormThemLichThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_MaLichThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_MaKhoaHoc;
        private System.Windows.Forms.CheckedListBox checkedListBox_LopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ThoiDiem;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_DotThi;
        private FontAwesome.Sharp.IconButton iconButton_Save;
        private FontAwesome.Sharp.IconButton iconButton_Cancel;
    }
}