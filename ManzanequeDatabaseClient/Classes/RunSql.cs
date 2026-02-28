using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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

        object result = null;

        //establishes connection
        public void initialise()
        {
            con.ConnectionString = ServerDetails.connstring;
        }

        // for grabbing data from the database
        public DataTable Pull(string command, string parameter1, string pam1Value, string parameter2, string pam2Value)
        {
            DataTable table = new DataTable();

            try
            {
                using (MySqlConnection con = new MySqlConnection(ServerDetails.connstring))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(command, con))
                    {
                        // Add parameters only if provided
                        if (!string.IsNullOrEmpty(parameter1))
                            cmd.Parameters.AddWithValue(parameter1, pam1Value);

                        if (!string.IsNullOrEmpty(parameter2))
                            cmd.Parameters.AddWithValue(parameter2, pam2Value);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
                con.Close();
            }

            return table;
        }

        // for pushing set commands to the database
        public void Push(string command)
        {
            try
            {
                con.Open();

                sql = command;
                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
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
                con.Close();
            }
        }

        //filter
        public void Filter()
        {

        }
    }
}
