using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory;
using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;
using MetroFramework.Forms;
namespace QuanLyTrungTamAnhNgu
{
    public partial class FormMain : KryptonForm
    {
        // private IconButton previousBtn;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        // list item search doi mau
        public List<UC_HocVien> listItemSearch = new List<UC_HocVien>();
        private UC_Filter ucFilter = null;
        public FormMain()
        {
            InitializeComponent();

            // leftBorder button menu       
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panelMenu.Controls.Add(leftBorderBtn);
            RegisterMouseClickEvent(this);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnThemKhoaHoc, "Thêm");
            // Hien trang chu
            currentBtn = btn_Home;
            btn_Home_Click(btn_Home, e);
            // gan duong dan
            lblDuongDan.Text = btn_Home.Text;
            // gan thong tin user
            lblUser.Text = Global.TenNguoiDung + "\n" + Global.Type;
            ucFilter = new UC_Filter(this);
            ucFilter.LoadData(currentBtn.Text);
            ucFilter.Visible = false;
            ucFilter.Location = new Point(1400, 0);
            panel_Button.Controls.Add(ucFilter);
            // an nut them va loc cho hoc vien
            if(Global.Type == "Student")
            {
                btnThemKhoaHoc.Visible = false;
                btnFilter.Visible = false;
                iconButton_LoaiKhoaHoc.Visible = false;
                btn_DiemDanh.Visible = false;
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnThemKhoaHoc.Visible = false;
            btnFilter.Visible = false;
            panel_Button.Controls.Clear();

            if (Global.Type == "Staff")
            {
              
                FormThongKe frm = new FormThongKe();
                frm.TopLevel = false; // cho phep form duoc nhung
                                      //frm.Dock = DockStyle.Fill;
                                      // frm.FormBorderStyle = FormBorderStyle.None; // bo vien tieu de
                panel_Button.Controls.Add(frm);
                frm.Show();
                /*Vidu*/
                /*test uc control*/
                /*            panel_Button.Controls.Clear();
                            List<String> tinhNangTrangChu = new List<String>() { "Thêm","Sửa","Xóas"};
                            int x = 1;

                            foreach(string s  in tinhNangTrangChu)
                            {
                                UC_Homecs uc = new UC_Homecs(s);
                                uc.Location = new Point(x, 1);
                                panel_Button.Controls.Add(uc);
                                x = x + uc.Width + 30;
                            }*/
            }
            else if(Global.Type == "Student")
            {

                FormThongKeHocVien frm = new FormThongKeHocVien();
                frm.TopLevel = false; // cho phep form duoc nhung
                                      //frm.Dock = DockStyle.Fill;
                                      // frm.FormBorderStyle = FormBorderStyle.None; // bo vien tieu de
                panel_Button.Controls.Add(frm);
                frm.Show();
            }
         
        }
        // xu ly su kien nhat button
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (((IconButton)senderBtn).Text.ToString() != "Trang chủ")
                    lblDuongDan.Text = lblDuongDan.Text.Replace((@" \ " + currentBtn.Text.ToString()), "");
                else
                {
                    if (currentBtn.Text.ToString() != "Trang chủ")
                        lblDuongDan.Text = lblDuongDan.Text.Replace((@" \ " + currentBtn.Text.ToString()), "");
                }

                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(225, 245, 250);
                currentBtn.ForeColor = Color.FromArgb(24, 161, 251); ;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(24, 161, 251);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.FromArgb(24, 161, 251);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                if (((IconButton)senderBtn).Text.ToString() != "Trang chủ")
                    lblDuongDan.Text += (@" \ " + currentBtn.Text.ToString().Trim());
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnThemKhoaHoc.Visible = false;
            btnFilter.Visible = false;


            panel_Button.Controls.Clear();

            btnThemKhoaHoc.Visible = false;
            frmDiemDanh frm = new frmDiemDanh();
            frm.TopLevel = false; // cho phep form duoc nhung
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None; // bo vien tieu de
            panel_Button.Controls.Add(frm);
            frm.Show();
        }

        private void btn_HocVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnThemKhoaHoc.Visible = false;
            btnFilter.Visible = false;

            LoadHocVien();
        }
        public void LoadHocVien()
        {

            panel_Button.Controls.Clear();

            UC_ThanhChucNang uccn = new UC_ThanhChucNang("HocVien", this);
            panel_Button.Controls.Add(uccn);
            uccn.Dock = DockStyle.Top;

            UC_MenuHV ucmenu = new UC_MenuHV(this);
            ucmenu.Location = new Point(1, 85);
            panel_Button.Controls.Add(ucmenu);

            int y = 95 + 120;

            using (var context = new Context())
            {
                context.Students.ToList().ForEach(s =>
                {
                    UC_HocVien row_UC = new UC_HocVien(this);
                    row_UC.lblMaHV.Text = s.MaHocVien.ToString();
                    row_UC.lblSDT.Text = s.SoDienThoai.ToString();
                    row_UC.lblTenHV.Text = s.Ho + " " + s.TenLot + " " + s.Ten;
                    row_UC.lblCCCD.Text = s.SoCCCD;

                    row_UC.Location = new Point(1, y);
                    panel_Button.Controls.Add(row_UC);
                    y = y + row_UC.Height + 10;
                });
            }
        }
        private void btn_LopHoc_Click(object sender, EventArgs e)
        {

            ActivateButton(sender);
            btnThemKhoaHoc.Visible = true;
            btnFilter.Visible = true;

            if (Global.Type == "Staff")
                LoadLopHoc();
            else if (Global.Type == "Student")
            {
                int maHocVien = Convert.ToInt32(Global.MaUser);
                LoadLopHocChoHocVien(maHocVien);
            }
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btnLichHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnThemKhoaHoc.Visible = false;
            btnFilter.Visible = false;
            LoadLichHoc();

        }
        private void LoadLichHoc()
        {

            panel_Button.Controls.Clear();

            frmLichHoc frmLH = new frmLichHoc();
            frmLH.TopLevel = false; // cho phep form duoc nhung
            frmLH.StartPosition = FormStartPosition.Manual; // Cho phép đặt vị trí thủ công


            int centerX = panel_Button.Location.X + (panel_Button.Width / 2);

            frmLH.Location = new Point(
                centerX - (frmLH.Width / 2),
               0
            );
            frmLH.FormBorderStyle = FormBorderStyle.None; // bo vien tieu de
            panel_Button.Controls.Add(frmLH);
            frmLH.Dock = DockStyle.Fill;
            frmLH.Show();

        }


        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {

            ActivateButton(sender);
            btnThemKhoaHoc.Visible = true;
            btnFilter.Visible = true;

            if (Global.Type == "Staff")
            {
                LoadKhoaHoc();
            }
            else if (Global.Type == "Student")
            {
                LoadKhoaHocChoHocVien(Convert.ToInt32(Global.MaUser));
            }

        }
        public void VeKhoaHoc(List<Course> danhSachKhoaHoc)
        {

            panel_Button.Controls.Clear();

            int x = 1;
            int y = 1;
            using (var context = new Context())
            {
                foreach (var item in danhSachKhoaHoc.ToList())
                {
                    UC_KhoaHoc khoaHoc = new UC_KhoaHoc(this);
                    khoaHoc.Update();
                    if ((x + khoaHoc.Width + 30) > panel_Button.Width)
                    {
                        x = 1;
                        y = y + khoaHoc.Height + 30;
                    }
                    khoaHoc.Location = new Point(x, y);
                    x = x + khoaHoc.Width + 30;

                    khoaHoc.label_khoahoc.Text = item.TenKhoaHoc;
                    khoaHoc.label_buoihoc.Text = item.SoBuoiHoc.ToString();
                    khoaHoc.label_price.Text = item.GiaTien.ToString();
                    khoaHoc.label_startday.Text = Convert.ToDateTime(item.NgayBatDau).ToString("dd-MM-yyyy");
                   
                    khoaHoc.iconButton_KhoaHoc.Text = item.MaKhoaHoc;

                    panel_Button.Controls.Add(khoaHoc);
                }
            }
        }
        public void LoadKhoaHocChoHocVien(int maHocVien)
        {
            // an nut them va loc cho hoc vien
            if (Global.Type == "Student")
            {
                btnThemKhoaHoc.Visible = false;
                btnFilter.Visible = false;
            }
            using (var context = new Context())
            {
                List<Course> danhSachKhoaHoc = context.Registers
                    .Where(s => s.MaHocVien == maHocVien)
                    .Select(s => s.Class)
                    .Select(s => s.Course).ToList();

                VeKhoaHoc(danhSachKhoaHoc);

            }

        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                /* if(WindowState == FormWindowState.Maximized)
              {
                  MessageBox.Show("hhhh");
              }*/
                currentBtn = btn_Home;
                if (currentBtn.Text == "Lịch học".ToString().Trim())
                    LoadLichHoc();
            }

        }

        private void btnThiThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnThemKhoaHoc.Visible = true;
            btnFilter.Visible = true;
            if (Global.Type == "Staff")
                LoadThiThu();
            else if (Global.Type == "Student")
            {
                int maHocVien = Convert.ToInt32(Global.MaUser);
                LoadThiThuHocVien(maHocVien);
            }
        }
        public void LoadThiThu()
        {
            panel_Button.Controls.Clear();
            int y = 1;
            int x = 1;
            using (var context = new Context())
            {
                var Schedules = context.ExamSchedules.ToList();
                foreach (var s in Schedules)
                {
                    UC_LichThi row_UC = new UC_LichThi(this,0);
                    // load du lieu
                    row_UC.lblMaLichThi.Text = s.MaLichThi.ToString();
                    row_UC.lblNgayThi.Text = s.ThoiDiemThi.ToString();
                    row_UC.lblTenDotThi.Text = s.TenDotThi.ToString();
                    row_UC.lbLop.Text = "";
                    s.ExamScheduleDetails.ToList().ForEach(p => row_UC.lbLop.Text += p.MaLopHoc);

                    //
                    row_UC.Update();
                    if ((x + row_UC.Width + 30) > panel_Button.Width)
                    {
                        x = 1;
                        y = y + row_UC.Height + 30;
                    }
                    row_UC.Location = new Point(x, y);
                    x = x + row_UC.Width + 30;

                    panel_Button.Controls.Add(row_UC);
                }
            }

            panel_Button.Refresh();
        }
        public void LoadThiThuHocVien(int maHocVien)
        {
            // an nut them va loc cho hoc vien
            if (Global.Type == "Student")
            {
                btnThemKhoaHoc.Visible = false;
                btnFilter.Visible = false;
            }
            panel_Button.Controls.Clear();
            int y = 1;
            int x = 1;
            using (var context = new Context())
            {
                var Schedules = context.ExamSchedules.ToList();
                foreach (var sch in Schedules)
                {
                    var lopUser = context.Students.Where(s => s.MaHocVien == maHocVien)
                        .SelectMany(s => s.Registers)
                        .Select(s => s.MaLopHoc).ToList();
                    var lopDK = context.ExamScheduleDetails
                            .Where(s => s.MaLichThi == sch.MaLichThi)
                            .Select(s => s.MaLopHoc).ToList();
                    bool check = lopUser.Any(s => lopDK.Contains(s));


                    if (check == true)
                    {
                        UC_LichThi row_UC = new UC_LichThi(this,maHocVien);
                        // load du lieu
                        row_UC.lblMaLichThi.Text = sch.MaLichThi.ToString();
                        row_UC.lblNgayThi.Text = sch.ThoiDiemThi.ToString();
                        row_UC.lblTenDotThi.Text = sch.TenDotThi.ToString();
                        row_UC.lbLop.Text = "";
                        sch.ExamScheduleDetails.ToList().ForEach(p => row_UC.lbLop.Text += p.MaLopHoc);

                        //
                        row_UC.Update();
                        if ((x + row_UC.Width + 30) > panel_Button.Width)
                        {
                            x = 1;
                            y = y + row_UC.Height + 30;
                        }
                        row_UC.Location = new Point(x, y);
                        x = x + row_UC.Width + 30;

                        panel_Button.Controls.Add(row_UC);
                    }

                }
            }
        }


        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            string text = "";
            // ActivateButton(sender);
            if (currentBtn.Text.ToString() == "Khóa học")
            {
                text = "Thêm khóa học";
                lblDuongDan.Text += @" \ " + text.Trim();
                FormThemKhoaHoc formThemKhoaHoc = new FormThemKhoaHoc();
                formThemKhoaHoc.ShowDialog();
                LoadKhoaHoc();
            }
            else if (currentBtn.Text.ToString() == "Thi thử")
            {
                text = "Thêm lịch thi";
                lblDuongDan.Text += @" \ " + text.Trim() + " ";
                // goi them thi thu
                FormThemLichThi formThemLichThi = new FormThemLichThi(this);
                formThemLichThi.ShowDialog();


            }
            else if (currentBtn.Text.ToString() == "Lớp học")
            {
                text = "Thêm lớp học";
                lblDuongDan.Text += @" \ " + text.Trim() + " ";
                // goi them thi thu
                //MessageBox.Show("them lớp học");
                FormChonKhoaHocKhiThemLop formChonKhoaHocKhiThemLop = new FormChonKhoaHocKhiThemLop(this);
                formChonKhoaHocKhiThemLop.StartPosition = FormStartPosition.CenterParent;
                formChonKhoaHocKhiThemLop.ShowDialog();
            }
            else if (currentBtn.Text.ToString() == "Loại khóa học")
            {
                text = "Thêm loại khóa học";
                lblDuongDan.Text += @" \ " + text.Trim() + " ";
                // goi them thi thu
                //MessageBox.Show("them lớp học");
                FormThemLoaiKhoaHoc formThemLoaiKhoaHoc = new FormThemLoaiKhoaHoc(this);
                formThemLoaiKhoaHoc.StartPosition = FormStartPosition.CenterParent;
                formThemLoaiKhoaHoc.ShowDialog();
            }
            lblDuongDan.Text = lblDuongDan.Text.Replace((@" \ " + text.Trim()), "");
        }
        public void LoadKhoaHoc()
        {
            // an nut them va loc cho hoc vien
            if (Global.Type == "Student")
            {
                btnThemKhoaHoc.Visible = false;
                btnFilter.Visible = false;
            }

            List<Course> danhSachKhoaHoc = (from course in (new Context().Courses) select course).ToList();
            VeKhoaHoc(danhSachKhoaHoc);

        }
        public void VeLopHoc(List<Class> danhSachLopHoc)
        {
            panel_Button.Controls.Clear();
            int x = 1;
            int y = 1;
            foreach (var item in danhSachLopHoc.ToList())
            {
                UC_LopHoc lopHoc = new UC_LopHoc(this);
                lopHoc.Update();
                if ((x + lopHoc.Width + 30) > panel_Button.Width)
                {
                    x = 1;
                    y = y + lopHoc.Height + 30;
                }
                lopHoc.Location = new Point(x, y);
                x = x + lopHoc.Width + 30;

                lopHoc.label_TenLop.Text = item.TenLop;
                lopHoc.label_TenGiangVien.Text = item.Lecturer.Ho + " " + item.Lecturer.TenLot + " " + item.Lecturer.Ten;
                lopHoc.label_NgayBatDau.Text = item.NgayBatDau?.ToString("dd-MM-yyyy");
                lopHoc.label_NgayKetThuc.Text = item.NgayKetThuc?.ToString("dd-MM-yyyy");
                /*lopHoc.label_NgayBatDau.Text = item.
                khoaHoc.label_startday.Text = Convert.ToDateTime(item.NgayBatDau).ToString("dd-MM-yyyy");*/
                /* if (item.NgayKetThuc != null)
                 {
                     khoaHoc.label_endday.Text = Convert.ToDateTime(item.NgayKetThuc).ToString("dd-MM-yyyy");
                 }
                 else
                 {
                     khoaHoc.label_endday.Text = "Chưa xác định";
                 }*/

                lopHoc.iconButton_LopHoc.Text = item.MaLopHoc;

                panel_Button.Controls.Add(lopHoc);
            }
        }
        public void LoadLopHoc()
        {
            // an nut them va loc cho hoc vien
            if (Global.Type == "Student")
            {
                btnThemKhoaHoc.Visible = false;
                btnFilter.Visible = false;
            }
            var danhSachLopHoc = (from lopHoc in (new Context().Classes) select lopHoc).ToList();
            VeLopHoc(danhSachLopHoc);

        }
        public void LoadLopHocChoHocVien(int maHocVien)
        {
            // an nut them va loc cho hoc vien
            if (Global.Type == "Student")
            {
                btnThemKhoaHoc.Visible = false;
                btnFilter.Visible = false;
            }
            using (var context = new Context())
            {
                List<Class> danhSachLopHoc = context.Registers
                    .Where(s => s.MaHocVien == maHocVien)
                    .Select(s => s.Class).ToList();
                VeLopHoc(danhSachLopHoc);
            }

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Dispose();
            login.ShowDialog();
        }


        private void RegisterMouseClickEvent(Control control)
        {
            control.MouseClick += Control_MouseClick;
            foreach (Control subControl in control.Controls)
            {
                RegisterMouseClickEvent(subControl);
            }

        }
        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender != lxbSearch)
            {
                lxbSearch.Visible = false;
            }
            if (sender != btnFilter)
            {
                ucFilter.Visible = false;
            }

            // đổi lại màu của UC_HocVien
            if (listItemSearch != null)
                listItemSearch.ForEach(s => s.BackColor = System.Drawing.Color.White);

            // Bubbling sự kiện ngược lại để không ảnh hưởng đến các hành vi khác
            ((Control)sender).Focus();
        }

        private void lxbSearch_MouseDown(object sender, MouseEventArgs e)
        {

            ListBox source = (ListBox)sender;
            for (int index = 0; index < source.Items.Count; index++)
            {
                // Kiem tra xem chuot co tro vao item hay khong
                if (source.GetItemRectangle(index).Contains(e.Location))
                {
                    source.SelectedItem = source.Items[index];
                    Item<int> item = (Item<int>)source.SelectedItem;

                    UserControl targetControl = null;
                    foreach (Control ctrl in panel_Button.Controls)
                    {
                        if (ctrl is UC_HocVien && ((UC_HocVien)ctrl).lblMaHV.Text == item.Value.ToString())
                        {

                            targetControl = (UserControl)ctrl;
                            targetControl.BackColor = System.Drawing.Color.FromArgb(202, 231, 255);
                            listItemSearch.Add((UC_HocVien)targetControl);
                            break;
                        }
                    }

                    if (targetControl != null)
                    {
                        using (var context = new Context())
                        {
                            // Đảm bảo rằng Panel có kích thước tối thiểu cần thiết để cuộn
                            panel_Button.AutoScrollMinSize = new Size(0, panel_Button.Controls.Cast<Control>().Sum(c => c.Height + c.Margin.Top + c.Margin.Bottom));

                            // Đặt vị trí cuộn sau khi cập nhật UI
                            this.BeginInvoke(new Action(() =>
                            {
                                int newPosition = targetControl.Top - panel_Button.VerticalScroll.Value;
                                panel_Button.AutoScrollPosition = new Point(0, newPosition);
                            }));
                        }

                    }

                    // an listbox va cap nhat lai textbox search
                    lxbSearch.Visible = false;
                    lxbSearch.Text = "Search";
                    break;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (ucFilter.Visible == false)
            {
                ucFilter = new UC_Filter(this);
                ucFilter.LoadData(currentBtn.Text);
                panel_Button.Controls.Add(ucFilter);
                ucFilter.Location = new Point(1325, 0);
                ucFilter.Visible = true;
                ucFilter.BringToFront();
            }
            else
                ucFilter.Visible = false;
        }

        private void iconButton_LoaiKhoaHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnThemKhoaHoc.Visible = true;
            btnFilter.Visible = false;

            if (Global.Type == "Staff")
            {
                LoadLoaiKhoaHoc();
            }
        }
        public void LoadLoaiKhoaHoc()
        {

            List<CourseType> danhSachLoaiKhoaHoc = (from coursetype in (new Context().CourseTypes) select coursetype).ToList();
            VeLoaiKhoaHoc(danhSachLoaiKhoaHoc);

        }
        public void VeLoaiKhoaHoc(List<CourseType> danhSachLoaiKhoaHoc)
        {

            panel_Button.Controls.Clear();

            int x = 1;
            int y = 1;
            using (var context = new Context())
            {
                foreach (var item in danhSachLoaiKhoaHoc.ToList())
                {
                    UC_LoaiKhoaHoc loaiKhoaHoc = new UC_LoaiKhoaHoc(this);
                    loaiKhoaHoc.Update();
                    if ((x + loaiKhoaHoc.Width + 30) > panel_Button.Width)
                    {
                        x = 1;
                        y = y + loaiKhoaHoc.Height + 30;
                    }
                    loaiKhoaHoc.Location = new Point(x, y);
                    x = x + loaiKhoaHoc.Width + 30;

                    loaiKhoaHoc.label_TenKhoaHoc.Text = item.TenLoaiKhoaHoc;
                    loaiKhoaHoc.iconButton_KhoaHoc.Text = item.MaLoaiKhoaHoc;

                    panel_Button.Controls.Add(loaiKhoaHoc);
                }
            }
        }
    }
}
