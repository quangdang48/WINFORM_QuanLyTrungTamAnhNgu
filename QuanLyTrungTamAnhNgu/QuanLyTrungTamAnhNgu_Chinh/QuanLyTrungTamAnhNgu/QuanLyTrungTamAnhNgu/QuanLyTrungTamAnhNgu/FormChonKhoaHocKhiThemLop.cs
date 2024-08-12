using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class FormChonKhoaHocKhiThemLop : Form
    {
        Context context;
        FormMain formMain;
        public FormChonKhoaHocKhiThemLop(FormMain formMain)
        {
            context = new Context();
            InitializeComponent();
            this.formMain = formMain;
        }

        private void label1_Click(object sender, EventArgs e)
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
        private void FormChonKhoaHocKhiThemLop_Load(object sender, EventArgs e)
        {
            LoadMaKhoaHocCombobox(context, this.comboBox_KhoaHoc);
            comboBox_KhoaHoc.Text = "";
            toolTip1.SetToolTip(iconButton_BuocTiep, "Tiếp theo");
            toolTip1.SetToolTip(iconButton_Cancel, "Cancel");

            

        }
        public void LoadMaKhoaHocCombobox(Context context,ComboBox comboBox)
        {
            var danhSachMaKhoaHoc = context.Courses.Select(s => s.MaKhoaHoc);
            danhSachMaKhoaHoc.ToList().ForEach(s => comboBox.Items.Add(s));
        }
        public int DemLopCuaKhoaHoc(string maKhoaHoc)
        {
            int count = 0;
            count = context.Classes.Where(s => s.MaKhoaHoc == maKhoaHoc).Count();
            return count;
        }

        private void comboBox_KhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current_maKhoaHoc = comboBox_KhoaHoc.SelectedItem.ToString();
            if(current_maKhoaHoc != "")
            {
                int soLopCuaKhoa = DemLopCuaKhoaHoc(current_maKhoaHoc);
                textBox_SoLopDangMo.Text = soLopCuaKhoa.ToString();
                

                using(var context = new Context())
                {
                    var khoaHoc = context.Courses.Find(current_maKhoaHoc);

                    if(khoaHoc != null)
                    {
                        textBox_GiaTien.Text = khoaHoc.GiaTien+"";
                        textBox_SoBuoiHoc.Text = khoaHoc.SoBuoiHoc + "";
                        textBox_TenKhoaHoc.Text = khoaHoc.TenKhoaHoc;
                    }
                    
                }
            }
            else
            {
                textBox_SoLopDangMo.Text = 0 + "";
            }


        }

        private void iconButton_BuocTiep_Click(object sender, EventArgs e)
        {
            frmThemLopHoc frm = new frmThemLopHoc(comboBox_KhoaHoc.SelectedItem.ToString(),formMain);
            frm.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_SoLopDangMo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là phím điều khiển, hủy bỏ ký tự được nhập vào
                MessageBox.Show("Không được nhập chữ");
                e.Handled = true;
            }
        }

        private void textBox_GiaTien_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là phím điều khiển, hủy bỏ ký tự được nhập vào
                MessageBox.Show("Không được nhập chữ");
                e.Handled = true;
            }
        }

        private void textBox_SoBuoiHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là phím điều khiển, hủy bỏ ký tự được nhập vào
                MessageBox.Show("Không được nhập chữ");
                e.Handled = true;
            }
        }
    }
}
