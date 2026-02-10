using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManzanequeDatabaseClient.Classes
{
    internal class RunSql
    {

        string sql;
        MySqlCommand cmd;
        MySqlConnection con = new MySqlConnection();

        public void initialise()
        {
            con.ConnectionString = ServerDetails.connstring;
        }

        // for grabbing data from the database
        public void Pull(string area)
        {
            try
            {
                con.Open();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        // for pushing set commands to the database
        public void Push(string command)
        {
            try
            {
                con.Open();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // for executing custom commands on the database
        public void Custom(string command)
        {
            try
            {
                con.Open();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
