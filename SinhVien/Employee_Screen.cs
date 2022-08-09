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
    public partial class Employee_Screen : Form
    {
        SqlConnection _connection;
        SqlCommand _command;
        string str = "Data Source=LAPTOP-SKAKNRQ2;Initial Catalog=QLSV;Integrated Security=True";
        SqlDataAdapter adaper = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loaddata()
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "select * from ThongTinSinhVien ";
            //_command.ExecuteNonQuery();
            adaper.SelectCommand = _command;
            table.Clear();

            adaper.Fill(table);
            dataGridView1.DataSource = table;
        }

        public Employee_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var hour = DateTime.Now.Hour;
            var minute = DateTime.Now.Minute;
            var second = DateTime.Now.Second;

            Text = "Chương trình quản lý học sinh  #  " + hour + " : " + minute + " : " + second;
        }

        private void ControlSV_Screen_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(str);
            _connection.Open(); // mo ket noi

            loaddata();

            timer1.Start();
        }

        private void label_Add_Click(object sender, EventArgs e)
        {
            
        }

        private void label_Delete_Click(object sender, EventArgs e)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "DELETE MASV FROM ThongTinSinhVien WHERE " + 
        }
    }
}
