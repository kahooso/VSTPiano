using _keys;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace DatabaseHelper
{
    public class DatabaseHelper
    {
        public static List<Users> load_users()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<Users>("SELECT * FROM users", new DynamicParameters()).ToList();
            }
        }

        public static void SaveUser(Users user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO users (login, password, time) values (@login, @password, @time)", user);
            }
        }

        public static Users AuthenticateUser(string login, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var user = cnn.QueryFirstOrDefault<Users>("select * from users where login = @login and password = @password", new { login, password });
                return user;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void UpdateUserTime(Users user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update users set time = @time where login = @login", new { user.time, user.login });
            }
        }
    }
}
