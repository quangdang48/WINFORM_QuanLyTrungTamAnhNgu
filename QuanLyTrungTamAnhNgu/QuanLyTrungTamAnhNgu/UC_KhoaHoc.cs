using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class UC_KhoaHoc : UserControl
    {
        FormMain parent_form; 
        public UC_KhoaHoc(FormMain parent_form)
        {
            InitializeComponent();
            this.parent_form = parent_form;
        }

        //Bo tròn góc 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius =   40; // càng lớn càng tròn
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            string maKhoaHoc = iconButton_KhoaHoc.Text;
            using (var context = new Context())
            {
                var khoaHoc = context.Courses.Find(maKhoaHoc);
                if (khoaHoc.TrangThai == false)
                {
                    bool checkAllLopDaKetThuc = khoaHoc.Classes.All(s => s.NgayKetThuc < DateTime.Now); // Nếu ngày hiện tại > ngày kết thúc => lớp đã kết thúc
                    if (checkAllLopDaKetThuc == true)
                    {
                        if (khoaHoc != null)
                        {
                            DialogResult check = MessageBox.Show($"Bạn có muốn xóa khóa học {maKhoaHoc}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (check == DialogResult.Yes)
                            {
                                context.Courses.Remove(khoaHoc);
                                context.SaveChanges();
                                parent_form.LoadKhoaHoc();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không xóa được");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Còn lớp học, không xóa được");
                    }
                }
                else
                {
                    MessageBox.Show("Khóa học chưa kết thúc, không thể xóa được");
                }
            }
        }
        private void iconButton_KhoaHoc_Click(object sender, EventArgs e)
        {
            FormChinhSuaKhoaHoc formChinhSuaKhoaHoc = new FormChinhSuaKhoaHoc(parent_form);
            formChinhSuaKhoaHoc.StartPosition = FormStartPosition.CenterScreen;
            formChinhSuaKhoaHoc.textBox_MaKhoaHoc.Text = this.iconButton_KhoaHoc.Text;
            formChinhSuaKhoaHoc.textBox_GiaTien.Text = this.label_price.Text;
            formChinhSuaKhoaHoc.textBox_SoBuoiHoc.Text = this.label_buoihoc.Text;
            formChinhSuaKhoaHoc.textBox_TenKhoaHoc.Text = this.label_khoahoc.Text;
            MessageBox.Show(this.label_startday.Text);

            string dateString = this.label_startday.Text;
            DateTime result; 
            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                formChinhSuaKhoaHoc.dateTimePicker_NgayBatDau.Value = result;
            }
            else
            {
                formChinhSuaKhoaHoc.dateTimePicker_NgayBatDau.Value = DateTime.Now;
            }


            
      //      formChinhSuaKhoaHoc.dateTimePicker_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            formChinhSuaKhoaHoc.ShowDialog();
        }

        private void iconButton_ChinhSua_Click(object sender, EventArgs e)
        {
           
        }

        private void UC_KhoaHoc_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnXoaHV, "Xóa");
            toolTip1.SetToolTip(iconButton_KhoaHoc,"Chỉnh sửa khóa học");
            if(Global.Type == "Student")
            {
                btnXoaHV.Visible = false;
            }
        }
    }
}
