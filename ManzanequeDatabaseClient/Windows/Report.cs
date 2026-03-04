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
    public partial class Report : Form
    {
        public Report(object result)
        {
            InitializeComponent();

            dataGridView.DataSource = result;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
