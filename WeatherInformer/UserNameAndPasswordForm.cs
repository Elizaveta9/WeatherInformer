using System;
using System.Data;
using System.Windows.Forms;

namespace WeatherInformer
{
    public partial class UserNameAndPasswordForm : Form
    {
        private DB db = DB.getDB();
        public UserNameAndPasswordForm()
        {
            InitializeComponent();
            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
           DataTable userDataTable = db.FindUserByNameAndPassword(nameTextBox.Text, passwordTextBox.Text);

           if (userDataTable.Rows.Count > 0)
           {
               string userName = userDataTable.Rows[0]["name"].ToString();
               this.Hide();
               WeatherInformerForm form = new WeatherInformerForm(userName);
           }
        }

        // public DataTable GetUser()
        // {
        //     
        // }
    }
}