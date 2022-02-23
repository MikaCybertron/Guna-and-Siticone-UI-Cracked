using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Win32;

namespace CrackedUI.Utils
{
    public static class Startup
    {
        public static void AddToStartup()
        {
            var currentdir = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
            var rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (!rk!.GetValueNames().Contains("CrackedUI"))
            {
                rk!.SetValue("CrackedUI", currentdir!);
            }
        }
    }
}