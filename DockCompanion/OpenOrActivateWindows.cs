using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace DockCompanion
{
    public static class OpenOrActivateWindows
    {
        public static void CheckDictionary()
        {
            Dictionary<IntPtr, string> windows = (Dictionary<IntPtr, string>)OpenWindowGetter.GetOpenWindows();

            // Filters dictionary for windows with a ProcessName that matches the Config.txt Line 1
            var filteredWindows = windows.Where(w => w.Value.Equals(ReadStringFromText.ProcessName));

            // If no windows match the criteria above then open the target application from the file path on line 2 of the Config.txt file
            if (!filteredWindows.Any())
            {
                //Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "");
                Process.Start(ReadStringFromText.TargetAppLocation, "");
            }
            else
            {
                // If windows do match the criteria find the first window on the list, check if it is a valid window, check it's size and location,
                // and then ShowWindow or SetForegroundWindow depending on if the window is minimized or not
                var windowToActivate = filteredWindows.FirstOrDefault();
                if (!WindowActivator.IsWindow(windowToActivate.Key))
                {
                    Console.WriteLine("Invalid handle");
                    return;
                }
                else
                {
                    WindowActivator.CheckWindowSize(windowToActivate.Key);
                    if (WindowActivator.IsIconic(windowToActivate.Key))
                    {
                        WindowActivator.ShowWindow(windowToActivate.Key, WindowActivator.SW_RESTORE);
                    }
                    else
                    {
                        WindowActivator.SetForegroundWindow(windowToActivate.Key);
                    }
                    // Debugging errors in the Console window 
                    /*uint error = WindowActivator.GetLastError();
                    if (error == 87)
                    {
                        string configSetupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DockCompanionConfigSetup.exe");
                        Process.Start(configSetupPath);
                    }
                    Console.WriteLine("Should have opened " + windowToActivate.Value);*/
                }
            }
        }
    }
}
