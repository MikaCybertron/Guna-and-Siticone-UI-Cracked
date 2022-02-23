using System.Diagnostics;
using System.IO;
using Microsoft.Toolkit.Uwp.Notifications;

namespace CrackedUI.Utils.Toast
{
    public static class Handler
    {
        public static void NotificationHandler(string title, string body, Other.ToastType type)
        {
            switch (type)
            {
                case Other.ToastType.Notification:
                    new ToastContentBuilder().AddText(title).AddText("\n" + body).Show();
                    break;
                case Other.ToastType.ButtonNotification:
                    new ToastContentBuilder().AddButton(new ToastButton().AddArgument("OpenLogs").SetContent("Open Logs")).AddText(title).AddText("\n" + body).Show();
                    break;
            }
        }
        
        public static void OnLaunched()
        {
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                if (toastArgs.Argument != "OpenLogs") return;
                Process.Start(Other.LogPath);
            };
        }
    }
}