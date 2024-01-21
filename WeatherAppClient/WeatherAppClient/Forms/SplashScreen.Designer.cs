namespace WeatherAppClient.Forms
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
            this.PogodaInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SplashStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PogodaInfoLabel
            // 
            this.PogodaInfoLabel.AutoSize = true;
            this.PogodaInfoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PogodaInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PogodaInfoLabel.Location = new System.Drawing.Point(116, 156);
            this.PogodaInfoLabel.Name = "PogodaInfoLabel";
            this.PogodaInfoLabel.Size = new System.Drawing.Size(219, 42);
            this.PogodaInfoLabel.TabIndex = 0;
            this.PogodaInfoLabel.Text = "Pogoda Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(345, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autor J.G";
            // 
            // SplashStatus
            // 
            this.SplashStatus.AutoSize = true;
            this.SplashStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SplashStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SplashStatus.Location = new System.Drawing.Point(97, 222);
            this.SplashStatus.Name = "SplashStatus";
            this.SplashStatus.Size = new System.Drawing.Size(209, 24);
            this.SplashStatus.TabIndex = 2;
            this.SplashStatus.Text = "... sprawdzanie dostępu";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherAppClient.Properties.Resources.Mapa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(437, 426);
            this.Controls.Add(this.SplashStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PogodaInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PogodaInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SplashStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}