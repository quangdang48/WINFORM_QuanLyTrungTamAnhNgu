
namespace QuanLyTrungTamAnhNgu
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTenDangNhap = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.iconButton_Cancel = new FontAwesome.Sharp.IconButton();
            this.iconButton_Login = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyTrungTamAnhNgu.Properties.Resources.LogoEnglish;
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(580, 96);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(233, 47);
            this.txtPass.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtPass.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtPass.StateCommon.Border.ColorAngle = 0F;
            this.txtPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPass.StateCommon.Border.Rounding = 15;
            this.txtPass.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txtPass.TabIndex = 37;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenDangNhap.Location = new System.Drawing.Point(580, 33);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(233, 47);
            this.txtTenDangNhap.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtTenDangNhap.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtTenDangNhap.StateCommon.Border.ColorAngle = 0F;
            this.txtTenDangNhap.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenDangNhap.StateCommon.Border.Rounding = 15;
            this.txtTenDangNhap.StateCommon.Content.Font = new System.Drawing.Font("SVN-Helves", 13F);
            this.txtTenDangNhap.TabIndex = 36;
            // 
            // iconButton_Cancel
            // 
            this.iconButton_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton_Cancel.Font = new System.Drawing.Font("UTM Avo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Cancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_Cancel.IconColor = System.Drawing.Color.Black;
            this.iconButton_Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Cancel.Location = new System.Drawing.Point(505, 177);
            this.iconButton_Cancel.Name = "iconButton_Cancel";
            this.iconButton_Cancel.Size = new System.Drawing.Size(144, 51);
            this.iconButton_Cancel.TabIndex = 35;
            this.iconButton_Cancel.Text = "Cancel";
            this.iconButton_Cancel.UseVisualStyleBackColor = false;
            this.iconButton_Cancel.Click += new System.EventHandler(this.iconButton_Cancel_Click);
            // 
            // iconButton_Login
            // 
            this.iconButton_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_Login.Font = new System.Drawing.Font("UTM Avo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Login.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_Login.IconColor = System.Drawing.Color.Black;
            this.iconButton_Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Login.Location = new System.Drawing.Point(672, 177);
            this.iconButton_Login.Name = "iconButton_Login";
            this.iconButton_Login.Size = new System.Drawing.Size(141, 51);
            this.iconButton_Login.TabIndex = 34;
            this.iconButton_Login.Text = "Login";
            this.iconButton_Login.UseVisualStyleBackColor = false;
            this.iconButton_Login.Click += new System.EventHandler(this.iconButton_Login_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 33;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(837, 285);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.iconButton_Cancel);
            this.Controls.Add(this.iconButton_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenDangNhap;
        private FontAwesome.Sharp.IconButton iconButton_Cancel;
        private FontAwesome.Sharp.IconButton iconButton_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}