using KeystrokeRedirector;
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
            if(e.KeyCode == Settings.PauseKey)
            {
                Settings.Paused = !Settings.Paused;
                MessageBox.Show("Paused: " + Settings.Paused);
            }

            if (Settings.Paused)
                return;

            if (Settings.Multithreading)
                new Thread(() => HandleKeyEvent(e)).Start();
            else
                HandleKeyEvent(e);
        }

        public void HandleKeyEvent(KeyEventArgs keyEventArgs)
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

                if (Settings.SendKeyDown)
                    WinApiWrapper.PostMessage(discordWindow.MainWindowHandle, WinApiWrapper.WM_KEYDOWN, keyEventArgs.KeyCode, IntPtr.Zero);
                if (Settings.SendKeyUp)
                    WinApiWrapper.PostMessage(discordWindow.MainWindowHandle, WinApiWrapper.WM_KEYUP, keyEventArgs.KeyCode, IntPtr.Zero);

                Thread.Sleep(Settings.SwapDelay);
                WinApiWrapper.SetForegroundWindow(Process.GetCurrentProcess().MainWindowHandle);
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.ShowDialog(this);
            //TODO: Unfocus button
        }
    }
}
