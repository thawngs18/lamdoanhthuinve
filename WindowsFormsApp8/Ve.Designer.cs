namespace WindowsFormsApp8
{
    partial class Ve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ve));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlVe = new System.Windows.Forms.Panel();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblTenghe = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.pnlVe.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(376, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pnlVe
            // 
            this.pnlVe.Controls.Add(this.lblPhong);
            this.pnlVe.Controls.Add(this.lblTenghe);
            this.pnlVe.Controls.Add(this.lblDate);
            this.pnlVe.Controls.Add(this.lblTenPhim);
            this.pnlVe.Location = new System.Drawing.Point(42, 40);
            this.pnlVe.Name = "pnlVe";
            this.pnlVe.Size = new System.Drawing.Size(287, 274);
            this.pnlVe.TabIndex = 1;

            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(57, 37);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(35, 13);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "label3";
            // 
            // lblTenghe
            // 
            this.lblTenghe.AutoSize = true;
            this.lblTenghe.Location = new System.Drawing.Point(57, 141);
            this.lblTenghe.Name = "lblTenghe";
            this.lblTenghe.Size = new System.Drawing.Size(35, 13);
            this.lblTenghe.TabIndex = 2;
            this.lblTenghe.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(57, 103);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label2";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(57, 65);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(35, 13);
            this.lblTenPhim.TabIndex = 0;
            this.lblTenPhim.Text = "label1";
            // 
            // Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 348);
            this.Controls.Add(this.pnlVe);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Ve";
            this.Text = "Ve";
            this.Load += new System.EventHandler(this.Ve_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlVe.ResumeLayout(false);
            this.pnlVe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel pnlVe;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblTenghe;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTenPhim;
    }
}