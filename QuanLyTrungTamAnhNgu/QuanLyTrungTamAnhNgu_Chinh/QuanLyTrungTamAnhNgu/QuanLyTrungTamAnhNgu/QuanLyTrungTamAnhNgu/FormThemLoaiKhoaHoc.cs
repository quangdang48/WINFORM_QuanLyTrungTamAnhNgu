using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class FormThemLoaiKhoaHoc : Form
    {
        FormMain formMain;
        public FormThemLoaiKhoaHoc(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void FormThemLoaiKhoaHoc_Load(object sender, EventArgs e)
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
        private void btnThemLoaiKhoaHoc_Click(object sender, EventArgs e)
        {
           
            try
            {
                string maLoaiKhoa = textBox_MaLoaiKhoa.Text;
                string tenLoaiKhoaHoc = textBox_TenLoaiKhoa.Text;

                DialogResult check = MessageBox.Show($"Bạn có muốn thêm khóa học {maLoaiKhoa}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    CourseType courseType = new CourseType
                    {
                       MaLoaiKhoaHoc = maLoaiKhoa,
                       TenLoaiKhoaHoc = tenLoaiKhoaHoc
                    };
                    using (var context = new Context())
                    { 
                        context.CourseTypes.Add(courseType);
                        context.SaveChanges();
                        MessageBox.Show("Đã thêm thành công loại khóa học");
                        formMain.LoadLoaiKhoaHoc();
                        this.Dispose();
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Dispose();
        }

        private void iconButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
