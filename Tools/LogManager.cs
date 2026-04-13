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
<<<<<<< HEAD

=======
>>>>>>> 0f768fb0cac83c82a0547067e934e76c3ec5f9fe
            {
                writeText.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
            }
        }

<<<<<<< HEAD
        public static void DeleteOldFolder()
=======
        public static void DeleteLastTwoMonthsFolders()
>>>>>>> 0f768fb0cac83c82a0547067e934e76c3ec5f9fe
        {
            if (!Directory.Exists(LogDirPath))
                return;

            DateTime now = DateTime.Now;

            DateTime startOfCurrentMonth = new DateTime(now.Year, now.Month, 1);
            DateTime startOfPreviousMonth = startOfCurrentMonth.AddMonths(-1);

            foreach (var yearDir in Directory.GetDirectories(LogDirPath))
            {
<<<<<<< HEAD
                try
                {
                    string folderName = Path.GetFileName(dir);
                    if (string.IsNullOrEmpty(folderName))
                        continue;

                   
                    string[] dateParts = folderName.Split('/'); 
                    if (dateParts.Length != 2 || !int.TryParse(dateParts[0], out int year) || !int.TryParse(dateParts[1], out int month))
                        continue;

                    DateTime folderDate = new DateTime(year, month, 1);

                    DateTime thresholdDate = DateTime.Now.AddMonths(-2);

                    if (folderDate < thresholdDate)
=======
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
>>>>>>> 0f768fb0cac83c82a0547067e934e76c3ec5f9fe
                    {
                        folderDate = new DateTime(year, month, 1);
                    }
<<<<<<< HEAD
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting folder '{dir}': {ex.Message}");
=======
                    catch
                    {
                        continue;
                    }

                
                    if (folderDate >= startOfPreviousMonth)
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
>>>>>>> 0f768fb0cac83c82a0547067e934e76c3ec5f9fe
                }
            }
        }
    }
}
<<<<<<< HEAD
=======





>>>>>>> 0f768fb0cac83c82a0547067e934e76c3ec5f9fe
