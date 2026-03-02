using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanequeDatabaseClient.Classes
{
    public static class Accounts
    {
        //this is not supposed to be secure and is purely for demonstration purposes

        public static string profile = "None";

        public static Dictionary<string, int> accounts = new Dictionary<string, int>
        {
            //account name, operator ID
            {"Helpdesk1", 143},
            {"Manager", 984},
            {"Admin", 443}
        };

        public static Dictionary<int, int> perms = new Dictionary<int, int>
        {
            //ID, perm
            {143,1}, //1 = can create/update tickets, cannot view tickets
            {984,2}, //2 = can view and create custom queries, cannot create tickets (through UI) 
            {443,3 } //3 = perms to all
        };
    }
}
