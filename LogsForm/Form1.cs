// Using directive for accessing the logging library
using LogBibliotekNew;

// Namespace declaration for the Windows Forms application
namespace LogsForm
{
    // Partial class definition for Form1, indicating it's part of a designer-generated partial class
    public partial class Form1 : Form
    {
        // List to hold instances of different logging strategies
        List<ILoggingStrategy> loggingStrategies = new List<ILoggingStrategy>();

        // Constructor for Form1, initializes components and sets up logging strategies
        public Form1()
        {
            InitializeComponent();
            dispSeverity(); // Method call to populate the severity combo box

            // Reads configuration from a file and initializes logging strategies based on the configuration
            Dictionary<string, bool> config = ReadConfigFile();
            loggingStrategies.Add(new DatabaseLoggingStrategy(config));
            loggingStrategies.Add(new FileLoggingStrategy(config));
            loggingStrategies.Add(new ConsoleLoggingStrategy(config));
        }

        // Event handler for a button click, logs entered information using all configured logging strategies
        private void btnLogEintrag_Click(object sender, EventArgs e)
        {
            string info = tbInfo.Text;
            DateTime dateTime = DateTime.Now;
            Severity severityLevel = Severity.byName[cbSeverity.SelectedItem as string];

            foreach (ILoggingStrategy strategy in loggingStrategies)
            {
                strategy.Log(dateTime, info, severityLevel);
            }
            MessageBox.Show("Log is saved");
            tbInfo.Text = "";
        }

        // Populates the severity combo box with predefined severity levels
        private void dispSeverity()
        {
            cbSeverity.Items.Clear();

            foreach (Severity severity in Severity.alle)
            {
                cbSeverity.Items.Add(severity.name);
            }
        }

        // Reads configuration settings from a text file and returns them as a dictionary
        private Dictionary<string, bool> ReadConfigFile()
        {
            var config = new Dictionary<string, bool>();
            using StreamReader sr = new StreamReader("config.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var parts = line.Split('=');
                if (parts.Length == 2)
                {
                    if (!config.ContainsKey(parts[0].Trim()))
                    {
                        config.Add(parts[0].Trim(), parts[1].Trim().ToLower().Equals("true"));
                    }
                    else
                    {
                        config[parts[0].Trim()] = bool.Parse(parts[1].Trim());
                    }
                }
            }
            return config;
        }
    }
}
