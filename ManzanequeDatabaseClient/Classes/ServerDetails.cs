using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManzanequeDatabaseClient.Classes
{
    internal static class ServerDetails
    {
        //enter your own server details here
        public const string password = "admin";
        public const string database = "manzaneque";

        public const string connstring = "server=localhost;uid=root;pwd=" + password + ";database=" + database;
    }
}
