using System;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class WeatherInformerForm : Form
    {
        public WeatherInformerForm(string userName)
        {
            InitializeComponent();
            
            DB db = DB.getDB();
            WorldWeatherSite WwSite = new WorldWeatherSite();
            string sity = db.GetCityOfUser(userName);
            userNameLabel.Text = userName + " " + sity;
            weatherWWLable.Text = WwSite.GetWeather(sity, "WW");
            weatherNGSLabel.Text = WwSite.GetWeather(sity, "NGS");
            weatherPPLabel.Text = WwSite.GetWeather(sity, "PP");
        }

        private void WeatherInformerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            HelloUserForm form = new HelloUserForm();
            this.Hide();
            form.Show();
        }

        private void addClothesButton_Click(object sender, EventArgs e)
        {
            AddClothesForm form = new AddClothesForm();
            form.ShowDialog();
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            UserNameAndPasswordForm form = new UserNameAndPasswordForm();
            form.ShowDialog();
            if (form.IsIdetified)
            {
                this.Hide();
            }
        }
        
    }
}