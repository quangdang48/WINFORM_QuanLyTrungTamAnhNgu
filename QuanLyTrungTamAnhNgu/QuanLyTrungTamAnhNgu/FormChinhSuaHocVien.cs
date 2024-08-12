using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace QuanLyTrungTamAnhNgu
{
    public partial class FormChinhSuaHocVien : KryptonForm
    {
        FormMain formMain;

        string ten = "";
        string tenLot = "";
        string ho = "";
        string soCCCD = "";
        string soDT = "";
    
        string tenDangNhap = "";
        string passWord = "";
        string maHocVien = "";
        Student current_student = null;
        public FormChinhSuaHocVien(FormMain formMain,Student student)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.current_student = student;
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
        private void iconButton1_Click(object sender, EventArgs e)
        {

            try
            {
                ten = txtTen.Text;
                tenLot = txtTenLot.Text;
                ho = txtHo.Text;
                soCCCD = textBoxSoCCCD.Text;
                soDT = textBox_SDT.Text; 
                    
                

                tenDangNhap = txt_TenDangNhap.Text;
                passWord = txt_Password.Text;
                using (var context = new Context())
                {
                    current_student.Ho = ho;
                    current_student.TenLot = tenLot;
                    current_student.Ten = ten;
                    current_student.SoCCCD = soCCCD;
                    current_student.SoDienThoai = soDT;
                    context.SaveChanges();
                    var login = context.Logins.Where(s => s.MaUser == current_student.MaHocVien && s.Type == "Student").FirstOrDefault();
                    login.TenDangNhap = tenDangNhap;
                    login.Password = passWord;
                    context.SaveChanges();
                    formMain.LoadHocVien();
                    MessageBox.Show("Đã cập nhạt thành công");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChinhSuaHocVien_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(iconButton_Cancel, "Cancel");
            toolTip1.SetToolTip(btn_Update, "Update");
        }

        private void textBox_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Số lượng ký tự tối đa được nhập vào TextBox
            int maxLength = 10; // Đổi thành số lượng ký tự tối đa mong muốn

            // Kiểm tra xem TextBox đã đạt đến giới hạn ký tự chưa
            if (textBox_SDT.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
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
            if (textBoxSoCCCD.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
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
            // Kiểm tra xem ký tự đã nhập có phải là chữ cái không
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Không được nhập số");
                // Nếu không phải là chữ cái và không phải là phím điều khiển (như Enter, Backspace, Delete), hủy bỏ ký tự được nhập vào
                e.Handled = true;
            }
        }

        private void iconButton_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
