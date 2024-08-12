using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class FormChinhSuaKhoaHoc : Form
    {
        FormMain formMain;
        public FormChinhSuaKhoaHoc(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btnChinhSuaKhoaHoc_Click(object sender, EventArgs e)
        {
            string maKhoaHoc = textBox_MaKhoaHoc.Text;
            string giaTien = textBox_GiaTien.Text;
            string soBuoiHoc = textBox_SoBuoiHoc.Text;
            string tenKhoaHoc = textBox_TenKhoaHoc.Text;
            DateTime ngayBatDau = dateTimePicker_NgayBatDau.Value;
            bool trangThai = true;
          //  DateTime ngayKetThuc = dateTimePicker_NgayKetThuc.Value;
            if(comboBox_TrangThai.Text == "False")
            {
                trangThai = false;
            }

            Context context = new Context();
            var khoaHoc = context.Courses.Find(maKhoaHoc);
            if(khoaHoc != null )
            {
                try
                {
                    khoaHoc.MaKhoaHoc = maKhoaHoc;
                    khoaHoc.GiaTien = Convert.ToDecimal(giaTien);
                    khoaHoc.SoBuoiHoc = Convert.ToInt32(soBuoiHoc);
                    khoaHoc.TenKhoaHoc = tenKhoaHoc;
                    khoaHoc.NgayBatDau = ngayBatDau;
                    khoaHoc.TrangThai = trangThai;
                  //  khoaHoc.NgayKetThuc = ngayKetThuc;
                    context.SaveChanges();
                    MessageBox.Show("Đã chỉnh sửa thành công");
                    formMain.LoadKhoaHoc();
                    this.Dispose();
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void FormChinhSuaKhoaHoc_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(iconButton_Cancel, "Cancel");
            toolTip1.SetToolTip(btnChinhSuaKhoaHoc, "Update");
        }

        private void textBoxSoCCCD_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBoxGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là phím điều khiển, hủy bỏ ký tự được nhập vào
                MessageBox.Show("Không được nhập chữ");
                e.Handled = true;
            }

        }

        private void textBoxSoBuoiHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là phím điều khiển, hủy bỏ ký tự được nhập vào
                MessageBox.Show("Không được nhập chữ");
                e.Handled = true;
            }
        }
    }
}
