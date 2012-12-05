namespace DoAnB
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelxinchao = new System.Windows.Forms.Label();
            this.label2tk = new System.Windows.Forms.Label();
            this.label3mk = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.quanlybtn = new System.Windows.Forms.Button();
            this.nhanvienbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelxinchao
            // 
            this.labelxinchao.AutoSize = true;
            this.labelxinchao.Location = new System.Drawing.Point(97, 296);
            this.labelxinchao.Name = "labelxinchao";
            this.labelxinchao.Size = new System.Drawing.Size(51, 13);
            this.labelxinchao.TabIndex = 1;
            this.labelxinchao.Text = "Chức Vụ:";
            // 
            // label2tk
            // 
            this.label2tk.AutoSize = true;
            this.label2tk.Location = new System.Drawing.Point(30, 323);
            this.label2tk.Name = "label2tk";
            this.label2tk.Size = new System.Drawing.Size(59, 13);
            this.label2tk.TabIndex = 1;
            this.label2tk.Text = "Tài Khoản:";
            // 
            // label3mk
            // 
            this.label3mk.AutoSize = true;
            this.label3mk.Location = new System.Drawing.Point(29, 358);
            this.label3mk.Name = "label3mk";
            this.label3mk.Size = new System.Drawing.Size(56, 13);
            this.label3mk.TabIndex = 1;
            this.label3mk.Text = "Mật Khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(100, 323);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(153, 20);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(100, 358);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(153, 20);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(275, 320);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 54);
            this.btDangNhap.TabIndex = 5;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(275, 219);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 54);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // quanlybtn
            // 
            this.quanlybtn.Location = new System.Drawing.Point(33, 219);
            this.quanlybtn.Name = "quanlybtn";
            this.quanlybtn.Size = new System.Drawing.Size(75, 54);
            this.quanlybtn.TabIndex = 0;
            this.quanlybtn.Text = "Quản Lý";
            this.quanlybtn.UseVisualStyleBackColor = true;
            this.quanlybtn.Click += new System.EventHandler(this.quanlybtn_Click);
            // 
            // nhanvienbtn
            // 
            this.nhanvienbtn.Location = new System.Drawing.Point(155, 219);
            this.nhanvienbtn.Name = "nhanvienbtn";
            this.nhanvienbtn.Size = new System.Drawing.Size(75, 54);
            this.nhanvienbtn.TabIndex = 1;
            this.nhanvienbtn.Text = "Nhân Viên";
            this.nhanvienbtn.UseVisualStyleBackColor = true;
            this.nhanvienbtn.Click += new System.EventHandler(this.nhanvienbtn_Click);
            // 
            // DangNhap
            // 
            this.AcceptButton = this.btDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(379, 397);
            this.Controls.Add(this.nhanvienbtn);
            this.Controls.Add(this.quanlybtn);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3mk);
            this.Controls.Add(this.label2tk);
            this.Controls.Add(this.labelxinchao);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelxinchao;
        private System.Windows.Forms.Label label2tk;
        private System.Windows.Forms.Label label3mk;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button quanlybtn;
        private System.Windows.Forms.Button nhanvienbtn;
    }
}