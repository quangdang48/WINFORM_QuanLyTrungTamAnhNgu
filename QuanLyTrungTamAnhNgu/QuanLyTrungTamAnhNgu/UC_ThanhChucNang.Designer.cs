
namespace QuanLyTrungTamAnhNgu
{
    partial class UC_ThanhChucNang
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
            this.components = new System.ComponentModel.Container();
            this.txtSeach = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLoc = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(119, 15);
            this.txtSeach.Multiline = true;
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(262, 41);
            this.txtSeach.StateCommon.Back.Color1 = System.Drawing.Color.SeaShell;
            this.txtSeach.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSeach.StateCommon.Border.ColorAngle = 0F;
            this.txtSeach.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSeach.StateCommon.Border.Rounding = 20;
            this.txtSeach.TabIndex = 1;
            this.txtSeach.Text = "Search";
            this.txtSeach.TextChanged += new System.EventHandler(this.txtSeach_TextChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnLoc.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoc.Location = new System.Drawing.Point(40, 15);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(52, 41);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThem.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(1428, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(152, 52);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UC_ThanhChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.btnThem);
            this.Name = "UC_ThanhChucNang";
            this.Size = new System.Drawing.Size(1615, 70);
            this.Load += new System.EventHandler(this.UC_ThanhChucNang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnThem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSeach;
        private FontAwesome.Sharp.IconButton btnLoc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
