using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace LogBibliotekNew
{
    // Implements the ILoggingStrategy interface for logging to a file
    public class FileLoggingStrategy : ILoggingStrategy
    {
        // Path to the log file
        private readonly string _logFilePath;

        // Property to indicate whether this strategy is active.
        public bool Aktiv { get; set; }

        // Constructor reads configuration and sets up the log file path.
        public FileLoggingStrategy(Dictionary<string, bool> config)
        {
            this.Aktiv = config.ContainsKey("file") && config["file"];
            string exeDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _logFilePath = Path.Combine(exeDirectory, "log.txt");
        }

        // Logs a message if the strategy is active
        public void Log(DateTime dateTime, string message, Severity severity)
        {
            if (Aktiv)
            {
                DoLog(dateTime, message, severity);
            }
        }

        // Helper method to write a log entry to the file
        protected virtual void DoLog(DateTime dateTime, string message, Severity severity)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_logFilePath));
            string logEntry = $"{dateTime:yyyy-MM-dd HH:mm:ss} [{severity.name}]: {message}\n";
            File.AppendAllText(_logFilePath, logEntry);
        }
    }
}

