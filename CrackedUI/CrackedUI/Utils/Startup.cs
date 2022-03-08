using System;
using System.Linq;
using Microsoft.Win32;

namespace CrackedUI.Utils
{
    public static class Startup
    {
        public static void AddToStartup()
        {
            var currentdir = Environment.CurrentDirectory;
            var rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (!rk!.GetValueNames().Contains("CrackedUI")) rk!.SetValue("CrackedUI", currentdir + @"\CrackedUI.exe");
        }
    }
}