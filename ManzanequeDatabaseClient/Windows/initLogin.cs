using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
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

            if (entLoginBox.Text == dummy_admin_login || entLoginBox.Text == dummy_helpdesk_login)
            {
                DatabaseMain databaseMain = new DatabaseMain(this);
                databaseMain.Show();
                this.Hide();
            }
        }

        private void initLogin_Load(object sender, EventArgs e)
        {

        }

        private void initLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Write("//Program Ending//\n");
        }
    }
}