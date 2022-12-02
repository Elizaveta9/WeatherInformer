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
                cities = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM city ORDER BY name");
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command.CommandText, connection);

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
                SqlCommand commandCheckUser = new SqlCommand("SELECT name FROM users WHERE name = @name", connection);
                commandCheckUser.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                DataTable tableForCheckingUsers = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(commandCheckUser);
                adapter.Fill(tableForCheckingUsers);
                if (tableForCheckingUsers.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с таким именем уже есть в системе", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    result = false;
                }
                else
                {
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
            SqlDataAdapter adapter = new SqlDataAdapter(command);
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
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }

        public void WriteClothesToUser(string userName, List<DataGridViewRow> clothes)
        {
            int userId = GetUserIdByName(userName);

            if (userId != 0)
            {
                SqlCommand command =
                    new SqlCommand("INSERT INTO user_clothes(user_id, clothes_id) VALUES (@userId, @clothesId)",
                        connection);
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

                    connection.Open();
                    foreach (DataRow tableRow in clothes.Rows)
                    {
                        command.Parameters["@clothesId"].Value = tableRow["id"];
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                    MessageBox.Show("Выбран стандартный набор одежды");
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
        }

        public DataTable AddNewClothes(string name, int maxTemp, int minTemp)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT name FROM clothes WHERE name = @name", connection);
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Данная одежда уже записана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new DataTable();
                }
                command =
                    new SqlCommand(
                        "INSERT INTO clothes(name, min_temperature, max_temperature) VALUES (@name, @minTemp, @maxTemp)",
                        connection);
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@minTemp", SqlDbType.Int).Value = minTemp;
                command.Parameters.Add("@maxTemp", SqlDbType.Int).Value = maxTemp;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return GetLastAddedClothes();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return GetLastAddedClothes();
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

        public string GetCityOfUser(string userName)
        {
            string city = "";
            SqlCommand command =
                new SqlCommand(
                    "SELECT nameTranslit FROM city INNER JOIN users ON city.id = users.city_id WHERE users.name = @userName",
                    connection);
            command.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                city = reader.GetString(0);
            }

            reader.Close();
            connection.Close();
            return city;
        }

        public DataTable FindUserByNameAndPassword(string name, string password)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE name = @name AND password = @password",
                connection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetSiteInfo(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM site WHERE name = @name", connection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetLastAddedClothes()
        {
            SqlCommand command = new SqlCommand("SELECT max(id) as 'id' FROM clothes", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void WriteClothesToUser(string userName, DataTable addeedClothes)
        {
            int userId = GetUserIdByName(userName);
            if (userId != 0)
            {
                SqlCommand command =
                    new SqlCommand("INSERT INTO user_clothes(user_id, clothes_id) VALUES (@userId, @clothesId)",
                        connection);
                command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@clothesId", SqlDbType.Int);
                connection.Open();
                foreach (DataRow clothesRow in addeedClothes.Rows)
                {
                    command.Parameters["@clothesId"].Value = Int32.Parse(clothesRow["id"].ToString());
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

        public int GetLastLoggedUserId()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM last_logged_user", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            int id = Int32.Parse(table.Rows[0][0].ToString());
            return id;
        }

        public string GetUserNameById(int userId)
        {
            SqlCommand command = new SqlCommand("SELECT name FROM users WHERE id = @id", connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            string name = table.Rows[0][0].ToString();
            return name;
        }

        public void SetLastLoggedUser(string name)
        {
            SqlCommand command =
                new SqlCommand("UPDATE last_logged_user SET user_id = @id",
                    connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = GetUserIdByName(name);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetUsersClothesInTemperatureRange(string userName, int temperature)
        {
            SqlCommand command =
                new SqlCommand(
                    "SELECT name, min_temperature, max_temperature FROM clothes INNER JOIN user_clothes ON id = clothes_id WHERE user_id = @userId AND min_temperature < @temp AND max_temperature > @temp",
                    connection);
            command.Parameters.Add("@userId", SqlDbType.Int).Value = GetUserIdByName(userName);
            command.Parameters.Add("@temp", SqlDbType.Int).Value = temperature;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public int GetAvgTemperatureForToday(DateTime now)
        {
            int avgTemp = 0;
            try
            {
                SqlCommand command =
                    new SqlCommand(
                        "SELECT avg(temperature) as 'avg' FROM weather WHERE date = @date AND temperature < 999",
                        connection);
                command.Parameters.Add("@date", SqlDbType.Date).Value = now;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                avgTemp = (int)table.Rows[0][0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return avgTemp;
        }

        public void UpdateWeather(int siteId, int temperature, DateTime nowDate, string precipitation)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM weather WHERE date = @nowDate AND site_id = @siteId",
                    connection);
                command.Parameters.Add("@nowDate", SqlDbType.Date).Value = nowDate;
                command.Parameters.Add("@siteId", SqlDbType.Int).Value = siteId;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    command = new SqlCommand(
                        "UPDATE weather SET temperature = @temp, precipitation = @prec WHERE site_id = @siteId",
                        connection);
                    command.Parameters.Add("@temp", SqlDbType.Int).Value = temperature;
                    command.Parameters.Add("@prec", SqlDbType.Text).Value = precipitation;
                    command.Parameters.Add("@siteId", SqlDbType.Int).Value = siteId;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    command = new SqlCommand(
                        "INSERT INTO weather(site_id, temperature, date, precipitation) VALUES (@siteId, @temp, @date, @prec)",
                        connection);
                    command.Parameters.Add("@siteId", SqlDbType.Int).Value = siteId;
                    command.Parameters.Add("@temp", SqlDbType.Int).Value = temperature;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = nowDate;
                    command.Parameters.Add("@prec", SqlDbType.Text).Value = precipitation;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}