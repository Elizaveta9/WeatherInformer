using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace WeatherInformer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebClient client = new WebClient();
            string html = client.DownloadString("https://www.gismeteo.ru/weather-penza-4445/");
            label1.Text = "";
            Regex regex = new Regex(@"<span class=""sign"">.?</span>.{1,2}<span class=""lower"">");
            MatchCollection matches = regex.Matches(html);
            foreach (Match match in matches)
            {
                
                label1.Text += match;
            }
            
        }
    }
}