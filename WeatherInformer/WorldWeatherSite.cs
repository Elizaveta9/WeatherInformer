using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeatherInformer
{
    public class WorldWeatherSite : IWeatherSite
    {
        public string GetWeather(string cityName)
        {
            string weather = "";
            try
            {
                WebClient client = new WebClient();
                string html =
                    client.DownloadString("https://world-weather.ru/pogoda/russia/" + cityName + "/");


                Regex regex = new Regex(@"<div id=""weather-now-number"">.{1,3}<span>");
                MatchCollection matches = regex.Matches(html);

                foreach (Match match in matches)
                {
                    weather = match.ToString();
                    
                    weather = weather.Replace(@"<div id=""weather-now-number"">", "");
                    weather = weather.Replace("<span>", "");
                }
            }
            catch
            {
                MessageBox.Show("Вы не подключены к интернету. Невозможно получить данные.");
            }

            return weather;

            //TODO очистить вывод от дивов и спанов
        }
    }
}