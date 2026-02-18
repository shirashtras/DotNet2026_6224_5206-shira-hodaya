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
        //public static void DeleteOldFolder()
        //{
        //    if (!Directory.Exists(LogDirPath))
        //        return;
        //    string[] nameFolders = Directory.GetDirectories(LogDirPath);

        //    foreach (string dir in nameFolders)
        //    {

        //        //string[] dateFolder = dir.Split(folderName);
        //        //if (dateFolder.Length > 2)
        //        //    continue;
        //        //int year = (int.Parse(dateFolder[0]));
        //        //int month = (int.Parse(dateFolder[1]));
        //        //if (year == DateTime.Now.Year)
        //        //{
        //        //    if (month + 2 < DateTime.Now.Month)
        //        //    {
        //        //        Directory.Delete(dir, true);
        //        //    }
        //        //}
        //        //else
        //        //{
        //        //    if (DateTime.Now.Month == 1)
        //        //    {
        //        //        if (month != 11 && month != 12)
        //        //        {
        //        //            Directory.Delete(dir, true);
        //        //        }
        //        //    }
        //        //    if (DateTime.Now.Month == 2)
        //        //    {
        //        //        if (month != 12)
        //        //        {
        //        //            Directory.Delete(dir, true);
        //        //        }
        //        //    }
        //        try
        //        {
        //            // Extract the folder name (e.g., "YYYY/MM")
        //            string folderName = Path.GetFileName(dir);
        //            if (string.IsNullOrEmpty(folderName))
        //                continue;

        //            // Split folder name into year and month
        //            string[] dateParts = folderName.Split(Path.DirectorySeparatorChar);
        //            if (dateParts.Length != 2 || !int.TryParse(dateParts[0], out int year) || !int.TryParse(dateParts[1], out int month))
        //                continue;

        //            // Calculate the folder's date
        //            DateTime folderDate = new DateTime(year, month, 1);

        //            // Calculate the threshold date (2 months ago)
        //            DateTime thresholdDate = DateTime.Now.AddMonths(-2);

        //            // Delete folder if it's older than the threshold date
        //            if (folderDate < thresholdDate)
        //            {
        //                Directory.Delete(dir, true);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error deleting folder '{dir}': {ex.Message}");
        //        }
        //    }
        //}
        public static void DeleteOldFolder()
        {
            if (!Directory.Exists(LogDirPath))
                return;

            string[] nameFolders = Directory.GetDirectories(LogDirPath);

            foreach (string dir in nameFolders)
            {
                try
                {
                    // Extract the folder name (e.g., "YYYY/MM")
                    string folderName = Path.GetFileName(dir);
                    if (string.IsNullOrEmpty(folderName))
                        continue;

                    // Split folder name into year and month
                    string[] dateParts = folderName.Split('-'); // Assuming folder names are in "YYYY-MM" format
                    if (dateParts.Length != 2 || !int.TryParse(dateParts[0], out int year) || !int.TryParse(dateParts[1], out int month))
                        continue;

                    // Calculate the folder's date
                    DateTime folderDate = new DateTime(year, month, 1);

                    // Calculate the threshold date (2 months ago)
                    DateTime thresholdDate = DateTime.Now.AddMonths(-2);

                    // Delete folder if it's older than the threshold date
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
        public static void DeleteRecentFiles()
        {
            if (!Directory.Exists(LogDirPath))
                return;

            string[] directories = Directory.GetDirectories(LogDirPath);

            foreach (string dir in directories)
            {
                try
                {
                    // Get all files in the directory
                    string[] files = Directory.GetFiles(dir, "*.txt", SearchOption.AllDirectories);

                    foreach (string file in files)
                    {
                        // Get the creation time of the file
                        DateTime creationTime = File.GetCreationTime(file);

                        // Calculate the threshold date (2 months ago)
                        DateTime thresholdDate = DateTime.Now.AddMonths(-2);

                        // Delete file if it was created within the last 2 months
                        if (creationTime >= thresholdDate)
                        {
                            File.Delete(file);
                            Console.WriteLine($"Deleted file: {file}");
                        }
                    }

                    // After deleting files, check if the directory is empty and delete it
                    if (Directory.GetFiles(dir).Length == 0 && Directory.GetDirectories(dir).Length == 0)
                    {
                        Directory.Delete(dir, true);
                        Console.WriteLine($"Deleted empty directory: {dir}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing directory '{dir}': {ex.Message}");
                }
            }
        }
    }
    }


        


