
namespace CKNET_QLSP.View
{
    partial class form_Detail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.but_OK = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.txt_nameSP = new System.Windows.Forms.TextBox();
            this.txt_Gianhap = new System.Windows.Forms.TextBox();
            this.txt_Soluong = new System.Windows.Forms.TextBox();
            this.pick_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbb_Tinh = new System.Windows.Forms.ComboBox();
            this.cbb_NhaCungCap = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tỉnh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhà Cung Cấp:";
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(207, 300);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 6;
            this.but_OK.Text = "OK";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // but_Cancel
            // 
            this.but_Cancel.Location = new System.Drawing.Point(471, 300);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(75, 23);
            this.but_Cancel.TabIndex = 7;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // txt_nameSP
            // 
            this.txt_nameSP.Location = new System.Drawing.Point(146, 24);
            this.txt_nameSP.Name = "txt_nameSP";
            this.txt_nameSP.Size = new System.Drawing.Size(190, 22);
            this.txt_nameSP.TabIndex = 8;
            // 
            // txt_Gianhap
            // 
            this.txt_Gianhap.Location = new System.Drawing.Point(146, 103);
            this.txt_Gianhap.Name = "txt_Gianhap";
            this.txt_Gianhap.Size = new System.Drawing.Size(190, 22);
            this.txt_Gianhap.TabIndex = 9;
            // 
            // txt_Soluong
            // 
            this.txt_Soluong.Location = new System.Drawing.Point(146, 194);
            this.txt_Soluong.Name = "txt_Soluong";
            this.txt_Soluong.Size = new System.Drawing.Size(100, 22);
            this.txt_Soluong.TabIndex = 10;
            // 
            // pick_NgayNhap
            // 
            this.pick_NgayNhap.Location = new System.Drawing.Point(480, 22);
            this.pick_NgayNhap.Name = "pick_NgayNhap";
            this.pick_NgayNhap.Size = new System.Drawing.Size(200, 22);
            this.pick_NgayNhap.TabIndex = 11;
            // 
            // cbb_Tinh
            // 
            this.cbb_Tinh.FormattingEnabled = true;
            this.cbb_Tinh.Location = new System.Drawing.Point(480, 103);
            this.cbb_Tinh.Name = "cbb_Tinh";
            this.cbb_Tinh.Size = new System.Drawing.Size(211, 24);
            this.cbb_Tinh.TabIndex = 12;
            this.cbb_Tinh.TextChanged += new System.EventHandler(this.cbb_Tinh_TextChanged);
            // 
            // cbb_NhaCungCap
            // 
            this.cbb_NhaCungCap.FormattingEnabled = true;
            this.cbb_NhaCungCap.Location = new System.Drawing.Point(480, 190);
            this.cbb_NhaCungCap.Name = "cbb_NhaCungCap";
            this.cbb_NhaCungCap.Size = new System.Drawing.Size(211, 24);
            this.cbb_NhaCungCap.TabIndex = 13;
            // 
            // form_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb_NhaCungCap);
            this.Controls.Add(this.cbb_Tinh);
            this.Controls.Add(this.pick_NgayNhap);
            this.Controls.Add(this.txt_Soluong);
            this.Controls.Add(this.txt_Gianhap);
            this.Controls.Add(this.txt_nameSP);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_Detail";
            this.Text = "FormDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.TextBox txt_nameSP;
        private System.Windows.Forms.TextBox txt_Gianhap;
        private System.Windows.Forms.TextBox txt_Soluong;
        private System.Windows.Forms.DateTimePicker pick_NgayNhap;
        private System.Windows.Forms.ComboBox cbb_Tinh;
        private System.Windows.Forms.ComboBox cbb_NhaCungCap;
    }
}