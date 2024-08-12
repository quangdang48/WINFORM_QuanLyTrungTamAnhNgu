using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnThiThu = new FontAwesome.Sharp.IconButton();
            this.btnLichHoc = new FontAwesome.Sharp.IconButton();
            this.btn_HocVien = new FontAwesome.Sharp.IconButton();
            this.btn_DiemDanh = new FontAwesome.Sharp.IconButton();
            this.btn_LopHoc = new FontAwesome.Sharp.IconButton();
            this.btnKhoaHoc = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblDuongDan = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel_Button = new System.Windows.Forms.Panel();
            this.btnThemKhoaHoc = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.btnThiThu);
            this.panelMenu.Controls.Add(this.btnLichHoc);
            this.panelMenu.Controls.Add(this.btn_HocVien);
            this.panelMenu.Controls.Add(this.btn_DiemDanh);
            this.panelMenu.Controls.Add(this.btn_LopHoc);
            this.panelMenu.Controls.Add(this.btnKhoaHoc);
            this.panelMenu.Controls.Add(this.btn_Home);
            this.panelMenu.Controls.Add(this.panel_Logo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Cornsilk;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 773);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.LeftRight;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 706);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(245, 67);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnThiThu
            // 
            this.btnThiThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThiThu.FlatAppearance.BorderSize = 0;
            this.btnThiThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnThiThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnThiThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThiThu.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.btnThiThu.ForeColor = System.Drawing.Color.Black;
            this.btnThiThu.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnThiThu.IconColor = System.Drawing.Color.Black;
            this.btnThiThu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThiThu.IconSize = 40;
            this.btnThiThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThiThu.Location = new System.Drawing.Point(0, 524);
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThiThu.Size = new System.Drawing.Size(245, 70);
            this.btnThiThu.TabIndex = 8;
            this.btnThiThu.Text = "Thi thử";
            this.btnThiThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThiThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThiThu.UseVisualStyleBackColor = true;
            this.btnThiThu.Click += new System.EventHandler(this.btnThiThu_Click);
            // 
            // btnLichHoc
            // 
            this.btnLichHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichHoc.FlatAppearance.BorderSize = 0;
            this.btnLichHoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnLichHoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnLichHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichHoc.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.btnLichHoc.ForeColor = System.Drawing.Color.Black;
            this.btnLichHoc.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnLichHoc.IconColor = System.Drawing.Color.Black;
            this.btnLichHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLichHoc.IconSize = 40;
            this.btnLichHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichHoc.Location = new System.Drawing.Point(0, 454);
            this.btnLichHoc.Name = "btnLichHoc";
            this.btnLichHoc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLichHoc.Size = new System.Drawing.Size(245, 70);
            this.btnLichHoc.TabIndex = 7;
            this.btnLichHoc.Text = "Lịch Học";
            this.btnLichHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichHoc.UseVisualStyleBackColor = true;
            this.btnLichHoc.Click += new System.EventHandler(this.btnLichHoc_Click);
            // 
            // btn_HocVien
            // 
            this.btn_HocVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HocVien.FlatAppearance.BorderSize = 0;
            this.btn_HocVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_HocVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_HocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HocVien.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.btn_HocVien.ForeColor = System.Drawing.Color.Black;
            this.btn_HocVien.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_HocVien.IconColor = System.Drawing.Color.Black;
            this.btn_HocVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_HocVien.IconSize = 40;
            this.btn_HocVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HocVien.Location = new System.Drawing.Point(0, 384);
            this.btn_HocVien.Name = "btn_HocVien";
            this.btn_HocVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_HocVien.Size = new System.Drawing.Size(245, 70);
            this.btn_HocVien.TabIndex = 3;
            this.btn_HocVien.Text = "Học viên";
            this.btn_HocVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HocVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HocVien.UseVisualStyleBackColor = true;
            this.btn_HocVien.Click += new System.EventHandler(this.btn_HocVien_Click);
            // 
            // btn_DiemDanh
            // 
            this.btn_DiemDanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DiemDanh.FlatAppearance.BorderSize = 0;
            this.btn_DiemDanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_DiemDanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_DiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DiemDanh.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.btn_DiemDanh.ForeColor = System.Drawing.Color.Black;
            this.btn_DiemDanh.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btn_DiemDanh.IconColor = System.Drawing.Color.Black;
            this.btn_DiemDanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DiemDanh.IconSize = 40;
            this.btn_DiemDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DiemDanh.Location = new System.Drawing.Point(0, 314);
            this.btn_DiemDanh.Name = "btn_DiemDanh";
            this.btn_DiemDanh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_DiemDanh.Size = new System.Drawing.Size(245, 70);
            this.btn_DiemDanh.TabIndex = 2;
            this.btn_DiemDanh.Text = "Điểm danh";
            this.btn_DiemDanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DiemDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DiemDanh.UseVisualStyleBackColor = true;
            this.btn_DiemDanh.Click += new System.EventHandler(this.btn_DiemDanh_Click);
            // 
            // btn_LopHoc
            // 
            this.btn_LopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LopHoc.FlatAppearance.BorderSize = 0;
            this.btn_LopHoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_LopHoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_LopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LopHoc.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.btn_LopHoc.ForeColor = System.Drawing.Color.Black;
            this.btn_LopHoc.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.btn_LopHoc.IconColor = System.Drawing.Color.Black;
            this.btn_LopHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_LopHoc.IconSize = 40;
            this.btn_LopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LopHoc.Location = new System.Drawing.Point(0, 244);
            this.btn_LopHoc.Name = "btn_LopHoc";
            this.btn_LopHoc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_LopHoc.Size = new System.Drawing.Size(245, 70);
            this.btn_LopHoc.TabIndex = 5;
            this.btn_LopHoc.Text = "Lớp học";
            this.btn_LopHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LopHoc.UseVisualStyleBackColor = true;
            this.btn_LopHoc.Click += new System.EventHandler(this.btn_LopHoc_Click);
            // 
            // btnKhoaHoc
            // 
            this.btnKhoaHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnKhoaHoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnKhoaHoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoaHoc.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.btnKhoaHoc.ForeColor = System.Drawing.Color.Black;
            this.btnKhoaHoc.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnKhoaHoc.IconColor = System.Drawing.Color.Black;
            this.btnKhoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoaHoc.IconSize = 40;
            this.btnKhoaHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoaHoc.Location = new System.Drawing.Point(0, 174);
            this.btnKhoaHoc.Name = "btnKhoaHoc";
            this.btnKhoaHoc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhoaHoc.Size = new System.Drawing.Size(245, 70);
            this.btnKhoaHoc.TabIndex = 6;
            this.btnKhoaHoc.Text = "Khóa học";
            this.btnKhoaHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoaHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoaHoc.UseVisualStyleBackColor = true;
            this.btnKhoaHoc.Click += new System.EventHandler(this.btnKhoaHoc_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.White;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btn_Home.IconColor = System.Drawing.Color.Black;
            this.btn_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Home.IconSize = 40;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 104);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Home.Size = new System.Drawing.Size(245, 70);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Trang chủ";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(245, 104);
            this.panel_Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::QuanLyTrungTamAnhNgu.Properties.Resources.LogoEnglish;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.White;
            this.panel_Header.Controls.Add(this.panel1);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(245, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1104, 82);
            this.panel_Header.TabIndex = 1;
            this.panel_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Header_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(796, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 82);
            this.panel1.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("UTM BryantLG", 15F);
            this.lblUser.Location = new System.Drawing.Point(54, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(254, 82);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "-";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 60;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(54, 82);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblDuongDan
            // 
            this.lblDuongDan.AutoSize = true;
            this.lblDuongDan.Location = new System.Drawing.Point(270, 94);
            this.lblDuongDan.Name = "lblDuongDan";
            this.lblDuongDan.Size = new System.Drawing.Size(86, 23);
            this.lblDuongDan.TabIndex = 3;
            this.lblDuongDan.Text = "Trang chủ";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::QuanLyTrungTamAnhNgu.Properties.Resources.close_form;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::QuanLyTrungTamAnhNgu.Properties.Resources.close_form_press;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::QuanLyTrungTamAnhNgu.Properties.Resources.close_form_press;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageNormal = global::QuanLyTrungTamAnhNgu.Properties.Resources.zoomform;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::QuanLyTrungTamAnhNgu.Properties.Resources.zoomformpress;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::QuanLyTrungTamAnhNgu.Properties.Resources.hideform;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::QuanLyTrungTamAnhNgu.Properties.Resources.hideformpress1;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::QuanLyTrungTamAnhNgu.Properties.Resources.hideformpress;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageNormal = global::QuanLyTrungTamAnhNgu.Properties.Resources.zoomform;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::QuanLyTrungTamAnhNgu.Properties.Resources.zoomform;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::QuanLyTrungTamAnhNgu.Properties.Resources.zoomform;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(-1, 5, 10, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Content.LongText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 5, 10, -1);
            this.kryptonPalette1.PalettePaint += new System.EventHandler<ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette1_PalettePaint);
            // 
            // panel_Button
            // 
            this.panel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Button.AutoScroll = true;
            this.panel_Button.Location = new System.Drawing.Point(274, 131);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(1075, 642);
            this.panel_Button.TabIndex = 4;
            this.panel_Button.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Button_Paint);
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnThemKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoaHoc.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnThemKhoaHoc.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemKhoaHoc.IconColor = System.Drawing.Color.SpringGreen;
            this.btnThemKhoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(1278, 84);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(71, 43);
            this.btnThemKhoaHoc.TabIndex = 5;
            this.btnThemKhoaHoc.UseVisualStyleBackColor = true;
            this.btnThemKhoaHoc.Visible = false;
            this.btnThemKhoaHoc.Click += new System.EventHandler(this.btnThemKhoaHoc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1349, 773);
            this.Controls.Add(this.btnThemKhoaHoc);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.lblDuongDan);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.StateCommon.Border.Rounding = 12;
            this.Text = "Quản lý trung tâm anh ngữ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.panelMenu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_Home;
        private FontAwesome.Sharp.IconButton btn_HocVien;
        private FontAwesome.Sharp.IconButton btn_DiemDanh;
        private FontAwesome.Sharp.IconButton btn_LopHoc;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnLichHoc;
        private FontAwesome.Sharp.IconButton btnKhoaHoc;
        private System.Windows.Forms.Label lblDuongDan;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private FontAwesome.Sharp.IconButton btnThiThu;
        private Panel panel_Button;
        private Panel panel1;
        private Label lblUser;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnThemKhoaHoc;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

