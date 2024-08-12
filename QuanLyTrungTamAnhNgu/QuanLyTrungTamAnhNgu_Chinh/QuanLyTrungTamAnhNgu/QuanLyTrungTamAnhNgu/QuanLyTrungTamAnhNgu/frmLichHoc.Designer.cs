
namespace QuanLyTrungTamAnhNgu
{
    partial class frmLichHoc
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelThongTinCaHoc = new System.Windows.Forms.Panel();
            this.panelLich = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelLich.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panelThongTinCaHoc);
            this.panel1.Controls.Add(this.panelLich);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1437, 729);
            this.panel1.TabIndex = 0;
            // 
            // panelThongTinCaHoc
            // 
            this.panelThongTinCaHoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelThongTinCaHoc.Location = new System.Drawing.Point(1225, 0);
            this.panelThongTinCaHoc.Name = "panelThongTinCaHoc";
            this.panelThongTinCaHoc.Size = new System.Drawing.Size(212, 103);
            this.panelThongTinCaHoc.TabIndex = 2;
            // 
            // panelLich
            // 
            this.panelLich.AutoScroll = true;
            this.panelLich.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLich.Controls.Add(this.panel3);
            this.panelLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLich.Location = new System.Drawing.Point(0, 77);
            this.panelLich.MaximumSize = new System.Drawing.Size(1225, 649);
            this.panelLich.MinimumSize = new System.Drawing.Size(1225, 649);
            this.panelLich.Name = "panelLich";
            this.panelLich.Size = new System.Drawing.Size(1225, 649);
            this.panelLich.TabIndex = 0;
            this.panelLich.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLich_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMonthYear);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(1225, 77);
            this.panel2.MinimumSize = new System.Drawing.Size(1225, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 77);
            this.panel2.TabIndex = 1;
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonthYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMonthYear.Font = new System.Drawing.Font("SVN-Helves", 14F);
            this.lblMonthYear.Location = new System.Drawing.Point(492, 3);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(244, 34);
            this.lblMonthYear.TabIndex = 9;
            this.lblMonthYear.Text = "MonthYear";
            this.lblMonthYear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrev.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.SquareCaretRight;
            this.btnPrev.IconColor = System.Drawing.Color.Black;
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.Location = new System.Drawing.Point(411, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 43);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.SquareCaretRight;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.Location = new System.Drawing.Point(766, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 43);
            this.btnNext.TabIndex = 7;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("SVN-Helves", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(922, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Friday";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("SVN-Helves", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1087, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saturday";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("SVN-Helves", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(732, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thursday";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("SVN-Helves", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(547, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("SVN-Helves", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(388, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tuesday";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("SVN-Helves", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(216, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Monday";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("SVN-Helves", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(49, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sunday";
            // 
            // frmLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1437, 729);
            this.Controls.Add(this.panel1);
            this.Name = "frmLichHoc";
            this.Text = "frmLichHoc";
            this.Load += new System.EventHandler(this.frmLichHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panelLich.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelLich;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnPrev;
        private FontAwesome.Sharp.IconButton btnNext;
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelThongTinCaHoc;
    }
}