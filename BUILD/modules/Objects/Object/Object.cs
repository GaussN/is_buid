using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUILD.modules.Objects;

namespace BUILD.modules.objects
{
    public class @Object : Iasd
    {
        private int _id;
        private string _title;
        private int _id_user;
        private int? _id_brigade;
        private double _area;
        private string _state;

        #region [get,set]

        public int Id => _id;

        public string Title => _title;

        public int IdUser => _id_user;

        public int? IdBrigade => _id_brigade;

        public double Area => _area;

        public string State => _state;

        #endregion

        public @Object(int id, string title, int idUser, int? idBrigade, double area, string state)
        {
            _id = id;
            _title = title;
            _id_user = idUser;
            _id_brigade = idBrigade;
            _area = area;
            _state = state;
        }
        public void Update(TableService servise, DataGridView grid){
            servise.FillObjectsTable(grid);
        }
        private void executeRequest(string cmd)
        {
            try
            {
                DB db = new DB();
                SqlCommand command = new SqlCommand(cmd, db.GetConnection());
                command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка в SQL\n{e.Message}", "Ого!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        public void Insert()
        {
            (new OInsertForm()).ShowDialog();
        }

        public void Change(DataGridViewRow row)
        {
            var x = row.Cells[3].Value.ToString().Trim();
            if (String.IsNullOrEmpty(x))
                x = "-1";
            //это уже пизда, а не магические числа
            
            this._id = int.Parse(row.Cells[0].Value.ToString().Trim());
            this._title = row.Cells[1].Value.ToString().Trim();
            this._id_user = int.Parse(row.Cells[2].Value.ToString().Trim());
            this._id_brigade = int.Parse(x);
            this._area = double.Parse(row.Cells[4].Value.ToString().Trim());
            this._state = row.Cells[5].Value.ToString().Trim();

            (new OChangeForm(this)).ShowDialog();
        }

        public void Delete(DataGridViewRow row)
        {
            if (MessageBox.Show("точно?", "за путина?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this._id = int.Parse(row.Cells[0].Value.ToString().Trim());
                string cmd = $"DELETE FROM objects_data WHERE object_id={this._id}";
                executeRequest(cmd);
            }

            
        }
    }
}