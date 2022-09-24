namespace UIBypass
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(88, 61);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 37);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start UIBypass";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(203, 61);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(109, 37);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop UIBypass";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(144, 104);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(109, 37);
            this.hideButton.TabIndex = 3;
            this.hideButton.Text = "Hide Window";
            this.hideButton.UseVisualStyleBackColor = true;
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.BalloonTipText = "Made by Verity";
            this.mainNotifyIcon.BalloonTipTitle = "UIBypass";
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "UIBypass";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 202);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIBypass | Developed by Verity";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
    }
}

