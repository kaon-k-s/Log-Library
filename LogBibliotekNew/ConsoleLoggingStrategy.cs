using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBibliotekNew
{
    // Implements the ILoggingStrategy interface for logging to the console
    public class ConsoleLoggingStrategy : ILoggingStrategy
    {
        // Property to indicate whether this strategy is active
        public bool Aktiv { get; set; }

        // Constructor reads configuration
        public ConsoleLoggingStrategy(Dictionary<string, bool> config)
        {
            this.Aktiv = config.ContainsKey("console") && config["console"];
        }

        // Logs a message if the strategy is active
        public void Log(DateTime dateTime, string message, Severity severity)
        {
            if (Aktiv)
            {
                DoLog(dateTime, message, severity);
            }
        }

        // Helper method to write a log entry to the console
        protected virtual void DoLog(DateTime dateTime, string message, Severity severity)
        {
            Console.Write($"[{dateTime:yyyy-MM-dd HH:mm:ss}]");
            Console.Write(severity.name + ": ");
            Console.WriteLine(message);
        }
    }
}
