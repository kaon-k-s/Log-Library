using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBibliotekNew
{
    // Interface defining the contract for logging strategies
    public interface ILoggingStrategy
    {
        // Property to indicate whether the strategy is active
        bool Aktiv { get; set; }

        // Method to log a message with a specified date/time, message, and severity level
        void Log(DateTime dateTime, string message, Severity severity);
    }

}
