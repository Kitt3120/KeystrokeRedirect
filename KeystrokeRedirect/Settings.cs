using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeystrokeRedirect
{
    class Settings
    {
        public static bool Paused { get; set; } = false;
        public static Keys PauseKey { get; set; } = Keys.Escape;
        public static bool Multithreading { get; set; } = true;
        public static bool OpenIfMinimized { get; set; } = true;

        public static Process[] SelectedProcesses { get; set; } = new Process[0];
        public static int SwapDelay { get; set; } = 1;

        public static bool SuppressKeyPress { get; set; } = true;
        public static bool SendKeyDown { get; set; } = true;
        public static bool SendKeyUp { get; set; } = false;
    }
}
