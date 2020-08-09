using System;
using System.IO;

namespace MTUCI_Clock
{
    public static class Logger
    {
        public static void Log(string mess) 
        {

            string Logger_path = @"C:\Users\Public\Logger";
            DirectoryInfo dirInfo = new DirectoryInfo(Logger_path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (StreamWriter sw = new StreamWriter(@Logger_path + @"\Loger data.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString() +" - "+ mess);
            }
        }
    }
}
