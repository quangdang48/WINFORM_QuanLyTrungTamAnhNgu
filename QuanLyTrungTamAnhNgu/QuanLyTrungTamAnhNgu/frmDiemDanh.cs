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
    public partial class frmDiemDanh : Form
    {
        private List<Class> lophoc = null;
        private List<DiemDanh> dsDiemdanh = null;
        private Context conext = null;
        public frmDiemDanh()
        {
            InitializeComponent();
            lophoc = new List<Class>();
            dsDiemdanh = new List<DiemDanh>();
            conext = new Context();
        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
        {
            LoadData();
            toolTip1.SetToolTip(btnLuu, "Save");
        }
        private void LoadData()
        {
            try
            {
                using (var context = new Context())
                {
                    // load lop hoc
                    lophoc = context.Classes.ToList();
                    cbxLopHoc.DataSource = lophoc;
                    cbxLopHoc.DisplayMember = "TenLop";
                    cbxLopHoc.ValueMember = "MaLopHoc";

                    // load ngay hoc
                    var ngayHoc = context.TimeTables
                        .Select(s => s.NgayHoc.Value)
                        .Distinct().ToList();
                    cbxNgayHoc.DataSource = ngayHoc;
                    

                    // load datagridview 
                    dsDiemdanh = context.Attendances.Select(s => new DiemDanh
                    {
                        MaDiemDanh = s.MaSoDiemDanh,
                        MaLopHoc = s.MaLopHoc,
                        NgayHoc = (DateTime)s.NgayDiemDanh,
                        MaHocVien = (int)s.MaHocVien,
                        TenHocVien = s.Student.Ho + " " + s.Student.TenLot + " " + s.Student.Ten,
                        TrangThai = (bool)s.Trangthai
                    }).ToList();
                    
                    dgvDsDiemDanh.DataSource = dsDiemdanh;
                    dgvDsDiemDanh.Columns[1].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LoadDataGridView(string maLop, DateTime ngayHoc)
        {
            try
            {
                using(var context = new Context())
                {
                    // load datagridview 
                    dsDiemdanh = context.Attendances.Where(s => s.MaLopHoc == maLop && s.NgayDiemDanh == ngayHoc)
                        .Select(s => new DiemDanh
                        {
                        MaDiemDanh = s.MaSoDiemDanh,
                        MaLopHoc = s.MaLopHoc,
                        NgayHoc = (DateTime)s.NgayDiemDanh,
                        MaHocVien = (int)s.MaHocVien,
                        TenHocVien = s.Student.Ho + " " + s.Student.TenLot + " " + s.Student.Ten,
                        TrangThai = (bool)s.Trangthai
                        }).ToList();

                    dgvDsDiemDanh.DataSource = dsDiemdanh;
                    dgvDsDiemDanh.Columns[1].Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "  + ex.Message);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maLopHoc = cbxLopHoc.SelectedValue.ToString();
                DateTime ngayHoc = Convert.ToDateTime(cbxNgayHoc.SelectedItem);
                
                // MessageBox.Show(maLopHoc + " " + ngayHoc.ToString());
                LoadDataGridView(maLopHoc, ngayHoc);
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
                conext.SaveChanges();
                MessageBox.Show("Cập nhật điểm danh thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }



        private void dgvDsDiemDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // cap nhat trang thai
                dgvDsDiemDanh.CommitEdit(DataGridViewDataErrorContexts.Commit);
                int maDiemDanh = (int)dgvDsDiemDanh.Rows[e.RowIndex].Cells[0].Value;
                bool trangThai = (bool) dgvDsDiemDanh.Rows[e.RowIndex].Cells[5].Value;
                
                var capnhatDD = conext.Attendances.Find(maDiemDanh);
                capnhatDD.Trangthai = trangThai;
                // MessageBox.Show(maDiemDanh + " " + trangThai);
            }
        }
    }
    public class DiemDanh
    {
        public int MaDiemDanh {get; set; }
        public string MaLopHoc { get; set; }
        public DateTime NgayHoc { get; set; }
        public int MaHocVien { get; set; }
        public string TenHocVien { get; set; }
        public bool TrangThai { get; set; }
    }
}
