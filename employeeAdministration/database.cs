using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace employeeAdministration
{
    class dataBase
    {
        protected string server = "192.168.13.22";
        protected string userid = "employeeadmin";
        protected string password = "employeeadmin";
        protected string database = "employeeadmin";

        MySqlConnection conn = null;
        DataSet ds = new DataSet();

        public DataSet readData(String sql){

            try
            {
                MySqlConnection conn = this.connectToDB();
                
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds);

                
                MessageBox.Show("MSG: reading data ", "database read success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.disconnectFromDB(conn);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:" + ex.ToString(), "database read error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return ds;
        }

        private MySqlConnection connectToDB()
        {
            string cs = @"server=" + this.server + ";userid=" + this.userid + ";password=" + this.password + ";database=" + this.database + "";


            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                //debug
                //MessageBox.Show("MySQL version :" + conn.ServerVersion.ToString() + "info" + conn.Database.ToString() + "", "server info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:" + ex.ToString(), "database connection error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            return conn;

        }
        private void disconnectFromDB(MySqlConnection conn)
        {

            try
            {
                //debug
                MessageBox.Show("Colsed conn" + conn.ServerVersion.ToString() + "info" + conn.Database.ToString() + "", "server info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:" + ex.ToString(), "database connection error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
