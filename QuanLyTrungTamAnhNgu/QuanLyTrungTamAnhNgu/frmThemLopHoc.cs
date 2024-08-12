using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class frmThemLopHoc : Form
    {
        FormMain formMain;
        private string maKhoaHoc;
        Context context;
        public frmThemLopHoc(string maKhoaHoc, FormMain formMain)
        {
            InitializeComponent();
            this.maKhoaHoc = maKhoaHoc;
            context = new Context();
            this.formMain = formMain;
        }
        //Cho phép duy chuyển form và vẫn ẩn border
        private Point _startPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(-_startPoint.X, -_startPoint.Y);
                this.Location = newPoint;
            }
        }
        private void frmThemKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadMaLopVaTenLopTiepTheo();
            toolTip1.SetToolTip(btnLuu, "Save");
            toolTip1.SetToolTip(btnHuy, "Cancel");
            try
            {
                using (var context = new Context())
                {
                    // load Giang Vien
                    var giangVien = context.Lecturers
                        .Select(s => new
                        {
                            s.MaGiangVien,
                            TenGiangVien = s.Ho.Trim() + " " +
                            s.TenLot.Trim() + " " + s.Ten.Trim()
                        }).ToList();

                    cbxGiangVien.DataSource = giangVien;
                    cbxGiangVien.DisplayMember = "TenGiangVien";
                    cbxGiangVien.ValueMember = "MaGiangVien";

                    // load Phong
                    var phong = context.Rooms.ToList();
                    cbxPhong.DataSource = phong;
                    cbxPhong.ValueMember = "MaPhong";


                    // load thu trong tuan
                    List<string> ThuB2 = new List<string> { "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy", "Chủ Nhật" };
                    List<string> ThuB3 = new List<string> { "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy", "Chủ Nhật" };
                    List<string> ThuB1 = new List<string> { "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy", "Chủ Nhật" };
                    cbxBuoi1.DataSource = ThuB1;
                    cbxBuoi2.DataSource = ThuB2;
                    cbxBuoi3.DataSource = ThuB3;


                    lblTenKhoaHoc.Text = context.Courses
                        .Where(s => s.MaKhoaHoc == maKhoaHoc.Trim())
                        .FirstOrDefault().TenKhoaHoc.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpNgayBatDau.Value < DateTime.Now)
                {
                    MessageBox.Show("Thời gian mở lớp không hợp lệ");

                }
                else
                {
                    List<int> BuoiHoc = new List<int>();
                    BuoiHoc.Add(GiaTriThu(cbxBuoi1.SelectedItem.ToString().Trim()));
                    BuoiHoc.Add(GiaTriThu(cbxBuoi2.SelectedItem.ToString().Trim()));
                    BuoiHoc.Add(GiaTriThu(cbxBuoi3.SelectedItem.ToString().Trim()));

                    // tim ca hoc
                    List<List<int>> listCaHoc = new List<List<int>>();
                    listCaHoc = DanhSachCaHoc();
                    if (!CheckLichHoc(listCaHoc, BuoiHoc))
                    {
                        MessageBox.Show("Trùng lịch");
                        return;
                    }
                    using (var scope = new TransactionScope())
                    {
                        // them lop hoc
                        var lophoc = new Class
                        {
                            MaLopHoc = label_MaLop.Text,
                            MaKhoaHoc = maKhoaHoc,
                            MaGiangVien = int.Parse(cbxGiangVien.SelectedValue.ToString().Trim()),
                            MaPhong = cbxPhong.SelectedValue.ToString(),
                            TenLop = txtTenLopHoc.Text,
                            NgayBatDau = dtpNgayBatDau.Value.Date,
                            NgayKetThuc = null
                        };

                        context.Classes.Add(lophoc);


                        // them lich hoc
                        var soBuoiHoc = context.Courses
                            .Where(s => s.MaKhoaHoc == maKhoaHoc.Trim())
                            .FirstOrDefault().SoBuoiHoc;

                        if (soBuoiHoc == null)
                        {
                            MessageBox.Show("Khóa học chưa có buổi học");
                            return;
                        }
                        // them ca hoc
                        DateTime currentDate = dtpNgayBatDau.Value.Date;

                        while (context.TimeTables.Where(s => s.MaLopHoc == lophoc.MaLopHoc.Trim()).Count() < (int)soBuoiHoc)
                        {

                            if (BuoiHoc[0] == ((int)currentDate.DayOfWeek))
                            {
                                // them lich hoc
                                var lichhoc = new TimeTable { NgayHoc = currentDate };
                                lophoc.TimeTables.Add(lichhoc);

                                for (int i = 0; i < listCaHoc[0].Count; i++)
                                {
                                    var shift = context.Shifts.Find(listCaHoc[0][i]);
                                    lichhoc.Shifts.Add(shift);
                                    shift.TimeTables.Add(lichhoc);
                                }

                                context.SaveChanges();
                            }
                            else if (BuoiHoc[1] == ((int)currentDate.DayOfWeek))
                            {

                                // them lich hoc
                                var lichhoc = new TimeTable { NgayHoc = currentDate };
                                lophoc.TimeTables.Add(lichhoc);

                                for (int i = 0; i < listCaHoc[1].Count; i++)
                                {
                                    var shift = context.Shifts.Find(listCaHoc[1][i]);
                                    lichhoc.Shifts.Add(shift);
                                    shift.TimeTables.Add(lichhoc);
                                }

                                context.SaveChanges();
                            }
                            else if (BuoiHoc[2] == ((int)currentDate.DayOfWeek))
                            {
                                // them lich hoc
                                var lichhoc = new TimeTable { NgayHoc = currentDate };
                                lophoc.TimeTables.Add(lichhoc);

                                for (int i = 0; i < listCaHoc[2].Count; i++)
                                {
                                    var shift = context.Shifts.Find(listCaHoc[2][i]);
                                    lichhoc.Shifts.Add(shift);
                                    shift.TimeTables.Add(lichhoc);
                                }

                                context.SaveChanges();
                            }
                            currentDate = currentDate.AddDays(1);
                        }
                        lophoc.NgayKetThuc = currentDate.AddDays(-1);

                        context.SaveChanges();

                        scope.Complete();
                    }



                    MessageBox.Show("Thêm thành công");
                    formMain.LoadLopHoc();
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        private bool CheckLichHoc(List<List<int>> dsCaHoc, List<int> buoiHoc)
        {
            try
            {
                using (var context = new Context())
                {
                    List<Class> dsLH = context.Classes.ToList();
                    foreach (Class s in dsLH)
                    {
                        if (s.MaPhong == cbxPhong.SelectedValue.ToString())
                        {
                            // tim thu hoc trong tuan
                            List<int> thuHoc = new List<int>();
                            List<List<int>> dsCH = new List<List<int>>();

                            foreach (TimeTable p in s.TimeTables)
                            {
                                int thu = (int)p.NgayHoc.Value.DayOfWeek;
                                if (!thuHoc.Contains(thu))
                                {
                                    thuHoc.Add(thu);
                                    dsCH.Add(p.Shifts.Select(k => k.MaCaHoc).ToList());
                                }

                                if (thuHoc.Count == 3)
                                    break;
                            }
                            // kiem tra xem co buoi hoc nao trung khong
                            for (int i = 0; i < buoiHoc.Count; i++)
                            {
                                for (int j = 0; j < thuHoc.Count; j++)
                                {
                                    if (buoiHoc[i] == thuHoc[j])
                                    {
                                        // so sanh ca hoc
                                        for (int k = 0; k < dsCaHoc[i].Count; k++)
                                        {
                                            for (int h = 0; h < dsCH[j].Count; h++)
                                                if (dsCH[j][h] == dsCaHoc[i][k])
                                                {
                                                    return false;

                                                }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            return true;
        }
        private List<List<int>> DanhSachCaHoc()
        {
            List<List<int>> dsCaHoc = new List<List<int>>();
            dsCaHoc.Add(new List<int>());
            // them ca hoc cho lich hoc
            if (checkboxCa1B1.Checked)
            {
                dsCaHoc[0].Add(1);
            }
            if (checkboxCa2B1.Checked)
            {
                dsCaHoc[0].Add(2);

            }
            if (checkboxCa3B1.Checked)
            {
                dsCaHoc[0].Add(3);

            }
            if (checkboxCa4B1.Checked)
            {
                dsCaHoc[0].Add(4);

            }
            dsCaHoc.Add(new List<int>());
            // them ca hoc cho lich hoc
            if (checkboxCa1B2.Checked)
            {
                dsCaHoc[1].Add(1);
            }
            if (checkboxCa2B2.Checked)
            {
                dsCaHoc[1].Add(2);
            }
            if (checkboxCa3B2.Checked)
            {
                dsCaHoc[1].Add(3);
            }
            if (checkboxCa4B2.Checked)
            {
                dsCaHoc[1].Add(4);
            }
            dsCaHoc.Add(new List<int>());
            if (checkboxCa1B3.Checked)
            {
                dsCaHoc[2].Add(1);
            }
            if (checkboxCa2B3.Checked)
            {
                dsCaHoc[2].Add(2);
            }
            if (checkboxCa3B3.Checked)
            {
                dsCaHoc[2].Add(3);
            }
            if (checkboxCa4B3.Checked)
            {
                dsCaHoc[2].Add(4);
            }

            return dsCaHoc;
        }

        private int GiaTriThu(string text)
        {
            switch (text)
            {
                case "Thứ Hai":
                    return 1;
                case "Thứ Ba":
                    return 2;
                case "Thứ Tư":
                    return 3;
                case "Thứ Năm":
                    return 4;
                case "Thứ Sáu":
                    return 5;
                case "Thứ Bảy":
                    return 6;
                case "Chủ Nhật":
                    return 0;
                default:
                    return 1;
            }
        }
        public void LoadMaLopVaTenLopTiepTheo()
        {
            string maLop = "";
            string tenLop = "";
            var current_course = context.Courses.Find(maKhoaHoc);
            int num_class_of_course = current_course.Classes.Count;
            int id_class_next = num_class_of_course + 1;
            maLop = maKhoaHoc.Trim() + "_" + (id_class_next);
            label_MaLop.Text = maLop;

            string tenLoaiKhoa = current_course.CourseType.TenLoaiKhoaHoc;
            int thuTuKhoa = current_course.soThuTuKhoa;
            tenLop = "Lớp " + tenLoaiKhoa + " " + id_class_next + " khóa " + thuTuKhoa;
            txtTenLopHoc.Text = tenLop;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}