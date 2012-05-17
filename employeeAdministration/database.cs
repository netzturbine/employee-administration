using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace employeeAdministration
{
    class database
    {
        void connectToDB(){
            string cs = @"server=localhost;userid=user12;
            password=34klq*;database=mydb";

        MySqlConnection conn = null;

        try 
        {
          conn = new MySqlConnection(cs);
          conn.Open();
          Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

        } catch (MySqlException ex) 
        {
          Console.WriteLine("Error: {0}",  ex.ToString());

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
