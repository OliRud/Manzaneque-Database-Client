using System.Security.Cryptography.X509Certificates;
using ManzanequeDatabaseClient.Windows;
using Mysqlx.Crud;

namespace ManzanequeDatabaseClient
{
    public partial class initLogin : Form
    {
        public initLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseMain databaseMain = new DatabaseMain();
            databaseMain.ShowDialog();
        }
    }
}