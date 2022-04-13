using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUILD.modules.Objects;

namespace BUILD.modules.objects
{
    public class Brigade : Iasd
    {
        private int _id;
        private int _id_brigadier;
        private string _name;
        private string _surname;

        #region [get,set]

        public int Id => _id;
        public int IdBrigadier => _id_brigadier;
        public string Name => _name;
        public string Surname => _surname;
        
        #endregion

        public Brigade(int id, int idBrigadier, string name, string surname)
        {
            _id = id;
            _id_brigadier = idBrigadier;
            this._name = name;
            _surname = surname;
        }

        private void executeRequest(string cmd)
        {
            try
            {
                DB db = new DB();
                SqlCommand command = new SqlCommand(cmd, db.GetConnection());
                //command.ExecuteReader();
                command.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка в SQL\n{e.Message}", "Люди!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(cmd);
                //throw;
            }
        }
        
        
        public void Insert()
        {
            (new BInsertForm()).ShowDialog();
        }

        public void Change(DataGridViewRow row)
        {
            _id = int.Parse(row.Cells[0].Value.ToString().Trim());
            _id_brigadier = int.Parse(row.Cells[1].Value.ToString().Trim());
            _name = row.Cells[2].Value.ToString().Trim();
            _surname = row.Cells[3].Value.ToString().Trim();
            (new BChangeForm(this)).ShowDialog();
        }

        public void Update(TableService servise, DataGridView grid)
        {
            servise.FillBrigadesTable(grid);
        }

        public void Delete(DataGridViewRow row)
        {
            if (MessageBox.Show("Удалять?","Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _id = int.Parse(row.Cells[0].Value.ToString().Trim());
                _id_brigadier = int.Parse(row.Cells[1].Value.ToString().Trim());
                string cmd1 = $"UPDATE objects_data SET brigade_id=NULL WHERE brigade_id={this.Id}";
                string cmd2 = $"UPDATE workers SET brigade_id=NULL WHERE brigade_id={this.Id}";
                string cmd3 = $"DELETE FROM brigades WHERE brigadier_id={this.IdBrigadier}";
                string cmd4 = $"DELETE FROM brigadiers WHERE brigadier_id={this.IdBrigadier}";

                //
                // MessageBox.Show(cmd1);
                // MessageBox.Show(cmd2);
                // MessageBox.Show(cmd3);
                // MessageBox.Show(cmd4);

                try
                {
                    executeRequest(cmd1);
                    executeRequest(cmd2);
                    executeRequest(cmd3);
                    executeRequest(cmd4);

                }
                catch (Exception e)
                {
                    //pass
                }
            }
        }
    }
}