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
    public partial class SignUp_Screen : Form
    {
        public SignUp_Screen()
        {
            InitializeComponent();
        }

        private void button_rs_Click(object sender, EventArgs e)
        {
            textBox_pn.Text = "";
            textBox_pw.Text = "";
            textBox_un.Text = "";
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            //Kiểm tra un - pw - sđt rồi thêm Account vào Database

            //....................................................
        }
    }
}
