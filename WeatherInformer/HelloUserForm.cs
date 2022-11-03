using System;
using System.Data;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class HelloUserForm : Form
    {
        private string name = "";
        private string password = "";
        private string city = "";

        private DB db = new DB();

        public HelloUserForm()
        {
            InitializeComponent();

            // cityComboBox.Items.Add("Пенза");
            // cityComboBox.Items.Add("Москва");
            // cityComboBox.Items.Add("Воронеж");

            DataTable table = db.GetCities();

            foreach (DataRow row in table.Rows)
            {
                cityComboBox.Items.Add(row["name"]);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            password = passwordTextBox.Text;
            city = cityComboBox.Text;

            MessageBox.Show(name + " " + password + " " + city);

            db.AddUser(name, password, city);
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            city = cityComboBox.SelectedItem.ToString();
        }
    }
}