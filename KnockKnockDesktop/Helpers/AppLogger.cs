using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnockDesktop.Helpers
{
    public static class AppLogger
    {
        /// <summary>
        /// Logging any exceptions during executing some methods
        /// </summary>
        /// <param name="Details"></param>
        /// <param name="Source"></param>
        /// <param name="Ex"></param>
        /// <returns></returns>
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
