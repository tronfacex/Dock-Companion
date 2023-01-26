using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockCompanion
{
    //<summary>This class contains a method for retrieving all open Window titles and keys and writes them to the console</summary>
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
