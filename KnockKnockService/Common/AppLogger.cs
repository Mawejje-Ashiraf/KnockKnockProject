using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KnockKnockService.Common
{
    public static class AppLogger
    {
        public static bool LogExceptionInFile(String Details, string Source, Exception Ex)
        {
            try
            {
                string logFileName = "ExceptionLog.txt";
                string logPath = AppDomain.CurrentDomain.BaseDirectory;

                logFileName = String.Format(@"{0}\{1}", logPath, logFileName);

                using (StreamWriter swLogFile = new StreamWriter(logFileName, true))
                {
                    swLogFile.WriteLine(String.Format("Details : {0}\nSource : {1}\nException : {2}\n-\n"), Details, Source, (Ex.Message + Environment.NewLine + Ex.StackTrace));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}