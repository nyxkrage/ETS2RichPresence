using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ets2RichPresence;

namespace ETS2RichPresenceUI
{
    public partial class ETS2RichPresenceUI : Form
    {
        public Ets2RichPresence.Ets2RichPresence richPresence = new Ets2RichPresence.Ets2RichPresence();
        public RichPresenceConfig richPresenceConfig = new RichPresenceConfig();
        NotifyIcon notifyIcon = new NotifyIcon();

        public ETS2RichPresenceUI()
        {
            InitializeComponent();

            Resize += ETS2RichPresenceUI_Resize;
            notifyIcon.DoubleClick += (s, e) =>
            {
                Show();
                ShowInTaskbar = true;
            };
            notifyIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Visible = true;
            notifyIcon.Text = Application.ProductName;

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Exit", null, (s, e) => { Application.Exit(); });
            contextMenu.Items.Add("Show", null, (s, e) => { Show(); ShowInTaskbar = true; });
            notifyIcon.ContextMenuStrip = contextMenu;

            useRealTimeFormat.CheckedChanged += (object sender, EventArgs e) =>
            {
                richPresenceConfig.timeFormat = useRealTimeFormat.Checked ? RichPresenceConfig.TimeFormat.RealTime : RichPresenceConfig.TimeFormat.InGameTime;
            };
            applyBtn.Click += (object sender, EventArgs e) =>
            {
                richPresence.config = richPresenceConfig;
            };
            runBtn.Click += StartRichPresence;
        }

        private void StartRichPresence(object sender, EventArgs e)
        {
            richPresence.Initalize();
            runBtn.Click -= StartRichPresence;
            runBtn.Click += StopRichPresence;
            runBtn.Text = "🔴 Stop Rich Presence";
        }

        private void StopRichPresence(object sender, EventArgs e)
        {
            richPresence.Deinitalize();
            runBtn.Click -= StopRichPresence;
            runBtn.Click += StartRichPresence;
            runBtn.Text = "🟢 Start Rich Presence";
        }

        private void ETS2RichPresenceUI_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                ShowInTaskbar = false;
                Hide();
            }
        }
    }
}
