using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class ClothesChooseForm : Form
    {
        private DB db = DB.getDB();
        private DataTable clothesTable = null;
        private string userName = "";

        public ClothesChooseForm(string userName = "Елизавета")
        {
            InitializeComponent();

            InitializeTableClothes();
            
            clothesDataGrid.Columns["id"].Visible = false;

            foreach (DataGridViewColumn column in clothesDataGrid.Columns)
            {
                column.ReadOnly = true;
            }

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.ReadOnly = false;
            checkColumn.HeaderText = "Выбор";
            clothesDataGrid.Columns.Insert(0, checkColumn);
            this.userName = userName;
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

        private void chooseStandartClothesButton_Click(object sender, EventArgs e)
        {
            db.WriteStandardClothesToUser(userName);
            MessageBox.Show("Выбрано");
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            // var checkedRows = new List<DataGridViewRow>();
            // //собрать чекмарки и присвоить всё юзеру
            //
            // foreach (DataGridViewRow row in clothesDataGrid.Rows)
            // {
            //     //нужен айдишник
            //     //if (row.Cells[0].Value == true)
            // }
        }


        private void addClothesButton_Click(object sender, EventArgs e)
        {
            AddClothesForm form = new AddClothesForm();
            form.ShowDialog();
        }

        private void ClothesChooseForm_Activated(object sender, EventArgs e)
        {
            InitializeTableClothes();
        }

        private void InitializeTableClothes()
        {
            clothesTable = db.GetAllClothes();
            clothesDataGrid.DataSource = clothesTable;
        }
    }
}