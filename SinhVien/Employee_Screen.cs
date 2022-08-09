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

        void loaddata()
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "select * from ThongTinSinhVien";
            _command.ExecuteNonQuery();
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
            _command.CommandText = "DELETE FROM ThongTinSinhVien WHERE MaSV = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString() + "'";
            adaper.SelectCommand = _command;
            table.Clear();

            adaper.Fill(table);
            dataGridView1.DataSource = table;
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
    }
}
