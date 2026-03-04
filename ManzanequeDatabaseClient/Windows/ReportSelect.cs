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
using MySqlX.XDevAPI.Common;

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

        // month's call summary
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
        // summary of technician jobs
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
        // in depth summary of individual workload
        private void btn1Submit_Click(object sender, EventArgs e)
        {
            string query = $"""
                SELECT
                    COUNT(*) AS Total_Jobs,
                    SUM(CASE WHEN Status = 0 THEN 1 ELSE 0 END) AS Open,
                    SUM(CASE WHEN Status = 1 THEN 1 ELSE 0 END) AS Closed,
                    SUM(TimeToResolve) AS Total_Time,
                    AVG(CASE WHEN Status = 1 THEN TimeToResolve ELSE NULL END) AS Avg_Time_Per_Job
                FROM tblTickets
                WHERE TechnicianAssigned = '{entTechnicianID.Value}'
                AND MONTH(DateofCall) = '{entMonth.Value}'
                AND YEAR(DateofCall) = '{entYear.Value}';
                """;

            object result = execute.Pull(query, null, null, null, null);

            Report report = new Report(result);
            report.Show();
        }
        // in depth summary of individual office
        private void btn2Submit_Click(object sender, EventArgs e)
        {
            string query = $"""
                SELECT 
                    OfficeName,
                    HardwareType,
                    SerialNumber,
                    COUNT(TicketID) AS Failure_Count,
                    SUM(CASE WHEN Status = 0 THEN 1 ELSE 0 END) AS Currently_Open
                FROM tblTickets
                WHERE OfficeName = '{entOfficeName.Text}'
                AND MONTH(DateofCall) = '{entMonth.Value}'
                AND YEAR(DateofCall) = '{entYear.Value}'
                GROUP BY SerialNumber, HardwareType;
                """;

            object result = execute.Pull(query, null, null, null, null);

            Report report = new Report(result);
            report.Show();
        }
        // summary of offices faults
        private void btnOfficeWorkload_Click(object sender, EventArgs e)
        {
            string query = $"""
                SELECT 
                    OfficeName,
                    SUM(CASE WHEN SerialNumber IS NOT NULL THEN 1 ELSE 0 END) AS Hardware_Faults,
                    SUM(CASE WHEN SoftwareID IS NOT NULL THEN 1 ELSE 0 END) AS Software_Faults,
                    SUM(TimeToResolve) AS Total_Time_Spent,
                    COUNT(DISTINCT TechnicianAssigned) AS Unique_Techs_Assigned
                FROM tblTickets
                GROUP BY OfficeName;
                """;

            object result = execute.Pull(query, null, null, null, null);

            Report report = new Report(result);
            report.Show();
        }
        // summary of equipment flagged
        private void btnEquipmentReliability_Click(object sender, EventArgs e)
        {
            string query = $"""
                SELECT 
                    SerialNumber,
                    HardwareType,
                    COUNT(TicketID) AS Total_Repairs,
                    SUM(TimeToResolve) AS Total_Downtime_Minutes
                FROM tblTickets
                WHERE SerialNumber IS NOT NULL
                GROUP BY SerialNumber, HardwareType -- Add HardwareType here
                ORDER BY Total_Repairs DESC;
                """;

            object result = execute.Pull(query, null, null, null, null);

            Report report = new Report(result);
            report.Show();
        }
    }
}
