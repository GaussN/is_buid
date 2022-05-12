using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules
{
    public class TableService
    {
        private readonly User _user;

        public TableService(User user)
        {
            _user = user;
        }

        private void fillTable(DataGridView dataGridView, string table, string query = null)
        {
            try
            {
                string cmd = query == null ? ("SELECT * FROM " + table) : query;
                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, db.GetConnection());
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, table);
                dataGridView.DataSource = dataSet.Tables[table];
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка в сервисах заполнения таблиц\n{exception.Message}", "Что ты уже сломал?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillUserTable(DataGridView dataGridView)
        {
            this.fillTable(dataGridView, "users_data");
        }

        public void FillWorkersTable(DataGridView dataGridView)
        {
            string cmd = "select * from workers";
            if (!this._user.rights)
                cmd += $" where brigade_id in (select brigade_id from objects_data where user_id={this._user.id})";
            this.fillTable(dataGridView, "workers", cmd);
        }

        public void FillBrigadesTable(DataGridView dataGridView)
        {
            string cmd =
                "select brigade_id as id, brigadiers.* from brigades, brigadiers where brigades.brigadier_id=brigadiers.brigadier_id";
            if (!this._user.rights)
                cmd += $" and brigade_id in (select brigade_id from objects_data where user_id={this._user.id})";
            this.fillTable(dataGridView, "brigades", cmd);
        }

        public void FillObjectsTable(DataGridView dataGridView)
        {
            string cmd = "select * from objects_data";
            if (!this._user.rights)
                cmd += $" where user_id={this._user.id}";
            this.fillTable(dataGridView, "objects_data", cmd);
        }

    }
}