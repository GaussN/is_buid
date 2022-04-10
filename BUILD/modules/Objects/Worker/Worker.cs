using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUILD.modules.Objects;

namespace BUILD.modules.objects
{
    public class Worker : Iasd
    {
        private int _id;
        private int _id_brigade;
        private string _name;
        private string _surname;
        private string _speciality;
        private int _lvl;

        #region [get,set]

        public int Id => _id;

        public int IdBrigade => _id_brigade;
        public string Name => _name;
        public string Surname => _surname;
        public string Speciality => _speciality;
        public int Lvl => _lvl;

         #endregion

         public Worker(int id, int brid, string name, string surname, string speciality, int lvl)
        {
            _lvl = lvl;
            _id = id;
            _id_brigade = brid;
            _name = name;
            _surname = surname;
            _speciality = speciality;
            _lvl = lvl;
        }

        public void Insert()
        {
            (new WInsertForm(this)).Show();
        }

        public void Change(DataGridViewRow row)
        {
            this._id = int.Parse(row.Cells[0].Value.ToString().Trim());
            this._id_brigade = int.Parse(row.Cells[1].Value.ToString().Trim());
            this._name = row.Cells[2].Value.ToString().Trim();
            this._surname = row.Cells[3].Value.ToString().Trim();
            this._speciality = row.Cells[4].Value.ToString().Trim();
            this._lvl = int.Parse(row.Cells[5].Value.ToString().Trim());
            (new WChangeForm(this)).ShowDialog();
        }

        public void Delete(DataGridViewRow row)
        {
            this._id = int.Parse(row.Cells[0].Value.ToString().Trim());
            if (MessageBox.Show("точно?", "уверны?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                executeRequest($"DELETE FROM workers WHERE worker_id={this._id}");
            }
        }
        private void executeRequest(string cmd)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand(cmd, db.GetConnection());
            command.ExecuteReader();
        }

    }
}