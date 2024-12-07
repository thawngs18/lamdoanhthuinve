namespace WindowsFormsApp8
{
    partial class Seller
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgLichChieuP = new System.Windows.Forms.DataGridView();
            this.grbChiTietLichChieu = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThoiGianChieu = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichChieuP)).BeginInit();
            this.grbChiTietLichChieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lich Chieu Phim";
            // 
            // dtgLichChieuP
            // 
            this.dtgLichChieuP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLichChieuP.Location = new System.Drawing.Point(321, 120);
            this.dtgLichChieuP.Name = "dtgLichChieuP";
            this.dtgLichChieuP.Size = new System.Drawing.Size(718, 439);
            this.dtgLichChieuP.TabIndex = 1;
            // 
            // grbChiTietLichChieu
            // 
            this.grbChiTietLichChieu.Controls.Add(this.comboBox2);
            this.grbChiTietLichChieu.Controls.Add(this.comboBox1);
            this.grbChiTietLichChieu.Controls.Add(this.label4);
            this.grbChiTietLichChieu.Controls.Add(this.label3);
            this.grbChiTietLichChieu.Controls.Add(this.label2);
            this.grbChiTietLichChieu.Controls.Add(this.dtpThoiGianChieu);
            this.grbChiTietLichChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTietLichChieu.Location = new System.Drawing.Point(26, 112);
            this.grbChiTietLichChieu.Name = "grbChiTietLichChieu";
            this.grbChiTietLichChieu.Size = new System.Drawing.Size(289, 285);
            this.grbChiTietLichChieu.TabIndex = 2;
            this.grbChiTietLichChieu.TabStop = false;
            this.grbChiTietLichChieu.Text = "Chi Tiet";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(48, 230);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xuat Chieu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thoi Gian:";
            // 
            // dtpThoiGianChieu
            // 
            this.dtpThoiGianChieu.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiGianChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianChieu.Location = new System.Drawing.Point(48, 87);
            this.dtpThoiGianChieu.Name = "dtpThoiGianChieu";
            this.dtpThoiGianChieu.Size = new System.Drawing.Size(200, 26);
            this.dtpThoiGianChieu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbChiTietLichChieu);
            this.Controls.Add(this.dtgLichChieuP);
            this.Controls.Add(this.label1);
            this.Name = "Seller";
            this.Text = "Seller";
            this.Load += new System.EventHandler(this.Seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichChieuP)).EndInit();
            this.grbChiTietLichChieu.ResumeLayout(false);
            this.grbChiTietLichChieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgLichChieuP;
        private System.Windows.Forms.GroupBox grbChiTietLichChieu;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThoiGianChieu;
        private System.Windows.Forms.Button button1;
    }
}