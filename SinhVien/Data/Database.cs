﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace SinhVien.Data
{
    internal class Database
    {
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static string str = "Data Source=LAPTOP-SKAKNRQ2;Integrated Security=True;Initial Catalog=QLSV";
        private static SqlDataAdapter adaper = new SqlDataAdapter();

        private static DataTable table = new DataTable();

        public static DataTable Table => table;

        public static SqlDataAdapter Adapter => adaper;

        public static void loadData(String tableName)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "SELECT * FROM " + tableName;
            adaper.SelectCommand = _command;
            table.Clear();

            adaper.Fill(table);            
        }

        public static void loadData(String tableName, String WHERE, String LIKE)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "SELECT * FROM " + tableName + " WHERE " + WHERE + " LIKE " + LIKE;
            adaper.SelectCommand = _command;
            table.Clear();

            adaper.Fill(table);
        }

        public static void fillGridView(System.Windows.Forms.DataGridView dataGridView)
        {
            dataGridView.DataSource = table;
        }

        public static void update(String tableName, String VALUES, String WHERE, String MaHS)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "UPDATE " + tableName + " SET " + VALUES + " WHERE " + WHERE;
            //_command.CommandText = "Insert into ThongTinSinhVien ( MaHS , HoSV, TenSV, Ngaysinh, GioiTinh) Values ('" + MaHS + " ' , 'B' , 'C' , '03/03/2000' , 'Nam')";
            _command.ExecuteNonQuery();
        }

        public static void update(String tableName, String VALUES)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "UPDATE " + tableName + " SET " + VALUES;
            _command.ExecuteNonQuery();
        }

        public static void insert(String tableName, String VALUES)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "INSERT INTO " + tableName + " VALUES " + VALUES + ";";
        }

        public static void delete(String table, String WHERE)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "DELETE FROM " + table + " WHERE " + WHERE + ";";
            _command.ExecuteNonQuery();
        }

        public static int count(String tableName, String VALUE)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = "SELECT COUNT " + VALUE + " FROM " + tableName;
            _command.ExecuteNonQuery();
            Int32 count = (Int32)_command.ExecuteScalar();

            return count;
        }

        public static void openConnection()
        {
            _connection = new SqlConnection(str);
            _connection.Open(); // mo ket noi
        }
    }
}
