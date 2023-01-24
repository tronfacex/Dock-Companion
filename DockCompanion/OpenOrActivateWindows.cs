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

            // Use the Where method to filter the dictionary
            var filteredWindows = windows.Where(w => w.Value.Contains(ReadStringFromText.ReadConfigTextAppName()) && !w.Value.EndsWith(".ini"));

            if (!filteredWindows.Any())
            {
                //Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "");
                Process.Start(ReadStringFromText.ReadConfigTextAppLocation(), "");
            }
            else
            {
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
