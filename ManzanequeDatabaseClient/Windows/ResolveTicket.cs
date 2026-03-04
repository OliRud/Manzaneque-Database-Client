using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManzanequeDatabaseClient.Classes;

namespace ManzanequeDatabaseClient.Windows
{
    public partial class ResolveTicket : Form
    {
        RunSql execute = new RunSql();

        public ResolveTicket()
        {
            InitializeComponent();
            execute.initialise();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string command = $"""
                UPDATE tblTickets 
                SET Status = 1, 
                    DateResolved = '{entDateTime.Value.ToString("yyyy-MM-dd")}', 
                    TimeResolved = CURTIME(),
                    TimeToResolve = '{entResolveTime.Value}',
                    Resolution = '{entResolution.Text}'
                WHERE TicketID = '{entTicketID.Value}';
                """;

            Debug.WriteLine(command);

            execute.Push(command);
        }
    }
}
