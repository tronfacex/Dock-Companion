using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockCompanion
{
    class RetrieveWindowHandles
    {
        public static void GetWindowHandles()
        {
            foreach (KeyValuePair<IntPtr, string> window in OpenWindowGetter.GetOpenWindows())
            {
                IntPtr handle = window.Key;
                string title = window.Value;

                Console.WriteLine("{0}: {1}", handle, title);
            }
        }
    }
}
