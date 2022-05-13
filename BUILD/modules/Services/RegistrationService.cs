using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules
{
    public class RegistrationService
    {
        public class LoginAlreadyExists : Exception
        {
            public LoginAlreadyExists() : base("Такой логин уже используется") { }
        }

        public static void RegisterUser(User user, string login, string password)
        {
            try
            {
                DB db = new DB();
                string checkLogin =
                    $"SELECT count(user_login) FROM autorization_data WHERE user_login=\'{login}\';";
                string addUserData =
                    $"INSERT INTO users_data(user_name, user_surname, user_rights) values('{user.name}', '{user.surname}', 0);\n";
                string addAutData =
                    $"INSERT INTO autorization_data(user_id, user_login, user_password) values((select max(user_id) from users_data where user_name='{user.name}' and user_surname='{user.surname}'), '{login}', '{password}');";
                MySqlCommand checkLoginQuery = new MySqlCommand(checkLogin, db.GetConnection());
                var re = checkLoginQuery.ExecuteReader();
                re.Read();
                if (re[0].ToString() != "0")
                {
                    throw new LoginAlreadyExists();
                }
                re.Close();
                MySqlCommand command = new MySqlCommand(addUserData + addAutData, db.GetConnection());
                command.ExecuteNonQuery();
            }
            catch (LoginAlreadyExists loginException)
            {
                MessageBox.Show(loginException.Message);
                throw;
            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}