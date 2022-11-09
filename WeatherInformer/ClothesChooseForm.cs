using System;
using System.Data;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class ClothesChooseForm : Form
    {
        private DB db = DB.getDB();
        private DataTable clothesTable = null;
        public ClothesChooseForm()
        {
            InitializeComponent();

            
            clothesTable = db.GetStandartClothes();
            clothesDataGrid.DataSource = clothesTable;
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

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}