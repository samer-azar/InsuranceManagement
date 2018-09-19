using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement.LoggerLibrary
{
    public static class Logger
    {
        public static void Log(string MethodName, string Exception, string StackTrace)
        {
            string fileName, fullPath, log;
            try
            {
                fileName = string.Format("LOGS_{0}_{1}_{2}.txt", DateTime.Today.Month.ToString("00"), DateTime.Today.Day.ToString("00"), DateTime.Today.Year);
                fullPath = Path.Combine(Properties.Settings.Default.LOGFILE_PATH, fileName);

                //Manually create the directories if path or part of the path does not exist
                if (!Directory.Exists(Properties.Settings.Default.LOGFILE_PATH))
                    Directory.CreateDirectory(Properties.Settings.Default.LOGFILE_PATH);

                //Automatically create the file if does not exist and write/append log to it
                using (StreamWriter file = new StreamWriter(fullPath, true))
                {
                    log = string.Format(@"At {0}  Method: {1} - Exception: {2} - Stack Trace: {3}.", DateTime.Now.ToString(@"HH:mm"), MethodName, Exception, StackTrace);
                    file.WriteLine(log);
                    file.WriteLine();
                }
            }
            catch (Exception)
            { throw; }
        }

        public static string GetCurrentMethod()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);
            return stackFrame.GetMethod().Name;
        }

        public static string GetCurrentAsyncMethod([CallerMemberName]string name = "")
        {
            return name;
        }


    }
}
