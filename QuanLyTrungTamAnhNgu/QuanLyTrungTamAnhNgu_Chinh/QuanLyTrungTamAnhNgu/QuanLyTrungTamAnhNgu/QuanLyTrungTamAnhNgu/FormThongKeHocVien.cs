using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyTrungTamAnhNgu
{
    public partial class FormThongKeHocVien : Form
    {
        public FormThongKeHocVien()
        {
            InitializeComponent();

        }
       /* public void LoadChart()
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
            series1.Points.AddXY("Số lớp học viên đã đăng ký", demSoLopaHocVienDaDangKy(maHocVien));
            series1.IsValueShownAsLabel = true;


            chart1.Series.Add(series1);

        }*/
        public int demSoLopaHocVienDaDangKy(int maHocVien)
        {
            int soLop = 0;
            using(var context = new Context())
            {
                soLop = context.Registers.Where(s => s.MaHocVien == maHocVien).Count();
            }

            return soLop;
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThongKeHocVien_Load(object sender, EventArgs e)
        {

        }
    }
}
