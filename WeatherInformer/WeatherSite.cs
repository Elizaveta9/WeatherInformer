using System;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeatherInformer
{
    public class WeatherSite
    {
        DB db = DB.getDB();
        private string siteName;
        private string html;
        private string temperature = "";
        private string precipitation = "";
        private DataTable siteTable;

        public WeatherSite(string siteName, string cityName)
        {
            try
            {
                this.siteName = siteName;
                siteTable = db.GetSiteInfo(siteName);
                WebClient client = new WebClient();
                html =
                    client.DownloadString(siteTable.Rows[0]["url"] + cityName + "/");
            }
            catch{}
        }

        public string GetTemperature()
        {
            try
            {
                Regex regex = new Regex(siteTable.Rows[0]["temperature_regex"].ToString());
                MatchCollection matches = regex.Matches(html);
                var match = matches[0];
                temperature = match.ToString();
                regex = new Regex(siteTable.Rows[0]["temperature_value_regex"].ToString());
                matches = regex.Matches(temperature);
                match = matches[0];
                temperature = match.ToString();
            }
            catch
            {
                temperature = "999";
                return "--";
            }
            return temperature + "°";
        }

        public string GetPrecipitation()
        {
            try
            {
                Regex regex = new Regex(siteTable.Rows[0]["precipitation_regex"].ToString());
                MatchCollection matches = regex.Matches(html);
                var match = matches[0];
                precipitation = match.ToString();
                regex = new Regex(siteTable.Rows[0]["precipitation_value_regex"].ToString());
                matches = regex.Matches(precipitation);
                match = matches[0];
                precipitation = match.ToString();
            }
            catch{}
            return precipitation;
        }

        public void WriteToDb()
        {
            try
            {
                if (!temperature.Equals(""))
                {
                    db.UpdateWeather((int)siteTable.Rows[0]["id"], Int32.Parse(temperature), DateTime.Now.Date,
                        precipitation);
                }
            }
            catch{}
        }
    }
}