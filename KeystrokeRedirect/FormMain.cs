using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeystrokeRedirect
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Settings.Multithreading)
                new Thread(() => Foo(e)).Start();
            else
                Foo(e);
        }

        public void Foo(KeyEventArgs keyEventArgs)
        {
            keyEventArgs.SuppressKeyPress = Settings.SuppressKeyPress;

            Process[] discords = WinApiWrapper.GetProcessList("Discord");
            foreach (Process discordWindow in WinApiWrapper.FilterWindows(discords))
            {
                if (Settings.OpenIfMinimized)
                {
                    WinApiWrapper.WINDOWPLACEMENT windowPlacement = new WinApiWrapper.WINDOWPLACEMENT();
                    WinApiWrapper.GetWindowPlacement(discordWindow.MainWindowHandle, ref windowPlacement);
                    if (windowPlacement.showCmd == 2)
                        WinApiWrapper.ShowWindow(discordWindow.MainWindowHandle, 1);
                }
                discordWindow.WaitForInputIdle();
                WinApiWrapper.SetForegroundWindow(discordWindow.MainWindowHandle);
                Thread.Sleep(Settings.SwapDelay);
                WinApiWrapper.PostMessage(discordWindow.MainWindowHandle, WinApiWrapper.WM_KEYDOWN, keyEventArgs.KeyCode, IntPtr.Zero);
                WinApiWrapper.PostMessage(discordWindow.MainWindowHandle, WinApiWrapper.WM_KEYDOWN, Keys.Enter, IntPtr.Zero);
                Thread.Sleep(Settings.SwapDelay);
                WinApiWrapper.SetForegroundWindow(Process.GetCurrentProcess().MainWindowHandle);
            }
        }
    }
}
