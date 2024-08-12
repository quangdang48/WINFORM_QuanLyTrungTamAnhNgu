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
    public partial class UC_LichThi : UserControl
    {
        FormMain formMain;
        int maHocVien; 
        public UC_LichThi(FormMain formMain, int maHocVien)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.maHocVien = maHocVien;
        }
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

        // ------ OKE -----
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(Global.Type == "Student")
            {
                using (var context = new Context())
                {
                    int maHV = int.Parse(Global.MaUser);
                    int maLT = int.Parse(lblMaLichThi.Text);
                    // kiem tra user da dang ky chua
                    int count = context.Marks.Where(s => s.MaHocVien == maHV
                                                && s.MaLichThi == maLT).Count();
                    
                    // kiem tra user thuoc lop duoc dang ky khong
                    var lopUser = context.Students.Where(s => s.MaHocVien == maHV)
                                            .SelectMany(s => s.Registers)
                                            .Select(s => s.MaLopHoc).ToList();
                    var lopDK = context.ExamScheduleDetails
                            .Where(s => s.MaLichThi == maLT)
                            .Select(s => s.MaLopHoc).ToList();
                    bool check = lopUser.Any(s => lopDK.Contains(s));

                    if(count > 0)
                    {
                        MessageBox.Show("Bạn đã đăng ký lịch thi này");
                    }
                    else if(check == false)
                    {
                        MessageBox.Show("Bạn không thuộc lớp được đăng ký lịch thi này");
                    }
                    else
                    {
                        try
                        {
                            var sql = "spDangKyThiThu {0}, {1}";
                            context.Database.ExecuteSqlCommand(sql, maLT, maHV);
                            MessageBox.Show("Đăng ký thành công");
                            formMain.LoadThiThuHocVien(maHV);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Bạn không được đăng ký thi");
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new Context())
                    {
                        int maLichThi = Convert.ToInt32(lblMaLichThi.Text);
                        var LichThi = context.ExamSchedules.Find(maLichThi);
                        if (LichThi != null)
                        {
                            context.ExamSchedules.Remove(LichThi);
                            context.SaveChanges();
                            MessageBox.Show("Xóa thành công");
                            formMain.LoadThiThu();

                        }
                        else
                        {
                            MessageBox.Show("Không xóa được");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
           
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (btnNhapDiem.Text == "Nhập điểm")
            {
                try
                {
                    frmNhapDiemThi frm = new frmNhapDiemThi(int.Parse(lblMaLichThi.Text.ToString().Trim()));
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
            else if(btnNhapDiem.Text == "Xem điểm")
            {
               using(var context = new Context())
                {

                    var lichThiHocVien = context.Marks.Where(s => s.MaHocVien == maHocVien /*&& s.MaLichThi == Convert.ToInt32(lblMaLichThi.Text)*/).FirstOrDefault();
                    if(lichThiHocVien != null)
                    {
                        MessageBox.Show($"Điểm thi của bạn trong đợt thi: {lichThiHocVien.ExamSchedule.TenDotThi} là {lichThiHocVien.DiemThi}");
                    }
                }
            }
          

        }

        private void UC_LichThi_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnXoaHV, "Xóa");
            toolTip1.SetToolTip(btnDangKy, "Đăng ký");
            toolTip1.SetToolTip(btnNhapDiem, "Nhập điểm");
            if (Global.Type.ToString() == "Student")
            {
                // an nut nhap diem
                // btnNhapDiem.Visible = false;
                btnNhapDiem.Text = "Xem điểm";
                btnXoaHV.Visible = false;
                // cap nhat nut dang ky
                using (var context = new Context())
                {
                    int maLichThi = int.Parse(lblMaLichThi.Text.ToString().Trim());
                    int maUser = int.Parse(Global.MaUser);
                    int sum = context.Marks
                        .Where(s => s.MaHocVien == maUser
                            && s.MaLichThi == maLichThi).Count();
                    if(sum == 1)
                    {
                        btnDangKy.Text = "Đã đăng ký";
                        btnDangKy.Size = new Size(155, 46);
                        btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
                    }
                }
            }
            else if(Global.Type.ToString() == "Staff")
            {
                btnDangKy.Visible = false;
            }
                
        }

        private void lblNgayThi_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTenDotThi_Click(object sender, EventArgs e)
        {

        }
    }
}
