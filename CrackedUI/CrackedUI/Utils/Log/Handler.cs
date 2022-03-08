using System;
using System.Diagnostics;
using System.IO;

namespace CrackedUI.Utils.Log
{
    public static class Handler
    {
        public static void Log(Process process, Other.IdeType ideType)
        {
            var windowTitle = process.MainWindowTitle;
            File.AppendAllText(Other.LogPath,
                $"CrackedUI @ {DateTime.Now}: {windowTitle} was patched on the Ide: {ideType}\n");
            Toast.Handler.NotificationHandler("CrackedUI", $"{windowTitle} was patched on the Ide: {ideType}",
                Other.ToastType.ButtonNotification);
        }
    }
}