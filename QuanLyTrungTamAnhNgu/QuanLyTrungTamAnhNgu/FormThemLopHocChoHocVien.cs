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
    public partial class FormThemLopHocChoHocVien : Form
    {
        int maHocVien = 0; 
        public FormThemLopHocChoHocVien(int maHocVien)
        {
            InitializeComponent();
            this.maHocVien = maHocVien;
        }

        private void FormThemLopHocChoHocVien_Load(object sender, EventArgs e)
        {
            LoadMaLopHocHocVienCoTheDangKy(maHocVien);
            dateTimePicker_NgayDangKy.Value = DateTime.Now;
        }
        public void LoadMaLopHocHocVienCoTheDangKy(int maHocVien)
        {
            using(var context = new Context())
            {
                var dsLopHocHocVienDaDangKy = context.Registers.Where(s => s.MaHocVien == maHocVien).Select(s => s.MaLopHoc).ToList();
                var dsLopHocVienCoTheDangKy = context.Classes.Where(s => dsLopHocHocVienDaDangKy.Contains(s.MaLopHoc) == false).Select(s => s.MaLopHoc).ToList();
                comboBox_MaLopHoc.DataSource = dsLopHocVienCoTheDangKy;
            }
        }

        private void comboBox_MaLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLophoc = comboBox_MaLopHoc.SelectedItem as string;
            using (var context = new Context())
            {
                string tenGiangVien = context.Classes.Find(maLophoc).Lecturer.Ho + " " + context.Classes.Find(maLophoc).Lecturer.TenLot + " " + context.Classes.Find(maLophoc).Lecturer.Ten;
                txt_GiangVien.Text = tenGiangVien;
                textBox_TenLopHoc.Text = context.Classes.Find(maLophoc).TenLop;
            }
        }

        private void iconButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLopHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                Register dangKy = new Register
                {
                    MaHocVien = maHocVien,
                    MaLopHoc = comboBox_MaLopHoc.Text,
                    ThoiDiemDangKy = dateTimePicker_NgayDangKy.Value
                };
                using (var context = new Context())
                {
                    context.Registers.Add(dangKy);
                    context.SaveChanges();
                }
                MessageBox.Show("Thêm thành công");
                LoadMaLopHocHocVienCoTheDangKy(maHocVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
