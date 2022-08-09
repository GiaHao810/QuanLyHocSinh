namespace SinhVien
{
    partial class Student_Screen
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ctdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Edit = new System.Windows.Forms.Label();
            this.label_so = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Enabled = false;
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(446, 39);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 24);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_class
            // 
            this.textBox_class.Enabled = false;
            this.textBox_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_class.Location = new System.Drawing.Point(446, 79);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.Size = new System.Drawing.Size(100, 24);
            this.textBox_class.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chương trình đào tạo :";
            // 
            // textBox_ctdd
            // 
            this.textBox_ctdd.Enabled = false;
            this.textBox_ctdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ctdd.Location = new System.Drawing.Point(541, 127);
            this.textBox_ctdd.Name = "textBox_ctdd";
            this.textBox_ctdd.Size = new System.Drawing.Size(100, 24);
            this.textBox_ctdd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(303, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 175);
            this.label4.TabIndex = 6;
            // 
            // label_Edit
            // 
            this.label_Edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Edit.ForeColor = System.Drawing.Color.Red;
            this.label_Edit.Location = new System.Drawing.Point(12, 16);
            this.label_Edit.Name = "label_Edit";
            this.label_Edit.Size = new System.Drawing.Size(261, 43);
            this.label_Edit.TabIndex = 10;
            this.label_Edit.Text = "SỬA THÔNG TIN";
            this.label_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Edit.Click += new System.EventHandler(this.label_Edit_Click);
            // 
            // label_so
            // 
            this.label_so.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_so.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_so.ForeColor = System.Drawing.Color.Red;
            this.label_so.Location = new System.Drawing.Point(79, 91);
            this.label_so.Name = "label_so";
            this.label_so.Size = new System.Drawing.Size(130, 43);
            this.label_so.TabIndex = 16;
            this.label_so.Text = "THOÁT";
            this.label_so.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_so.Click += new System.EventHandler(this.label_so_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.Location = new System.Drawing.Point(563, 34);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(114, 34);
            this.button_confirm.TabIndex = 17;
            this.button_confirm.Text = "XÁC NHẬN";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Visible = false;
            // 
            // Student_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 198);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label_so);
            this.Controls.Add(this.label_Edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ctdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_class);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label4);
            this.Name = "Student_Screen";
            this.Text = "Student_Screen";
            this.Load += new System.EventHandler(this.Student_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ctdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Edit;
        private System.Windows.Forms.Label label_so;
        private System.Windows.Forms.Button button_confirm;
    }
}