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
        SqlConnection _connection = null;
        SqlCommand _command;
        string str = "Data Source=LAPTOP-SKAKNRQ2;Integrated Security=True;Initial Catalog=QLSV";
        SqlDataAdapter adaper = new SqlDataAdapter();

        DataTable table = new DataTable();

        public static String getValue = "";

        void loaddata()
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "select * from Accounts";
            _command.ExecuteNonQuery();
            adaper.SelectCommand = _command;
            table.Clear();

            adaper.Fill(table);
        }

        public SignIn_Screen()
        {
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            Employee_Screen controlSV_Screen = new Employee_Screen();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["un"].ToString() == textBox_un.Text && table.Rows[i]["pw"].ToString() == textBox_pw.Text)
                {
                    _command.CommandText = "UPDATE Accounts SET state = 'Online' WHERE un = '" + textBox_un.Text + "'";
                    _command.ExecuteNonQuery();
                    adaper.SelectCommand = _command;

                    getValue = textBox_un.Text;

                    Visible = false;

                    controlSV_Screen.Show();
                    break;

                }
                else if (table.Rows[i]["un"].ToString() != textBox_un.Text)
                {
                    MessageBox.Show("Tài khoản không chính xác!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (table.Rows[i]["pw"].ToString() != textBox_pw.Text)
                {
                    MessageBox.Show("Mật khẩu không chính xác!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }

            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            SignUp_Screen screenA = new SignUp_Screen();

            screenA.Show();
        }

        private void SignIn_Screen_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(str);
            _connection.Open(); // mo ket noi

            loaddata();

        }
    }
}
