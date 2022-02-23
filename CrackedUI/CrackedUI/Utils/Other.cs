using System.IO;

namespace CrackedUI.Utils
{
    public static class Other
    {
        public static readonly string LogPath = $@"{Directory.GetCurrentDirectory()}\Logs\Log.txt";
        public static readonly string LogDirectory = $@"{Directory.GetCurrentDirectory()}\Logs\";
        
        public enum IdeType
        {
            Rider,
            Vs
        }

        public enum ToastType
        {
            Notification,
            ButtonNotification
        }
    }
}