namespace winform_app_csharp_splash_screen
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.PanelLoading = new System.Windows.Forms.Panel();
            this.PanelLoadRunning = new System.Windows.Forms.Panel();
            this.TimeRunning = new System.Windows.Forms.Timer(this.components);
            this.PanelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLoading
            // 
            this.PanelLoading.BackColor = System.Drawing.Color.LightSlateGray;
            this.PanelLoading.Controls.Add(this.PanelLoadRunning);
            this.PanelLoading.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLoading.Location = new System.Drawing.Point(0, 0);
            this.PanelLoading.Name = "PanelLoading";
            this.PanelLoading.Size = new System.Drawing.Size(684, 10);
            this.PanelLoading.TabIndex = 0;
            // 
            // PanelLoadRunning
            // 
            this.PanelLoadRunning.BackColor = System.Drawing.SystemColors.Control;
            this.PanelLoadRunning.Location = new System.Drawing.Point(0, 0);
            this.PanelLoadRunning.Name = "PanelLoadRunning";
            this.PanelLoadRunning.Size = new System.Drawing.Size(21, 10);
            this.PanelLoadRunning.TabIndex = 1;
            // 
            // TimeRunning
            // 
            this.TimeRunning.Enabled = true;
            this.TimeRunning.Interval = 10;
            this.TimeRunning.Tick += new System.EventHandler(this.TimeRunning_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.PanelLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.PanelLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLoading;
        private System.Windows.Forms.Panel PanelLoadRunning;
        private System.Windows.Forms.Timer TimeRunning;
    }
}

