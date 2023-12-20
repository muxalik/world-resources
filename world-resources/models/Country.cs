using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace world_resources.models
{
    internal class Country
    {
        public int id { get; set; }
        public string name { get; set; }

        public static List<Country> getAll()
        {
            List<Country> countries = new List<Country>();

            DB dB = new DB();

            String query = "SELECT id, name FROM countries";

            SqlConnection connection = dB.getConnection();

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader != null)
            {
                while (reader.Read())
                {
                    Country country = new Country();

                    country.id = Convert.ToInt32(reader["id"]);
                    country.name = reader["name"].ToString();

                    countries.Add(country);
                }
            }

            connection.Close();

            return countries;
        }
    }
}
