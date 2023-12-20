using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace world_resources.models
{
    internal class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public static List<User> getAll()
        {
            List<User> users = new List<User>();

            DB dB = new DB();

            String query = "SELECT id, login, password FROM users";

            SqlConnection connection = dB.getConnection();

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader != null)
            {
                while (reader.Read())
                {
                    User user = new User();

                    user.id = Convert.ToInt32(reader["id"]);
                    user.login = reader["login"].ToString();
                    user.password = reader["password"].ToString();

                    users.Add(user);
                }
            }

            connection.Close();

            return users;
        }
    }
}
