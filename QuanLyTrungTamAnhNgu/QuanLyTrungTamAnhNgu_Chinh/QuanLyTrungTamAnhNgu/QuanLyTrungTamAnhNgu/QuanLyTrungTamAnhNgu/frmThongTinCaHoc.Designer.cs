
namespace QuanLyTrungTamAnhNgu
{
    partial class frmThongTinCaHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.BackColor = System.Drawing.Color.Transparent;
            this.lblDays.Font = new System.Drawing.Font("SVN-Helves", 9F);
            this.lblDays.Location = new System.Drawing.Point(12, 9);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(158, 58);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "-";
            this.lblDays.Click += new System.EventHandler(this.lblDays_Click);
            // 
            // frmThongTinCaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(176, 76);
            this.Controls.Add(this.lblDays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinCaHoc";
            this.Text = "frmThongTinCaHoc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
    }
}