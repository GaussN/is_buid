using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules
{
    public class RegistrationService
    {
        public static void RegisterUser(User user, string login, string password)
        {
            try
            {
                DB db = new DB();
                string addUserData = 
                    $"INSERT INTO users_data(user_name, user_surname, user_rights) values('{user.name}', '{user.surname}', 0);\n";
                string addAutData = 
                    $"INSERT INTO autorization_data(user_id, user_login, user_password) values((select max(user_id) from users_data where user_name='{user.name}' and user_surname='{user.surname}'), '{login}', '{password}');";
                MySqlCommand command = new MySqlCommand(addUserData+addAutData, db.GetConnection());
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                //удалени записи
                DB db = new DB();
                string cmd = "delete from users_data where user_id={}";
                
                MessageBox.Show("Ошибка регистрации нового пользователя\n" + exception.Message, "Пиу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}