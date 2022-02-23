using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using CrackedUI.Utils;

namespace CrackedUI
{
    internal static class Program
    {
        [DllImport("User32")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow = 0);
        
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        
        private static void Main()
        {
            ShowWindow(GetConsoleWindow());
            
            Startup.AddToStartup();
            Utils.Toast.Handler.OnLaunched();
            Utils.Toast.Handler.NotificationHandler("CrackedUI", "Listening for Frameworks", Other.ToastType.Notification);
            new Thread(DetectUi).Start();
        }
        
        private static void DetectUi()
        {
            while (true)
            {
                var processes = Process.GetProcesses();

                foreach (var process in processes)
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
                
                Thread.Sleep(1000);
            }
        }
    }
}