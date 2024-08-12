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
    public partial class FormXemDiemThi : Form
    {
        int maHocVien; 
        public FormXemDiemThi(int maHocVien)
        {
            InitializeComponent();
            this.maHocVien = maHocVien;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormXemDiemThi_Load(object sender, EventArgs e)
        {
            LoadData();
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
        public void LoadData()
        {

            try
            {
                using (var context = new Context())
                {
                    // load datagridview
                    var dsDiemThiCuaHocVien = context.Marks.Where(s => s.MaHocVien == maHocVien).Select(s => new
                    {
                        //MaLichThi = s.MaLichThi,
                        //MaHocVien = s.MaHocVien,
                        //TenHocVien = s.Student.Ho + " " + s.Student.TenLot + " " + s.Student.Ten,
                        DiemThi = s.DiemThi,
                        HocLuc = s.HocLuc,
                        TenDotThi = s.ExamSchedule.TenDotThi,
                        ThoiDiemThi = s.ExamSchedule.ThoiDiemThi
                    }).ToList();

                    for (int i = 0; i < dsDiemThiCuaHocVien.Count(); i++)
                    {
                        dgvDiemThi.Rows.Add();
                        var thongTin = dsDiemThiCuaHocVien[i];
                        dgvDiemThi.Rows[i].Cells["HocLuc"].Value = thongTin.HocLuc;
                        dgvDiemThi.Rows[i].Cells["DiemThi"].Value = thongTin.DiemThi;
                        if(thongTin.ThoiDiemThi != null)
                        {
                            dgvDiemThi.Rows[i].Cells["ThoiDiemThi"].Value = thongTin.ThoiDiemThi?.ToString("dd-MM-yyyy");
                        }
                       
                        dgvDiemThi.Rows[i].Cells["TenDotThi"].Value = thongTin.TenDotThi;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
