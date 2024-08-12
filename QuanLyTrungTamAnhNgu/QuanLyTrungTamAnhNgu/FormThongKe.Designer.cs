namespace QuanLyTrungTamAnhNgu
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxQuy = new System.Windows.Forms.ComboBox();
            this.btnOke = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label15);
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1570, 98);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Info;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.kryptonPanel1.StateCommon.ColorAngle = 30F;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPanel1.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("UTM Avo", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SlateBlue;
            this.label15.Location = new System.Drawing.Point(533, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(572, 41);
            this.label15.TabIndex = 23;
            this.label15.Text = "Trung tâm Anh ngữ số 1 Võ Văn Ngân ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(0, 253);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(1570, 532);
            this.chart1.TabIndex = 51;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnOke);
            this.panel1.Controls.Add(this.kryptonGroup1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxQuy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1570, 155);
            this.panel1.TabIndex = 52;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(120, 26);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.lbDoanhThu);
            this.kryptonGroup1.Size = new System.Drawing.Size(406, 116);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(198)))), ((int)(((byte)(234)))));
            this.kryptonGroup1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(112)))), ((int)(((byte)(207)))));
            this.kryptonGroup1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(198)))), ((int)(((byte)(234)))));
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(112)))), ((int)(((byte)(207)))));
            this.kryptonGroup1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 15;
            this.kryptonGroup1.StateCommon.Border.Width = 1;
            this.kryptonGroup1.TabIndex = 5;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.lbDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDoanhThu.Font = new System.Drawing.Font("UTM Avo", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbDoanhThu.ForeColor = System.Drawing.Color.White;
            this.lbDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(394, 104);
            this.lbDoanhThu.TabIndex = 0;
            this.lbDoanhThu.Text = "00";
            this.lbDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(995, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("UTM Avo", 10F);
            this.txtNam.Location = new System.Drawing.Point(984, 84);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(127, 30);
            this.txtNam.TabIndex = 3;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1175, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quý";
            // 
            // cbxQuy
            // 
            this.cbxQuy.Font = new System.Drawing.Font("UTM Avo", 11F);
            this.cbxQuy.FormattingEnabled = true;
            this.cbxQuy.Location = new System.Drawing.Point(1170, 84);
            this.cbxQuy.Name = "cbxQuy";
            this.cbxQuy.Size = new System.Drawing.Size(121, 33);
            this.cbxQuy.TabIndex = 1;
            // 
            // btnOke
            // 
            this.btnOke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOke.FlatAppearance.BorderSize = 0;
            this.btnOke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOke.Font = new System.Drawing.Font("UTM Avo", 11F, System.Drawing.FontStyle.Bold);
            this.btnOke.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.btnOke.IconColor = System.Drawing.Color.Green;
            this.btnOke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOke.IconSize = 55;
            this.btnOke.Location = new System.Drawing.Point(1343, 66);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(75, 56);
            this.btnOke.TabIndex = 6;
            this.btnOke.UseVisualStyleBackColor = true;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 785);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxQuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.Label lbDoanhThu;
        private FontAwesome.Sharp.IconButton btnOke;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}