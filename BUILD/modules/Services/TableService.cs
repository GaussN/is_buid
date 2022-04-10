using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            
            string cmd = query == null ? ("SELECT * FROM " + table) : query;
            DB db = new DB();
            SqlDataAdapter command = new SqlDataAdapter(cmd, db.GetConnection());
            DataSet dataSet = new DataSet();

            command.Fill(dataSet, table);
            dataGridView.DataSource = dataSet.Tables[table];
        }

        public void FillUserTable(DataGridView dataGridView)
        {
            this.fillTable(dataGridView, "users_data");
        }

        public void FillWorkersTable(DataGridView dataGridView)
        {
            string cmd = "select * from workers";
            if (!this._user.rights)
                cmd += $" where brigade_id=(select brigade_id from objects_data where user_id={this._user.id})";
            this.fillTable(dataGridView, "workers", cmd);
        }

        public void FillBrigadesTable(DataGridView dataGridView)
        {
            string cmd =
                "select brigade_id as id, brigadiers.* from brigades, brigadiers where brigades.brigadier_id=brigadiers.brigadier_id";
            if (!this._user.rights)
                cmd += $" and brigade_id=(select brigade_id from objects_data where user_id={this._user.id})";
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