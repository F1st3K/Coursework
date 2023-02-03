using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AISShopComputerParts.Logic
{
    internal sealed class MySqlExecutor
    {
        private static MySqlExecutor _instance;
        private string _connectionString;
        private  MySqlConnection _dbConection;

        public MySqlExecutor(string connectionString)
        {
            _instance = this;
            _connectionString = connectionString;
            _dbConection = new MySqlConnection(_connectionString);
        }

        public static MySqlExecutor GetInstance()
        {
            if (_instance == null)
                throw new ArgumentNullException("Instace is null, create him.");
            return _instance;
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
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                MessageBox.Show(ex.Message + "\n" + query, "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
