using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WeatherInformer
{
    public class DB
    {
        private SqlConnection Connection =
            new SqlConnection("Server=localhost;Database=weather_informer;Trusted_Connection=True");

        public DataTable GetCities()
        {
            SqlCommand command = new SqlCommand("SELECT name FROM city ORDER BY name");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command.CommandText, Connection);

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            return table;
        }
    }
}