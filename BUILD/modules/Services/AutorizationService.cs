﻿using System.Data.SqlClient;

namespace BUILD.modules
{
    public class AutorizationService
    {
        public static User UserAutorization(string login, string password)
        {
            User user = new User() { id=-1 };
            string cmd = $"select * from users_data where user_id=(select user_id from autorization_data where user_password=\'{password}\' and user_login=\'{login}\')";
            DB db = new DB();
            SqlCommand command = new SqlCommand(cmd, db.GetConnection());
            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows == true)
                {
                    reader.Read();
                    user.id = int.Parse(reader[0].ToString());
                    user.name = reader[1].ToString().Trim();
                    user.surname = reader[2].ToString().Trim();
                    user.rights = bool.Parse(reader[3].ToString());
                }
            }
            return user;
        }
    }
}