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
    public partial class frmThongTinCaHoc : Form
    {
        public frmThongTinCaHoc(string txt)
        {
            InitializeComponent();
            this.lblDays.Text = txt;
        }

        private void lblDays_Click(object sender, EventArgs e)
        {

        }
    }
}
