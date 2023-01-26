using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using HWND = System.IntPtr;
using System.Diagnostics;

namespace DockCompanion
{
    /// <summary>Contains functionality to get all the open windows. This class is basically pulled directly from an answer on StackOverflow post https://stackoverflow.com/questions/7268302/get-the-titles-of-all-open-windows </summary>
    public static class OpenWindowGetter
    {
        private delegate bool EnumWindowsProc(HWND hWnd, int lParam);

        [DllImport("USER32.DLL")]
        private static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowText(HWND hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowTextLength(HWND hWnd);

        [DllImport("USER32.DLL")]
        private static extern bool IsWindowVisible(HWND hWnd);

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetShellWindow();

        [DllImport("user32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        /// <summary>Returns a dictionary that contains the handle and title of all the open windows.</summary>
        /// <returns>A dictionary that contains the handle and title of all the open windows.</returns>
        public static IDictionary<HWND, string> GetOpenWindows()
        {
            HWND shellWindow = GetShellWindow();
            Dictionary<HWND, string> windows = new Dictionary<HWND, string>();

            EnumWindows(delegate (HWND hWnd, int lParam)
            {
                if (!IsWindowVisible(hWnd)) return true;

                int lpdwProcessId;
                GetWindowThreadProcessId(hWnd, out lpdwProcessId);
                var process = Process.GetProcessById(lpdwProcessId);
                windows[hWnd] = process.ProcessName;
                return true;

            }, 0);

            return windows;
        }

        /*public static IDictionary<HWND, string> GetProcessNameOfWindows()
        {
            foreach (var window in GetOpenWindows())
            {
                string windowTitle = window.Value.ToString(); 
                window.Value = 
            }
        }*/
    }
}

