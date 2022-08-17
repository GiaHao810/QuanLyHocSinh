namespace SinhVien
{
    partial class Employee_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Screen));
            this.label_so = new System.Windows.Forms.Label();
            this.label_Edit = new System.Windows.Forms.Label();
            this.label_Delete = new System.Windows.Forms.Label();
            this.label_Add = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nhapten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_hienthiSV = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Confirm2 = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_tenhs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_timKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_so
            // 
            this.label_so.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_so.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_so.ForeColor = System.Drawing.Color.Red;
            this.label_so.Location = new System.Drawing.Point(690, 561);
            this.label_so.Name = "label_so";
            this.label_so.Size = new System.Drawing.Size(68, 20);
            this.label_so.TabIndex = 15;
            this.label_so.Text = "THOÁT";
            this.label_so.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_so.Click += new System.EventHandler(this.label_so_Click);
            // 
            // label_Edit
            // 
            this.label_Edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Edit.ForeColor = System.Drawing.Color.Red;
            this.label_Edit.Location = new System.Drawing.Point(134, 561);
            this.label_Edit.Name = "label_Edit";
            this.label_Edit.Size = new System.Drawing.Size(54, 20);
            this.label_Edit.TabIndex = 12;
            this.label_Edit.Text = "SỬA";
            this.label_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Edit.Click += new System.EventHandler(this.label_Edit_Click);
            // 
            // label_Delete
            // 
            this.label_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delete.ForeColor = System.Drawing.Color.Red;
            this.label_Delete.Location = new System.Drawing.Point(72, 561);
            this.label_Delete.Name = "label_Delete";
            this.label_Delete.Size = new System.Drawing.Size(54, 20);
            this.label_Delete.TabIndex = 10;
            this.label_Delete.Text = "XÓA";
            this.label_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Delete.Click += new System.EventHandler(this.label_Delete_Click);
            // 
            // label_Add
            // 
            this.label_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Add.ForeColor = System.Drawing.Color.Red;
            this.label_Add.Location = new System.Drawing.Point(12, 561);
            this.label_Add.Name = "label_Add";
            this.label_Add.Size = new System.Drawing.Size(54, 20);
            this.label_Add.TabIndex = 9;
            this.label_Add.Text = "THÊM";
            this.label_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Add.Click += new System.EventHandler(this.label_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 238);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 77);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(194, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Report";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nhapten
            // 
            this.txt_nhapten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapten.Location = new System.Drawing.Point(205, 86);
            this.txt_nhapten.Multiline = true;
            this.txt_nhapten.Name = "txt_nhapten";
            this.txt_nhapten.Size = new System.Drawing.Size(231, 23);
            this.txt_nhapten.TabIndex = 21;
            this.txt_nhapten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nhapten_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhập tên:";
            // 
            // btn_hienthiSV
            // 
            this.btn_hienthiSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthiSV.Location = new System.Drawing.Point(624, 280);
            this.btn_hienthiSV.Name = "btn_hienthiSV";
            this.btn_hienthiSV.Size = new System.Drawing.Size(134, 25);
            this.btn_hienthiSV.TabIndex = 23;
            this.btn_hienthiSV.Text = "Hiển thị tất cả:";
            this.btn_hienthiSV.UseVisualStyleBackColor = true;
            this.btn_hienthiSV.Click += new System.EventHandler(this.btn_hienthiSV_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Name.Location = new System.Drawing.Point(8, 43);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(47, 20);
            this.label_Name.TabIndex = 25;
            this.label_Name.Text = "User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Confirm2);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.button_Confirm);
            this.groupBox1.Controls.Add(this.cb_gioitinh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_ngaySinh);
            this.groupBox1.Controls.Add(this.txt_tenhs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 159);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điền thông tin sinh viên";
            // 
            // button_Confirm2
            // 
            this.button_Confirm2.Location = new System.Drawing.Point(617, 35);
            this.button_Confirm2.Name = "button_Confirm2";
            this.button_Confirm2.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm2.TabIndex = 8;
            this.button_Confirm2.Text = "XÁC NHẬN";
            this.button_Confirm2.UseVisualStyleBackColor = true;
            this.button_Confirm2.Visible = false;
            this.button_Confirm2.Click += new System.EventHandler(this.button_Confirm2_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(617, 78);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "HỦY";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Visible = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(617, 35);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 6;
            this.button_Confirm.Text = "XÁC NHẬN";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Visible = false;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(355, 111);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(179, 21);
            this.cb_gioitinh.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày sinh:";
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.Location = new System.Drawing.Point(88, 113);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(198, 20);
            this.dtp_ngaySinh.TabIndex = 2;
            this.dtp_ngaySinh.Value = new System.DateTime(2001, 9, 11, 0, 0, 0, 0);
            // 
            // txt_tenhs
            // 
            this.txt_tenhs.Location = new System.Drawing.Point(347, 75);
            this.txt_tenhs.Name = "txt_tenhs";
            this.txt_tenhs.ReadOnly = true;
            this.txt_tenhs.Size = new System.Drawing.Size(207, 20);
            this.txt_tenhs.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên HV:";
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(86, 75);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.ReadOnly = true;
            this.txt_ho.Size = new System.Drawing.Size(207, 20);
            this.txt_ho.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ HS:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(86, 37);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(207, 20);
            this.txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HS:";
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.Location = new System.Drawing.Point(455, 84);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(91, 25);
            this.btn_timKiem.TabIndex = 22;
            this.btn_timKiem.Text = "Search";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // Employee_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(794, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.btn_hienthiSV);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txt_nhapten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_so);
            this.Controls.Add(this.label_Edit);
            this.Controls.Add(this.label_Delete);
            this.Controls.Add(this.label_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee_Screen";
            this.Load += new System.EventHandler(this.Employee_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_so;
        private System.Windows.Forms.Label label_Edit;
        private System.Windows.Forms.Label label_Delete;
        private System.Windows.Forms.Label label_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nhapten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_hienthiSV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.TextBox txt_tenhs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Button button_Confirm2;
        private System.Windows.Forms.Button btn_timKiem;
    }
}