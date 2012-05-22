using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace employeeAdministration
{
    class dataBase
    {
        protected string server = "192.168.13.22";
        protected string userid = "employeeadmin";
        protected string password = "employeeadmin";
        protected string database = "employeeadmin";


       public void connectToDB(){
           string cs = @"server="+this.server+";userid="+this.userid+";password=" + this.password +";database="+ this.database +"";
        MySqlConnection conn = null;

        try 
        {
          conn = new MySqlConnection(cs);
          conn.Open();

          //debug
          MessageBox.Show("MySQL version :"+conn.ServerVersion.ToString()+"info"+conn.Database.ToString()+"","server info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        } catch (MySqlException ex) 
        {
            MessageBox.Show("Error:"+ ex.ToString(), "database connection error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        } finally 
        {          
          if (conn != null) 
          {
              conn.Close();
          }
        }
        }
    }
}
