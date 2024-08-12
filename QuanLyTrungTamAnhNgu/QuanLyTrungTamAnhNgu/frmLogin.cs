using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyTrungTamAnhNgu
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
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
        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
        //Cho phép duy chuyển form và vẫn ẩn border
       
        private void frmLogin_Load(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(iconButton_Login, "Login");
            toolTip1.SetToolTip(iconButton_Cancel, "Cancel");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton_Login_Click(object sender, EventArgs e)
        {
            bool found = false;
            using (var context = new Context())
            {
                FormMain frm = new FormMain();
                context.Logins.ToList().ForEach(s =>
                {
                    if (s.TenDangNhap == txtTenDangNhap.Text.Trim() && s.Password == txtPass.Text.Trim())
                    {
                        found = true;
                        Global.TenDangNhap = s.TenDangNhap;
                        Global.Password = s.Password;
                        Global.Type = s.Type;
                        Global.MaUser = s.MaUser.ToString();

                        if (s.Type.Trim() == "Staff")
                        {
                            frm.btn_HocVien.Show();
                            var staff = context.Staffs.Where(p => p.MaNhanVien == s.MaUser).FirstOrDefault();
                            Global.TenNguoiDung = staff.Ho + " " + staff.TenLot + " " + staff.Ten;
                        }
                        else if (s.Type.Trim() == "Student")
                        {
                            frm.btn_HocVien.Dispose();
                            var staff = context.Students.Where(p => p.MaHocVien == s.MaUser).FirstOrDefault();
                            Global.TenNguoiDung = staff.Ho + " " + staff.TenLot + " " + staff.Ten;
                        }
                       
                    }
                });
                this.Hide();
                frm.ShowDialog();

                this.Close();
            }
            if(found == false)
            {
                MessageBox.Show("Sai tài khoảng hoặc mật khẩu");
            }
        }

        private void iconButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
