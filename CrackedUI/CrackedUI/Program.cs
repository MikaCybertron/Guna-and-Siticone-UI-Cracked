using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using CrackedUI.Utils;
using CrackedUI.Utils.Toast;

namespace CrackedUI
{
    internal static class Program
    {
        [DllImport("User32")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow = 0);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        private static void Main()
        {
            ShowWindow(GetConsoleWindow());

            Handler.OnLaunched();
            Handler.NotificationHandler("CrackedUI", "Started successfully, waiting to make Guna and/or Siticone mad.",
                Other.ToastType.Notification);
            if (!Directory.Exists(Other.LogDirectory))
            {
                Directory.CreateDirectory(Other.LogDirectory);
                Handler.NotificationHandler("CrackedUI", "Logs directory created.", Other.ToastType.Notification);
            }
            
            DetectUi();
        }

        private static void DetectUi()
        {
            while (true)
            {
                GC.Collect();
                
                foreach (var process in Process.GetProcesses())
                {
                    if (process.MainWindowTitle.Length == 0) continue;
                    if (process.MainWindowTitle.Contains("Microsoft Visual Studio")) continue;
                    
                    switch (process.ProcessName)
                    {
                        case "devenv":
                            Utils.Log.Handler.Log(process, Other.IdeType.Vs);
                            ShowWindow(process.MainWindowHandle);
                            break;
                        case "RiderWinFormsDesignerLauncher64":
                            Utils.Log.Handler.Log(process, Other.IdeType.Rider);
                            ShowWindow(process.MainWindowHandle);
                            break;
                    }
                }

                Thread.Sleep(300);
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}