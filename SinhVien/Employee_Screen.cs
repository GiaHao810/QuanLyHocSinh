using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Min da them thu vien
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using OfficeOpenXml.Core.ExcelPackage;

namespace SinhVien
{
    public partial class Employee_Screen : Form
    {
        SqlConnection _connection;
        SqlCommand _command;
        string str = "Data Source=LAPTOP-SKAKNRQ2;Integrated Security=True;Initial Catalog=QLSV";
        SqlDataAdapter adaper = new SqlDataAdapter();

        DataTable table = new DataTable();

        String s;

        public string S { get => s; set => s = value; }

        void loaddata()
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "select * from ThongTinSinhVien";
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
            label_Name.Text = "USERNAME : " + SignIn_Screen.getValue;

            _connection = new SqlConnection(str);
            _connection.Open(); // mo ket noi

            loaddata();

            timer1.Start();
        }
        //Tminh
        private void label_Add_Click(object sender, EventArgs e)
        {
            button_Confirm.Visible = true;
            button_Cancel.Visible = true;
            txt_ho.ReadOnly = false;
            txt_id.ReadOnly = false;
            txt_tenhs.ReadOnly = false;
        }

        private void label_Delete_Click(object sender, EventArgs e)
        {
            //Lỗi nè Minh
            _command = _connection.CreateCommand();
            _command.CommandText = "DELETE FROM ThongTinSinhVien WHERE MaHS = '" + txt_id.Text + "'";
            _command.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loaddata();
        }

        //code of Min
        private void ExportExel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            //set tieu de cot
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

            }
            // set dong
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;

                }

            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        public void loadGrid()
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "select * from ThongTinSinhVien where TenSV like '%" + txt_nhapten.Text + "%'";
            adaper.SelectCommand = _command;
            table.Clear();

            adaper.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btn_hienthiSV_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)| *.xlsx | Excel (*.xlsx) |*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label_so_Click(object sender, EventArgs e)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "UPDATE Accounts SET state = 'Offline' WHERE un = '" + SignIn_Screen.getValue + "'";
            _command.ExecuteNonQuery();
            adaper.SelectCommand = _command;

            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label_Edit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;

            txt_id.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_ho.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_tenhs.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtp_ngaySinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            cb_gioitinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;

            txt_id.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_ho.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_tenhs.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtp_ngaySinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            cb_gioitinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            Boolean check = false;

            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txt_id.Text)
                    {
                        MessageBox.Show("Mã Học Sinh không được trùng");
                        check = false;
                        break;
                    }
                    check = true;
                }
            } catch (NullReferenceException n){
                n.ToString();
            }

            if (check)
            {
                _command = _connection.CreateCommand();
                _command.CommandText = "INSERT INTO ThongTinSinhVien (MaHS, HoSV, TenSV, Ngaysinh, GioiTinh) VALUES ('" + txt_id.Text + "','" + txt_ho.Text + "','" + txt_tenhs.Text + "','" + dtp_ngaySinh.Value + "','" + cb_gioitinh.Text + "')";
                _command.ExecuteNonQuery();
                loaddata();
                button_Confirm.Visible = false;
                button_Cancel.Visible = false;
                txt_ho.ReadOnly = true;
                txt_id.ReadOnly = true;
                txt_tenhs.ReadOnly = true;
            }
            

            /*
            string add = "insert into ThongTinSinhVien values (@MaSV, @HoSV, @TenSV, @NgaySinh , @Gioitinh)";
            _command = new SqlCommand(add, _connection);
            _command.Parameters.AddWithValue("MaSV", txt_id.Text);
            _command.Parameters.AddWithValue("HoSV", txt_ho.Text);
            _command.Parameters.AddWithValue("TenSV", txt_tenhs.Text);
            _command.Parameters.AddWithValue("NgaySinh", dtp_ngaySinh.Text);
            _command.Parameters.AddWithValue("Gioitinh", cb_gioitinh.Text);
            _command.ExecuteNonQuery();
            loaddata();
            */
        }

        private void label3_Click(object sender, EventArgs e)
        {
        
            _command = _connection.CreateCommand();
            _command.CommandText = "SELECT  COUNT (MaHS) FROM [ThongTinSinhVien] ";
            _command.ExecuteNonQuery();
            Int32 count = (Int32)_command.ExecuteScalar();

            MessageBox.Show("Tong So Sinh Vien " + count);



        }

        private void dtp_ngaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            button_Confirm.Visible = false;
            button_Cancel.Visible = false;
            txt_ho.ReadOnly = true;
            txt_id.ReadOnly = true;
            txt_tenhs.ReadOnly = true;
        }
    }
}
