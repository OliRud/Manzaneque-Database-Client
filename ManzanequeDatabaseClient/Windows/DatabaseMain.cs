using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzanequeDatabaseClient.Windows
{
    public partial class DatabaseMain : Form
    {
        Form root = null;

        public DatabaseMain(Form root_class)
        {
            InitializeComponent();

            root = root_class;
        }

        private void DatabaseMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            root.Close();
        }
    }
}
