namespace SinhVien
{
    partial class SignUp_Screen
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
            this.textBox_un = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.textBox_pn = new System.Windows.Forms.TextBox();
            this.button_rs = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.boxLoai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(73, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "ĐĂNG KÝ";
            // 
            // textBox_un
            // 
            this.textBox_un.Location = new System.Drawing.Point(128, 95);
            this.textBox_un.Name = "textBox_un";
            this.textBox_un.Size = new System.Drawing.Size(176, 20);
            this.textBox_un.TabIndex = 4;
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(128, 129);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(176, 20);
            this.textBox_pw.TabIndex = 5;
            // 
            // textBox_pn
            // 
            this.textBox_pn.Location = new System.Drawing.Point(128, 163);
            this.textBox_pn.Name = "textBox_pn";
            this.textBox_pn.Size = new System.Drawing.Size(176, 20);
            this.textBox_pn.TabIndex = 6;
            // 
            // button_rs
            // 
            this.button_rs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rs.Location = new System.Drawing.Point(25, 234);
            this.button_rs.Name = "button_rs";
            this.button_rs.Size = new System.Drawing.Size(125, 38);
            this.button_rs.TabIndex = 7;
            this.button_rs.Text = "NHẬP LẠI";
            this.button_rs.UseVisualStyleBackColor = true;
            this.button_rs.Click += new System.EventHandler(this.button_rs_Click);
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.Location = new System.Drawing.Point(190, 234);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(125, 38);
            this.button_register.TabIndex = 8;
            this.button_register.Text = "ĐĂNG KÝ";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Chọn loại :";
            // 
            // boxLoai
            // 
            this.boxLoai.FormattingEnabled = true;
            this.boxLoai.Items.AddRange(new object[] {
            "NHÂN VIÊN",
            "HỌC SINH"});
            this.boxLoai.Location = new System.Drawing.Point(171, 198);
            this.boxLoai.Name = "boxLoai";
            this.boxLoai.Size = new System.Drawing.Size(121, 21);
            this.boxLoai.TabIndex = 20;
            // 
            // SignUp_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 284);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxLoai);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_rs);
            this.Controls.Add(this.textBox_pn);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_un);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp_Screen";
            this.Text = "ĐĂNG KÝ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_un;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.TextBox textBox_pn;
        private System.Windows.Forms.Button button_rs;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxLoai;
    }
}