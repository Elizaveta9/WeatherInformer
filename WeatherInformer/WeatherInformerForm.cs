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

            weatherLable.Text = WwSite.GetWeather(db.GetCityOfUser(userName));
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
            // и переключись на нового пользователя
        }

        private void addClothesButton_Click(object sender, EventArgs e)
        {
            AddClothesForm form = new AddClothesForm();
            form.ShowDialog();
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            //медот переключения на пользователя
            UserNameAndPasswordForm form = new UserNameAndPasswordForm();
            form.ShowDialog();
        }
        
    }
}