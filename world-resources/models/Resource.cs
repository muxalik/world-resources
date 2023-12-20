using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace world_resources.models
{
    internal class Resource
    {
        public int id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
 
        public static List<Resource> getAll()
        {
            List<Resource> resources = new List<Resource>();

            DB dB = new DB();

            String query = "SELECT id, name, unit FROM resources";

            SqlConnection connection = dB.getConnection();
            
            connection.Open();
            
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader != null )
            {
                while ( reader.Read()) { 
                    Resource resource = new Resource();

                    resource.id = Convert.ToInt32(reader["id"]);
                    resource.name = reader["name"].ToString();
                    resource.unit = reader["unit"].ToString();

                    resources.Add(resource);
                }
            }

            connection.Close();

            return resources;
        }
    }
}
