using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Window_Resizer
{
    public partial class Form2 : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private IntPtr targetWindowHandle;

        public Form2()
        {
            InitializeComponent();
        }

        private void cancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resizeb_Click(object sender, EventArgs e)
        {
            int width, height;
            if (!int.TryParse(resolutionwidth.Text, out width) || !int.TryParse(resolutionheight.Text, out height))
            {
                MessageBox.Show("Invalid resolution input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RECT rect;
            GetWindowRect(targetWindowHandle, out rect);
            int x = rect.Left;
            int y = rect.Top;

            uint flags = 0;

            flags |= 0x0002;

            SetWindowPos(targetWindowHandle, IntPtr.Zero, x, y, width, height, flags);

            Close();
        }

        private void resolutionheight_TextChanged(object sender, EventArgs e)
        {

        }

        private void resolutionwidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            targetWindowHandle = GetForegroundWindow();
            RECT rect;
            GetWindowRect(targetWindowHandle, out rect);
            resolutionwidth.Text = (rect.Right - rect.Left).ToString();
            resolutionheight.Text = (rect.Bottom - rect.Top).ToString();
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
    }
}
