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
    public partial class frmNhapDiemThi : Form
    {
        private int maLichThi;
        public frmNhapDiemThi(int maLichThi)
        {
            InitializeComponent();
            this.maLichThi = maLichThi;
        }

        private void frmNhapDiemThi_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhoaHoc();
            LoadData();
            toolTip1.SetToolTip(btnLuu, "Save");
            toolTip1.SetToolTip(btnThoat, "Cancel");
        }
        public void LoadData()
        {
           
            try
            {
                using(var context = new Context())
                {
                    // load datagridview
                    var dsDiemThi = context.Marks.Where(s => s.MaLichThi == maLichThi).Select(s => new
                    {
                        MaHocVien = s.MaHocVien,
                        TenHocVien = s.Student.Ho + " " + s.Student.TenLot + " " + s.Student.Ten,
                        DiemThi = s.DiemThi,
                        HocLuc = s.HocLuc
                    }).ToList();
                    dgvDiemThi.DataSource = dsDiemThi;

                    // load combobox HocLuc
                    List<string> hocLuc = new List<string> { "","Đạt", "Không đạt", "Hạn chế", "Bình thường", "Khá", "Tốt" };
                    cbxHocLuc.DataSource = hocLuc;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LoadComboBoxKhoaHoc()
        {
            using (var context = new Context())
            {
                var dsLoaiKhoaHoc = context.CourseTypes.Select(s => s.MaLoaiKhoaHoc);
                kryptonComboBox_KhoaHoc.DataSource = dsLoaiKhoaHoc.ToList();

            }
        }

        private void dgvDiemThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvDiemThi.CurrentCell.RowIndex;
                lblMaHocVien.Text = dgvDiemThi.Rows[row].Cells[0].Value.ToString();
                lblTenHocVien.Text = dgvDiemThi.Rows[row].Cells[1].Value.ToString();
                txtDiem.Text = dgvDiemThi.Rows[row].Cells[2].Value.ToString();
               
                if (dgvDiemThi.Rows[row].Cells[3].Value == null)
                    cbxHocLuc.SelectedItem = "";
                else
                    cbxHocLuc.SelectedItem = dgvDiemThi.Rows[row].Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using(var context = new Context())
                {
                    // kiem tra diem co chua dau phay
                    if (txtDiem.Text.ToString().Trim().Contains(',')){
                        MessageBox.Show("Điểm số không được chứa dấu phẩy");
                        return;
                    }

                    int maHocVien = int.Parse(lblMaHocVien.Text.ToString().Trim());
                    var diemThi = context.Marks
                        .Where(s => s.MaLichThi == maLichThi
                            && s.MaHocVien == maHocVien)
                        .FirstOrDefault();
                   // diemThi.HocLuc = cbxHocLuc.SelectedItem.ToString().Trim();
                    diemThi.DiemThi = decimal.Parse(txtDiem.Text.ToString());
                    //  if(Convert.ToInt32(diemThi.DiemThi) <= 990 && )

                    double diemThiThu = Convert.ToDouble(diemThi.DiemThi);
                    //Toeic && ielt 
                    //AVGT

                    if(kryptonComboBox_KhoaHoc.SelectedItem.ToString() == "T4KN" || kryptonComboBox_KhoaHoc.SelectedItem.ToString() == "TND")
                    {
                        if (diemThiThu >= 10)
                        {
                            if (diemThiThu <= 990 && diemThiThu >= 600)
                            {
                                diemThi.HocLuc = "Đạt";
                            }
                            else
                            {
                                diemThi.HocLuc = "Không đạt";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Điểm toeic không bé hơn 10");
                            return;
                        }
                        
                    }
                    if (kryptonComboBox_KhoaHoc.SelectedItem.ToString() == "AVGT")
                    {
                        if (diemThiThu <= 10 && diemThiThu >= 0)
                        {
                            if(diemThiThu >= 0 && diemThiThu < 5)
                            {
                                diemThi.HocLuc = "Hạn chế";
                            }
                            else if (diemThiThu >= 5 && diemThiThu < 6.5)
                            {
                                diemThi.HocLuc = "Bình thường";
                            }
                            else if (diemThiThu >= 6.5 && diemThiThu < 8)
                            {
                                diemThi.HocLuc = "Khá";
                            }
                            else
                            {
                                diemThi.HocLuc = "Tốt";
                            }

                        }
                        else
                        {
                            MessageBox.Show("Điểm AVGT không lớn 10");
                            return;
                        }
                    }
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        { 
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số hoặc dấu chấm không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                MessageBox.Show("Không được nhập chữ hoặc số âm");
                e.Handled = true; // Hủy bỏ ký tự nếu không phải là số hoặc dấu chấm
            }

            // Kiểm tra dấu chấm chỉ được nhập một lần và không được nhập ở vị trí đầu tiên
/*            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.Length == 0))
            {
                e.Handled = true; // Hủy bỏ ký tự nếu đã có dấu chấm hoặc nếu dấu chấm ở vị trí đầu tiên
            }*/


        }

        private void lblTenHocVien_Click(object sender, EventArgs e)
        {

        }
    }
}
