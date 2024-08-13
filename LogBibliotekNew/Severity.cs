using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBibliotekNew
{
    // Defines severity levels for logging messages
    public class Severity
    {
        // Static dictionaries to map severity names and numbers to Severity objects
        public static Dictionary<String, Severity> byName = new Dictionary<String, Severity>();
        public static Dictionary<int, Severity> byNummer = new Dictionary<int, Severity>();

        // Predefined severity levels
        public static readonly Severity ERROR = new Severity("ERROR", 3);
        public static readonly Severity WARNING = new Severity("WARNING", 2);
        public static readonly Severity DEBUG = new Severity("DEBUG", 1);
        public static readonly Severity INFO = new Severity("INFO", 0);

        // Array containing all severity levels
        public static Severity[] alle = { ERROR, WARNING, DEBUG, INFO };

        // Properties for severity name and number
        public readonly String name;
        public readonly int nummer;

        // Private constructor to initialize a Severity object
        private Severity(String name, int nummer)
        {
            this.name = name;
            this.nummer = nummer;
            byName[this.name] = this;
            byNummer[this.nummer] = this;
        }

        // Overrides ToString method to return the severity name
        public string ToString()
        {
            return name;
        }
    }

}

