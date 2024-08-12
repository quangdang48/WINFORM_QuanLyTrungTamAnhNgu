using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class FormThemKhoaHoc : Form
    {
        Context context;
        int thuTuTiepTheo = 0; 
        public FormThemKhoaHoc()
        {
            InitializeComponent();
            context = new Context();
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            try
            {
                string maLoaiKhoa = comboBox_MaLoaiKhoaHoc.SelectedValue as string;
                string maKhoaHoc = label_MaKhoaHoc.Text;
                string tenKhoaHoc = textBox_TenKhoaHoc.Text;
                int soBuoihoc = Convert.ToInt32(textBox_SoBuoiHoc.Text);
                decimal giaTien = Convert.ToDecimal(textBox_GiaTien.Text);
                DateTime ngayBatDau = dateTimePicker_NgayBatDau.Value;
                

                DialogResult check = MessageBox.Show($"Bạn có muốn thêm khóa học {maKhoaHoc}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    Course course = new Course
                    {
                        MaKhoaHoc = maKhoaHoc,
                        MaLoaiKhoaHoc = maLoaiKhoa,
                        TenKhoaHoc = tenKhoaHoc,
                        SoBuoiHoc = soBuoihoc,
                        GiaTien = giaTien,
                        NgayBatDau = ngayBatDau,
                        NgayKetThuc = null,
                        soThuTuKhoa = thuTuTiepTheo,
                        TrangThai = true
                    };
                        context.Courses.Add(course);
                        context.SaveChanges();
                    MessageBox.Show("Đã thêm thành công khóa học"); 
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        private void FormThemKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadMaLoaiKhoaHoc();
            toolTip1.SetToolTip(iconButton_Cancel, "Cancel");
            toolTip1.SetToolTip(btnThemKhoaHoc, "Thên khóa học");
            toolTip1.SetToolTip(textBox_GiaTien, "Giá tiền");
        }

        private void textBox_MaKhoaHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }
        public void LoadMaLoaiKhoaHoc()
        {
            var danhSachLoaiKhoaHoc = context.CourseTypes.Select(s => s.MaLoaiKhoaHoc);
            comboBox_MaLoaiKhoaHoc.DataSource = danhSachLoaiKhoaHoc.ToList();
        }
        public int LayThuTuKhoaTiepTheo(string maLoaiKhoa)
        {
            int thuTuMaxCuaKhoaHienTai = 0;
            thuTuMaxCuaKhoaHienTai = context.Courses.Where(s => s.MaLoaiKhoaHoc == maLoaiKhoa).Max(s => s.soThuTuKhoa);
            return thuTuMaxCuaKhoaHienTai + 1;

        }

        private void comboBox_MaLoaiKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoaiKhoaCurrent = comboBox_MaLoaiKhoaHoc.SelectedItem as string;
            thuTuTiepTheo = LayThuTuKhoaTiepTheo(maLoaiKhoaCurrent);
            var current_course_type = context.CourseTypes.Find(maLoaiKhoaCurrent);
            string current_name_course_type = current_course_type.TenLoaiKhoaHoc;
            if(thuTuTiepTheo > 0)
            {
                string maKhoaTiepTheo = maLoaiKhoaCurrent+ "_" +thuTuTiepTheo;
                label_MaKhoaHoc.Text = maKhoaTiepTheo;
                textBox_TenKhoaHoc.Text = "Khóa " + current_name_course_type + " " + thuTuTiepTheo;
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_TenKhoaHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_GiaTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Không được nhập chữ");
                // Nếu không phải số, hủy bỏ ký tự
                e.Handled = true;
            }
        }

        private void textBox_SoBuoiHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Không được nhập chữ");
                // Nếu không phải số, hủy bỏ ký tự
                e.Handled = true;
            }
        }
    }
}
