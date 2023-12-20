using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace world_resources.models
{
    internal class Consumption
    {
        public String countryName { get; set; }
        public String resourceName { get; set; }
        public String resourceUnit { get; set; }
        public double amount { get; set; }
        public String periodStart { get; set; }
        public String periodEnd { get; set; }

        public static List<Consumption> getAll()
        {
            List<Consumption> consumptions = new List<Consumption>();

            DB dB = new DB();

            String query = "SELECT countries.name country_name, resources.name resource_name, resources.unit resource_unit, amount, period_start, period_end " +
                "FROM consumptions " +
                "JOIN countries ON countries.id = country_id " +
                "JOIN resources ON resources.id = resource_id";

            SqlConnection connection = dB.getConnection();

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader != null)
            {
                while (reader.Read())
                {
                    Consumption consumption = new Consumption();

                    consumption.countryName = reader["country_name"].ToString();
                    consumption.resourceName = reader["resource_name"].ToString();
                    consumption.resourceUnit = reader["resource_unit"].ToString();
                    consumption.amount = Convert.ToDouble(reader["amount"].ToString());
                    consumption.periodStart = reader["period_start"].ToString().Split(' ')[0];
                    consumption.periodEnd = reader["period_end"].ToString().Split(' ')[0];

                    consumptions.Add(consumption);
                }
            }

            connection.Close();

            return consumptions;
        }
    }
}
