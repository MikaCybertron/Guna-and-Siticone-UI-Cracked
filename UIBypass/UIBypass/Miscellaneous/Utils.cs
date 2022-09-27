using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UIBypass.Miscellaneous
{
    internal class Utils
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        Logging logging = new Logging();

        bool enabled;

        public void Toggle()
        {
            enabled = !enabled;
            if(enabled)
            {
                logging.LogMessage(Logging.LogType.Message, "Detection Started!");
                DetectWindow();
            }
            else
            {
                logging.LogMessage(Logging.LogType.Message, "Detection Stopped!");
            }
        }

        private void DetectWindow()
        {
            new Thread(() => 
            {
                while (enabled)
                {
                    foreach(var proccess in Process.GetProcesses())
                    {
                        if(proccess.MainWindowTitle.ToLower().Contains("guna ui") && proccess.ProcessName.Contains("devenv") || proccess.ProcessName.Contains("rider64"))
                        {
                            HideWindow(proccess.MainWindowHandle, false);
                            logging.LogMessage(Logging.LogType.Message, "Patched Guna UI");
                        }

                        if(proccess.MainWindowTitle.ToLower().Contains("siticone") && proccess.ProcessName.Contains("devenv") || proccess.ProcessName.Contains("rider64"))
                        {
                            HideWindow(proccess.MainWindowHandle, false);
                            logging.LogMessage(Logging.LogType.Message, "Patched Siticone");
                        }
                    }
                    Thread.Sleep(5000);
                }
            }).Start();
        }

        public void HideWindow(IntPtr windowHandle, bool show)
        {
            if(show) ShowWindow(windowHandle, 5); else ShowWindow(windowHandle, 0);
        }
    }
}
