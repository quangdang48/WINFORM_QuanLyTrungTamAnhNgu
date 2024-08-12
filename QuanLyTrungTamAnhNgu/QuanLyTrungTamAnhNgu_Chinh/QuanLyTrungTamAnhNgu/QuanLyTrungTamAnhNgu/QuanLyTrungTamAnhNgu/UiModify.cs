using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyTrungTamAnhNgu
{
    public static class UiModify
    {
        public static void FitDgvToGroupBox(KryptonDataGridView kdgv, KryptonGroup groupBox)
        {
            int availableWidth = groupBox.Width;

            kdgv.Size = new Size(availableWidth, kdgv.Size.Height);
            kdgv.RowHeadersVisible = false;
            kdgv.ClearSelection();

            int totalColumnWidths = 0;
            foreach (DataGridViewColumn column in kdgv.Columns)
            {
                totalColumnWidths += column.Width;
            }

            if(totalColumnWidths <= availableWidth)
            {
                float scalingFactor = (float)availableWidth / totalColumnWidths;

                foreach (DataGridViewColumn column in kdgv.Columns)
                {
                    column.Width = (int)(column.Width * scalingFactor);
                }

            }


            kdgv.CellClick += (sender, e) =>
            {
                // Check if the clicked cell is valid and not in the header row
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Select the entire row
                    kdgv.Rows[e.RowIndex].Selected = true;
                }
            };
        }

        // Load form to panel 
        public static void  LoadFormToPanel(Form form, Panel panel)
        {
            if (form == null || form.IsDisposed)
            {
                CloseAllForms(panel);
                return;
            }
            CloseAllForms(panel);

            form.TopLevel = false;
            form.Size = panel.ClientSize;

            form.FormClosed += (object sender, FormClosedEventArgs e) =>
            {
                form = null;
            };

            panel.Controls.Add(form);

            form.Show();
        }

        // Clear all form in panel 
        public static void CloseAllForms(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is Form form)
                {
                    form.Close();
                }
            }
        }
    }
}
