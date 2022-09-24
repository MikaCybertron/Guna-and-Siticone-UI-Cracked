using System;
using System.Windows.Forms;

namespace UIBypass.Miscellaneous
{
    internal class Logging
    {
        public enum LogType
        {
            Message,
            Warning,
            Error
        }

        public void LogMessage(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.Message:
                    Console.WriteLine($"Message -> {message}\n");
                    break;
                case LogType.Warning:
                    Console.WriteLine($"Warning -> {message}\n");
                    break;
                case LogType.Error:
                    Console.WriteLine($"Error -> {message}\n");
                    break;
            }
        }
    }
}