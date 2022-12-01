using System;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class WeatherInformerForm : Form
    {
        private DB db = DB.getDB();
        private string userName = "";
        public WeatherInformerForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            DB db = DB.getDB();
            WeatherSite site = new WeatherSite();
            string sity = db.GetCityOfUser(userName);
            userNameLabel.Text = userName + " " + sity;
            weatherWWLable.Text = site.GetWeather(sity, "WW");
            weatherNGSLabel.Text = site.GetWeather(sity, "NGS");
            weatherPPLabel.Text = site.GetWeather(sity, "PP");
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
            db.WriteClothesToUser(userName, form.AddeedClothes);
            
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