using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class FormChinhSuaLopHoc : Form
    {
        FormMain form_main;
        public FormChinhSuaLopHoc(FormMain form_main)
        {
            InitializeComponent();
            this.form_main = form_main;
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
        private void FormChinhSuaLopHoc_Load(object sender, EventArgs e)
        {
            LoadComboBoxGiangVien();
            LoadComboBoxPhong();
            toolTip1.SetToolTip(iconButton_Cancel, "Cancel");
            toolTip1.SetToolTip(btnChinhSuaKhoaHoc, "Update");
        }

        private void cbxGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maGiangVien = Convert.ToInt32(cbxGiangVien.SelectedItem);
            setTenGiangVienTheoMa(maGiangVien);
        }
        public void LoadComboBoxGiangVien()
        {
            using(var context = new Context())
            {
                var danhSachMaGiangVien = context.Lecturers.Select(s => s.MaGiangVien).ToList();
                cbxGiangVien.DataSource = danhSachMaGiangVien;
            }
        }
        public void LoadComboBoxPhong()
        {
            using (var context = new Context())
            {
                var danhSachMaPhong = context.Rooms.Select(s => s.MaPhong).ToList();
                cbxPhong.DataSource = danhSachMaPhong;
            }
        }
        public void setTenGiangVienTheoMa(int maGiangVien)
        {
            using(var context = new Context())
            {
                var giangVien = context.Lecturers.Find(maGiangVien);
                label4.Text = giangVien.Ho + " " + giangVien.TenLot +" "+giangVien.Ten;
            }
        }

        private void btnChinhSuaKhoaHoc_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var current_class = context.Classes.Find(textBox_MaLopHoc.Text);
                    current_class.TenLop = textBox_TenLopHoc.Text;
                    current_class.MaGiangVien = Convert.ToInt32(cbxGiangVien.SelectedItem);
                    current_class.MaPhong = cbxPhong.SelectedItem as string;
                    context.SaveChanges();
                    form_main.LoadLopHoc();
                    MessageBox.Show("Cập nhật thành công");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
