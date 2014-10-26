using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSServer
{
    class ServerLog
    {
        protected static string currentFileName = "";
        protected static readonly string logPath = @"/Files/Logs/";
        protected static bool append = false;

        internal static void Write(string message)
        {
            try
            {
                Console.WriteLine("----- Log to file started -----");
                WriteToFile(message);
                Console.WriteLine("----- Log to file finished -----");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        internal static void Write(ref System.Windows.Forms.RichTextBox logWindow, string message)
        {
            try
            {
                Write(message);
                Console.WriteLine("----- Log to file started -----");
                WriteToScreen(ref logWindow, message);
                Console.WriteLine("----- Log to file finished -----");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected static void WriteToFile(string message)
        {
            string fileName = BuildFileName();
            //TODO: write to file
        }
        protected static void WriteToScreen(ref System.Windows.Forms.RichTextBox logWindow, string message)
        {
            //TODO: write to screen
            throw new NotImplementedException();
        }

        protected static string BuildFileName()
        {
            //----------FILE NAME----------
            //date + time + log + extension
            //e.g.: 20140910_1405_log.txt
            //----------FILE NAME----------
            string c_Date;
            string c_Time;
            string c_Log;
            string c_Extension;

            if (currentFileName == "")
            {
                append = false;
                List<string> logFileList = Directory.GetFiles(logPath).ToList();
                GetCurrenTime(out c_Date, out c_Time, out c_Log, out c_Extension);

                if (logFileList.Count != 0)
                {
                    string lastLogFile = logFileList.Last();
                    string l_Date = lastLogFile.Substring(0, 8);
                    string l_Time = lastLogFile.Substring(l_Date.Length + 1, 4);
                    string l_Log = "log";
                    string l_Extension = "txt";

                    if (l_Date.Equals(c_Date) && l_Time.Substring(0, 2).Equals(c_Time.Substring(0, 2)))
                    {
                        //append message to the existing file
                        append = true;
                        currentFileName = l_Date + "_" + l_Time + "_" + l_Log + "." + l_Extension;
                        return currentFileName;
                    }
                }
                //create new log and write the message to it
                append = false;
                currentFileName = c_Date + "_" + c_Time + "_" + c_Log + "." + c_Extension;
                return currentFileName;
            }
            else
            {
                //TODO:van aktuális fájl név
            }

            return currentFileName;
        }
        private static void GetCurrenTime(out string c_Date, out string c_Time, out string c_Log, out string c_Extension)
        {
            DateTime cdt = DateTime.Now;
            c_Date = cdt.Year.ToString() + cdt.Month.ToString() + cdt.Day.ToString();
            c_Time = "0000";
            if (cdt.Minute >= 0 && cdt.Minute < 30)
            {
                c_Time = cdt.Hour.ToString() + "00";
            }
            else if (cdt.Minute >= 30 && cdt.Minute < 60)
            {
                c_Time = cdt.Hour.ToString() + "30";
            }
            c_Log = "log";
            c_Extension = "txt";
        }       
    }
}
