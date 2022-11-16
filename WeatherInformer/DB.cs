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

        private static DB instanceDb;

        private DataTable cities = null;

        private DB()
        {
        }

        public static DB getDB()
        {
            if (instanceDb == null)
                instanceDb = new DB();
            return instanceDb;
        }

        public DataTable GetCities()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM city ORDER BY name");
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command.CommandText, connection);

                cities = new DataTable();

                dataAdapter.Fill(cities);

                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cities;
        }

        public bool AddUser(string name, string password, string city)
        {
            bool result = false;
            try
            {
                //TODO сделать проверку на наличие пользователя, добавить проврку "был ли осуществлён вход на этом компе", заполнены ли все поля
                //TODO шифровка пароля

                //проверка наличия пользователя
                SqlCommand commandCheckUser = new SqlCommand("SELECT name FROM users WHERE name = @name", connection);
                commandCheckUser.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable tableForCheckingUsers = new DataTable();

                adapter.SelectCommand = commandCheckUser;
                adapter.Fill(tableForCheckingUsers);

                if (tableForCheckingUsers.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с таким именем уже есть в системе");
                    result = false;
                }
                else
                {
                    //добавление пользователя
                    DataRow[] cityRows = cities.Select("name = '" + city + "'");

                    SqlCommand command =
                        new SqlCommand("INSERT INTO users(name, password, city_id) VALUES (@name, @password, @city_id)",
                            connection);
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                    command.Parameters.Add("@city_id", SqlDbType.Int).Value = cityRows[0][0];

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    result = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return result;
        }

        public DataTable GetStandartClothes()
        {
            DataTable table = new DataTable();
            SqlCommand command =
                new SqlCommand(
                    "SELECT id, name AS Название, RTRIM('от' + str(min_temperature) + ' до' + str(max_temperature)) AS Температура FROM clothes WHERE is_standart='Y'",
                    connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        
        public DataTable GetAllClothes()
        {
            DataTable table = new DataTable();
            SqlCommand command =
                new SqlCommand(
                    "SELECT id, name AS Название, RTRIM('от' + str(min_temperature) + ' до' + str(max_temperature)) AS Температура FROM clothes",
                    connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public void WriteClothesToUser(string userName, List<DataGridViewRow> clothes)
        {
            int userId = GetUserIdByName(userName);

            if (userId != 0)
            {
                SqlCommand command = new SqlCommand("INSERT INTO user_clothes(user_id, clothes_id) VALUES (@userId, @clothesId)", connection);
                command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@clothesId", SqlDbType.Int);

                connection.Open();
                foreach (DataGridViewRow clothesRow in clothes)
                {
                    command.Parameters["@clothesId"].Value = clothesRow.Cells["id"].Value;
                    command.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Одежда успешно добавлена");
            }
            else
            {
                MessageBox.Show("Индекс пользователя равен 0");
            }
        }

        public void WriteStandardClothesToUser(string userName)
        {
            int userId = 0;
            DataTable clothes = GetStandartClothes();
            
            connection.Open();
            try
            {
                userId = GetUserIdByName(userName);
                if (userId != 0)
                {
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO user_clothes(user_id, clothes_id) VALUES (@userId, @clothesId)",
                        connection);
                    command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                    command.Parameters.Add("@clothesId", SqlDbType.Int);

                    foreach (DataRow tableRow in clothes.Rows)
                    {
                        command.Parameters["@clothesId"].Value = tableRow["id"];
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Индекс пользователя равен 0");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        public void AddNewClothes(string name, int maxTemp, int minTemp)
        {
            try
            {
                SqlCommand command =
                    new SqlCommand(
                        "INSERT INTO clothes(name, min_temperature, max_temperature) VALUES (@name, @minTemp, @maxTemp)",
                        connection);
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@minTemp", SqlDbType.Int).Value = minTemp;
                command.Parameters.Add("@maxTemp", SqlDbType.Int).Value = maxTemp;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public Int32 GetUserIdByName(string name)
        {
            int id = 0;
            SqlCommand command = new SqlCommand("SELECT id FROM users WHERE name = @name", connection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
                
            }
            reader.Close();
            connection.Close();
            return id;
        }
    }
}