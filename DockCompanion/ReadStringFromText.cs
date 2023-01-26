using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DockCompanion
{
    /// <summary>Contains various methods for reading from the Config.txt file.</summary>
    class ReadStringFromText
    {
        public static string ProcessName;
        public static string TargetAppLocation;
        private static string configFilePath;
        public static void CheckAndLaunchConfigSetup()
        {
            configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.txt");
            if (!File.Exists(configFilePath))
            {
                string configSetupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DockCompanionConfigSetup.exe");
                if (File.Exists(configSetupPath))
                {
                    Process.Start(configSetupPath);
                }
                else
                {
                    throw new InvalidOperationException("This operation cannot be completed because the expected Config.txt file doesn't exist and the DockCompanionConfigSetup.exe file is missing");
                }
            }
        }

        public static void ReadConfigSettings()
        {
            try
            {
                string searchString = File.ReadAllText(configFilePath);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("No permission to access file: " + configFilePath);
                throw new InvalidOperationException("This operation cannot be completed because the application does not have read access to the Config.txt file");
            }
            string[] lines = File.ReadAllLines(configFilePath);
            ProcessName = lines[0];
            TargetAppLocation = lines[1];
        }
    }
}
