using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanequeDatabaseClient.Classes
{
    public class Init
    {
        public void initialise()
        {
            RunSql execute = new RunSql();
            execute.initialise();

            string create_database = """
                
                """;

            execute.Push("wazzup\n");
        }
    }
}
