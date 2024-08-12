using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyTrungTamAnhNgu
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnOke, "Xem thống kê");
            LoadChart();

            // load combobox Quy
            List<Item<int>> listQuy = new List<Item<int>>();
            listQuy.AddRange(new List<Item<int>>
            {
                new Item<int> { Display = "Qúy 1", Value = 1 },
                new Item<int> { Display = "Qúy 2", Value = 2 },
                new Item<int> { Display = "Qúy 3", Value = 3 },
                new Item<int> { Display = "Qúy 4", Value = 4 }
            });
            cbxQuy.DataSource = listQuy;
            cbxQuy.DisplayMember = "Display";
            cbxQuy.ValueMember = "Value";
            txtNam.Text = (DateTime.Now.Year).ToString();
            int thangHT = DateTime.Now.Month;
            if (thangHT <= 3)
                cbxQuy.SelectedIndex = 0;
            else if(thangHT <= 6)
                cbxQuy.SelectedIndex = 1;
            else if (thangHT <= 9)
                cbxQuy.SelectedIndex = 2;
            else
                cbxQuy.SelectedIndex = 3;
            btnOke_Click(new object(), new EventArgs());
        }
        public int demSoKhoaHoc()
        {
            int count = 0; 
            using(var context = new Context())
            {
                count = context.Courses.Count();
            }
            return count;
        }
        public int demSoLopHoc()
        {
            int count = 0;
            using (var context = new Context())
            {
                count = context.Classes.Count();
            }
            return count;
        }
        public int demSoHocVien()
        {
            int count = 0;
            using (var context = new Context())
            {
                count = context.Students.Count();
            }
            return count;
        }
        public double TongDoanhThu(int nam, int quy)
        {
            try
            {
                double tongDoanhThu = 0;
                DateTime ngayBD = new DateTime();
                DateTime ngayKT = new DateTime();
                if(quy == 1)
                {
                    ngayBD = new DateTime(nam, 1, 1);
                    ngayKT = new DateTime(nam, 3, 31);
                }
                else if(quy == 2)
                {
                    ngayBD = new DateTime(nam, 4, 1);
                    ngayKT = new DateTime(nam, 6, 30);
                }
                else if(quy == 3)
                {
                    ngayBD = new DateTime(nam, 7, 1);
                    ngayKT = new DateTime(nam, 9, 30);
                }
                else if(quy == 4)
                {
                    ngayBD = new DateTime(nam, 10, 1);
                    ngayKT = new DateTime(nam, 12, 31);
                }
                using(var context = new Context())
                {
                    var listBienLai = context.Registers
                        .Where(s => s.ThoiDiemDangKy <= ngayKT && s.ThoiDiemDangKy >= ngayBD)
                        .SelectMany(s => s.Receipts).ToList();
                    tongDoanhThu = (double)listBienLai.Where(s => s.TrangThaiThanhToan == true)
                        .Sum(s => s.GiaTien);
                }
                return tongDoanhThu;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return 0;
            }

        }
        public void LoadChart()
        {
            // Kiểm tra và loại bỏ Series1 nếu đã tồn tại
            if (chart1.Series.IndexOf("Series1") != -1)
            {
                chart1.Series.Remove(chart1.Series["Series1"]);
            }

            // Tạo một ChartArea mới
            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);
            
            // Series cho biểu đồ bánh
            Series series1 = new Series("Thống kê về trung tâm");
           // series1.ChartType = SeriesChartType.Area; // Chọn loại biểu đồ bánh
            series1.Points.AddXY("Số khóa học đã mở", demSoKhoaHoc());
            series1.Points.AddXY("Số lớp học đã mở", demSoLopHoc());
            series1.Points.AddXY("Số học viên đã học", demSoHocVien());
            series1.IsValueShownAsLabel = true;


            chart1.Series.Add(series1);

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            try
            {
                int quy = ((Item<int>)cbxQuy.SelectedItem).Value;
                int nam = int.Parse(txtNam.Text.Trim().ToString());
                if (nam > 0)
                    lbDoanhThu.Text = TongDoanhThu(nam, quy).ToString("N2") + " VND";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đã nhập có phải là số không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là phím điều khiển, hủy bỏ ký tự được nhập vào
                MessageBox.Show("Chỉ được nhập ký tự số");
                e.Handled = true;
            }
        }
    }
}
