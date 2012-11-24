namespace ProjectA
{
    partial class ThemThucUong
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
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenThucUong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.qLThucPhamDS = new ProjectA.QLThucPhamDS();
            this.loaiThucUongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiThucUongTableAdapter1 = new ProjectA.QLThucPhamDSTableAdapters.LoaiThucUongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLThucPhamDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucUongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(286, 312);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(83, 36);
            this.btXoa.TabIndex = 34;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(167, 312);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(83, 36);
            this.btThem.TabIndex = 35;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(88, 251);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(281, 20);
            this.txtDonVi.TabIndex = 30;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(88, 195);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(281, 20);
            this.txtGia.TabIndex = 31;
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.Location = new System.Drawing.Point(88, 80);
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.Size = new System.Drawing.Size(281, 20);
            this.txtTenThucUong.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Đơn Vị:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thêm Thức Uống";
            // 
            // cbbLoai
            // 
            this.cbbLoai.DataSource = this.loaiThucUongBindingSource;
            this.cbbLoai.DisplayMember = "LoaiThucUong";
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(88, 139);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(281, 21);
            this.cbbLoai.TabIndex = 36;
            this.cbbLoai.ValueMember = "MaLoaiThucUong";
            // 
            // qLThucPhamDS
            // 
            this.qLThucPhamDS.DataSetName = "QLThucPhamDS";
            this.qLThucPhamDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiThucUongBindingSource
            // 
            this.loaiThucUongBindingSource.DataMember = "LoaiThucUong";
            this.loaiThucUongBindingSource.DataSource = this.qLThucPhamDS;
            // 
            // loaiThucUongTableAdapter1
            // 
            this.loaiThucUongTableAdapter1.ClearBeforeFill = true;
            // 
            // ThemThucUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenThucUong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ThemThucUong";
            this.Text = "Thêm Thức Uống";
            this.Load += new System.EventHandler(this.ThemThucUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLThucPhamDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucUongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenThucUong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoai;
        private QLThucPhamDS qLThucPhamDS;
        private System.Windows.Forms.BindingSource loaiThucUongBindingSource;
        private QLThucPhamDSTableAdapters.LoaiThucUongTableAdapter loaiThucUongTableAdapter1;
    }
}