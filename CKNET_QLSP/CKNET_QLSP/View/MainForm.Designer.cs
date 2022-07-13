
namespace CKNET_QLSP
{
    partial class form_Main
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.but_Edit = new System.Windows.Forms.Button();
            this.but_Delete = new System.Windows.Forms.Button();
            this.but_Sort = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbb_TinhTP = new System.Windows.Forms.ComboBox();
            this.cbb_NCC = new System.Windows.Forms.ComboBox();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí sản phẩm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tinh TP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà Cung Cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm Kiếm";
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(52, 415);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 4;
            this.but_Add.Text = "Add";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // but_Edit
            // 
            this.but_Edit.Location = new System.Drawing.Point(171, 415);
            this.but_Edit.Name = "but_Edit";
            this.but_Edit.Size = new System.Drawing.Size(75, 23);
            this.but_Edit.TabIndex = 5;
            this.but_Edit.Text = "Edit";
            this.but_Edit.UseVisualStyleBackColor = true;
            this.but_Edit.Click += new System.EventHandler(this.but_Edit_Click);
            // 
            // but_Delete
            // 
            this.but_Delete.Location = new System.Drawing.Point(288, 415);
            this.but_Delete.Name = "but_Delete";
            this.but_Delete.Size = new System.Drawing.Size(75, 23);
            this.but_Delete.TabIndex = 6;
            this.but_Delete.Text = "Delete";
            this.but_Delete.UseVisualStyleBackColor = true;
            this.but_Delete.Click += new System.EventHandler(this.but_Delete_Click);
            // 
            // but_Sort
            // 
            this.but_Sort.Location = new System.Drawing.Point(701, 415);
            this.but_Sort.Name = "but_Sort";
            this.but_Sort.Size = new System.Drawing.Size(75, 23);
            this.but_Sort.TabIndex = 7;
            this.but_Sort.Text = "Sort";
            this.but_Sort.UseVisualStyleBackColor = true;
            this.but_Sort.Click += new System.EventHandler(this.but_Sort_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(612, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(100, 22);
            this.txt_Search.TabIndex = 8;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cbb_TinhTP
            // 
            this.cbb_TinhTP.FormattingEnabled = true;
            this.cbb_TinhTP.Location = new System.Drawing.Point(92, 16);
            this.cbb_TinhTP.Name = "cbb_TinhTP";
            this.cbb_TinhTP.Size = new System.Drawing.Size(121, 24);
            this.cbb_TinhTP.TabIndex = 9;
            this.cbb_TinhTP.TextChanged += new System.EventHandler(this.cbb_TinhTP_TextChanged);
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.FormattingEnabled = true;
            this.cbb_NCC.Location = new System.Drawing.Point(356, 16);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Size = new System.Drawing.Size(121, 24);
            this.cbb_NCC.TabIndex = 10;
            this.cbb_NCC.TextChanged += new System.EventHandler(this.cbb_NCC_TextChanged);
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Items.AddRange(new object[] {
            "Ten",
            "Gia Nhap",
            "So Luong"});
            this.cbb_Sort.Location = new System.Drawing.Point(561, 415);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(121, 24);
            this.cbb_Sort.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbb_Sort);
            this.Controls.Add(this.cbb_NCC);
            this.Controls.Add(this.cbb_TinhTP);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.but_Sort);
            this.Controls.Add(this.but_Delete);
            this.Controls.Add(this.but_Edit);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_Main";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_Edit;
        private System.Windows.Forms.Button but_Delete;
        private System.Windows.Forms.Button but_Sort;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cbb_TinhTP;
        private System.Windows.Forms.ComboBox cbb_NCC;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.Button button1;
    }
}

