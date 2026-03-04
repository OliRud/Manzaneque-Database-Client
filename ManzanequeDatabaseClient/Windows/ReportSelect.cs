using System;
using System.Collections;
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
    public partial class ReportSelect : Form
    {
        RunSql execute = new RunSql();

        public ReportSelect()
        {
            InitializeComponent();
            execute.initialise();
        }
        private void btnMonthlyCallSummary_Click(object sender, EventArgs e)
        {
            string query = $"""
                SELECT 
                    COUNT(TicketID) AS Total_Calls,
                    SUM(CASE WHEN Status = 0 THEN 1 ELSE 0 END) AS Open_Cases,
                    SUM(CASE WHEN Status = 1 THEN 1 ELSE 0 END) AS Closed_Cases,
                    SUM(TimeToResolve) AS Total_Minutes_Spent
                FROM tblTickets
                WHERE MONTH(DateofCall) = '{entMonth.Value}' AND YEAR(DateofCall) = '{entYear.Value}';
                """;

            object result = execute.Pull(query, null, null, null, null);

            Report report = new Report(result);
            report.Show();
        }
        private void btnMonthlyTechnicianJobs_Click(object sender, EventArgs e)
        {
            string query = $"""
                SELECT 
                    p.Name AS Technician_Name,
                    COUNT(t.TicketID) AS Total_Jobs,
                    SUM(CASE WHEN t.Status = 0 THEN 1 ELSE 0 END) AS Open_Jobs,
                    SUM(CASE WHEN t.Status = 1 THEN 1 ELSE 0 END) AS Closed_Jobs,
                    SUM(t.TimeToResolve) AS Total_Time_Spent
                FROM tblTechnicianPool p
                JOIN tblTickets t ON p.ID = t.TechnicianAssigned
                WHERE MONTH(t.DateofCall) = '{entMonth.Value}' AND YEAR(DateofCall) = '{entYear.Value}'
                GROUP BY p.ID;
                """;
            
            object result = execute.Pull(query, null, null, null, null);

            Report report = new Report(result);
            report.Show();
        }
        // technician, office
        private void btn1Submit_Click(object sender, EventArgs e)
        {

        }
        private void btn2Submit_Click(object sender, EventArgs e)
        {

        }
        //
        private void btnOfficeWorkload_Click(object sender, EventArgs e)
        {

        }
        private void btnEquipmentReliability_Click(object sender, EventArgs e)
        {

        }
    }
}
