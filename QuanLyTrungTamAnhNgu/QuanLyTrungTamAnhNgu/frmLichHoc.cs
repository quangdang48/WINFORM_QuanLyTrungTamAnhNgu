using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu
{
    public partial class frmLichHoc : Form
    {
        private int month, year;
        private List<LichHoc> lichHoc = null;
        // taoToolTip
        // private ToolTip toolTip = new ToolTip();

        public frmLichHoc()
        {
            InitializeComponent();
            lichHoc = new List<LichHoc>();
        }


        private void frmLichHoc_Load(object sender, EventArgs e)
        {
            // set tool tip
            toolTip.SetToolTip(this.btnPrev, "Previous month");
            toolTip.SetToolTip(this.btnNext, "Next month");

            // lay du lieu danh sach lich hoc
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            if (Global.Type == "Student")
            {
                using (var context = new Context())
                {
                    int maHV = int.Parse(Global.MaUser);
                    var lopHoc = context.Registers
                        .Where(s => s.MaHocVien == maHV)
                        .Select(s => s.MaLopHoc).ToList();

                    lichHoc = context.TimeTables
                        .Where(s => lopHoc.Contains(s.MaLopHoc))
                        .Select(s => new LichHoc
                        {
                            MaLichHoc = s.MaLichHoc,
                            MaLopHoc = s.MaLopHoc,
                            NgayHoc = (DateTime)s.NgayHoc,
                            CaHoc = s.Shifts,
                            PhongHoc = s.Class.MaPhong
                        }).ToList();
                }

            }
            else if (Global.Type == "Staff")
            {
                using (var context = new Context())
                {
                    lichHoc = context.TimeTables
                        .Select(s => new LichHoc
                        {
                            MaLichHoc = s.MaLichHoc,
                            MaLopHoc = s.MaLopHoc,
                            NgayHoc = (DateTime)s.NgayHoc,
                            CaHoc = s.Shifts,
                            PhongHoc = s.Class.MaPhong
                        }).ToList();
                }
            }

            LoadLichHoc();

        }
        private void LoadLichHoc()
        {
            try
            {
            panelLich.Controls.Clear();

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = monthName + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);


            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));
            for (int i = 1; i <= dayOfWeek; i++)
            {
                UCBlank ucBlank = new UCBlank();
                panelLich.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UCDays ucdays = new UCDays();
                ucdays.days(i);
                DateTime date = new DateTime(year, month, i);
                if (date == DateTime.Now.Date)
                    ucdays.BackColor = System.Drawing.Color.FromArgb(202, 231, 255);

                if (lichHoc.Any(s => s.NgayHoc == date))
                {

                    var chiTietLichHoc = lichHoc.Where(s => s.NgayHoc == date)
                        .Select(s => new
                        {
                            MaLopHoc = s.MaLopHoc,
                            CaHoc = s.CaHoc,
                            PhongHoc = s.PhongHoc
                        }).ToList();

                    chiTietLichHoc.ForEach(p =>
                    {
                        string phong = "";
                        if (p.PhongHoc != null)
                            phong = p.PhongHoc.Trim();
                        string textToopTip = "Lớp: " + p.MaLopHoc.Trim() + "\n" + "Phòng: " + phong;

                        List<string> times = new List<string>();
                        int prev = -1;
                        int current = 0;
                        string gioBatDau = "";
                        string gioKetThuc = "";
                        int count = p.CaHoc.Count();

                        p.CaHoc.OrderBy(s => s.MaCaHoc).ToList().ForEach(s =>
                        {
                            if (s.GioBatDau.HasValue && s.GioKetThuc.HasValue)
                            {
                                count--;
                                current = s.MaCaHoc;
                                if (prev == -1)
                                {
                                    gioBatDau = String.Format("{0:hh\\:mm}", s.GioBatDau);
                                    prev = current - 1;
                                }
                                if ((prev + 1) == current)
                                {
                                    gioKetThuc = String.Format("{0:hh\\:mm}", s.GioKetThuc);
                                    
                                }
                                else
                                {
                                    times.Add(gioBatDau + " - " + gioKetThuc);
                                    gioBatDau = String.Format("{0:hh\\:mm}", s.GioBatDau);
                                    gioKetThuc = String.Format("{0:hh\\:mm}", s.GioKetThuc);
                                }
                                if (count == 0)
                                    times.Add(gioBatDau + " - " + gioKetThuc);
                                prev = current;

                            }

                        });
                        times.ForEach(h => VeCaHoc(ucdays, h.ToString(), textToopTip));
                    });

                }

                panelLich.Controls.Add(ucdays);

            }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }
        private void VeCaHoc(UCDays ucdays, string time, string maLopHoc)
        {
            // tao txtCaHoc
            ComponentFactory.Krypton.Toolkit.KryptonTextBox
            txtCaHoc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();

            txtCaHoc.Multiline = true;
            txtCaHoc.Name = "txtCaHoc";
            txtCaHoc.Size = new System.Drawing.Size(90, 20);
            txtCaHoc.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(26)))));
            txtCaHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            txtCaHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            txtCaHoc.StateCommon.Border.Rounding = 8;
            txtCaHoc.StateCommon.Border.Width = 2;
            txtCaHoc.StateCommon.Content.Color1 = System.Drawing.Color.White;
            txtCaHoc.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCaHoc.TabIndex = 6;
            txtCaHoc.Text = time.Trim();
            txtCaHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtCaHoc.Enabled = true;
            txtCaHoc.ReadOnly = true;
            txtCaHoc.Cursor = Cursors.Hand;


           
            frmThongTinCaHoc frm = new frmThongTinCaHoc(maLopHoc);
            txtCaHoc.MouseDown += (sender, e) => HienText(maLopHoc, frm);


            ucdays.panelCaHoc.Controls.Add(txtCaHoc);


        }

        private void HienText(string maLopHoc, frmThongTinCaHoc frm)
        {

            panelThongTinCaHoc.Controls.Clear();
            frm.TopLevel = false; // cho phep form duoc nhung
            frm.Dock = DockStyle.Fill;
            panelThongTinCaHoc.Controls.Add(frm);
            frm.Show();
            
        }

        private void panelLich_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
                month--;

            LoadLichHoc();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
                month++;
            LoadLichHoc();
        }
    }
    public class LichHoc
    {
        public int MaLichHoc { get; set; }
        public string MaLopHoc { get; set; }
        public DateTime NgayHoc { get; set; }
        public ICollection<Shift> CaHoc { get; set; }
        public string PhongHoc { get; set; }
    }
}
