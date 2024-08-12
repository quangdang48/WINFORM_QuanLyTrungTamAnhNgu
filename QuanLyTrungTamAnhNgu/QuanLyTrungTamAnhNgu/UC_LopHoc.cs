using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class UC_LopHoc : UserControl
    {
        FormMain form_main;
        public UC_LopHoc(FormMain form_main)
        {
            InitializeComponent();
            this.form_main = form_main;
        }
        public UC_LopHoc()
        {
            InitializeComponent();
        }

        // bo tron goc
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 40; // càng lớn càng tròn
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void iconButton_LopHoc_Click(object sender, EventArgs e)
        {
            string maLopHoc = iconButton_LopHoc.Text;
            Class current_class = null;
            using (var context = new Context())
            {
                current_class = context.Classes.Find(maLopHoc);
                FormChinhSuaLopHoc formChinhSuaLopHoc = new FormChinhSuaLopHoc(form_main);
                formChinhSuaLopHoc.cbxPhong.Text = current_class.MaPhong;
                formChinhSuaLopHoc.textBox_MaLopHoc.Text = maLopHoc;
                formChinhSuaLopHoc.textBox_TenLopHoc.Text = current_class.TenLop;
                formChinhSuaLopHoc.cbxGiangVien.Text = current_class.Lecturer.MaGiangVien + "";

               /* if (current_class.NgayBatDau != null)
                {
                    formChinhSuaLopHoc..Value = current_class.NgayBatDau.Value;
                }

                if (current_class.NgayBatDau != null)
                {
                    formChinhSuaLopHoc.dateTimePicker_NgayKetThuc.Value = current_class.NgayKetThuc.Value;
                }*/
                formChinhSuaLopHoc.ShowDialog();
            }

        }



        private void UC_LopHoc_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnXoaLopHoc, "Xóa");
            toolTip1.SetToolTip(iconButton_LopHoc, "Chỉnh sửa lớp học");
            if(Global.Type == "Student")
            {
                btnXoaLopHoc.Visible = false;
            }
        }

        private void btnXoaLopHoc_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show($"Bạn có muốn xóa lớp học", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                // try
                //{
                using (var context = new Context())
                {
                    string maLopHoc = iconButton_LopHoc.Text.Trim();

                    int soHocVien = context.Registers.Where(s => s.MaLopHoc == maLopHoc).Count();
                    // neu co hoc vien hoc, kiem tra xem lop co ket thuc chua
                    if (soHocVien > 0)
                    {
                        var ngayKT = context.Classes
                            .Where(s => s.MaLopHoc == maLopHoc)
                            .Select(s => s.NgayKetThuc).FirstOrDefault();
                        if (ngayKT == null)
                        {
                            MessageBox.Show("Lỗi lớp học chưa có ngày kết thúc");
                            return;
                        }
                        else if ((DateTime)ngayKT >= DateTime.Now)
                        {
                            MessageBox.Show("Lớp học có học viên đang học, không thể xóa");
                            return;
                        }
                    }
                    // xoa lop hoc

                    Class lopHoc = context.Classes.Where(s => s.MaLopHoc == maLopHoc).FirstOrDefault();
                    context.Classes.Remove(lopHoc);
                    context.SaveChanges();
                    MessageBox.Show("Xóa lớp học thành công");
                    form_main.LoadLopHoc();
                }
               /* }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }*/
                
            }
        }
    }
}
