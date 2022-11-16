using System;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class AddClothesForm : Form
    {
        DB db = DB.getDB();
        public AddClothesForm()
        {
            InitializeComponent();
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
                db.AddNewClothes(name, Int32.Parse(maxTemp), Int32.Parse(minTemp));
                this.Hide();
            }
            else
            {
                MessageBox.Show(@"Температуру необходимо указывать используя только знаки +, - и цифры");
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