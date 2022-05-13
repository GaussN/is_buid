using System;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules
{
    public class AutorizationService
    {
        public static User UserAutorization(string login, string password)
        {
            User user = new User() { id=-1 };
            try
            {
                string cmd = $"select * from users_data where user_id=(select user_id from autorization_data where user_password='{password}' and user_login='{login}')";
                DB db = new DB();
                MySqlCommand command = new MySqlCommand(cmd, db.GetConnection());
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        user.id = int.Parse(reader[0].ToString());
                        user.name = reader[1].ToString().Trim();
                        user.surname = reader[2].ToString().Trim();
                        user.rights = Convert.ToBoolean(Convert.ToInt16(reader[3].ToString()));
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка в функции авторизации", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return user;
        }
    }
}