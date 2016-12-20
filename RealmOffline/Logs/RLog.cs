using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace RealmOffline.Logs
{
    /// <summary>
    /// Our message Types
    /// </summary>
    public enum MessageType
    {
        Error,
        Information,
        Warning
    }
    public class RLog
    {
        /// <summary>
        /// The file we are saving to
        /// </summary>
        public string LogFile { get; private set; }

        /// <summary>
        /// Our error logger, by default it just logs to console
        /// use a filename here to log to file as well.
        /// </summary>
        /// <param name="toFile"></param>
        public RLog(string toFile = "")
        {
            this.LogFile = toFile;
        }
        /// <summary>
        /// Logs a message, by type, to file of your choice, will
        /// also log to console by default
        /// </summary>
        /// <param name="message">the message</param>
        /// <param name="messageType">the type</param>
        /// <param name="logToConsole">logs to console by default</param>
        public void LogMessage(string message, MessageType messageType, bool logToConsole = true)
        {
            Task task = Task.Factory.StartNew(() =>
                {
                    // Log to console first if needed, otherwise just log to file.
                    switch (messageType)
                    {
                        case MessageType.Error:
                            {
                                if (logToConsole)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(string.Format("Error!! : {0}", message));
                                }

                                // Log to file
                                if (this.LogFile != string.Empty)
                                    WriteLog(this.LogFile, string.Format("Error!! : {0}", message));
                                else Console.WriteLine("Error");
                                Console.ResetColor();
                            }
                            break;
                        case MessageType.Warning:
                            {
                                if (logToConsole)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(string.Format("Warning!! : {0}", message));
                                }

                                // Log to file
                                if (this.LogFile != string.Empty)
                                    WriteLog(this.LogFile, string.Format("Warning!! : {0}", message));
                                Console.ResetColor();
                            }
                            break;
                        case MessageType.Information:
                            {
                                if (logToConsole)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(string.Format("Information!! : {0}", message));
                                    Tools.ResetColor();
                                }

                                // Log to file
                                if (this.LogFile != string.Empty)
                                    WriteLog(this.LogFile, string.Format("Information!! : {0}", message));
                            }
                            break;
                    }
                });
        }
        /// <summary>
        /// Writes an exception to log and file
        /// </summary>
        /// <param name="ex">The Exception to write</param>
        public void WriteException(Exception ex)
        {
            LogMessage(FlattenException(ex), MessageType.Error);
        }
        /// <summary>
        /// Calls our writetask
        /// </summary>
        /// <param name="fileName">the log file</param>
        /// <param name="logMessage">the message</param>
        /// <returns>true if call succeeded</returns>
        private bool WriteLog(string fileName, string logMessage)
        {
            return WriteTask(fileName, logMessage);
        }
        /// <summary>
        /// Writes to a log file, will create the file by default
        /// if it does not exist
        /// </summary>
        /// <param name="fileName">the log file to write</param>
        /// <param name="logMessage">the message</param>
        /// <param name="createFile">creates by default</param>
        /// <returns>true if file was written</returns>
        private bool WriteTask(string fileName, string logMessage, bool createFile = true)
        {
            Task<bool> writeTask = Task.Factory.StartNew(() =>
                        {
                            if (!File.Exists(fileName))
                            {
                                if (createFile)
                                    try
                                    {
                                        DirectoryInfo dInfo = Directory.GetParent(fileName);
                                        Tools.SetColor(ConsoleColor.Green);
                                        Tools.ResetColor();

                                        if (!Directory.Exists(dInfo.FullName)) { Directory.CreateDirectory(dInfo.FullName); }
                                        using (FileStream fs = File.Create(fileName)) { fs.Flush(); }
                                    }
                                    catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
                                else
                                    return false;
                            }
                            while (true)
                            {
                                try
                                {
                                    using (StreamWriter writer = File.AppendText(fileName))
                                    {
                                        writer.WriteLine(string.Format("{0}: {1}", DateTime.Now, logMessage));
                                        return true;
                                    }
                                }
                                catch (IOException)
                                {
                                    
                                }
                            }
                        });
            return writeTask.Result;
        }
        private static string FlattenException(Exception exception)
        {
            var stringBuilder = new StringBuilder();

            while (exception != null)
            {
                stringBuilder.AppendLine(exception.Message);
                stringBuilder.AppendLine(exception.StackTrace);

                exception = exception.InnerException;
            }

            return stringBuilder.ToString();
        }
        public void WriteRawLog(string message)
        {
            if (this.LogFile != string.Empty)
                WriteTask(this.LogFile, message);
        }
    }
}
