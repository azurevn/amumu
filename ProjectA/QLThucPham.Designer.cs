namespace DoAnB
{
    partial class QLThucPham
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttTimDA = new System.Windows.Forms.Button();
            this.dgChiTiet = new System.Windows.Forms.DataGridView();
            this.bttDongDA = new System.Windows.Forms.Button();
            this.lblSoTP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttCapNhatDA = new System.Windows.Forms.Button();
            this.bttXoaDA = new System.Windows.Forms.Button();
            this.bttThemDA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLoaiThucPham = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(431, 106);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(217, 20);
            this.txtTimKiem.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tìm Kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản Lý Thực Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Loại Thức Ăn:";
            // 
            // bttTimDA
            // 
            this.bttTimDA.Location = new System.Drawing.Point(666, 104);
            this.bttTimDA.Name = "bttTimDA";
            this.bttTimDA.Size = new System.Drawing.Size(75, 23);
            this.bttTimDA.TabIndex = 25;
            this.bttTimDA.Text = "Tìm";
            this.bttTimDA.UseVisualStyleBackColor = true;
            // 
            // dgChiTiet
            // 
            this.dgChiTiet.AllowUserToAddRows = false;
            this.dgChiTiet.AllowUserToDeleteRows = false;
            this.dgChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTiet.Location = new System.Drawing.Point(7, 20);
            this.dgChiTiet.Name = "dgChiTiet";
            this.dgChiTiet.Size = new System.Drawing.Size(753, 294);
            this.dgChiTiet.TabIndex = 0;
            // 
            // bttDongDA
            // 
            this.bttDongDA.Location = new System.Drawing.Point(638, 481);
            this.bttDongDA.Name = "bttDongDA";
            this.bttDongDA.Size = new System.Drawing.Size(103, 51);
            this.bttDongDA.TabIndex = 21;
            this.bttDongDA.Text = "Đóng";
            this.bttDongDA.UseVisualStyleBackColor = true;
            this.bttDongDA.Click += new System.EventHandler(this.bttDongDA_Click);
            // 
            // lblSoTP
            // 
            this.lblSoTP.AutoSize = true;
            this.lblSoTP.Location = new System.Drawing.Point(86, 500);
            this.lblSoTP.Name = "lblSoTP";
            this.lblSoTP.Size = new System.Drawing.Size(35, 13);
            this.lblSoTP.TabIndex = 29;
            this.lblSoTP.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttCapNhatDA);
            this.groupBox2.Controls.Add(this.bttXoaDA);
            this.groupBox2.Controls.Add(this.bttThemDA);
            this.groupBox2.Location = new System.Drawing.Point(179, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 84);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tuỳ Chọn";
            // 
            // bttCapNhatDA
            // 
            this.bttCapNhatDA.Location = new System.Drawing.Point(297, 31);
            this.bttCapNhatDA.Name = "bttCapNhatDA";
            this.bttCapNhatDA.Size = new System.Drawing.Size(98, 32);
            this.bttCapNhatDA.TabIndex = 0;
            this.bttCapNhatDA.Text = "Cập Nhật";
            this.bttCapNhatDA.UseVisualStyleBackColor = true;
            this.bttCapNhatDA.Click += new System.EventHandler(this.bttCapNhatDA_Click);
            // 
            // bttXoaDA
            // 
            this.bttXoaDA.Location = new System.Drawing.Point(165, 31);
            this.bttXoaDA.Name = "bttXoaDA";
            this.bttXoaDA.Size = new System.Drawing.Size(98, 32);
            this.bttXoaDA.TabIndex = 0;
            this.bttXoaDA.Text = "Xoá";
            this.bttXoaDA.UseVisualStyleBackColor = true;
            this.bttXoaDA.Click += new System.EventHandler(this.bttXoaDA_Click);
            // 
            // bttThemDA
            // 
            this.bttThemDA.Location = new System.Drawing.Point(33, 31);
            this.bttThemDA.Name = "bttThemDA";
            this.bttThemDA.Size = new System.Drawing.Size(98, 32);
            this.bttThemDA.TabIndex = 0;
            this.bttThemDA.Text = "Thêm";
            this.bttThemDA.UseVisualStyleBackColor = true;
            this.bttThemDA.Click += new System.EventHandler(this.bttThemDA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgChiTiet);
            this.groupBox1.Location = new System.Drawing.Point(13, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 320);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ Liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số Món Ăn:";
            // 
            // cbbLoaiThucPham
            // 
            this.cbbLoaiThucPham.FormattingEnabled = true;
            this.cbbLoaiThucPham.Location = new System.Drawing.Point(117, 104);
            this.cbbLoaiThucPham.Name = "cbbLoaiThucPham";
            this.cbbLoaiThucPham.Size = new System.Drawing.Size(201, 21);
            this.cbbLoaiThucPham.TabIndex = 30;
            // 
            // QLThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.cbbLoaiThucPham);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttTimDA);
            this.Controls.Add(this.bttDongDA);
            this.Controls.Add(this.lblSoTP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "QLThucPham";
            this.Text = "QLThucPham";
            this.Load += new System.EventHandler(this.QLThucPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttTimDA;
        private System.Windows.Forms.DataGridView dgChiTiet;
        private System.Windows.Forms.Button bttDongDA;
        private System.Windows.Forms.Label lblSoTP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttCapNhatDA;
        private System.Windows.Forms.Button bttXoaDA;
        private System.Windows.Forms.Button bttThemDA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLoaiThucPham;
    }
}