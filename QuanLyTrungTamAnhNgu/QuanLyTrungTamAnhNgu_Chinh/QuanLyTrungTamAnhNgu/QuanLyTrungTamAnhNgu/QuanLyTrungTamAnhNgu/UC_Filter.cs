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
    public partial class UC_Filter : UserControl
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGiaTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkTenKhoaHoc;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;

        private System.Windows.Forms.CheckedListBox checkedListBoxGiangVien;
        private System.Windows.Forms.Label label4;

        FormMain frm = null;
        List<string> dsLoaiKhoa = new List<string>();
        List<string> dsKhoaHoc = new List<string>();
        List<int> dsGiangVien = new List<int>();

        string text = "";
        public UC_Filter(FormMain frm)
        {
            InitializeComponent();
            this.frm = frm;

        }
        public void LoadData(string text)
        {
            try
            {
                this.text = text;
                KhoiTaoDoiTuongChoKhoaHoc();
                if (text == "Khóa học")
                {
                    // load combobox giaTien 
                    List<Item<int>> lstGiaTien = new List<Item<int>>
                {
                    new Item<int> { Value = 0, Display = "All"},
                    new Item<int> { Value = 1, Display = "0 - 2000K"},
                    new Item<int> { Value = 2, Display = "2000K - 3500K"},
                    new Item<int> { Value = 3, Display = "3500K - 5000K"},
                    new Item<int> { Value = 4, Display = "> 5000K"}
                };
                    cbxGiaTien.DataSource = lstGiaTien;
                    cbxGiaTien.DisplayMember = "Display";
                    cbxGiaTien.ValueMember = "Value";

                    // load check
                    using (var context = new Context())
                    {
                        var dsLoaiKhoa = context.CourseTypes.ToList();
                        dsLoaiKhoa.ForEach(s =>
                        {

                            Item<string> item = new Item<string> { Display = s.TenLoaiKhoaHoc, Value = s.MaLoaiKhoaHoc };
                            checkTenKhoaHoc.Items.Add(item);
                        });
                    }
                    // gan su kien
                    checkTenKhoaHoc.ItemCheck += checkTenKhoaHoc_ItemCheck;
                }
                else if (text == "Lớp học")
                {
                    KhoiTaoDoiTuongChoLopHoc();

                    // load combobox giaTien 
                    List<Item<int>> lstGiaTien = new List<Item<int>>
                {
                    new Item<int> { Value = 0, Display = "All"},
                    new Item<int> { Value = 1, Display = "0 - 2000K"},
                    new Item<int> { Value = 2, Display = "2000K - 3500K"},
                    new Item<int> { Value = 3, Display = "3500K - 5000K"},
                    new Item<int> { Value = 4, Display = "> 5000K"}
                };
                    cbxGiaTien.DataSource = lstGiaTien;
                    cbxGiaTien.DisplayMember = "Display";
                    cbxGiaTien.ValueMember = "Value";
                    // load GiangVien KhoaHoc
                    using (var context = new Context())
                    {
                        var dsGiangVien = context.Lecturers.ToList();
                        checkedListBoxGiangVien.Items.Add(new Item<int> { Value = 0, Display = "All" });
                        dsGiangVien.ForEach(s =>
                        {

                            Item<int> item = new Item<int> 
                            { 
                                Display = s.Ho + " " + s.TenLot + " " + s.Ten,
                                Value = s.MaGiangVien 
                            };
                            checkedListBoxGiangVien.Items.Add(item);
                        });
                        var dsKhoaHoc = context.Courses.ToList();
                        dsKhoaHoc.ForEach(s =>
                        {

                            Item<string> item = new Item<string>
                            {
                                Display = s.TenKhoaHoc,
                                Value = s.MaKhoaHoc
                            };
                            checkTenKhoaHoc.Items.Add(item);
                        });
                    }
                    // gan su kien
                    checkedListBoxGiangVien.ItemCheck += checkedListBoxGiangVien_ItemCheck;
                    checkTenKhoaHoc.ItemCheck += checkTenKhoaHoc_ItemCheck;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        private void KhoiTaoDoiTuongChoKhoaHoc()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGiaTien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkTenKhoaHoc = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giá tiền";
            // 
            // cbxGiaTien
            // 
            this.cbxGiaTien.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold);
            this.cbxGiaTien.FormattingEnabled = true;
            this.cbxGiaTien.Location = new System.Drawing.Point(16, 40);
            this.cbxGiaTien.Name = "cbxGiaTien";
            this.cbxGiaTien.Size = new System.Drawing.Size(178, 33);
            this.cbxGiaTien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại khóa";
            // 
            // checkedListBox1
            // 
            this.checkTenKhoaHoc.FormattingEnabled = true;
            this.checkTenKhoaHoc.Location = new System.Drawing.Point(16, 99);
            this.checkTenKhoaHoc.Name = "checkTenKhoaHoc";
            this.checkTenKhoaHoc.Size = new System.Drawing.Size(178, 89);
            this.checkTenKhoaHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bắt đầu từ ngày:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "dd-MM-yyyy";
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime1.Location = new System.Drawing.Point(17, 222);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(177, 30);
            this.metroDateTime1.TabIndex = 7;
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkTenKhoaHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxGiaTien);
            this.Controls.Add(this.label1);
        }
        private void KhoiTaoDoiTuongChoLopHoc()
        {
            this.checkedListBoxGiangVien = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            // 
            // checkedListBoxGiangVien
            // 
            this.checkedListBoxGiangVien.FormattingEnabled = true;
            this.checkedListBoxGiangVien.Location = new System.Drawing.Point(16, 280);
            this.checkedListBoxGiangVien.Name = "checkedListBoxGiangVien";
            this.checkedListBoxGiangVien.Size = new System.Drawing.Size(178, 89);
            this.checkedListBoxGiangVien.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold);
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giảng viên";
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBoxGiangVien);
            // 
            label2.Text = "Khóa học";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int giaTien = ((Item<int>)cbxGiaTien.SelectedItem).Value;
                DateTime ngay = metroDateTime1.Value.Date;
                 
                if (text == "Khóa học")
                {
                    // loc KhoaHoc
                    using(var context = new Context())
                    {
                        List<Course> dsKhoaHoc = new List<Course>();

                        context.Courses.ToList().ForEach(s =>
                        {
                            if (s.NgayBatDau >= ngay && dsLoaiKhoa.Contains(s.MaLoaiKhoaHoc))
                            {
                                if (giaTien == 1 && s.GiaTien > 0 && s.GiaTien <= 2000000)
                                    dsKhoaHoc.Add(s);
                                else if (giaTien == 2 && s.GiaTien > 2000000 && s.GiaTien <= 3500000)
                                    dsKhoaHoc.Add(s);
                                else if (giaTien == 3 && s.GiaTien > 3500000 && s.GiaTien <= 5000000)
                                    dsKhoaHoc.Add(s);
                                else if (giaTien == 4 && s.GiaTien > 5000000)
                                    dsKhoaHoc.Add(s);
                                else
                                    dsKhoaHoc.Add(s);
                            }
                        });

                        frm.VeKhoaHoc(dsKhoaHoc);
                       
                    }
                }
                else if(text == "Lớp học")
                {
                    
                    // loc LopHo
                    List<Class> dsLopHoc = new List<Class>();
                    using(var context = new Context())
                    {
                        context.Classes.ToList().ForEach(s =>
                        {
                            if(s.NgayBatDau >= ngay && dsKhoaHoc.Contains(s.Course.MaKhoaHoc))
                            {
                                if (dsGiangVien.Contains((int)s.MaGiangVien) || dsGiangVien.Contains(0))
                                {
                                    if (giaTien == 1 && s.Course.GiaTien > 0 && s.Course.GiaTien <= 2000000)
                                        dsLopHoc.Add(s);
                                    else if (giaTien == 2 && s.Course.GiaTien > 2000000 && s.Course.GiaTien <= 3500000)
                                        dsLopHoc.Add(s);
                                    else if (giaTien == 3 && s.Course.GiaTien > 3500000 && s.Course.GiaTien <= 5000000)
                                        dsLopHoc.Add(s);
                                    else if (giaTien == 4 && s.Course.GiaTien > 5000000)
                                        dsLopHoc.Add(s);
                                    else
                                        dsLopHoc.Add(s);
                                }                       
                            }
                        });
                        frm.VeLopHoc(dsLopHoc);
                    }
                }
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void checkTenKhoaHoc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Tạm thời cập nhật trạng thái check mới
            this.BeginInvoke(new Action(() => {
                UpdateSelectedItems();
            }));
        }

        private void UpdateSelectedItems()
        {
            if(text == "Khóa học")
            {
                foreach (Item<string> item in checkTenKhoaHoc.CheckedItems)
                {
                    dsLoaiKhoa.Add(item.Value);
                }
            }
            else if(text == "Lớp học")
            {
                
                foreach (Item<string> item in checkTenKhoaHoc.CheckedItems)
                {
                    dsKhoaHoc.Add(item.Value);
                   
                }
            }
            
        }
        private void checkedListBoxGiangVien_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Tạm thời cập nhật trạng thái check mới
            this.BeginInvoke(new Action(() => {
                UpdateSelectedItemsGiangVien();
            }));
        }

        private void UpdateSelectedItemsGiangVien()
        {
            foreach (Item<int> item in checkedListBoxGiangVien.CheckedItems)
            {
                dsGiangVien.Add(item.Value);
            }
        }

        private void UC_Filter_Load(object sender, EventArgs e)
        {

        }
    }
}
