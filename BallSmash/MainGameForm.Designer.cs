namespace MetalopEmgucvBallSmashUI
{
    partial class MainApplicationForm
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
                
                if (!(bomb == null)) {
                    bomb.Dispose();
                }
                capture.Dispose();
                DifferenceFrame.Dispose();
                DifferenceFrameGray.Dispose();
                BombFrame.Dispose();
                if (!(output == null))
                {
                    output.Dispose();
                }
                
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
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LabelTotalTime = new System.Windows.Forms.Label();
            this.LabelNumberOfHitsValue = new System.Windows.Forms.Label();
            this.LabelNumberOfMissValue = new System.Windows.Forms.Label();
            this.LabelTotalTimeValue = new System.Windows.Forms.Label();
            this.LabelNumberOfHits = new System.Windows.Forms.Label();
            this.LabelNumberOfMiss = new System.Windows.Forms.Label();
            this.LabelGameMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseResumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMenuBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGestureBallSmashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibOriginal
            // 
            this.ibOriginal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ibOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibOriginal.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.ibOriginal.Location = new System.Drawing.Point(0, 24);
            this.ibOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(640, 426);
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            this.ibOriginal.WaitOnLoad = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTotalTime
            // 
            this.LabelTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTotalTime.AutoSize = true;
            this.LabelTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelTotalTime.Font = new System.Drawing.Font("Garamond", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalTime.ForeColor = System.Drawing.Color.Snow;
            this.LabelTotalTime.Location = new System.Drawing.Point(29, 34);
            this.LabelTotalTime.Name = "labelTotalTime";
            this.LabelTotalTime.Padding = new System.Windows.Forms.Padding(5);
            this.LabelTotalTime.Size = new System.Drawing.Size(204, 52);
            this.LabelTotalTime.TabIndex = 8;
            this.LabelTotalTime.Text = "Total Time";
            // 
            // labelNumberOfHitsValue
            // 
            this.LabelNumberOfHitsValue.AutoSize = true;
            this.LabelNumberOfHitsValue.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumberOfHitsValue.Font = new System.Drawing.Font("Garamond", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOfHitsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(77)))));
            this.LabelNumberOfHitsValue.Location = new System.Drawing.Point(90, 207);
            this.LabelNumberOfHitsValue.Name = "labelNumberOfHitsValue";
            this.LabelNumberOfHitsValue.Size = new System.Drawing.Size(33, 39);
            this.LabelNumberOfHitsValue.TabIndex = 9;
            this.LabelNumberOfHitsValue.Text = "0";
            // 
            // labelNumberOfMissValue
            // 
            this.LabelNumberOfMissValue.AutoSize = true;
            this.LabelNumberOfMissValue.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumberOfMissValue.Font = new System.Drawing.Font("Garamond", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOfMissValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.LabelNumberOfMissValue.Location = new System.Drawing.Point(90, 312);
            this.LabelNumberOfMissValue.Name = "labelNumberOfMissValue";
            this.LabelNumberOfMissValue.Size = new System.Drawing.Size(33, 39);
            this.LabelNumberOfMissValue.TabIndex = 10;
            this.LabelNumberOfMissValue.Text = "0";
            // 
            // labelTotalTimeValue
            // 
            this.LabelTotalTimeValue.AutoSize = true;
            this.LabelTotalTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.LabelTotalTimeValue.Font = new System.Drawing.Font("Garamond", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalTimeValue.ForeColor = System.Drawing.Color.Snow;
            this.LabelTotalTimeValue.Location = new System.Drawing.Point(90, 100);
            this.LabelTotalTimeValue.Name = "labelTotalTimeValue";
            this.LabelTotalTimeValue.Size = new System.Drawing.Size(35, 42);
            this.LabelTotalTimeValue.TabIndex = 11;
            this.LabelTotalTimeValue.Text = "0";
            // 
            // labelNumberOfHits
            // 
            this.LabelNumberOfHits.AutoSize = true;
            this.LabelNumberOfHits.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumberOfHits.Font = new System.Drawing.Font("Gabriola", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOfHits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(77)))));
            this.LabelNumberOfHits.Location = new System.Drawing.Point(18, 133);
            this.LabelNumberOfHits.Name = "labelNumberOfHits";
            this.LabelNumberOfHits.Size = new System.Drawing.Size(215, 65);
            this.LabelNumberOfHits.TabIndex = 12;
            this.LabelNumberOfHits.Text = "Number Of Hits";
            // 
            // labelNumberOfMiss
            // 
            this.LabelNumberOfMiss.AutoSize = true;
            this.LabelNumberOfMiss.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumberOfMiss.Font = new System.Drawing.Font("Gabriola", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOfMiss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.LabelNumberOfMiss.Location = new System.Drawing.Point(12, 247);
            this.LabelNumberOfMiss.Name = "labelNumberOfMiss";
            this.LabelNumberOfMiss.Size = new System.Drawing.Size(221, 65);
            this.LabelNumberOfMiss.TabIndex = 13;
            this.LabelNumberOfMiss.Text = "Number Of Miss";
            // 
            // labelGameMessage
            // 
            this.LabelGameMessage.AutoSize = true;
            this.LabelGameMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelGameMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGameMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameMessage.ForeColor = System.Drawing.Color.White;
            this.LabelGameMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelGameMessage.Location = new System.Drawing.Point(448, 264);
            this.LabelGameMessage.Name = "labelGameMessage";
            this.LabelGameMessage.Padding = new System.Windows.Forms.Padding(5);
            this.LabelGameMessage.Size = new System.Drawing.Size(385, 58);
            this.LabelGameMessage.TabIndex = 14;
            this.LabelGameMessage.Text = "labelGameMessage";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseResumeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pauseResumeToolStripMenuItem
            // 
            this.pauseResumeToolStripMenuItem.Name = "pauseResumeToolStripMenuItem";
            this.pauseResumeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.pauseResumeToolStripMenuItem.Text = "Pause";
            this.pauseResumeToolStripMenuItem.Click += new System.EventHandler(this.pauseResumeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showMenuBarToolStripMenuItem
            // 
            this.showMenuBarToolStripMenuItem.CheckOnClick = true;
            this.showMenuBarToolStripMenuItem.Name = "showMenuBarToolStripMenuItem";
            this.showMenuBarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.showMenuBarToolStripMenuItem.Text = "Show Menu Bar";
            this.showMenuBarToolStripMenuItem.Click += new System.EventHandler(this.showMenuBarToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // gameSettingsToolStripMenuItem
            // 
            this.gameSettingsToolStripMenuItem.Name = "gameSettingsToolStripMenuItem";
            this.gameSettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gameSettingsToolStripMenuItem.Text = "Game Settings";
            this.gameSettingsToolStripMenuItem.Click += new System.EventHandler(this.gameSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGestureBallSmashToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutGestureBallSmashToolStripMenuItem
            // 
            this.aboutGestureBallSmashToolStripMenuItem.Name = "aboutGestureBallSmashToolStripMenuItem";
            this.aboutGestureBallSmashToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.aboutGestureBallSmashToolStripMenuItem.Text = "About Gesture Ball Smash";
            this.aboutGestureBallSmashToolStripMenuItem.Click += new System.EventHandler(this.aboutGestureBallSmashToolStripMenuItem_Click);
            // 
            // MainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.LabelGameMessage);
            this.Controls.Add(this.LabelNumberOfMiss);
            this.Controls.Add(this.LabelNumberOfHits);
            this.Controls.Add(this.LabelTotalTimeValue);
            this.Controls.Add(this.LabelNumberOfMissValue);
            this.Controls.Add(this.LabelNumberOfHitsValue);
            this.Controls.Add(this.LabelTotalTime);
            this.Controls.Add(this.ibOriginal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApplicationForm";
            this.Text = "Gesture Ball Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibOriginal;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label LabelTotalTime;
        private System.Windows.Forms.Label LabelNumberOfHitsValue;
        private System.Windows.Forms.Label LabelNumberOfMissValue;
        private System.Windows.Forms.Label LabelTotalTimeValue;
        private System.Windows.Forms.Label LabelNumberOfHits;
        private System.Windows.Forms.Label LabelNumberOfMiss;
        private System.Windows.Forms.Label LabelGameMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseResumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGestureBallSmashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMenuBarToolStripMenuItem;
    }
}

