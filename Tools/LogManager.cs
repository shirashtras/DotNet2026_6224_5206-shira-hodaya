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

            string[] nameFolders = Directory.GetDirectories(LogDirPath);

            foreach (string dir in nameFolders)
            {
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
                    {
                        Directory.Delete(dir, true);
                        Console.WriteLine($"Deleted folder: {dir}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting folder '{dir}': {ex.Message}");
                }
            }
        }
    }
}
