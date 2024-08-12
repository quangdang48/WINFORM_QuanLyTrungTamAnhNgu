namespace QuanLyTrungTamAnhNgu
{
    partial class FormChinhSuaHocVien
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iconButton_Cancel = new FontAwesome.Sharp.IconButton();
            this.btn_Update = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoCCCD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_TenDangNhap = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SDT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTenLot = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtHo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // iconButton_Cancel
            // 
            this.iconButton_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton_Cancel.ForeColor = System.Drawing.Color.Purple;
            this.iconButton_Cancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton_Cancel.IconColor = System.Drawing.Color.Black;
            this.iconButton_Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Cancel.Location = new System.Drawing.Point(237, 408);
            this.iconButton_Cancel.Name = "iconButton_Cancel";
            this.iconButton_Cancel.Size = new System.Drawing.Size(91, 55);
            this.iconButton_Cancel.TabIndex = 61;
            this.iconButton_Cancel.UseVisualStyleBackColor = false;
            this.iconButton_Cancel.Click += new System.EventHandler(this.iconButton_Cancel_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_Update.IconColor = System.Drawing.Color.Black;
            this.btn_Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Update.Location = new System.Drawing.Point(386, 408);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(91, 55);
            this.btn_Update.TabIndex = 60;
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("SVN-Helves", 10F);
            this.label5.Location = new System.Drawing.Point(382, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 28);
            this.label5.TabIndex = 59;
            this.label5.Text = "Căn cước công dân";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("SVN-Helves", 10F);
            this.label6.Location = new System.Drawing.Point(398, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 28);
            this.label6.TabIndex = 49;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(386, 312);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(271, 47);
            this.txt_Password.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txt_Password.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txt_Password.StateCommon.Border.ColorAngle = 0F;
            this.txt_Password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Password.StateCommon.Border.Rounding = 15;
            this.txt_Password.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txt_Password.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("SVN-Helves", 10F);
            this.label4.Location = new System.Drawing.Point(25, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 57;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSoCCCD
            // 
            this.textBoxSoCCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSoCCCD.HideSelection = false;
            this.textBoxSoCCCD.Location = new System.Drawing.Point(386, 204);
            this.textBoxSoCCCD.Name = "textBoxSoCCCD";
            this.textBoxSoCCCD.Size = new System.Drawing.Size(271, 47);
            this.textBoxSoCCCD.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBoxSoCCCD.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBoxSoCCCD.StateCommon.Border.ColorAngle = 0F;
            this.textBoxSoCCCD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSoCCCD.StateCommon.Border.Rounding = 15;
            this.textBoxSoCCCD.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBoxSoCCCD.TabIndex = 48;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(29, 312);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(271, 47);
            this.txt_TenDangNhap.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txt_TenDangNhap.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txt_TenDangNhap.StateCommon.Border.ColorAngle = 0F;
            this.txt_TenDangNhap.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_TenDangNhap.StateCommon.Border.Rounding = 15;
            this.txt_TenDangNhap.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txt_TenDangNhap.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("SVN-Helves", 10F);
            this.label7.Location = new System.Drawing.Point(41, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 28);
            this.label7.TabIndex = 47;
            this.label7.Text = "Tên đăng nhập";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("SVN-Helves", 10F);
            this.label3.Location = new System.Drawing.Point(509, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SDT.Location = new System.Drawing.Point(29, 204);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.Size = new System.Drawing.Size(271, 47);
            this.textBox_SDT.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.textBox_SDT.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.textBox_SDT.StateCommon.Border.ColorAngle = 0F;
            this.textBox_SDT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_SDT.StateCommon.Border.Rounding = 15;
            this.textBox_SDT.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.textBox_SDT.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("SVN-Helves", 10F);
            this.label2.Location = new System.Drawing.Point(276, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tên lót";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SVN-Helves", 10F);
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 53;
            this.label1.Text = "Họ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(497, 60);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(181, 48);
            this.txtTen.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtTen.StateCommon.Border.ColorAngle = 0F;
            this.txtTen.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTen.StateCommon.Border.Rounding = 15;
            this.txtTen.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txtTen.TabIndex = 52;
            this.txtTen.Text = "Tên";
            // 
            // txtTenLot
            // 
            this.txtTenLot.Location = new System.Drawing.Point(266, 60);
            this.txtTenLot.Name = "txtTenLot";
            this.txtTenLot.Size = new System.Drawing.Size(181, 48);
            this.txtTenLot.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtTenLot.StateCommon.Border.ColorAngle = 0F;
            this.txtTenLot.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenLot.StateCommon.Border.Rounding = 15;
            this.txtTenLot.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txtTenLot.TabIndex = 51;
            this.txtTenLot.Text = "Tên Lót";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(29, 60);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(181, 48);
            this.txtHo.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtHo.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtHo.StateCommon.Border.ColorAngle = 0F;
            this.txtHo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHo.StateCommon.Border.Rounding = 15;
            this.txtHo.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txtHo.TabIndex = 50;
            this.txtHo.Text = "Họ";
            // 
            // FormChinhSuaHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 484);
            this.Controls.Add(this.iconButton_Cancel);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoCCCD);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_SDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtTenLot);
            this.Controls.Add(this.txtHo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChinhSuaHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChinhSuaHocVien";
            this.Load += new System.EventHandler(this.FormChinhSuaHocVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton iconButton_Cancel;
        private FontAwesome.Sharp.IconButton btn_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Password;
        private System.Windows.Forms.Label label4;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxSoCCCD;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTen;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenLot;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtHo;
    }
}