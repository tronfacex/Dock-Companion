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
        public static void CheckAndLaunchConfigSetup()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.txt");
            if (!File.Exists(filePath))
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
        public static string ReadConfigTextAppName()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.txt");
            //string filePath = @"C:\Users\name\Documents\Builds\Config.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found " + filePath);
                throw new InvalidOperationException("This operation cannot be completed because the expected Config.txt file doesn't exist");
                //throw a dialog box and then open the WindowFinder app to make a new Congif.txt file
            }
            try
            {
                string searchString = File.ReadAllText(filePath);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("No permission to access file: " + filePath);
                throw new InvalidOperationException("This operation cannot be completed because the application does not have read access to the Config.txt file");
            }
            string[] lines = File.ReadAllLines(filePath);
            string appNameString = lines[0];
            return appNameString;
        }
        public static string ReadConfigTextAppLocation()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.txt");
            //string filePath = @"C:\Users\name\Documents\Builds\Config.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found " + filePath);
                throw new InvalidOperationException("This operation cannot be completed because the expected Config.txt file doesn't exist");
                //Throw error dialog that the filepath of config.txt may not be working
            }
            try
            {
                string searchString = File.ReadAllText(filePath);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("No permission to access file: " + filePath);
                throw new InvalidOperationException("This operation cannot be completed because the application does not have read access to the Config.txt file");
            }
            //string configString = File.ReadAllText(filePath);
            string[] lines = File.ReadAllLines(filePath);
            string appLocationString = lines[1];
            return appLocationString;
        }
    }
}
