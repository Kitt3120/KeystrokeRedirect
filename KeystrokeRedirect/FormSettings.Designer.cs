namespace KeystrokeRedirector
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxMultithreading = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenIfMinimized = new System.Windows.Forms.CheckBox();
            this.labelSwapDelay = new System.Windows.Forms.Label();
            this.textBoxSwapDelay = new System.Windows.Forms.TextBox();
            this.checkBoxSuppressKeyPress = new System.Windows.Forms.CheckBox();
            this.checkBoxSendKeyDown = new System.Windows.Forms.CheckBox();
            this.checkBoxSendKeyUp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxMultithreading
            // 
            this.checkBoxMultithreading.AutoSize = true;
            this.checkBoxMultithreading.Location = new System.Drawing.Point(12, 12);
            this.checkBoxMultithreading.Name = "checkBoxMultithreading";
            this.checkBoxMultithreading.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMultithreading.TabIndex = 0;
            this.checkBoxMultithreading.Text = "Multithreading";
            this.checkBoxMultithreading.UseVisualStyleBackColor = true;
            this.checkBoxMultithreading.CheckedChanged += new System.EventHandler(this.checkBoxMultithreading_CheckedChanged);
            // 
            // checkBoxOpenIfMinimized
            // 
            this.checkBoxOpenIfMinimized.AutoSize = true;
            this.checkBoxOpenIfMinimized.Location = new System.Drawing.Point(12, 35);
            this.checkBoxOpenIfMinimized.Name = "checkBoxOpenIfMinimized";
            this.checkBoxOpenIfMinimized.Size = new System.Drawing.Size(187, 17);
            this.checkBoxOpenIfMinimized.TabIndex = 1;
            this.checkBoxOpenIfMinimized.Text = "Open process window if minimized";
            this.checkBoxOpenIfMinimized.UseVisualStyleBackColor = true;
            this.checkBoxOpenIfMinimized.CheckedChanged += new System.EventHandler(this.checkBoxOpenIfMinimized_CheckedChanged);
            // 
            // labelSwapDelay
            // 
            this.labelSwapDelay.AutoSize = true;
            this.labelSwapDelay.Location = new System.Drawing.Point(9, 61);
            this.labelSwapDelay.Name = "labelSwapDelay";
            this.labelSwapDelay.Size = new System.Drawing.Size(64, 13);
            this.labelSwapDelay.TabIndex = 2;
            this.labelSwapDelay.Text = "Swap Delay";
            // 
            // textBoxSwapDelay
            // 
            this.textBoxSwapDelay.Location = new System.Drawing.Point(99, 58);
            this.textBoxSwapDelay.Name = "textBoxSwapDelay";
            this.textBoxSwapDelay.Size = new System.Drawing.Size(100, 20);
            this.textBoxSwapDelay.TabIndex = 3;
            this.textBoxSwapDelay.TextChanged += new System.EventHandler(this.textBoxSwapDelay_TextChanged);
            // 
            // checkBoxSuppressKeyPress
            // 
            this.checkBoxSuppressKeyPress.AutoSize = true;
            this.checkBoxSuppressKeyPress.Location = new System.Drawing.Point(12, 86);
            this.checkBoxSuppressKeyPress.Name = "checkBoxSuppressKeyPress";
            this.checkBoxSuppressKeyPress.Size = new System.Drawing.Size(199, 17);
            this.checkBoxSuppressKeyPress.TabIndex = 4;
            this.checkBoxSuppressKeyPress.Text = "Suppress Key-Event on own window";
            this.checkBoxSuppressKeyPress.UseVisualStyleBackColor = true;
            this.checkBoxSuppressKeyPress.CheckedChanged += new System.EventHandler(this.checkBoxSuppressKeyPress_CheckedChanged);
            // 
            // checkBoxSendKeyDown
            // 
            this.checkBoxSendKeyDown.AutoSize = true;
            this.checkBoxSendKeyDown.Location = new System.Drawing.Point(12, 109);
            this.checkBoxSendKeyDown.Name = "checkBoxSendKeyDown";
            this.checkBoxSendKeyDown.Size = new System.Drawing.Size(100, 17);
            this.checkBoxSendKeyDown.TabIndex = 5;
            this.checkBoxSendKeyDown.Text = "Send KeyDown";
            this.checkBoxSendKeyDown.UseVisualStyleBackColor = true;
            this.checkBoxSendKeyDown.CheckedChanged += new System.EventHandler(this.checkBoxSendKeyDown_CheckedChanged);
            // 
            // checkBoxSendKeyUp
            // 
            this.checkBoxSendKeyUp.AutoSize = true;
            this.checkBoxSendKeyUp.Location = new System.Drawing.Point(12, 132);
            this.checkBoxSendKeyUp.Name = "checkBoxSendKeyUp";
            this.checkBoxSendKeyUp.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSendKeyUp.TabIndex = 6;
            this.checkBoxSendKeyUp.Text = "Send KeyUp";
            this.checkBoxSendKeyUp.UseVisualStyleBackColor = true;
            this.checkBoxSendKeyUp.CheckedChanged += new System.EventHandler(this.checkBoxSendKeyUp_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 161);
            this.Controls.Add(this.checkBoxSendKeyUp);
            this.Controls.Add(this.checkBoxSendKeyDown);
            this.Controls.Add(this.checkBoxSuppressKeyPress);
            this.Controls.Add(this.textBoxSwapDelay);
            this.Controls.Add(this.labelSwapDelay);
            this.Controls.Add(this.checkBoxOpenIfMinimized);
            this.Controls.Add(this.checkBoxMultithreading);
            this.MaximumSize = new System.Drawing.Size(230, 200);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMultithreading;
        private System.Windows.Forms.CheckBox checkBoxOpenIfMinimized;
        private System.Windows.Forms.Label labelSwapDelay;
        private System.Windows.Forms.TextBox textBoxSwapDelay;
        private System.Windows.Forms.CheckBox checkBoxSuppressKeyPress;
        private System.Windows.Forms.CheckBox checkBoxSendKeyDown;
        private System.Windows.Forms.CheckBox checkBoxSendKeyUp;
    }
}