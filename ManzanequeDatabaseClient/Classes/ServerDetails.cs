using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManzanequeDatabaseClient.Classes
{
    internal static class ServerDetails
    {
        //enter server details here
        public const string password = "pling123"; 
        public const string database = "test_databse";

        public const string connstring = "server=localhost;uid=root;pwd=" + password + ";database=" + database;
    }
}
