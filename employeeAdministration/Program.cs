using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

            DB.connectToDB();

            tools tools = new tools();

            tools.checkValue("username","admin");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new administration());
        }
    }
}
