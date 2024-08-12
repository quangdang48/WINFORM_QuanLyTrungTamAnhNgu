using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyTrungTamAnhNgu
{
    public partial class frmCRUHocVien : KryptonForm
    {
        string type;
        public frmCRUHocVien(string type)
        {
            InitializeComponent();
            this.type = type;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDT.Text.Length < 10 || txtCCCD.Text.Length < 12 || (txtPassword.Text.Trim()).Length == 0
                    || (txtTenDangNhap.Text.Trim()).Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin");
                    return;
                }
                if (Global.Type == "Staff")
                {
                    int maNV = int.Parse(Global.MaUser);
                    string ho = txtHo.Text;
                    string tenLot = txtTenLot.Text;
                    string ten = txtTen.Text;
                    string SDT = txtSDT.Text;
                    string soCCCD = txtCCCD.Text;
                    string maLopHoc = cbxLopHoc.SelectedValue.ToString();


                    double giaTien = 0;
                    double.TryParse(txtGiaTien.Text.ToString().Trim(), out giaTien);
                    /*MessageBox.Show(giaTien.ToString());*/

                    bool trangThaiThanhToan = false;
                    if (checkBoxThanhToan.Checked)
                        trangThaiThanhToan = true;
                    DateTime ngayDangKy = dtpNgayDangKy.Value.Date;
                    using (var scope = new TransactionScope())
                    {
                        using (var context = new Context())
                        {
                            if (context.Logins.Any(s => s.TenDangNhap == txtTenDangNhap.Text.Trim()))
                            {
                                MessageBox.Show("Trùng tên đăng nhập. Vui lòng nhập tên khác.");
                                return;
                            }
                            string sql = "spThemHocVien {0}, {1}, {2}, {3}, {4}," +
                                "{5}, {6}, {7}, {8}, {9}";
                            context.Database.ExecuteSqlCommand(sql, ho, tenLot, ten, SDT,
                                soCCCD, maLopHoc, maNV, ngayDangKy, giaTien, trangThaiThanhToan);
                            // them tai khoan
                            var login = new Login
                            {
                                MaUser = context.Students.OrderByDescending(s => s.MaHocVien)
                                    .FirstOrDefault().MaHocVien,
                                TenDangNhap = txtTenDangNhap.Text.Trim(),
                                Password = txtPassword.Text.Trim(),
                                Type = "Student"
                            };

                            context.Logins.Add(login);
                            context.SaveChanges();

                            scope.Complete();
                        }
                        MessageBox.Show("Đăng ký thành công!");

                        this.Close();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        private void cbxKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoaHoc = cbxKhoaHoc.SelectedValue.ToString();
            LoadLopHoc(maKhoaHoc);
            using(var context = new Context())
            {
                lblNgay.Text = "Ngày: " + context.Courses
                    .Where(s => s.MaKhoaHoc == maKhoaHoc)
                    .Select(s => s.NgayBatDau.ToString().Trim() +
                        " - " + s.NgayKetThuc.ToString())
                      .FirstOrDefault();
                txtGiaTien.Text = context.Courses
                        .Where(s => s.MaKhoaHoc == maKhoaHoc)
                        .Select(s => s.GiaTien.ToString())
                        .FirstOrDefault();
            }
            checkBoxThanhToan.CheckStateChanged += checkBoxThanhToan_CheckedChanged;
             
        }
        private void LoadLopHoc(string maKhoaHoc)
        {
            using (var context = new Context())
            {
                var lopHoc = context.Classes.Where(s => s.MaKhoaHoc == maKhoaHoc)
                    .Select(s => new { MaLopHoc = s.MaLopHoc, s.MaKhoaHoc, s.MaPhong, s.TenLop,
                        s.TimeTables, s.Lecturer, s.Registers, display = s.MaKhoaHoc.Trim() + " - " + s.TenLop })
                    .ToList();

                cbxLopHoc.DataSource = lopHoc;
                cbxLopHoc.DisplayMember = "display";
                cbxLopHoc.ValueMember = "MaLopHoc";
               
            }
        }
        
        private void frmCRUHocVien_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnHuy, "Cancel");
            toolTip1.SetToolTip(btnLuu, "Save");
            try
            {
                using(var context = new Context())
                {
                    // load combobox KhoaHoc
                    var khoaHoc = context.Courses
                            .Select(s => new { MaKhoaHoc = s.MaKhoaHoc, s.TenKhoaHoc, s.NgayBatDau, 
                                s.NgayKetThuc, display = s.MaKhoaHoc.Trim() + " - " + s.TenKhoaHoc }).ToList();
                    cbxKhoaHoc.DataSource = khoaHoc;
                    cbxKhoaHoc.DisplayMember = "display";
                    cbxKhoaHoc.ValueMember = "MaKhoaHoc";
                    // load lop hoc
                    cbxLopHoc.DataSource = context.Classes
                    .Select(s => new {
                        s.MaLopHoc,
                        s.MaKhoaHoc,
                        s.MaPhong,
                        s.TenLop,
                        s.TimeTables,
                        s.Lecturer,
                        s.Registers,
                        display = s.MaKhoaHoc.Trim() + " - " + s.TenLop
                    })
                    .ToList();
                    cbxLopHoc.DisplayMember = "display";
                    cbxLopHoc.ValueMember = "MaLopHoc";
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbxLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new Context())
            {

                string maLop = cbxLopHoc.SelectedValue.ToString().Trim();

                var lopHoc = context.Classes.Where(s => s.MaLopHoc == maLop).FirstOrDefault();
                lblGiangVien.Text = lopHoc.Lecturer.Ho + " " + lopHoc.Lecturer.TenLot + " " + lopHoc.Lecturer.Ten;
                lblPhong.Text = lopHoc.MaPhong;
                lblSiso.Text = "Sỉ số: " + lopHoc.Registers.Count().ToString();
                // lich hoc

            }
        }

        private void checkBoxThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxThanhToan.Checked)
            {
                lblTienThanhToan.Visible = true;
                txtGiaTien.Visible = true;
                using (var context = new Context())
                {
                    string maKhoaHoc = cbxKhoaHoc.SelectedValue.ToString().Trim();
                    
                    txtGiaTien.Text = context.Courses
                        .Where(s => s.MaKhoaHoc == maKhoaHoc)
                        .Select(s => s.GiaTien.ToString())
                        .FirstOrDefault();
                }
            }
            else
            {
                lblTienThanhToan.Visible = false;
                txtGiaTien.Visible = false;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Số lượng ký tự tối đa được nhập vào TextBox
            int maxLength = 10; // Đổi thành số lượng ký tự tối đa mong muốn
        
            // Kiểm tra xem TextBox đã đạt đến giới hạn ký tự chưa
            if (txtSDT.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                // Nếu đã đạt đến giới hạn và ký tự không phải là phím Backspace, hủy bỏ ký tự được nhập vào
                e.Handled = true;
                return;
            }

            // Kiểm tra xem ký tự đã nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là phím điều khiển, hủy bỏ ký tự được nhập vào
                MessageBox.Show("Không được nhập chữ");
                e.Handled = true;
            }
            
        }

        private void textBoxSoCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Số lượng ký tự tối đa được nhập vào TextBox
            int maxLength = 12; // Đổi thành số lượng ký tự tối đa mong muốn
            
            // Kiểm tra xem TextBox đã đạt đến giới hạn ký tự chưa
            if (txtCCCD.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                // Nếu đã đạt đến giới hạn và ký tự không phải là phím Backspace, hủy bỏ ký tự được nhập vào
                e.Handled = true;
                return;
            }

            // Kiểm tra xem ký tự đã nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là phím điều khiển, hủy bỏ ký tự được nhập vào
                MessageBox.Show("Không được nhập chữ");
                e.Handled = true;
            }
            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số không
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Không được nhập số");
                // Hủy bỏ ký tự được nhập vào
                e.Handled = true;
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void frmCRUHocVien_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            // neu nhap chua du chu so
            if (txtSDT.Text.Length < 10)
            {
                this.txtSDT.StateCommon.Border.Color1 = System.Drawing.Color.Red;
                this.txtSDT.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            }
            else
            {
                this.txtSDT.StateCommon.Border.Color1 = System.Drawing.Color.Black;
                this.txtSDT.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            // neu nhap chua du chu so
            if (txtCCCD.Text.Length < 12)
            {
                this.txtCCCD.StateCommon.Border.Color1 = System.Drawing.Color.Red;
                this.txtCCCD.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            }
            else
            {
                this.txtCCCD.StateCommon.Border.Color1 = System.Drawing.Color.Black;
                this.txtCCCD.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if ((txtTenDangNhap.Text.Trim()).Length == 0 )
            {
                this.txtTenDangNhap.StateCommon.Border.Color1 = System.Drawing.Color.Red;
                this.txtTenDangNhap.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            }
            else
            {
                this.txtTenDangNhap.StateCommon.Border.Color1 = System.Drawing.Color.Black;
                this.txtTenDangNhap.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtPassword.Text.Trim()).Length == 0)
            {
                this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.Red;
                this.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            }
            else
            {
                this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.Black;
                this.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            }
        }
    }
}
