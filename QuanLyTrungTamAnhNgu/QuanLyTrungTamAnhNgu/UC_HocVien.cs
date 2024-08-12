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
    public partial class UC_HocVien : UserControl
    {
        FormMain parentForm;
        public UC_HocVien(FormMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            RegisterMouseClickEvent(this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            int maHocVien = Convert.ToInt32(lblMaHV.Text);
            var context = new Context();


            var hocVien = context.Students.Find(maHocVien);
            if (hocVien != null)
            {
                DialogResult check = MessageBox.Show($"Bạn có muốn xóa học viên {maHocVien}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    string sql = @"spXoaHocVien {0}";


                    context.Database.ExecuteSqlCommand(sql, maHocVien);
                    parentForm.LoadHocVien();
                }
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }

        }

        private void btnSuaHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                int maHocVien = Convert.ToInt32(lblMaHV.Text);
               
                using(var context = new Context()) 
                {
                    var current_hv = context.Students.Find(maHocVien);
                    var account_hv = context.Logins.Where(s => s.MaUser == maHocVien && s.Type == "Student").First();
                    if (current_hv != null)
                    {
                        FormChinhSuaHocVien formChinhSuaHocVien = new FormChinhSuaHocVien(parentForm,current_hv);
                        formChinhSuaHocVien.txtHo.Text = current_hv.Ho;
                        formChinhSuaHocVien.txtTenLot.Text = current_hv.TenLot;
                        formChinhSuaHocVien.txtTen.Text = current_hv.Ten;

                        formChinhSuaHocVien.textBox_SDT.Text = current_hv.SoDienThoai;
                        formChinhSuaHocVien.textBoxSoCCCD.Text = current_hv.SoCCCD;


              /*          if (account_hv != null)
                        {*/
                            formChinhSuaHocVien.txt_TenDangNhap.Text = account_hv.TenDangNhap;
                            formChinhSuaHocVien.txt_Password.Text = account_hv.Password;
                        //}
                        formChinhSuaHocVien.ShowDialog(parentForm);
                    }
                }


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_HocVien_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDiemThi, "Xem điểm thi");
            toolTip1.SetToolTip(btnXoaHV, "Xóa");
            toolTip1.SetToolTip(btnSuaHocVien, "Sửa học viên");
            toolTip1.SetToolTip(iconButton_ThemXoaLopHoc, "Thêm xóa lớp học cho học viên");
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
            if (sender != parentForm.lxbSearch)
            {
                parentForm.lxbSearch.Visible = false;
            }
            // Bubbling sự kiện ngược lại để không ảnh hưởng đến các hành vi khác
            ((Control)sender).Focus();
        }

        private void btnDiemThi_Click(object sender, EventArgs e)
        {
            try
            {
                int maHocVien = Convert.ToInt32(lblMaHV.Text);
                FormXemDiemThi formXemDiemThi = new FormXemDiemThi(maHocVien);
                formXemDiemThi.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  

        }

        private void iconButton_ThemXoaLopHoc_Click(object sender, EventArgs e)
        {
            try
            {
                int maHocVien = Convert.ToInt32(lblMaHV.Text);
                FormThemLopHocChoHocVien themLopHocChoHocVien = new FormThemLopHocChoHocVien(maHocVien);
                themLopHocChoHocVien.FormBorderStyle = FormBorderStyle.None;
                
                themLopHocChoHocVien.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
