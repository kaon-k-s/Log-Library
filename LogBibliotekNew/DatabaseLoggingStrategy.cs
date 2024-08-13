using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogBibliotekNew
{
    // Implements the ILoggingStrategy interface for logging to a database.
    public class DatabaseLoggingStrategy : ILoggingStrategy
    {
        // Database connection object
        private MySqlConnection con;

        // Property to indicate whether this strategy is active
        public bool Aktiv { get; set; }

        // Constructor reads configuration and initializes database connection
        public DatabaseLoggingStrategy(Dictionary<string, bool> config)
        {
            this.Aktiv = config.ContainsKey("database") && config["database"];
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "SERVER=localhost;DATABASE=LogBibliotek;UID=root;PASSWORD='';";
            con = new MySqlConnection(connectionString);
            con.Open();
        }
        private void close()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        // Logs a message if the strategy is active
        public void Log(DateTime dateTime, string message, Severity severity)
        {
            if (Aktiv)
            {
                DoLog(dateTime, message, severity);
            }
        }

        // Helper method to save a log entry to the database
        protected virtual void DoLog(DateTime dateTime, string message, Severity severity)
        {
            SaveLog(dateTime, message, severity);
        }

        // Saves a log entry to the database
        private void SaveLog(DateTime dateTime, string message, Severity severity)
        {
            MySqlCommand command = con.CreateCommand();
            string formattedDate = dateTime.ToString();
            string query = $"INSERT INTO logs VALUES(NULL, '{formattedDate}', '{severity.name}', '{message}');";

            command.CommandText = query;
            command.ExecuteNonQuery();
            close();
        }
    }
}
