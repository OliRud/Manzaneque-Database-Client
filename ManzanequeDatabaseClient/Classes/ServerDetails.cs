using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManzanequeDatabaseClient.Classes
{
    internal static class ServerDetails
    {
        //enter your own server details here
        public const string password = "admin";
        public const string database = "manzaneque";

        public const string connstring = "server=localhost;uid=root;pwd=" + password + ";database=" + database;

        public static void BackupToDesktop(string user)
        {
            // 1. Get the path to the current user's Desktop automatically
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // 2. Create a folder named "DB_Backups" on the desktop if it doesn't exist
            string backupFolder = Path.Combine(desktopPath, "Manzaneque_backup");
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }

            string fileName = $"Backup_{database}_{DateTime.Now:yyyyMMdd_HHmm}.sql";
            string fullPath = Path.Combine(backupFolder, fileName);

            // 3. Build the command
            // We use --result-file to handle spaces in file paths correctly
            string command = $"/c mysqldump -u {user} -p{password} {database} --result-file=\"{fullPath}\"";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = command,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = Process.Start(psi))
                {
                    string errors = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        Console.WriteLine($"Backup successful! Check your Desktop folder: ML_Backups");
                    }
                    else
                    {
                        Console.WriteLine($"Backup failed: {errors}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"System Error: {ex.Message}");
            }
        }
    }
}
