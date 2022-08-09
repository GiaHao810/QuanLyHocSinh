using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            Form2 nhanvienForm = new Form2();
            //Đăng nhập
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Form3 register_Form = new Form3();

            register_Form.Show();

            //Đăng ký
        }
    }
}
