﻿namespace QuanLyKhoHang
{
    partial class DoiQuyen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_tdn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_dq = new System.Windows.Forms.Button();
            this.tbx_quyencu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_quyenmoi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(176, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 123);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú Ý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "nếu đổi quyền cho tài khoản khác!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "- Tên Đăng Nhập không Thể bỏ trống";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "đổi quyền cho chĩnh bản thân!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "- Tên Đăng Nhập có Thể bỏ trống nếu ";
            // 
            // tbx_tdn
            // 
            this.tbx_tdn.Location = new System.Drawing.Point(328, 70);
            this.tbx_tdn.Name = "tbx_tdn";
            this.tbx_tdn.Size = new System.Drawing.Size(156, 20);
            this.tbx_tdn.TabIndex = 24;
            this.tbx_tdn.Validated += new System.EventHandler(this.tbx_tdn_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên Đăng Nhập";
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Image = global::QuanLyKhoHang.Properties.Resources.Huy1;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(404, 197);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(80, 42);
            this.btn_huy.TabIndex = 28;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_dq
            // 
            this.btn_dq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dq.Image = global::QuanLyKhoHang.Properties.Resources.reset;
            this.btn_dq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dq.Location = new System.Drawing.Point(311, 197);
            this.btn_dq.Name = "btn_dq";
            this.btn_dq.Size = new System.Drawing.Size(78, 42);
            this.btn_dq.TabIndex = 27;
            this.btn_dq.Text = "Đổi";
            this.btn_dq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dq.UseVisualStyleBackColor = true;
            this.btn_dq.Click += new System.EventHandler(this.btn_dq_Click);
            // 
            // tbx_quyencu
            // 
            this.tbx_quyencu.Location = new System.Drawing.Point(328, 112);
            this.tbx_quyencu.Name = "tbx_quyencu";
            this.tbx_quyencu.Size = new System.Drawing.Size(158, 20);
            this.tbx_quyencu.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Quyền mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Quyền hiện Tại";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 43);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nâng Cấp Quyền Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_quyenmoi
            // 
            this.tbx_quyenmoi.Location = new System.Drawing.Point(328, 153);
            this.tbx_quyenmoi.Name = "tbx_quyenmoi";
            this.tbx_quyenmoi.Size = new System.Drawing.Size(158, 20);
            this.tbx_quyenmoi.TabIndex = 31;
            // 
            // DoiQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbx_tdn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dq);
            this.Controls.Add(this.tbx_quyencu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_quyenmoi);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DoiQuyen";
            this.Text = "DoiQuyen";
            this.Load += new System.EventHandler(this.DoiQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_tdn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_dq;
        private System.Windows.Forms.TextBox tbx_quyencu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_quyenmoi;
    }
}