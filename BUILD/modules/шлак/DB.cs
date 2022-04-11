using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BUILD.modules
{
    public class DB
    {
        private SqlConnection _connection = new SqlConnection();

        public DB()
        {
            //string conn= "Server=localhost\\DESKTOP-BT6E7LB;Database=_BUILD_;Trusted_Connection=True;";
            try
            {
                string conn = "Server=DESKTOP-BT6E7LB;Database=_BUILD_;Trusted_Connection=True;";
                _connection.ConnectionString = conn;
                Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка в подключения БД", "Приехали", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        public SqlConnection GetConnection()
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