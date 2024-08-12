
namespace QuanLyTrungTamAnhNgu
{
    partial class frmThiThu
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
            this.panel_Content = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Content)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Content.Panel)).BeginInit();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Content.Location = new System.Drawing.Point(64, 36);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_Content.Size = new System.Drawing.Size(1071, 632);
            this.panel_Content.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.panel_Content.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.panel_Content.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.panel_Content.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.panel_Content.StateCommon.Border.ColorAngle = 0F;
            this.panel_Content.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.panel_Content.StateCommon.Border.Rounding = 15;
            this.panel_Content.TabIndex = 3;
            // 
            // frmThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 705);
            this.Controls.Add(this.panel_Content);
            this.Name = "frmThiThu";
            this.Text = "frmThiThu";
            ((System.ComponentModel.ISupportInitialize)(this.panel_Content.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Content)).EndInit();
            this.panel_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroup panel_Content;
    }
}