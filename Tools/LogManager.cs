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
        //static DirectoryInfo CurrentDir;
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
            using (StreamWriter writeText = new StreamWriter(folder))
            {
                writeText.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
            }
        }
        public static void DeleteOldFolder()
        {
            if (!Directory.Exists(getDirPath()))
                return;
            string[] nameFolders = Directory.GetDirectories(LogDirPath);

            foreach (string dir in nameFolders)
            {
                string[] dateFolder = dir.Split('/');
                if (dateFolder.Length > 2)
                    continue;
                int year = (int.Parse(dateFolder[0]));
                int month = (int.Parse(dateFolder[1]));
                if (year == DateTime.Now.Year)
                {
                    if (month + 2 < DateTime.Now.Month)
                    {
                        Directory.Delete(dir, true);
                    }
                }
                else
                {
                    if (DateTime.Now.Month == 1)
                    {
                        if (month != 11 && month != 12)
                        {
                            Directory.Delete(dir, true);
                        }
                    }
                    if (DateTime.Now.Month == 2)
                    {
                        if (month != 12)
                        {
                            Directory.Delete(dir, true);
                        }
                    }
                }


            }


        }

    }


}

