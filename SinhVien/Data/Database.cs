using System;
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
        private static SqlConnection _connection = null;
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
            _command.ExecuteNonQuery();
            adaper.SelectCommand = _command;
            table.Clear();

            adaper.Fill(table);
        }

        public static void update(String table, String column, String WHERE)
        {
            _command.CommandText = "UPDATE " + table + " SET " + column + " WHERE " + WHERE + "'";
            _command.ExecuteNonQuery();
            adaper.SelectCommand = _command;
        }

        public static void openConnection(String tableName)
        {
            _connection = new SqlConnection(str);
            _connection.Open(); // mo ket noi

            loadData(tableName);
        }
    }
}
