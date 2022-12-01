using System;
using System.Data;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class AddClothesForm : Form
    {
        DB db = DB.getDB();
        private string userName;
        public DataTable AddeedClothes
        {
            get { return db.GetLastAddedClothes(); }
        }

        public AddClothesForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string minTemp = minTemperatureTextBox.Text;
            string maxTemp = maxTemperatureTextBox.Text;

            if (name.Equals("") || minTemp.Equals("") || maxTemp.Equals(""))
            {
                MessageBox.Show("Заполните все поля");
            }
            else if (isNumeric(minTemp) && isNumeric(maxTemp))
            {
                int maxTempNum = Int32.Parse(maxTemp);
                int minTempNum = Int32.Parse(minTemp);
                if (minTempNum < maxTempNum)
                {
                    db.WriteClothesToUser(userName, db.AddNewClothes(name, maxTempNum, minTempNum));
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(@"Недопустимое значение температуры");
            }
        }

        private bool isNumeric(string str)
        {
            bool result = false;

            try
            {
                int num = Int32.Parse(str);
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}