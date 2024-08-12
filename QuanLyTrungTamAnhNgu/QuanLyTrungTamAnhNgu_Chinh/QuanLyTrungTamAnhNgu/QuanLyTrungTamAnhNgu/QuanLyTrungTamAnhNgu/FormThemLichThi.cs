using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class FormThemLichThi : Form
    {
        FormMain formMain;
        public FormThemLichThi(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void FormThemLichThi_Load(object sender, EventArgs e)
        {
            LoadMaKhoaHoc();
        }
        public void LoadMaKhoaHoc()
        {
            textBox_MaLichThi.Text = LayMaLichThiTiepTheo() + "";
            using(var context = new Context())
            {
                comboBox_MaKhoaHoc.DataSource = context.Courses.Select(s => s.MaKhoaHoc).ToList();
            }
        }

        private void checkedListBox_LopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_MaKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                string maKhoaHoc = comboBox_MaKhoaHoc.SelectedItem as string;
                var khoaHoc = context.Courses.Find(maKhoaHoc);

                var listClass = khoaHoc.Classes
                    .Select(s => new Item<string> { Value = s.MaLopHoc, Display = s.TenLop });


                checkedListBox_LopHoc.DataSource = listClass.ToList();
                checkedListBox_LopHoc.DisplayMember = "Display";
                checkedListBox_LopHoc.ValueMember = "Value";
            }
        }
        public int LayMaLichThiTiepTheo()
        {
            int maLichThi = 1; 
            using (var context = new Context())
            {
                var dsMaLichThi = context.ExamSchedules.FirstOrDefault();
                if(dsMaLichThi != null)
                {
                    int maxCurrentMaLichThi = context.ExamSchedules.Max(s => s.MaLichThi);
                    maLichThi = maxCurrentMaLichThi + 1;
                }
               
            }
            return maLichThi;
        }

        private void iconButton_Save_Click(object sender, EventArgs e)
        {
            DateTime thoiDiemThi = dateTimePicker_ThoiDiem.Value;
            if (thoiDiemThi > DateTime.Now)
            {
                try
                {
                    string tenDotThi = txt_DotThi.Text;
                    ExamSchedule lichThi = new ExamSchedule
                    {
                        TenDotThi = tenDotThi,
                        ThoiDiemThi = thoiDiemThi
                    };
                    using (var context = new Context())
                    {
                        context.ExamSchedules.Add(lichThi);
                        context.SaveChanges();

                        foreach (var selectedItem in checkedListBox_LopHoc.CheckedItems)
                        {
                            string maLop = ((Item<String>)selectedItem).Value;
                            ExamSchedule lichThiMoiNhat = context.ExamSchedules.OrderByDescending(s => s.MaLichThi).First();
                            int maLichThi = lichThiMoiNhat.MaLichThi;

                            ExamScheduleDetail chiTietLichThi = new ExamScheduleDetail
                            {
                                MaLichThi = maLichThi,
                                MaLopHoc = maLop
                            };

                            context.ExamScheduleDetails.Add(chiTietLichThi);
                            context.SaveChanges();
                        }
                        formMain.LoadThiThu();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Thời điểm mở lớp không đúng");
            }
           
        }

        private void iconButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
