using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetalopEmgucvBallSmashUI
{
    public partial class GameSettingOptionsForm : Form
    {
        private int ballTimeThreshold = 5;// the maximum amount if time to touch the ball
        private int timeIntervelToIncreaseBalls = 20;
        private int bombDisplayTime = 5;// Maximum Intervel to display the bomb on screen
        private int timeIntervelWhenToDisplayBomb = 20;

        public GameSettingOptionsForm()
        {
            InitializeComponent();
        }


        // Defining a property

        public int GetVal_BallTimeThreshold
        {
            set
            {
                ballTimeThreshold = value;
            }
            get
            {
                return ballTimeThreshold;
            }
        }

        public int GetVal_timeIntervelToIncreaseBalls
        {
            set
            {
                timeIntervelToIncreaseBalls = value;
            }
            get
            {
                return timeIntervelToIncreaseBalls;
            }
        }
        public int GetVal_bombDisplayTime
        {
            set
            {
                bombDisplayTime = value;
            }
            get
            {

                return bombDisplayTime;
            }
        }

        public int GetVal_timeIntervelWhenToDisplayBomb
        {
            set
            {
                timeIntervelWhenToDisplayBomb = value;
            }
            get
            {
                return timeIntervelWhenToDisplayBomb;
            }
        }





        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBarBallTimeThreshold_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBarBallTimeThreshold, trackBarBallTimeThreshold.Value.ToString());
            ballTimeThreshold = trackBarBallTimeThreshold.Value;
             
        }

        private void trackBarTimeToIncreaseBalls_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBarTimeToIncreaseBalls, trackBarTimeToIncreaseBalls.Value.ToString());
            timeIntervelToIncreaseBalls = trackBarTimeToIncreaseBalls.Value;
            
        }
        
               

        private void trackBarMaxTimeToDisplayBomb_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBarMaxTimeToDisplayBomb, trackBarMaxTimeToDisplayBomb.Value.ToString());
            bombDisplayTime = trackBarMaxTimeToDisplayBomb.Value;
        }

        private void trackBarTimeAfterWhichToDisplayBomb_Scroll(object sender, EventArgs e)
        {
            ballTimeThreshold = 5;// the maximum amount if time to touch the ball
            timeIntervelToIncreaseBalls = 20;
            bombDisplayTime = 5;// Maximum Intervel to display the bomb on screen
            timeIntervelWhenToDisplayBomb = 20;
            toolTip1.SetToolTip(trackBarTimeAfterWhichToDisplayBomb, trackBarTimeAfterWhichToDisplayBomb.Value.ToString());
            timeIntervelWhenToDisplayBomb = trackBarTimeAfterWhichToDisplayBomb.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
