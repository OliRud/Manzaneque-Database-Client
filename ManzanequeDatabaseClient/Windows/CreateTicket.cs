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
    public partial class CreateTicket : Form
    {
        RunSql execute = new RunSql();
        public CreateTicket()
        {
            execute.initialise();

            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string command = $"""
                INSERT INTO tblTickets (
                    DateofCall, TimeofCall, OperatorID, 
                    EmployeeID, EmployeeName, ContactNumber, Email, OfficeName, 
                    SerialNumber, HardwareType, 
                    SoftwareID, OperatingSystem, SoftwareName, SoftwareLicense, 
                    TechnicianAssigned, Note, Status
                )
                SELECT 
                    CURDATE(), CURTIME(), 105,              -- Static: Date, Time, Operator ID
                    e.ID, e.Name, e.ContactNumber, e.Email, e.Location, -- From tblEmployees
                    h.SerialNumber, h.HardwareType,         -- From tblHardware
                    s.AssetID, s.OS, s.Application, s.LicenceKey, -- From tblSoftware
                    '{entTechnicianID.Text}',                                      -- Static: Technician ID
                    '{entNote.Text}', -- Static: The Note
                    0                                       -- Static: Status (Open)
                FROM tblEmployees e
                JOIN tblHardware h ON h.SerialNumber = '{entSerialNumber.Value}'
                JOIN tblSoftware s ON s.AssetID = '{entAssetID.Value}'
                WHERE e.ID = '{entEmployeeID.Value}';
                """;

            execute.Push(command);
        }

        private void entTechnicianID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void entSerialNumber_ValueChanged(object sender, EventArgs e)
        {
        }

        private void entEmployeeID_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
