using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AISShopComputerParts.BusinessLogic
{
    internal class SqlQueryExecutor
    {
        private static SqlQueryExecutor instance;
        private string _connectionString;
        private  MySqlConnection _dbConection;

        public SqlQueryExecutor()
        {
            _connectionString = "host='localhost';database='carwah_shema';uid='root';pwd='';charset=utf8;";
            _dbConection = new MySqlConnection(_connectionString);
        }

        public SqlQueryExecutor(string connectionString)
        {
            _connectionString = connectionString;
            _dbConection = new MySqlConnection(_connectionString);
        }

        public static SqlQueryExecutor GetInstance()
        {
            if (instance == null)
                instance = new SqlQueryExecutor();
            return instance;
        }

        public DataTable QueryReturn(string query)
        {
            DataTable table = new DataTable();
            try
            {
                _dbConection.Open();
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(table);
                _dbConection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return table;
        }

        public void QueryExecute(string query)
        {
            try
            {
                _dbConection.Open();
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                command.ExecuteNonQuery();
                _dbConection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
