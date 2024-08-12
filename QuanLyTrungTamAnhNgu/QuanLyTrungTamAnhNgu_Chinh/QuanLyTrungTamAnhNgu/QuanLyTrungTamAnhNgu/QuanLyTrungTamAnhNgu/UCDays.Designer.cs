
namespace QuanLyTrungTamAnhNgu
{
    partial class UCDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDays = new System.Windows.Forms.Label();
            this.panelCaHoc = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("SVN-Helves", 9F);
            this.lblDays.Location = new System.Drawing.Point(2, 1);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(26, 22);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "00";
            // 
            // panelCaHoc
            // 
            this.panelCaHoc.AutoScroll = true;
            this.panelCaHoc.Location = new System.Drawing.Point(17, 22);
            this.panelCaHoc.Name = "panelCaHoc";
            this.panelCaHoc.Size = new System.Drawing.Size(134, 75);
            this.panelCaHoc.TabIndex = 1;
            this.panelCaHoc.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCaHoc_Paint);
            // 
            // UCDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCaHoc);
            this.Controls.Add(this.lblDays);
            this.Name = "UCDays";
            this.Size = new System.Drawing.Size(169, 100);
            this.Load += new System.EventHandler(this.UCDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        public System.Windows.Forms.FlowLayoutPanel panelCaHoc;
    }
}
