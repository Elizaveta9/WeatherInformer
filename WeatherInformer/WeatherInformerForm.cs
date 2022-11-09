using System;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class WeatherInformerForm : Form
    {
        public WeatherInformerForm()
        {
            InitializeComponent();
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
            throw new System.NotImplementedException();
        }
    }
}