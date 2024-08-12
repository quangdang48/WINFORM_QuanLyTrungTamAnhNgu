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
    public partial class UC_ThanhChucNang : UserControl
    {
        string type = "";
        FormMain frm = null;

        public UC_ThanhChucNang(string type, FormMain frm)
        {
            InitializeComponent();
            this.type = type;
            this.frm = frm;
            RegisterMouseClickEvent(this);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(type == "KhoaHoc")
            {

            }
            else if(type == "HocVien")
            {
                frmCRUHocVien frm = new frmCRUHocVien("Them");
                frm.ShowDialog();

            }
        }

        private void UC_ThanhChucNang_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnThem, "Thêm");
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frm.listItemSearch != null)
                    frm.listItemSearch.ForEach(s => s.BackColor = System.Drawing.Color.White);

                frm.panel_Button.Controls.Add(frm.lxbSearch);
                frm.lxbSearch.Visible = true;
                frm.lxbSearch.BringToFront();


                string textSearch = txtSeach.Text.Trim();

                using (var context = new Context())
                {
                    var listSearch = context.Students
                        .Select(s => new Item<int> { Value = s.MaHocVien, Display = s.Ho + " " + s.TenLot + " " + s.Ten })
                        .Where(s => s.Display.Contains(textSearch)).ToList();

                    frm.lxbSearch.DataSource = listSearch;
                    frm.lxbSearch.DisplayMember = "Display";
                    frm.lxbSearch.ValueMember = "Value";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
           
        }

        private void RegisterMouseClickEvent(Control control)
        {
            control.MouseClick += Control_MouseClick;
            foreach (Control subControl in control.Controls)
            {
                RegisterMouseClickEvent(subControl);
            }

        }
        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender != frm.lxbSearch)
            {
                frm.lxbSearch.Visible = false;
                
              
                
            }
            // doi mau UC_HocVien
            if (frm.listItemSearch != null)
                frm.listItemSearch.ForEach(s => s.BackColor = System.Drawing.Color.White);

            // Bubbling sự kiện ngược lại để không ảnh hưởng đến các hành vi khác
            ((Control)sender).Focus();
        }

       
        
    }
    public class Item<T>
    {
        public T Value { get; set; }
        public string Display { get; set; }
        public override string ToString()
        {
            return Display;
        }
    }
}
