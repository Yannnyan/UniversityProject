using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject.Debug
{
    public class Logger
    {
        private static string path = @"C:\Users\Yan\Desktop\Projects\database_projects\first_project\UniversityProject\Debug\logFile.txt";

        public static void Log(string value)
        {
            using (StreamWriter fs = File.AppendText(path))
            {
                fs.WriteLine(value);
            } 
        }
    }
}
