using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Drawing;
using Ets2RichPresence;

namespace Ets2RichPresenceConsole
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    internal class Program
    {

        static NotifyIcon notifyIcon = new NotifyIcon();
        static bool Visible = true;
        static void Main(string[] args)
        {
            notifyIcon.DoubleClick += (s, e) =>
            {
                Visible = !Visible;
                SetConsoleWindowVisibility(Visible);
            };
            notifyIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Visible = true;
            notifyIcon.Text = Application.ProductName;

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Exit", null, (s, e) => { Application.Exit(); });
            notifyIcon.ContextMenuStrip = contextMenu;

            SetConsoleWindowVisibility(false);
            Console.WriteLine("Running!");
            new Ets2RichPresence.Ets2RichPresence(new ConsoleLogger()).Initalize();

            // Standard message loop to catch click-events on notify icon
            // Code after this method will be running only after Application.Exit()
            Application.Run();

            notifyIcon.Visible = false;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        public static void SetConsoleWindowVisibility(bool visible)
        {
            IntPtr hWnd = FindWindow(null, Console.Title);
            if (hWnd != IntPtr.Zero)
            {
                if (visible) ShowWindow(hWnd, 1); //1 = SW_SHOWNORMAL           
                else ShowWindow(hWnd, 0); //0 = SW_HIDE               
            }
        }


    }
}
