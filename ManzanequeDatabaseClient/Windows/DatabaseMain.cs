using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManzanequeDatabaseClient.Classes;
using Mysqlx.Prepare;

namespace ManzanequeDatabaseClient.Windows
{
    public partial class DatabaseMain : Form
    {
        Form root = null;
        RunSql execute = new RunSql();

        string currentWindow = null;


        public DatabaseMain(Form root_class)
        {
            InitializeComponent();
            root = root_class;

            execute.initialise();
            ChangeView("tblEmployees");

            //permission check
            if (Accounts.perms[Accounts.accounts[Accounts.profile]] == 1)
            {
                btnShowTickets.Enabled = false;
                btnEnterQuery.Enabled = false;
            }
            else if (Accounts.perms[Accounts.accounts[Accounts.profile]] == 2)
            {
                btnCreateTicket.Enabled = false;
                btnResolve.Enabled = false;
            }
        }

        private void DatabaseMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            root.Close();
        }


        // table view
        private void ChangeView(string view_to_change) //updating the table with new information 
        {
            currentWindow = view_to_change;

            string query = @"SELECT * FROM " + currentWindow + ";";

            object result = execute.Pull(query, null, null, null, null);

            dataGridView.DataSource = result;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            ChangeView("tblEmployees");
        }
        private void btnShowOffices_Click(object sender, EventArgs e)
        {
            ChangeView("tblOffices");
        }
        private void btnShowHardware_Click(object sender, EventArgs e)
        {
            ChangeView("tblHardware");
        }
        private void btnShowSoftware_Click(object sender, EventArgs e)
        {
            ChangeView("tblSoftware");
        }
        private void btnShowTechnicians_Click(object sender, EventArgs e)
        {
            ChangeView("tblTechnicians");
        }
        private void btnShowTickets_Click(object sender, EventArgs e)
        {
            ChangeView("tblTickets");
        }


        // opening windows
        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            CreateTicket createTicket = new CreateTicket();
            createTicket.Show();
        }
        private void btnResolve_Click(object sender, EventArgs e)
        {
            ResolveTicket resolveTicket = new ResolveTicket();
            resolveTicket.Show();
        }
        private void btnEnterQuery_Click(object sender, EventArgs e)
        {
            CustomQuery query = new CustomQuery();
            query.Show();
        }
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            ReportSelect reportSelect = new ReportSelect();
            reportSelect.Show();
        }
    }
}
