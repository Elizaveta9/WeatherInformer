using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WeatherInformer
{
    public class DB
    {
        private SqlConnection connection =
            new SqlConnection("Server=localhost;Database=weather_informer;Trusted_Connection=True");

        private DataTable cities = null;
        
        public DataTable GetCities()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM city ORDER BY name");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command.CommandText, connection);

            cities = new DataTable();

            dataAdapter.Fill(cities);

            return cities;
        }

        public void AddUser(string name, string password, string city)
        {
            try
            {
                //TODO сделать проверку на наличие пользователя
                
                DataRow[] cityRows = cities.Select("name = '" + city + "'");

                SqlCommand command =
                    new SqlCommand("INSERT INTO users(name, password, city_id) VALUES (@name, @password, @city_id)",connection);
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                command.Parameters.Add("@city_id", SqlDbType.Int).Value = cityRows[0][0];
             
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                
                MessageBox.Show("user added");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}