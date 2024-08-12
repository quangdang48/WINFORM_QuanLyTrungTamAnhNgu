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
    public partial class UC_MenuHV : UserControl
    {
        FormMain frm = null;
        public UC_MenuHV(FormMain frm)
        {
            InitializeComponent();
            this.frm = frm;
            RegisterMouseClickEvent(this);
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
            if (frm.listItemSearch != null)
                frm.listItemSearch.ForEach(s => s.BackColor = System.Drawing.Color.White);

            // Bubbling sự kiện ngược lại để không ảnh hưởng đến các hành vi khác
            ((Control)sender).Focus();
        }
    }
}
