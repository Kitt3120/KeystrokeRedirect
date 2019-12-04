using KeystrokeRedirect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeystrokeRedirector
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            checkBoxMultithreading.Checked = Settings.Multithreading;
            checkBoxOpenIfMinimized.Checked = Settings.OpenIfMinimized;
            textBoxSwapDelay.Text = Settings.SwapDelay.ToString();
            checkBoxSuppressKeyPress.Checked = Settings.SuppressKeyPress;
            checkBoxSendKeyDown.Checked = Settings.SendKeyDown;
            checkBoxSendKeyUp.Checked = Settings.SendKeyUp;
        }

        private void checkBoxMultithreading_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Multithreading = checkBoxMultithreading.Checked;
        }

        private void checkBoxOpenIfMinimized_CheckedChanged(object sender, EventArgs e)
        {
            Settings.OpenIfMinimized = checkBoxOpenIfMinimized.Checked;
        }

        private void textBoxSwapDelay_TextChanged(object sender, EventArgs e)
        {
            if(textBoxSwapDelay.Text.Length > 0)
            {
                int delay;
                if(int.TryParse(textBoxSwapDelay.Text, out delay) && delay >= 0)
                {
                    Settings.SwapDelay = delay;
                } 
                else
                {
                    MessageBox.Show("Please put in a valid number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSwapDelay.Clear();
                }
            }
        }

        private void checkBoxSuppressKeyPress_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SuppressKeyPress = checkBoxSuppressKeyPress.Checked;
        }

        private void checkBoxSendKeyDown_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SendKeyDown = checkBoxSendKeyDown.Checked;
        }

        private void checkBoxSendKeyUp_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SendKeyUp = checkBoxSendKeyUp.Checked;
        }
    }
}
