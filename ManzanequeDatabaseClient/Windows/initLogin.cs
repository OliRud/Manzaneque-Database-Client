using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using ManzanequeDatabaseClient.Classes;
using ManzanequeDatabaseClient.Windows;
using Mysqlx.Crud;

namespace ManzanequeDatabaseClient
{
    public partial class initLogin : Form
    {
        public initLogin()
        {
            InitializeComponent();

            DialogResult result = MessageBox.Show(
                """
                -NEW DATABASE-

                Would you like to create a fresh database?

                Yes (New Save) - Creates a fresh database
                No (Load Save) - Uses existing database


                Click 'Yes' if this is your first time running the program.
                """,
                "New Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Init initialise = new Init();
                initialise.initialise();
            }
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

        private void initLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Write("//Program Ending//\n");
        }
    }
}