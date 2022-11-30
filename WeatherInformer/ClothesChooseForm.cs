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
            checkColumn.Name = "Выбор";
            clothesDataGrid.Columns.Insert(0, checkColumn);
            
            this.userName = userName;
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            WeatherInformerForm form = new WeatherInformerForm(userName);
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
            
            WeatherInformerForm form = new WeatherInformerForm(userName);
            this.Hide();
            form.Show();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            var checkedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in clothesDataGrid.Rows)
            {
                if (row.Cells["Выбор"].Value.Equals(true))
                {
                    checkedRows.Add(row);
                }
            }
            db.WriteClothesToUser(userName, checkedRows);
            WeatherInformerForm form = new WeatherInformerForm(userName);
            this.Hide();
            form.Show();
        }
        
        private void addClothesButton_Click(object sender, EventArgs e)
        {
            AddClothesForm form = new AddClothesForm();
            form.ShowDialog();
        }

        private void ClothesChooseForm_Activated(object sender, EventArgs e)
        {
            InitializeTableClothes();
            foreach (DataGridViewRow dataGridViewRow in clothesDataGrid.Rows)
            {
                dataGridViewRow.Cells["Выбор"].Value = false;
            }
        }

        private void InitializeTableClothes()
        {
            clothesTable = db.GetAllClothes();
            clothesDataGrid.DataSource = clothesTable;
        }
    }
}