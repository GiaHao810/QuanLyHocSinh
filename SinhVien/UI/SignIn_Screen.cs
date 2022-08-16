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

using SinhVien.Controller;

using SinhVien.Data;

namespace SinhVien
{
    public partial class SignIn_Screen : Form
    {

        public TextBox TextBox_un => this.textBox_un;
        public TextBox TextBox_pw => this.textBox_pw;
        public Button Button => this.button_signin;

        SignIn_Controller siController = new SignIn_Controller();

        DataTable a = new DataTable();

        public static String getValue = "";

        public SignIn_Screen()
        {
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            Employee_Screen controlSV_Screen = new Employee_Screen();

            MessageBox.Show(siController.signIn(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(siController.signIn() == "Đăng nhập thành công")
            {
                Visible = false;
                controlSV_Screen.Show();
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
            a.Clear();

            Database.Adapter.Fill(a);
        }

        private void textBox_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
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
