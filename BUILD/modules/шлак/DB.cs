using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules
{
    public class DB
    {
        private MySqlConnection _connection = new MySqlConnection();

        public DB()
        {
            //string conn= "Server=localhost\\DESKTOP-BT6E7LB;Database=_BUILD_;Trusted_Connection=True;";
            try
            {
                string conn = "server=localhost;user=root;database=_BUILD_;port=3306;password=root;";
                //string conn = "Server=localhost\\SQLEXPRESS;Database=_BUILD_;Trusted_Connection=True;";
                _connection.ConnectionString = conn;
                Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка в подключения БД", "Приехали", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
        }
        public MySqlConnection GetConnection()
        {
            return _connection;
        }
        public void Open()
        {
            _connection.Open();
        }
        public void Close()
        {
            //_connection.Close();
        }
        ~DB()
        {
            Close();   
        }
    }
}