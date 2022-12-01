using System;
using System.Data;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class WeatherInformerForm : Form
    {
        private DB db = DB.getDB();
        private DataTable clothesTable;
        private string userName = "";
        private int avgTemperature;
        public WeatherInformerForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            DB db = DB.getDB();
            string city = db.GetCityOfUser(userName);
            WeatherSite ww = new WeatherSite("WW", city);
            WeatherSite ngs = new WeatherSite("NGS", city);
            WeatherSite pp = new WeatherSite("PP", city);
            userNameLabel.Text = "Пользователь: " + userName;
            weatherWWLable.Text = ww.GetTemperature();
            weatherNGSLabel.Text = ngs.GetTemperature();
            weatherPPLabel.Text = pp.GetTemperature();
            precipitationWWLabel.Text = ww.GetPrecipitation();
            precipitationNgsLabel.Text = ngs.GetPrecipitation();
            precipitationPPLabel.Text = pp.GetPrecipitation();
            ww.WriteToDb();
            ngs.WriteToDb();
            pp.WriteToDb();
            avgTemperature = db.GetAvgTemperatureForToday(DateTime.Now.Date);
            if (avgTemperature > 0)
            {
                avgTemperatureLabel.Text = "+" + avgTemperature;
            }
            else
            {
                avgTemperatureLabel.Text = avgTemperature.ToString();
            }
            try
            {
                clothesTable = db.GetUsersClothesInTemperatureRange(userName, avgTemperature);
                foreach (DataRow clothesTableRow in clothesTable.Rows)
                {
                    clothesListBox.Items.Add(clothesTableRow["name"]);
                }
            }
            catch
            {
                clothesListBox.Items.Add("Нет подходящей одежды");
            }
            
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
            AddClothesForm form = new AddClothesForm(userName);
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