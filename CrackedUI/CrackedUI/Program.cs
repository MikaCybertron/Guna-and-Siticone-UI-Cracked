using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using static Colorful.Console;

namespace CrackedUI
{
    internal static class Program
    {
        private const int SwHide = 0;

        [DllImport("User32")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow = SwHide);

        private enum IdeType
        {
            Rider,
            Vs
        }
        
        private static void Main()
        {
            Title = "CrackedUI | By Verity";
            WriteLine(" CrackedUI @ " + DateTime.Now + ": Listening for Frameworks...\n", Color.MediumPurple);
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
                            Log(process, IdeType.Vs);
                            ShowWindow(process.MainWindowHandle);
                            break;
                        case "RiderWinFormsDesignerLauncher64":
                            Log(process, IdeType.Rider);
                            ShowWindow(process.MainWindowHandle);
                            break;
                    }
                }
                
                CursorVisible = false;
                Thread.Sleep(500);
            }
        }

        private static void Log(Process process, IdeType ideType)
        {
            var windowTitle = process.MainWindowTitle;
            WriteLine(" CrackedUI @ " + DateTime.Now + ": " + windowTitle + $" was successfully patched. Ide: {ideType}", Color.Aqua);
        }
    }
}