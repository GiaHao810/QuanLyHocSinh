using SinhVien.Controller;
using SinhVien.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class SignIn_Screen : Form
    {
        private SignIn_Controller siController = new SignIn_Controller();

        public static String getValue = "";

        public SignIn_Screen()
        {
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            Employee_Screen controlSV_Screen = new Employee_Screen();

            DataTable table = new DataTable();

            String str = siController.signIn();

            if (str == "Đăng nhập thành công")
            {
                Visible = false;

                controlSV_Screen.Show();

                MessageBox.Show(str, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(str, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            SignUp_Screen screenA = new SignUp_Screen();

            screenA.Show();
        }

        private void SignIn_Screen_Load(object sender, EventArgs e)
        {
            siController.openC("Accounts");
        }

        private void textBox_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_signin_Click(sender, e);
            }
        }

        private void textBox_un_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_signin_Click(sender, e);
            }
        }
    }
}
