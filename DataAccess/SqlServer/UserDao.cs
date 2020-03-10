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
        //
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(7) + ", " + reader.GetString(8);
                        string userMail = reader.GetString(3);
                        string accountPassword = reader.GetString(4);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "Система: запрос на восстановление пароля",
                            body: "Здравствуйте, " + userName + "\nВы сделали запрос на восстановление пароля\n" +
                            "Ваш текущий пароль: " + accountPassword +
                            "\nЖелательно после входа в систему сменить пароль для безопасности.",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Здравствуйте, " + userName + "\nВы сделали запрос на восстановление пароля\n" +
                            "проверьте вашу почту: " + userMail +
                            "\nЖелательно после входа в систему сменить пароль для безопасности.";
                    }
                    else
                        return "К сожалению, у вас нет учетной записи с этим именем пользователя или почты.";
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
            if (UserLoginCache.Position == Positions.Courier)
            {
                
            }
        }
    }
}
