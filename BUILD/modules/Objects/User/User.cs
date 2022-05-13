﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUILD.modules.Objects;
using MySqlConnector;

namespace BUILD.modules.objects
{
    public class User : Iasd
    {
        private int _id;
        private string _name;
        private string _surname;
        private bool _right;
    
        #region [get,set]

        public int Id
        {
            get => _id;
        }
        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            private set => _surname = value;
        }

        public bool Right
        {
            get => _right;
            private set => _right = value;
        }

        #endregion

        public User(int id, string name, string surname, bool right)
        {
            _id = id;
            Name = name;
            Surname = surname;
            Right = right;
        }

        public void Update(TableService service, DataGridView grid)
        {
            service.FillUserTable(grid);
            
        }

        private void executeRequest(string cmd)
        {
            try
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand(cmd, db.GetConnection());
                command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка MySql\n{e.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Change(DataGridViewRow row)
        {
            try
            {
                this._id = int.Parse(row.Cells[0].Value.ToString().Trim());
                this.Name = row.Cells[1].Value.ToString().Trim();
                this.Surname = row.Cells[2].Value.ToString().Trim();
                this.Right = row.Cells[3].Value.ToString().Trim() != "0";
                (new UChangeForm(this)).ShowDialog();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void Insert()
        {
            //этот метод не нужен тк нельзя добавлять новых пользователей
        }
        
        public void Delete(DataGridViewRow row)
        {
            this._id = int.Parse(row.Cells[0].Value.ToString().Trim());
            if (MessageBox.Show("точно?", "уверны?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //executeRequest($"DELETE FROM autorization_data WHERE user_id={this._id}");
                executeRequest($"DELETE FROM objects_data WHERE user_id={this._id}");
                executeRequest($"DELETE FROM users_data WHERE user_id={this._id}");
            }
        }
    }
}