using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Window_Resizer
{
    public partial class Form1 : Form
    {
        private const string StartupRegistryKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        private const string AppName = "Window Resizer";
        private NotifyIcon notifyIcon;
        private bool runAtStartupChecked;

        private const int MOD_ALT = 0x0001;
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
        private const int WM_HOTKEY = 0x0312;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public Form1()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 1, MOD_CONTROL | MOD_ALT, (int)Keys.Oemplus);
            RegisterHotKey(this.Handle, 2, MOD_CONTROL | MOD_SHIFT, (int)Keys.Oemplus);

            UpdateRunAtStartupState();

            InitializeSystemTrayIcon();

            System.Threading.Thread checkboxThread = new System.Threading.Thread(UpdateCheckboxState);
            checkboxThread.IsBackground = true;
            checkboxThread.Start();
        }

        private void InitializeSystemTrayIcon()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Visible = true;

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Open");
            openMenuItem.Click += TrayIcon_Open_Click;
            ToolStripMenuItem runAtStartupMenuItem = new ToolStripMenuItem("Run at Startup");
            runAtStartupMenuItem.Click += TrayIcon_RunAtStartup_Click;
            ToolStripMenuItem quitMenuItem = new ToolStripMenuItem("Quit");
            quitMenuItem.Click += QuitMenuItem_Click;

            contextMenu.Items.Add(openMenuItem);
            contextMenu.Items.Add(runAtStartupMenuItem);
            contextMenu.Items.Add(quitMenuItem);

            notifyIcon.ContextMenuStrip = contextMenu;

            runAtStartupMenuItem.Checked = runAtStartupChecked;
        }

        private void UpdateRunAtStartupState()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupRegistryKey))
            {
                if (key != null)
                {
                    object value = key.GetValue(AppName);
                    if (value != null && value.ToString() == Application.ExecutablePath)
                    {
                        runAtStartupChecked = true;
                    }
                    else
                    {
                        runAtStartupChecked = false;
                    }
                }
                else
                {
                    runAtStartupChecked = false;
                }
            }
        }

        private void TrayIcon_Open_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void TrayIcon_RunAtStartup_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.Checked = !menuItem.Checked;
            runAtStartupChecked = menuItem.Checked;

            runats.Checked = runAtStartupChecked;

            UpdateStartupRegistrySetting();
        }

        private void QuitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateStartupRegistrySetting()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupRegistryKey, true))
            {
                if (runAtStartupChecked)
                {
                    if (key.GetValue(AppName) == null)
                    {
                        key.SetValue(AppName, Application.ExecutablePath);
                    }
                    key.SetValue(AppName, Application.ExecutablePath);
                }
                else
                {
                    key.SetValue(AppName, Application.ExecutablePath, RegistryValueKind.String);
                    key.DeleteValue(AppName, false);
                }
            }
        }

        private void UpdateCheckboxState()
        {
            while (true)
            {
                runats.Invoke((MethodInvoker)(() =>
                {
                    runats.Checked = runAtStartupChecked;
                }));
                System.Threading.Thread.Sleep(1000);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    ShowSettingsForm();
                }
                else if (id == 2)
                {
                    Show();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleVisibility();
        }

        private void ToggleVisibility()
        {
            if (Visible)
            {
                Hide();
            }
            else
            {
                Show();
            }
        }

        private void clkeeprunning_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void runats_CheckedChanged(object sender, EventArgs e)
        {
            runAtStartupChecked = runats.Checked;

            ToolStripMenuItem runAtStartupMenuItem = null;
            foreach (ToolStripMenuItem item in notifyIcon.ContextMenuStrip.Items)
            {
                if (item.Text == "Run at Startup")
                {
                    runAtStartupMenuItem = item;
                    break;
                }
            }

            if (runAtStartupMenuItem != null)
            {
                runAtStartupMenuItem.Checked = runAtStartupChecked;
            }

            UpdateStartupRegistrySetting();
        }

        private void ShowSettingsForm()
        {
            Form2 settingsForm = new Form2();
            settingsForm.ShowDialog();
        }

        private void Gtb(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}