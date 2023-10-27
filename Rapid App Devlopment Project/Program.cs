using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLDataLayer;

namespace Rapid_App_Devlopment_Project
{
    class Program
    {

        static void Main(string[] args)
        {
            SQLDataLayer.MainSQLConnection conn = new MainSQLConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }
    }
}
