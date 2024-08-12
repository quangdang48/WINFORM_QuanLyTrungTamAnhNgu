using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class UC_LoaiKhoaHoc : UserControl
    {
        FormMain formMain;
        public UC_LoaiKhoaHoc(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void UC_LoaiKhoaHoc_Load(object sender, EventArgs e)
        {

        }

        private void iconButton_KhoaHoc_Click(object sender, EventArgs e)
        {
            string maLoaiKhoa = this.iconButton_KhoaHoc.Text;
            string tenLoaiKhoa = this.label_TenKhoaHoc.Text;
            using (var context = new Context())
            {
                FormChinhSuaLoaiKhoaHoc formChinhSuaLoaiKhoaHoc = new FormChinhSuaLoaiKhoaHoc(formMain);
                formChinhSuaLoaiKhoaHoc.StartPosition = FormStartPosition.CenterScreen;
                formChinhSuaLoaiKhoaHoc.textBox_MaLoaiKhoaHoc.Text = this.iconButton_KhoaHoc.Text;
                formChinhSuaLoaiKhoaHoc.textBox_TenLoaiKhoaHoc.Text = this.label_TenKhoaHoc.Text;

                int soKhoaDangMo = context.CourseTypes.Find(maLoaiKhoa).Courses.Count;
                int soLopDangMo = 0;
                var dsLopCuaLoaiKhoa = context.CourseTypes.Find(maLoaiKhoa).Courses.Select(s => s.Classes).ToList();
                dsLopCuaLoaiKhoa.ForEach(s => soKhoaDangMo += s.Count);

                formChinhSuaLoaiKhoaHoc.textBox_SoKhoaDangMo.Text = soKhoaDangMo + "";
                formChinhSuaLoaiKhoaHoc.txt_SoLopDangMo.Text = soKhoaDangMo + "";
                formChinhSuaLoaiKhoaHoc.ShowDialog();

            }
           
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            try
            {
                string maLoaiKhoaHoc = iconButton_KhoaHoc.Text;
                using (var context = new Context())
                {
                    var khoaHoc = context.CourseTypes.Find(maLoaiKhoaHoc);
                    bool checkCacKhoaHocDangMo = khoaHoc.Courses.All(s => s.TrangThai == false); // true là tất cả các khóa học đã đóng 

                    if (checkCacKhoaHocDangMo == true)
                    {
                        context.CourseTypes.Remove(khoaHoc);
                        context.SaveChanges();
                        MessageBox.Show("Đã xóa thành công");
                        formMain.LoadLoaiKhoaHoc();
                    }
                    else
                    {
                        MessageBox.Show("Các hhóa học chưa kết thúc, không thể xóa được");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
    }
}
