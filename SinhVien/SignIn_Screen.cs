using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace SinhVien
{
    public partial class SignIn_Screen : Form
    {
        public SignIn_Screen()
        { 
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            //Kiểm tra un - pw

            //..................................................

            //Kiểm tra role để chọn màn hình 
            if(boxLoai.SelectedItem.ToString() == "")
            {

                MessageBox.Show("Vui lòng chọn chức vụ!!");

            } else if(boxLoai.SelectedItem.ToString() == "NHÂN VIÊN")
            {

                Employee_Screen controlSV_Screen = new Employee_Screen();

                controlSV_Screen.Show();

            } else if(boxLoai.SelectedItem.ToString() == "HỌC SINH")
            {

                Student_Screen student_Screen = new Student_Screen();

                student_Screen.Show();

            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            SignUp_Screen screenA = new SignUp_Screen();

            screenA.Show();
        }
    }
}
