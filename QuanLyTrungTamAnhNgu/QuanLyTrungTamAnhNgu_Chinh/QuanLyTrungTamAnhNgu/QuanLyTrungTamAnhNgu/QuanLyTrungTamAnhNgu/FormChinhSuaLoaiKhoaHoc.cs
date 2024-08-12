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
    public partial class FormChinhSuaLoaiKhoaHoc : Form
    {
        FormMain formMain;
        public FormChinhSuaLoaiKhoaHoc(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void FormChinhSuaLoaiKhoaHoc_Load(object sender, EventArgs e)
        {

        }

        private void iconButton_Cancel_Click(object sender, EventArgs e)
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

        private void btnChinhSuaKhoaHoc_Click(object sender, EventArgs e)
        {
            string maLoaiKhoaHoc = textBox_MaLoaiKhoaHoc.Text;
            string tenLoaiKhoaHoc = textBox_TenLoaiKhoaHoc.Text;
            Context context = new Context();
            var loaiKhoaHoc = context.CourseTypes.Find(maLoaiKhoaHoc);
            if (loaiKhoaHoc != null)
            {
                try
                {
                    loaiKhoaHoc.TenLoaiKhoaHoc = tenLoaiKhoaHoc;
                    context.SaveChanges();
                    MessageBox.Show("Đã chỉnh sửa thành công");
                    formMain.LoadLoaiKhoaHoc();
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }
        }
    }
}
