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
    public partial class UC_Homecs : UserControl
    {
        public UC_Homecs(string content)
        {
            InitializeComponent();
            this.button.Text = content;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
