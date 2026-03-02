using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using ManzanequeDatabaseClient.Classes;
using ManzanequeDatabaseClient.Windows;
using Mysqlx.Crud;

namespace ManzanequeDatabaseClient
{
    public partial class initLogin : Form
    {

        //fix this later
        string dummy_helpdesk_login = "helpdesk123";
        string dummy_admin_login = "admin";

        public initLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (Accounts.accounts.ContainsKey(entLoginBox.Text))
            {
                Accounts.profile = entLoginBox.Text;
                DatabaseMain databaseMain = new DatabaseMain(this);
                databaseMain.Show();
                this.Hide();
            }
        }

        //second initialise for some reason
        private void initLogin_Load(object sender, EventArgs e)
        {
            Init initialise = new Init();
            initialise.initialise();
        }

        private void initLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Write("//Program Ending//\n");
        }
    }
}