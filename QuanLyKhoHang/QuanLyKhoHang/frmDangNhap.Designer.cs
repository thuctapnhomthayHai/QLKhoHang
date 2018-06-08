namespace QuanLyKhoHang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.cbxNhoTaiKhoan = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxHienMatKhau = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 234);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(89, 259);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(113, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tên đăng nhập";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(89, 304);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mật khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(318, 348);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 23);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbxNhoTaiKhoan
            // 
            // 
            // 
            // 
            this.cbxNhoTaiKhoan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxNhoTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhoTaiKhoan.Location = new System.Drawing.Point(89, 372);
            this.cbxNhoTaiKhoan.Name = "cbxNhoTaiKhoan";
            this.cbxNhoTaiKhoan.Size = new System.Drawing.Size(125, 23);
            this.cbxNhoTaiKhoan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxNhoTaiKhoan.TabIndex = 3;
            this.cbxNhoTaiKhoan.Text = "Nhớ tài khoản";
            // 
            // cbxHienMatKhau
            // 
            // 
            // 
            // 
            this.cbxHienMatKhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxHienMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHienMatKhau.Location = new System.Drawing.Point(275, 377);
            this.cbxHienMatKhau.Name = "cbxHienMatKhau";
            this.cbxHienMatKhau.Size = new System.Drawing.Size(129, 23);
            this.cbxHienMatKhau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxHienMatKhau.TabIndex = 3;
            this.cbxHienMatKhau.Text = "Hiện mật khẩu";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(234, 261);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.Size = new System.Drawing.Size(188, 26);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "admin";
            // 
            // txtPassWord
            // 
            // 
            // 
            // 
            this.txtPassWord.Border.Class = "TextBoxBorder";
            this.txtPassWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(234, 301);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PreventEnterBeep = true;
            this.txtPassWord.Size = new System.Drawing.Size(188, 26);
            this.txtPassWord.TabIndex = 4;
            this.txtPassWord.Text = "1";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 412);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cbxHienMatKhau);
            this.Controls.Add(this.cbxNhoTaiKhoan);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxNhoTaiKhoan;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxHienMatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassWord;
    }
}