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

namespace ManzanequeDatabaseClient.Windows
{
    public partial class CustomQuery : Form
    {
        RunSql execute = new RunSql();

        public CustomQuery()
        {
            InitializeComponent();
            execute.initialise();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            execute.Push(entQuery.Text);
        }
    }
}
