using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DockCompanion
{
    public static class OpenOrActivateWindows
    {
        public static void CheckDictionary()
        {
            Dictionary<IntPtr, string> windows = (Dictionary<IntPtr, string>)OpenWindowGetter.GetOpenWindows();

            //var filteredWindows = 

            // Use the Where method to filter the dictionary for string and then remove Rainmeter skins and FileExplorer that match
            /*var filteredWindows = windows.Where(w =>
            {
                var processId = 0;
                var threadId = OpenWindowGetter.GetWindowThreadProcessId(w.Key, out processId);
                var process = Process.GetProcessById(processId);
                return w.Value.Contains(ReadStringFromText.ReadConfigTextAppName()) && !w.Value.EndsWith(".ini") && process.ProcessName != "explorer";
            });*/
            var filteredWindows = windows.Where(w => w.Value.EndsWith("," + ReadStringFromText.ReadConfigTextAppName()));

            // If no windows match the criteria above then open the application on line 2 of the Config.txt file
            if (!filteredWindows.Any())
            {
                //Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "");
                Process.Start(ReadStringFromText.ReadConfigTextAppLocation(), "");
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
                        //WindowActivator.CheckWindowSize(windowToActivate.Key);
                        //WindowActivator.ShowWindow(windowToActivate.Key, WindowActivator.SW_RESTORE);
                        WindowActivator.SetForegroundWindow(windowToActivate.Key);
                    }
                    // Debuggin errors in the Console window
                    // This could be removed
                    uint error = WindowActivator.GetLastError();
                    if (error != 0)
                    {
                        Console.WriteLine("Error occurred: " + error);
                    }
                    Console.WriteLine("Should have opened " + windowToActivate.Value);
                }
            }
        }
    }
}
