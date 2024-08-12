namespace QuanLyTrungTamAnhNgu
{
    partial class FormXemDiemThi
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
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.dgvDiemThi = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDotThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).BeginInit();
            this.SuspendLayout();
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
            this.btnThoat.Location = new System.Drawing.Point(922, 329);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(74, 59);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDiemThi
            // 
            this.dgvDiemThi.AllowUserToAddRows = false;
            this.dgvDiemThi.AllowUserToDeleteRows = false;
            this.dgvDiemThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiemThi,
            this.HocLuc,
            this.TenDotThi,
            this.ThoiDiemThi});
            this.dgvDiemThi.Location = new System.Drawing.Point(1, 1);
            this.dgvDiemThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDiemThi.Name = "dgvDiemThi";
            this.dgvDiemThi.ReadOnly = true;
            this.dgvDiemThi.RowHeadersWidth = 51;
            this.dgvDiemThi.RowTemplate.Height = 24;
            this.dgvDiemThi.Size = new System.Drawing.Size(1008, 321);
            this.dgvDiemThi.TabIndex = 18;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.FillWeight = 62.03209F;
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.MinimumWidth = 6;
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.ReadOnly = true;
            // 
            // HocLuc
            // 
            this.HocLuc.DataPropertyName = "HocLuc";
            this.HocLuc.FillWeight = 62.03209F;
            this.HocLuc.HeaderText = "Học lực";
            this.HocLuc.MinimumWidth = 6;
            this.HocLuc.Name = "HocLuc";
            this.HocLuc.ReadOnly = true;
            // 
            // TenDotThi
            // 
            this.TenDotThi.FillWeight = 213.9037F;
            this.TenDotThi.HeaderText = "Tên đợt thi";
            this.TenDotThi.MinimumWidth = 6;
            this.TenDotThi.Name = "TenDotThi";
            this.TenDotThi.ReadOnly = true;
            // 
            // ThoiDiemThi
            // 
            this.ThoiDiemThi.FillWeight = 62.03209F;
            this.ThoiDiemThi.HeaderText = "Thời điểm thi";
            this.ThoiDiemThi.MinimumWidth = 6;
            this.ThoiDiemThi.Name = "ThoiDiemThi";
            this.ThoiDiemThi.ReadOnly = true;
            // 
            // FormXemDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 408);
            this.Controls.Add(this.dgvDiemThi);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormXemDiemThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemDiemThi";
            this.Load += new System.EventHandler(this.FormXemDiemThi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public FontAwesome.Sharp.IconButton btnThoat;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDotThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiDiemThi;
    }
}