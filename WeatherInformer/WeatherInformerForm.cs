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
    }
}