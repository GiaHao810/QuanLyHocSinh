﻿namespace SinhVien
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
            this.label_Export = new System.Windows.Forms.Label();
            this.label_Edit = new System.Windows.Forms.Label();
            this.label_Import = new System.Windows.Forms.Label();
            this.label_Delete = new System.Windows.Forms.Label();
            this.label_Add = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txt_nhapten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_hienthiSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_so
            // 
            this.label_so.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_so.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_so.ForeColor = System.Drawing.Color.Red;
            this.label_so.Location = new System.Drawing.Point(15, 397);
            this.label_so.Name = "label_so";
            this.label_so.Size = new System.Drawing.Size(130, 43);
            this.label_so.TabIndex = 15;
            this.label_so.Text = "THOÁT";
            this.label_so.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Export
            // 
            this.label_Export.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Export.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Export.ForeColor = System.Drawing.Color.Red;
            this.label_Export.Location = new System.Drawing.Point(15, 274);
            this.label_Export.Name = "label_Export";
            this.label_Export.Size = new System.Drawing.Size(130, 43);
            this.label_Export.TabIndex = 14;
            this.label_Export.Text = "Export";
            this.label_Export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Export.Click += new System.EventHandler(this.label_Export_Click);
            // 
            // label_Edit
            // 
            this.label_Edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Edit.ForeColor = System.Drawing.Color.Red;
            this.label_Edit.Location = new System.Drawing.Point(15, 149);
            this.label_Edit.Name = "label_Edit";
            this.label_Edit.Size = new System.Drawing.Size(130, 43);
            this.label_Edit.TabIndex = 12;
            this.label_Edit.Text = "SỬA";
            this.label_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Import
            // 
            this.label_Import.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Import.ForeColor = System.Drawing.Color.Red;
            this.label_Import.Location = new System.Drawing.Point(15, 216);
            this.label_Import.Name = "label_Import";
            this.label_Import.Size = new System.Drawing.Size(130, 43);
            this.label_Import.TabIndex = 11;
            this.label_Import.Text = "Import";
            this.label_Import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Delete
            // 
            this.label_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delete.ForeColor = System.Drawing.Color.Red;
            this.label_Delete.Location = new System.Drawing.Point(15, 87);
            this.label_Delete.Name = "label_Delete";
            this.label_Delete.Size = new System.Drawing.Size(130, 43);
            this.label_Delete.TabIndex = 10;
            this.label_Delete.Text = "XÓA";
            this.label_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Delete.Click += new System.EventHandler(this.label_Delete_Click);
            // 
            // label_Add
            // 
            this.label_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Add.ForeColor = System.Drawing.Color.Red;
            this.label_Add.Location = new System.Drawing.Point(15, 25);
            this.label_Add.Name = "label_Add";
            this.label_Add.Size = new System.Drawing.Size(130, 43);
            this.label_Add.TabIndex = 9;
            this.label_Add.Text = "THÊM";
            this.label_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Add.Click += new System.EventHandler(this.label_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 270);
            this.dataGridView1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(785, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 77);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(235, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 478);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 43);
            this.label3.TabIndex = 19;
            this.label3.Text = "Report";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.Location = new System.Drawing.Point(647, 70);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(91, 25);
            this.btn_timKiem.TabIndex = 22;
            this.btn_timKiem.Text = "Search";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_nhapten
            // 
            this.txt_nhapten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapten.Location = new System.Drawing.Point(246, 70);
            this.txt_nhapten.Multiline = true;
            this.txt_nhapten.Name = "txt_nhapten";
            this.txt_nhapten.Size = new System.Drawing.Size(395, 23);
            this.txt_nhapten.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhập tên:";
            // 
            // btn_hienthiSV
            // 
            this.btn_hienthiSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthiSV.Location = new System.Drawing.Point(183, 173);
            this.btn_hienthiSV.Name = "btn_hienthiSV";
            this.btn_hienthiSV.Size = new System.Drawing.Size(134, 25);
            this.btn_hienthiSV.TabIndex = 23;
            this.btn_hienthiSV.Text = "Hiển thị tất cả:";
            this.btn_hienthiSV.UseVisualStyleBackColor = true;
            this.btn_hienthiSV.Click += new System.EventHandler(this.btn_hienthiSV_Click);
            // 
            // Employee_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(878, 496);
            this.Controls.Add(this.btn_hienthiSV);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txt_nhapten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_so);
            this.Controls.Add(this.label_Export);
            this.Controls.Add(this.label_Edit);
            this.Controls.Add(this.label_Import);
            this.Controls.Add(this.label_Delete);
            this.Controls.Add(this.label_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "Employee_Screen";
            this.Load += new System.EventHandler(this.ControlSV_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_so;
        private System.Windows.Forms.Label label_Export;
        private System.Windows.Forms.Label label_Edit;
        private System.Windows.Forms.Label label_Import;
        private System.Windows.Forms.Label label_Delete;
        private System.Windows.Forms.Label label_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txt_nhapten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_hienthiSV;
    }
}