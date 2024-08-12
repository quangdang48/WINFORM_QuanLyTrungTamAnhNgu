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
    public partial class UCDays : UserControl
    {
        public UCDays()
        {
            InitializeComponent();
            
        }

        private void UCDays_Load(object sender, EventArgs e)
        {
            CustomScrollBarInPanel(panelCaHoc);
        }
        public void days(int numday)
        {
            lblDays.Text = numday.ToString();
        }

        private void panelCaHoc_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void CustomScrollBarInPanel(Panel panel)
        {
            //Hide Scroll Bar
            panel.AutoScroll = false;
            panel.VerticalScroll.Maximum = 0;
            panel.VerticalScroll.Visible = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.HorizontalScroll.Visible = false;
            panel.AutoScroll = true;
        }
    }
}
