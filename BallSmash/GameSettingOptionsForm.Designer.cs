namespace MetalopEmgucvBallSmashUI
{
    partial class GameSettingOptionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarBallTimeThreshold = new System.Windows.Forms.TrackBar();
            this.trackBarTimeToIncreaseBalls = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBombDisplayTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarTimeAfterWhichToDisplayBomb = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarMaxTimeToDisplayBomb = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBallTimeThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeToIncreaseBalls)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeAfterWhichToDisplayBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxTimeToDisplayBomb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum Time To Touch The Ball";
            // 
            // trackBarBallTimeThreshold
            // 
            this.trackBarBallTimeThreshold.AllowDrop = true;
            this.trackBarBallTimeThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.trackBarBallTimeThreshold.Location = new System.Drawing.Point(312, 3);
            this.trackBarBallTimeThreshold.Minimum = 1;
            this.trackBarBallTimeThreshold.Name = "trackBarBallTimeThreshold";
            this.trackBarBallTimeThreshold.Size = new System.Drawing.Size(241, 29);
            this.trackBarBallTimeThreshold.TabIndex = 1;
            this.trackBarBallTimeThreshold.Value = 5;
            this.trackBarBallTimeThreshold.Scroll += new System.EventHandler(this.trackBarBallTimeThreshold_Scroll);
            // 
            // trackBarTimeToIncreaseBalls
            // 
            this.trackBarTimeToIncreaseBalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.trackBarTimeToIncreaseBalls.Location = new System.Drawing.Point(312, 84);
            this.trackBarTimeToIncreaseBalls.Maximum = 50;
            this.trackBarTimeToIncreaseBalls.Minimum = 5;
            this.trackBarTimeToIncreaseBalls.Name = "trackBarTimeToIncreaseBalls";
            this.trackBarTimeToIncreaseBalls.Size = new System.Drawing.Size(241, 27);
            this.trackBarTimeToIncreaseBalls.TabIndex = 2;
            this.trackBarTimeToIncreaseBalls.TickFrequency = 5;
            this.trackBarTimeToIncreaseBalls.Value = 20;
            this.trackBarTimeToIncreaseBalls.Scroll += new System.EventHandler(this.trackBarTimeToIncreaseBalls_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Intervel To Increase The Number Of Balls";
            // 
            // labelBombDisplayTime
            // 
            this.labelBombDisplayTime.AutoSize = true;
            this.labelBombDisplayTime.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBombDisplayTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(233)))));
            this.labelBombDisplayTime.Location = new System.Drawing.Point(3, 160);
            this.labelBombDisplayTime.Name = "labelBombDisplayTime";
            this.labelBombDisplayTime.Size = new System.Drawing.Size(269, 33);
            this.labelBombDisplayTime.TabIndex = 4;
            this.labelBombDisplayTime.Text = "Maximum Time To Display The Bomb On Screen";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.35714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.64286F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarBallTimeThreshold, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.trackBarTimeAfterWhichToDisplayBomb, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBarTimeToIncreaseBalls, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBombDisplayTime, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.trackBarMaxTimeToDisplayBomb, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 331);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(3, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "(Increasing Value Decreses Difficulty)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(3, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Intervel After Which To Display A Bomb";
            // 
            // trackBarTimeAfterWhichToDisplayBomb
            // 
            this.trackBarTimeAfterWhichToDisplayBomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.trackBarTimeAfterWhichToDisplayBomb.Location = new System.Drawing.Point(312, 245);
            this.trackBarTimeAfterWhichToDisplayBomb.Maximum = 50;
            this.trackBarTimeAfterWhichToDisplayBomb.Name = "trackBarTimeAfterWhichToDisplayBomb";
            this.trackBarTimeAfterWhichToDisplayBomb.Size = new System.Drawing.Size(241, 28);
            this.trackBarTimeAfterWhichToDisplayBomb.TabIndex = 7;
            this.trackBarTimeAfterWhichToDisplayBomb.TickFrequency = 5;
            this.trackBarTimeAfterWhichToDisplayBomb.Value = 20;
            this.trackBarTimeAfterWhichToDisplayBomb.Scroll += new System.EventHandler(this.trackBarTimeAfterWhichToDisplayBomb_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Increasing Value Decreses Difficulty)";
            // 
            // trackBarMaxTimeToDisplayBomb
            // 
            this.trackBarMaxTimeToDisplayBomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.trackBarMaxTimeToDisplayBomb.Location = new System.Drawing.Point(312, 163);
            this.trackBarMaxTimeToDisplayBomb.Minimum = 1;
            this.trackBarMaxTimeToDisplayBomb.Name = "trackBarMaxTimeToDisplayBomb";
            this.trackBarMaxTimeToDisplayBomb.Size = new System.Drawing.Size(241, 27);
            this.trackBarMaxTimeToDisplayBomb.TabIndex = 5;
            this.trackBarMaxTimeToDisplayBomb.Value = 5;
            this.trackBarMaxTimeToDisplayBomb.Scroll += new System.EventHandler(this.trackBarMaxTimeToDisplayBomb_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "(Increasing Value Increases Difficulty)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "(Increasing Value Decreses Difficulty)";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(70, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(376, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.BackColor = System.Drawing.Color.DarkViolet;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.ShowAlways = true;
            // 
            // formGameSettingOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "formGameSettingOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBallTimeThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeToIncreaseBalls)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeAfterWhichToDisplayBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxTimeToDisplayBomb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarBallTimeThreshold;
        private System.Windows.Forms.TrackBar trackBarTimeToIncreaseBalls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBombDisplayTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar trackBarMaxTimeToDisplayBomb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarTimeAfterWhichToDisplayBomb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}