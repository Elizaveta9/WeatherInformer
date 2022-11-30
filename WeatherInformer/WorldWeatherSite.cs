using System;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeatherInformer
{
    public class WorldWeatherSite : IWeatherSite
    {
        DB db = DB.getDB();

        public string GetWeather(string cityName, string siteName)
        {
            string weather = "";
            DataTable siteTable = db.GetSiteInfo(siteName);
            try
            {
                WebClient client = new WebClient();
                string html =
                    client.DownloadString(siteTable.Rows[0]["url"] + cityName + "/");


                Regex regex = new Regex(siteTable.Rows[0]["temperature_regex"].ToString());
                MatchCollection matches = regex.Matches(html);

                var match = matches[0];
                weather = match.ToString();

                regex = new Regex(siteTable.Rows[0]["temperature_value_regex"].ToString());
                matches = regex.Matches(weather);
                
                match = matches[0];
                weather = match.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return weather;
        }
    }
}