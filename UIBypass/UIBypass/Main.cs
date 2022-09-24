using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UIBypass.Miscellaneous;

namespace UIBypass
{
    public partial class Main : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        readonly Logging logging = new Logging();
        readonly Utils Utils = new Utils();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Console.Title = "UIBypass | Developed by Verity";
            logging.LogMessage(Logging.LogType.Message, "Main Form Loaded");
        }

        #region Events
        private void Main_Shown(object sender, EventArgs e)
        {
            startButton.Click += EventHandler;
            stopButton.Click += EventHandler;
            hideButton.Click += EventHandler;

            mainNotifyIcon.DoubleClick += MainNotifyIcon_DoubleClick; ;
        }

        private void MainNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Utils.HideWindow(GetConsoleWindow(), true);
            Show();
            mainNotifyIcon.Visible = false;
        }

        private void EventHandler(object sender, EventArgs eventArgs)
        {
            var control = sender as Control;
            switch (control.Name)
            {
                case "logTextBox":
                    ActiveControl = null;
                    break;
                case "startButton":
                    Utils.Toggle();
                    break;
                case "stopButton":
                    Utils.Toggle();
                    break;
                case "hideButton":
                    Utils.HideWindow(GetConsoleWindow(), false);
                    Hide();
                    mainNotifyIcon.Visible = true;
                    break;
            }
        }
        #endregion
    }
}
