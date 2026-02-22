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

        }

        private void DatabaseMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            root.Close();
        }

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
    }
}
