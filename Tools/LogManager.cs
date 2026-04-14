using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private const string LogDirPath = "Log";
        public static string getDirPathYear()
        {
            return LogDirPath + "/" + DateTime.Now.Year.ToString();
        }
        public static string getDirPath()
        {
            return getDirPathYear() + "/" + DateTime.Now.Month.ToString();
        }
        public static string getFilePath()
        {
            return getDirPath() + "/" + DateTime.Now.Day.ToString() + ".txt";
        }
        public static void writeToLog(string projectName, string funcName, string message)
        {
            string folder = getDirPath();
            string file = getFilePath();
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }

            using (StreamWriter writeText = new StreamWriter(file, true))

            {
                writeText.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
            }
        }


        public static void DeleteOldFolder()
        {
            if (!Directory.Exists(LogDirPath))
                return;

            
            DateTime thresholdDate = DateTime.Now.AddMonths(-2);

            foreach (var yearDir in Directory.GetDirectories(LogDirPath))
            {
                string yearName = Path.GetFileName(yearDir);
                if (!int.TryParse(yearName, out int year))
                    continue;

                foreach (var monthDir in Directory.GetDirectories(yearDir))
                {
                    string monthName = Path.GetFileName(monthDir);
                    if (!int.TryParse(monthName, out int month))
                        continue;

                    DateTime folderDate;
                    try
                    {
                        folderDate = new DateTime(year, month, 1);
                    }
                    catch
                    {
                        continue;
                    }

                    if (folderDate < thresholdDate)
                    {
                        try
                        {
                            Directory.Delete(monthDir, true);
                            Console.WriteLine($"Deleted folder: {monthDir}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error deleting {monthDir}: {ex.Message}");
                        }
                    }
                }

                if (!Directory.GetDirectories(yearDir).Any())
                {
                    try
                    {
                        Directory.Delete(yearDir);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting year folder {yearDir}: {ex.Message}");
                    }
                }
            }
        }
    }
}
