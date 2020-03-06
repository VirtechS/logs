using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao: ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) {
                            UserLoginCache.id = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(7);
                            UserLoginCache.LastName = reader.GetString(8);
                            UserLoginCache.phone = reader.GetString(6);
                            UserLoginCache.Email = reader.GetString(3);
                            UserLoginCache.Position = reader.GetString(9);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        public void AnyMethod() {
            if (UserLoginCache.Position == Positions.Administrator)
            {

            }
            if (UserLoginCache.Position == Positions.Client)
            {

            }
        }
    }
}
