namespace QuanLyTrungTamAnhNgu
{
    partial class UC_LoaiKhoaHoc
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
            this.label_TenKhoaHoc = new System.Windows.Forms.Label();
            this.btnXoaHV = new FontAwesome.Sharp.IconButton();
            this.iconButton_KhoaHoc = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label_TenKhoaHoc
            // 
            this.label_TenKhoaHoc.AutoSize = true;
            this.label_TenKhoaHoc.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenKhoaHoc.Location = new System.Drawing.Point(80, 207);
            this.label_TenKhoaHoc.Name = "label_TenKhoaHoc";
            this.label_TenKhoaHoc.Size = new System.Drawing.Size(0, 27);
            this.label_TenKhoaHoc.TabIndex = 19;
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoaHV.BackColor = System.Drawing.Color.White;
            this.btnXoaHV.FlatAppearance.BorderSize = 0;
            this.btnXoaHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHV.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnXoaHV.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaHV.IconColor = System.Drawing.Color.OrangeRed;
            this.btnXoaHV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaHV.Location = new System.Drawing.Point(303, 297);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(42, 44);
            this.btnXoaHV.TabIndex = 23;
            this.btnXoaHV.UseVisualStyleBackColor = false;
            this.btnXoaHV.Click += new System.EventHandler(this.btnXoaHV_Click);
            // 
            // iconButton_KhoaHoc
            // 
            this.iconButton_KhoaHoc.BackColor = System.Drawing.Color.Cyan;
            this.iconButton_KhoaHoc.BackgroundImage = global::QuanLyTrungTamAnhNgu.Properties.Resources.online_course;
            this.iconButton_KhoaHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconButton_KhoaHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_KhoaHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_KhoaHoc.Font = new System.Drawing.Font("SVN-Helves", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_KhoaHoc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_KhoaHoc.IconColor = System.Drawing.Color.Black;
            this.iconButton_KhoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_KhoaHoc.Location = new System.Drawing.Point(0, 0);
            this.iconButton_KhoaHoc.Name = "iconButton_KhoaHoc";
            this.iconButton_KhoaHoc.Size = new System.Drawing.Size(348, 195);
            this.iconButton_KhoaHoc.TabIndex = 18;
            this.iconButton_KhoaHoc.Text = "      iconButton1";
            this.iconButton_KhoaHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton_KhoaHoc.UseVisualStyleBackColor = false;
            this.iconButton_KhoaHoc.Click += new System.EventHandler(this.iconButton_KhoaHoc_Click);
            // 
            // UC_LoaiKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXoaHV);
            this.Controls.Add(this.label_TenKhoaHoc);
            this.Controls.Add(this.iconButton_KhoaHoc);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UC_LoaiKhoaHoc";
            this.Size = new System.Drawing.Size(348, 341);
            this.Load += new System.EventHandler(this.UC_LoaiKhoaHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnXoaHV;
        public System.Windows.Forms.Label label_TenKhoaHoc;
        public FontAwesome.Sharp.IconButton iconButton_KhoaHoc;
    }
}
