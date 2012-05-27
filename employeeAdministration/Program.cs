using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace employeeAdministration
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dataBase DB = new dataBase();

            DataSet ds = DB.readData("SELECT * FROM users;");

            // DataGrid dg = new DataGrid(); 

            //tools tools = new tools();

            //tools.checkValue("username","admin");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new administration());
        }
    }
}
