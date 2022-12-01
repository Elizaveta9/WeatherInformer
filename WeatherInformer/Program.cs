using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherInformer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DB db = DB.getDB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int userId = db.GetLastLoggedUserId();
            if (userId == 0)
            {
                Application.Run(new HelloUserForm());
            }
            else
            {
                Application.Run(new WeatherInformerForm(db.GetUserNameById(userId)));
            }
        }
    }
}