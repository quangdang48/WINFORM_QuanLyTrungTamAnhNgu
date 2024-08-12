namespace QuanLyTrungTamAnhNgu
{
    partial class UC_Homecs
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
            this.button = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button.IconColor = System.Drawing.Color.Black;
            this.button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button.Location = new System.Drawing.Point(26, 14);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(146, 147);
            this.button.TabIndex = 0;
            this.button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // UC_Homecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Name = "UC_Homecs";
            this.Size = new System.Drawing.Size(201, 183);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton button;
    }
}
