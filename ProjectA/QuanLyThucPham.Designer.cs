namespace DoAnB
{
    partial class QuanLyThucPham
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
            this.tctrlThucPham = new System.Windows.Forms.TabControl();
            this.tpThucAn = new System.Windows.Forms.TabPage();
            this.bttDongDA = new System.Windows.Forms.Button();
            this.lblSoMonAn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttCapNhatDA = new System.Windows.Forms.Button();
            this.bttXoaDA = new System.Windows.Forms.Button();
            this.bttThemDA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgChiTietDoAn = new System.Windows.Forms.DataGridView();
            this.bttTimDA = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLoaiThucAn = new System.Windows.Forms.ComboBox();
            this.qLThucPhamDS = new DoAnB.QLThucPhamDS();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bttDongTU = new System.Windows.Forms.Button();
            this.lblSoTU = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btCapNhatTU = new System.Windows.Forms.Button();
            this.bttXoaTU = new System.Windows.Forms.Button();
            this.bttThemTU = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgChiTietTU = new System.Windows.Forms.DataGridView();
            this.bttTimTU = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLoaiTU = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loaiThucAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiThucAnTableAdapter1 = new DoAnB.QLThucPhamDSTableAdapters.LoaiThucAnTableAdapter();
            this.loaiThucUongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiThucUongTableAdapter2 = new DoAnB.QLThucPhamDSTableAdapters.LoaiThucUongTableAdapter();
            this.tctrlThucPham.SuspendLayout();
            this.tpThucAn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietDoAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThucPhamDS)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucUongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tctrlThucPham
            // 
            this.tctrlThucPham.Controls.Add(this.tpThucAn);
            this.tctrlThucPham.Controls.Add(this.tabPage2);
            this.tctrlThucPham.Location = new System.Drawing.Point(3, 64);
            this.tctrlThucPham.Name = "tctrlThucPham";
            this.tctrlThucPham.SelectedIndex = 0;
            this.tctrlThucPham.Size = new System.Drawing.Size(786, 508);
            this.tctrlThucPham.TabIndex = 0;
            // 
            // tpThucAn
            // 
            this.tpThucAn.Controls.Add(this.bttDongDA);
            this.tpThucAn.Controls.Add(this.lblSoMonAn);
            this.tpThucAn.Controls.Add(this.groupBox2);
            this.tpThucAn.Controls.Add(this.label4);
            this.tpThucAn.Controls.Add(this.groupBox1);
            this.tpThucAn.Controls.Add(this.bttTimDA);
            this.tpThucAn.Controls.Add(this.txtTimKiem);
            this.tpThucAn.Controls.Add(this.label3);
            this.tpThucAn.Controls.Add(this.cbbLoaiThucAn);
            this.tpThucAn.Controls.Add(this.label2);
            this.tpThucAn.Location = new System.Drawing.Point(4, 22);
            this.tpThucAn.Name = "tpThucAn";
            this.tpThucAn.Padding = new System.Windows.Forms.Padding(3);
            this.tpThucAn.Size = new System.Drawing.Size(778, 482);
            this.tpThucAn.TabIndex = 0;
            this.tpThucAn.Text = "Thức Ăn";
            this.tpThucAn.UseVisualStyleBackColor = true;
            // 
            // bttDongDA
            // 
            this.bttDongDA.Location = new System.Drawing.Point(631, 398);
            this.bttDongDA.Name = "bttDongDA";
            this.bttDongDA.Size = new System.Drawing.Size(103, 51);
            this.bttDongDA.TabIndex = 0;
            this.bttDongDA.Text = "Đóng";
            this.bttDongDA.UseVisualStyleBackColor = true;
            this.bttDongDA.Click += new System.EventHandler(this.bttDongDA_Click);
            // 
            // lblSoMonAn
            // 
            this.lblSoMonAn.AutoSize = true;
            this.lblSoMonAn.Location = new System.Drawing.Point(79, 417);
            this.lblSoMonAn.Name = "lblSoMonAn";
            this.lblSoMonAn.Size = new System.Drawing.Size(35, 13);
            this.lblSoMonAn.TabIndex = 8;
            this.lblSoMonAn.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttCapNhatDA);
            this.groupBox2.Controls.Add(this.bttXoaDA);
            this.groupBox2.Controls.Add(this.bttThemDA);
            this.groupBox2.Location = new System.Drawing.Point(172, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 84);
            this.groupBox2.TabIndex = 7;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Món Ăn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgChiTietDoAn);
            this.groupBox1.Location = new System.Drawing.Point(6, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 320);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ Liệu";
            // 
            // dgChiTietDoAn
            // 
            this.dgChiTietDoAn.AllowUserToAddRows = false;
            this.dgChiTietDoAn.AllowUserToDeleteRows = false;
            this.dgChiTietDoAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTietDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietDoAn.Location = new System.Drawing.Point(7, 20);
            this.dgChiTietDoAn.Name = "dgChiTietDoAn";
            this.dgChiTietDoAn.Size = new System.Drawing.Size(753, 294);
            this.dgChiTietDoAn.TabIndex = 0;
            // 
            // bttTimDA
            // 
            this.bttTimDA.Location = new System.Drawing.Point(659, 21);
            this.bttTimDA.Name = "bttTimDA";
            this.bttTimDA.Size = new System.Drawing.Size(75, 23);
            this.bttTimDA.TabIndex = 4;
            this.bttTimDA.Text = "Tìm";
            this.bttTimDA.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(424, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(217, 20);
            this.txtTimKiem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm Kiếm:";
            // 
            // cbbLoaiThucAn
            // 
            this.cbbLoaiThucAn.DataSource = this.loaiThucAnBindingSource;
            this.cbbLoaiThucAn.DisplayMember = "LoaiThucAn";
            this.cbbLoaiThucAn.FormattingEnabled = true;
            this.cbbLoaiThucAn.Location = new System.Drawing.Point(110, 23);
            this.cbbLoaiThucAn.Name = "cbbLoaiThucAn";
            this.cbbLoaiThucAn.Size = new System.Drawing.Size(193, 21);
            this.cbbLoaiThucAn.TabIndex = 1;
            this.cbbLoaiThucAn.ValueMember = "MaLoaiThucAn";
            this.cbbLoaiThucAn.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiThucAn_SelectedIndexChanged);
            // 
            // qLThucPhamDS
            // 
            this.qLThucPhamDS.DataSetName = "QLThucPhamDS";
            this.qLThucPhamDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Thức Ăn:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bttDongTU);
            this.tabPage2.Controls.Add(this.lblSoTU);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.bttTimTU);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbbLoaiTU);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thức Uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bttDongTU
            // 
            this.bttDongTU.Location = new System.Drawing.Point(651, 401);
            this.bttDongTU.Name = "bttDongTU";
            this.bttDongTU.Size = new System.Drawing.Size(98, 48);
            this.bttDongTU.TabIndex = 0;
            this.bttDongTU.Text = "Đóng";
            this.bttDongTU.UseVisualStyleBackColor = true;
            this.bttDongTU.Click += new System.EventHandler(this.bttDongTU_Click);
            // 
            // lblSoTU
            // 
            this.lblSoTU.AutoSize = true;
            this.lblSoTU.Location = new System.Drawing.Point(80, 419);
            this.lblSoTU.Name = "lblSoTU";
            this.lblSoTU.Size = new System.Drawing.Size(35, 13);
            this.lblSoTU.TabIndex = 8;
            this.lblSoTU.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số Đồ Uống:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btCapNhatTU);
            this.groupBox4.Controls.Add(this.bttXoaTU);
            this.groupBox4.Controls.Add(this.bttThemTU);
            this.groupBox4.Location = new System.Drawing.Point(186, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 84);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tuỳ Chọn";
            // 
            // btCapNhatTU
            // 
            this.btCapNhatTU.Location = new System.Drawing.Point(306, 26);
            this.btCapNhatTU.Name = "btCapNhatTU";
            this.btCapNhatTU.Size = new System.Drawing.Size(98, 32);
            this.btCapNhatTU.TabIndex = 0;
            this.btCapNhatTU.Text = "Cập Nhật";
            this.btCapNhatTU.UseVisualStyleBackColor = true;
            this.btCapNhatTU.Click += new System.EventHandler(this.btCapNhatTU_Click);
            // 
            // bttXoaTU
            // 
            this.bttXoaTU.Location = new System.Drawing.Point(168, 27);
            this.bttXoaTU.Name = "bttXoaTU";
            this.bttXoaTU.Size = new System.Drawing.Size(98, 32);
            this.bttXoaTU.TabIndex = 0;
            this.bttXoaTU.Text = "Xoá";
            this.bttXoaTU.UseVisualStyleBackColor = true;
            this.bttXoaTU.Click += new System.EventHandler(this.bttXoaTU_Click);
            // 
            // bttThemTU
            // 
            this.bttThemTU.Location = new System.Drawing.Point(27, 27);
            this.bttThemTU.Name = "bttThemTU";
            this.bttThemTU.Size = new System.Drawing.Size(98, 32);
            this.bttThemTU.TabIndex = 0;
            this.bttThemTU.Text = "Thêm";
            this.bttThemTU.UseVisualStyleBackColor = true;
            this.bttThemTU.Click += new System.EventHandler(this.bttThemTU_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgChiTietTU);
            this.groupBox3.Location = new System.Drawing.Point(6, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(766, 329);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ Liệu";
            // 
            // dgChiTietTU
            // 
            this.dgChiTietTU.AllowUserToAddRows = false;
            this.dgChiTietTU.AllowUserToDeleteRows = false;
            this.dgChiTietTU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTietTU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietTU.Location = new System.Drawing.Point(7, 20);
            this.dgChiTietTU.Name = "dgChiTietTU";
            this.dgChiTietTU.Size = new System.Drawing.Size(753, 303);
            this.dgChiTietTU.TabIndex = 0;
            // 
            // bttTimTU
            // 
            this.bttTimTU.Location = new System.Drawing.Point(664, 20);
            this.bttTimTU.Name = "bttTimTU";
            this.bttTimTU.Size = new System.Drawing.Size(75, 23);
            this.bttTimTU.TabIndex = 4;
            this.bttTimTU.Text = "Tìm";
            this.bttTimTU.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tìm Kiếm:";
            // 
            // cbbLoaiTU
            // 
            this.cbbLoaiTU.DataSource = this.loaiThucUongBindingSource;
            this.cbbLoaiTU.DisplayMember = "LoaiThucUong";
            this.cbbLoaiTU.FormattingEnabled = true;
            this.cbbLoaiTU.Location = new System.Drawing.Point(123, 18);
            this.cbbLoaiTU.Name = "cbbLoaiTU";
            this.cbbLoaiTU.Size = new System.Drawing.Size(188, 21);
            this.cbbLoaiTU.TabIndex = 1;
            this.cbbLoaiTU.ValueMember = "MaLoaiThucUong";
            this.cbbLoaiTU.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiTU_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại Thức Uống:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thực Phẩm";
            // 
            // loaiThucAnBindingSource
            // 
            this.loaiThucAnBindingSource.DataMember = "LoaiThucAn";
            this.loaiThucAnBindingSource.DataSource = this.qLThucPhamDS;
            // 
            // loaiThucAnTableAdapter1
            // 
            this.loaiThucAnTableAdapter1.ClearBeforeFill = true;
            // 
            // loaiThucUongBindingSource
            // 
            this.loaiThucUongBindingSource.DataMember = "LoaiThucUong";
            this.loaiThucUongBindingSource.DataSource = this.qLThucPhamDS;
            // 
            // loaiThucUongTableAdapter2
            // 
            this.loaiThucUongTableAdapter2.ClearBeforeFill = true;
            // 
            // QuanLyThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tctrlThucPham);
            this.Name = "QuanLyThucPham";
            this.Text = "Quản Lý Thực Phẩm";
            this.Load += new System.EventHandler(this.QuanLyThucAn_Load);
            this.tctrlThucPham.ResumeLayout(false);
            this.tpThucAn.ResumeLayout(false);
            this.tpThucAn.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietDoAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThucPhamDS)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucUongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlThucPham;
        private System.Windows.Forms.TabPage tpThucAn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgChiTietDoAn;
        private System.Windows.Forms.Button bttTimDA;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLoaiThucAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttDongDA;
        private System.Windows.Forms.Label lblSoMonAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttCapNhatDA;
        private System.Windows.Forms.Button bttXoaDA;
        private System.Windows.Forms.Button bttThemDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttTimTU;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bttThemTU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSoTU;
        private System.Windows.Forms.Button btCapNhatTU;
        private System.Windows.Forms.Button bttXoaTU;
        private System.Windows.Forms.Button bttDongTU;
        private System.Windows.Forms.DataGridView dgChiTietTU;
        private System.Windows.Forms.ComboBox cbbLoaiTU;
        private QLThucPhamDS qLThucPhamDS;
        private System.Windows.Forms.BindingSource loaiThucAnBindingSource;
        private QLThucPhamDSTableAdapters.LoaiThucAnTableAdapter loaiThucAnTableAdapter1;
        private System.Windows.Forms.BindingSource loaiThucUongBindingSource;
        private QLThucPhamDSTableAdapters.LoaiThucUongTableAdapter loaiThucUongTableAdapter2;

    }
}