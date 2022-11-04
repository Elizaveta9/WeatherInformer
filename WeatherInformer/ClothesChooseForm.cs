using System;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class ClothesChooseForm : Form
    {
        public ClothesChooseForm()
        {
            InitializeComponent();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            WeatherInformerForm form = new WeatherInformerForm();
            this.Hide();
            form.Show();
        }

        private void ClothesChooseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}