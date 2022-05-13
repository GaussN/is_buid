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
            try
            {
                string conn = "server=localhost;user=root;database=_BUILD_;port=3306;password=root;";
                _connection.ConnectionString = conn;
                Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка в подключения БД", "Приехали", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(exception.Message);
                Application.Exit();
            }
        }
        //лямбда 
        public MySqlConnection GetConnection() =>_connection;
            public void Open()
        {
            _connection.Open();
        }
        public void Close()
        {
            _connection.Close();
        }
        ~DB()=>Close();   
        
    }
}