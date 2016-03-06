using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Metalop.Emgucv.BallSmash.UI.Helpers;
using Metalop.Emgucv.BallSmash.Helpers;


/* A Samll Game(Sort of ) built using EmguCV library 
 * developed By: Shiva Saxena
 * email: shivasaxena@outlook.com
 */


namespace MetalopEmgucvBallSmashUI
{
    public partial class MainApplicationForm : Form
    {

               //takes images from camera as image frames
        int timeStamp = 0;// This value stores the time stamps of the events relative to the application start
        int Threshold = 30; //stores threshold for background sub between two frames
        int BallTimeThreshold = 5;// the maximum amount if time to touch the ball
        int BombDisplayTime = 5;// Time intervel after which the bomb is to be displayed
        int LevelNumber = 1;    // The Level 
        int TimeIntervelToIncreaseBalls = 20;
        int TimeIntervelWhenToDisplayBomb = 20;
        int NumberOfHits = 0;//Total number of hits
        int Score = 0;      // to count the Score of the player
        int NumberOfMiss = 0;       // the nomber of misses
        int NumberOfBalls = 2;   // Number of balls to be displayed in the game
        int[,] XYCoordinatesOfBalls = new int[10, 2];// to store the xy coordinates of the balls appearing on the screen
        int[,] XYCoordinatesOfBomb = new int[1, 2];
        private Capture capture;

        double[] timeThresholdOfBall = new double[10];

        /// Various Types of Images that are used
        Image<Gray, Byte>[] Balls = new Image<Gray, byte>[10];
        Image<Bgr, Byte> InputImageFrame;
        Image<Gray, Byte> BombFrame;
        Image<Gray, Byte> CurrentFrame; //current Frame from camera
        Image<Gray, Byte> PreviousFrame; //prevoius  from camera
        Image<Gray, Byte> DifferenceFrame = new Image<Gray, byte>(640, 480, new Gray(1));//different Frame Between the current frame and prevoius frame
        Image<Gray, Byte> DifferenceFrameGray = new Image<Gray, byte>(640, 480, new Gray(1));
        
        bool ready = false;
        // Temporay variables
       
        bool processingStarted = false;
        bool gamePaused = false;

        //sound engine variables
        
        private NAudio.Wave.WaveFileReader bomb = null;
        private NAudio.Wave.DirectSoundOut output = null;
        WMPLib.WindowsMediaPlayer BackgroundMusic = new WMPLib.WindowsMediaPlayer();
        
       
            
        CircleData[] CircleList = new CircleData[10];
        CircleData[] BombList = new CircleData[5];
        public MainApplicationForm()
        {
            InitializeComponent();

            LabelTotalTime.Parent = ibOriginal;
            LabelTotalTimeValue.Parent = ibOriginal;
            LabelNumberOfHits.Parent = ibOriginal;
            LabelNumberOfHitsValue.Parent = ibOriginal;
            LabelNumberOfMiss.Parent = ibOriginal;
            LabelNumberOfMissValue.Parent = ibOriginal;
            LabelGameMessage.Parent = ibOriginal;
            LabelGameMessage.Left = (this.ClientRectangle.Width + (LabelGameMessage.Width / 4)) / 2;
            LabelGameMessage.Top = (this.ClientRectangle.Height - (LabelGameMessage.Height / 2)) / 2;
            this.capture = new Emgu.CV.Capture();

        }





        // The Onload Event Handler.
        // Here it adds an event handler that executes the Process Frame Object every time the application is idle

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundMusic.URL = Constants.BACKGROUND_MUSIC_FILE_LOC;
            //a.controls.play();
            LabelGameMessage.Hide();

            SplashScreen s = new SplashScreen();
            this.Hide();
            gamePaused = true;
            s.ShowDialog();
            this.Show();
            gamePaused = false;
            // initilise the images
            for (int i = 0; i < 10; i++)
            {
                Balls[i] = new Image<Gray, byte>(640, 480, new Gray(1));
                generateXYCoordiantesForBall(i);

            }
            ibOriginal.Width = this.ClientRectangle.Width;
            ibOriginal.Height = this.ClientRectangle.Height - 24;
            Application.Idle += ProcessFrame;

        }
        /// <summary>
        /// The Function to do the image processing on the image

        private void ProcessFrame(object sender, EventArgs arg)
        {
            #region if capture is not created, create it now
            //if (capture == null)
            //{
            //    try
            //    {
            //        capture = new Capture();
            //    }
            //    catch (NullReferenceException excpt)
            //    {
            //        MessageBox.Show(excpt.Message);
            //    }
            //}
            #endregion


            #region The Main Image Processing Goes On Here
            RetriveAndInitFrames();

            if (ready == false)
            {
                Draw321OnScreen();

            }
            else
            {
                if ((timeStamp % TimeIntervelWhenToDisplayBomb) < BombDisplayTime + TimeIntervelWhenToDisplayBomb)
                {
                    displayBomb();

                }

                DrawBallsOnScreen();
                CheckForAHit();
                CheckForAMiss();
            }

            LabelTotalTimeValue.Text = timeStamp.ToString() + "s";
            LabelNumberOfHitsValue.Text = NumberOfHits.ToString();



            using (InputImageFrame = InputImageFrame.Resize(this.ClientRectangle.Width, (this.ClientRectangle.Height - 25), Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR, false))
            {
                ibOriginal.Image = InputImageFrame;        //line 2
            }

            #endregion
        }

        private void RetriveAndInitFrames()
        {
            //using (Capture capture = new Emgu.CV.Capture(0))
            //{
                if (CurrentFrame == null) //we need at least one fram to work out running average so acquire one before doing anything
                {
                    capture.Start();

                    //display the frame aquired
                    Image<Bgr, Byte> imageFrameTemp = capture.RetrieveBgrFrame(); //we could use RetrieveGrayFrame if we didn't care about displaying colour image
                    
                    InputImageFrame = imageFrameTemp.Convert<Bgr, Byte>();
                    CurrentFrame = InputImageFrame.Convert<Gray, Byte>();
                    PreviousFrame = CurrentFrame.Copy(); //copy the frame to act as the previous

                    
                  
                }
                else
                {
                    //acquire the frame
                    Image<Bgr, Byte> imageFrameTemp = capture.QueryFrame(); //we could use RetrieveGrayFrame if we didn't care about displaying colour image
                    InputImageFrame = imageFrameTemp.Convert<Bgr, Byte>();
                    InputImageFrame = InputImageFrame.Flip(Emgu.CV.CvEnum.FLIP.HORIZONTAL);
                    InputImageFrame = InputImageFrame.SmoothGaussian(3, 0, 0, 0);

                    CurrentFrame = InputImageFrame.Convert<Gray, Byte>();
                    DifferenceFrame = PreviousFrame.AbsDiff(CurrentFrame); //find the absolute difference 
                                                                           //
                                                                           /*Play with the value 60 to set a threshold for movement*/
                    DifferenceFrame = DifferenceFrame.ThresholdBinary(new Gray(Threshold), new Gray(255)); //if value > 60 set to 255, 0 otherwise 
                    DifferenceFrameGray = DifferenceFrame.Convert<Gray, Byte>();
                    PreviousFrame = CurrentFrame.Copy(); //copy the frame to act as the previous frame

                }
            //}
        }

        private void Draw321OnScreen()
        {
            //TODO : use a better font
            MCvFont largeFont = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_COMPLEX, 4d, 4d);
            if (processingStarted == false)
            {
                NumberOfHits = 0;
                timeStamp = 1;
                processingStarted = true;
            }


            // TODO : use better fonts
            switch (timeStamp)
            {

                case 1:
                    InputImageFrame.Draw("3", ref largeFont, new Point(280, 240), new Bgr(Color.Red));
                    break;
                case 2:
                    InputImageFrame.Draw("2", ref largeFont, new Point(280, 240), new Bgr(Color.Yellow));
                    break;
                case 3:
                    InputImageFrame.Draw("1", ref largeFont, new Point(280, 240), new Bgr(Color.Green));
                    break;
                default:
                    ready = true;
                    break;
            }
        }



        // The Timer Function to increase the value of timestamp every one second

        private void timer_Tick(object sender, EventArgs e)
        {
            if (gamePaused == false)
            {
                //TODO : Apply a mechanism to prevent the overflow of a timestamp
                timeStamp += 1;
                //Generate the xy co-ordinated for the BOMB
                if (timeStamp % BombDisplayTime == 0)
                {

                    BombFrame = new Image<Gray, byte>(640, 480, new Gray(1));
                    XYCoordinatesOfBomb[0, 0] = CommonUtil.generateRandomXCoordinate(640);
                    XYCoordinatesOfBomb[0, 1] = CommonUtil.generateRandomYCoordinate(480);
                }
                // increase number of balls to be displayed
                #region Increase the Number Of Balls
                LabelGameMessage.Hide();



                if ((timeStamp % TimeIntervelToIncreaseBalls) == 0)
                {
                    LevelNumber++;
                    LabelGameMessage.Text = "↑ Level UP ↑ \n   Level  " + LevelNumber;
                    LabelGameMessage.Show();
                    IncreaseNumberOfBallsDrawn();
                }
                #endregion 
            }
        }


        // function to generate the random number

      

        private void generateXYCoordiantesForBall(int ballNumber)
        {
            XYCoordinatesOfBalls[ballNumber, 0] = CommonUtil.generateRandomXCoordinate(640);
            XYCoordinatesOfBalls[ballNumber, 1] = CommonUtil.generateRandomYCoordinate(480);
            timeThresholdOfBall[ballNumber] = timeStamp;
        }

        // function for drawing the balls on the viewport
        private void DrawBallsOnScreen()
        {
            for (int i = 0; i < NumberOfBalls; i++)
            {
                CircleList[i] = (new CircleData(new CircleF(new PointF(XYCoordinatesOfBalls[i, 0], XYCoordinatesOfBalls[i, 1]), 10), new Gray(255), 20));


                InputImageFrame.Draw(CircleList[i].circle, new Bgr(154, 250, 0), CircleList[i].thickness);

               
                Balls[i] = new Image<Gray, byte>(640, 480, new Gray(1));
                Balls[i].Draw(CircleList[i].circle, new Gray(255), 20);

            }

        }

        //display and check the Bomb

        private void displayBomb()
        {
            // defing the font variable used to write on top of the image
            MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_DUPLEX, 1d, 1d);
            MCvFont fontSmall = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, .25d, .5d);
            Image<Gray, byte> temp; 

            BombList[0] = (new CircleData(new CircleF(new PointF(XYCoordinatesOfBomb[0, 0], XYCoordinatesOfBomb[0, 1]), 10), new Gray(255), 20));
            InputImageFrame.Draw(BombList[0].circle, new Bgr(0, 0, 255), BombList[0].thickness);
            InputImageFrame.Draw("BOMB!", ref fontSmall, new Point(XYCoordinatesOfBomb[0, 0] - 20, XYCoordinatesOfBomb[0, 1] + 5), new Bgr(Color.Blue));
            BombFrame = new Image<Gray, byte>(640, 480, new Gray(1));
            BombFrame.Draw(BombList[0].circle, new Gray(255), 20);

            temp = BombFrame.And(DifferenceFrame);
            temp = temp.ThresholdBinary(new Gray(240), new Gray(255));
            int number = temp.CountNonzero()[0];
            if (number != 0)
            {
                NumberOfHits -= 1;
                InputImageFrame.Draw(new CircleF(new PointF(XYCoordinatesOfBomb[0, 0], XYCoordinatesOfBomb[0, 1]), 10), new Bgr(0, 0, 0), 50);

                InputImageFrame.Draw("Oops!", ref font, new Point(XYCoordinatesOfBomb[0, 0] - 40, XYCoordinatesOfBomb[0, 1] + 10), new Bgr(Color.White));
            }
        }

        // function to check a valid hit in the program
        private void CheckForAHit()
        {
            Image<Gray, byte> temp;
            for (int i = 0; i < NumberOfBalls; i++)
            {

                temp = Balls[i].And(DifferenceFrame);
                temp = temp.ThresholdBinary(new Gray(240), new Gray(255));
                int number = temp.CountNonzero()[0];
               
                if (number != 0)
                {
                    MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_DUPLEX, 1d, 1d);
                    MCvFont fontSmall = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, .25d, .5d);
                    NumberOfHits++;
                    Score++;
                    bomb = new NAudio.Wave.WaveFileReader(Constants.BOMB_EXPLOSION_FILE_LOC);

                    //TODO: move the initlization out and make sure that only once the init happens
                    output = new NAudio.Wave.DirectSoundOut();
                    output.Init(new NAudio.Wave.WaveChannel32(bomb));
                    Random r = new Random();
                    InputImageFrame.Draw(new CircleF(new PointF(XYCoordinatesOfBalls[i, 0], XYCoordinatesOfBalls[i, 1]), 10), new Bgr(r.Next(0, 255), 0, 255), 50);

                    InputImageFrame.Draw("Hit", ref font, new Point(XYCoordinatesOfBalls[i, 0] - 20, XYCoordinatesOfBalls[i, 1] + 10), new Bgr(Color.White));
                    generateXYCoordiantesForBall(i);


                }
            }
            if (output != null) { output.Play(); }



        }

        /// function to check a missed ball

        private void CheckForAMiss()
        {
            for (int i = 0; i < NumberOfBalls; i++)
            {
                if ((timeStamp - timeThresholdOfBall[i]) > BallTimeThreshold)
                {
                    MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_DUPLEX, 1d, 1d);
                    NumberOfMiss++;
                    LabelNumberOfMissValue.Text = NumberOfMiss.ToString();
                    InputImageFrame.Draw(new CircleF(new PointF(XYCoordinatesOfBalls[i, 0], XYCoordinatesOfBalls[i, 1]), 10), new Bgr(Color.Black), 50);
                    InputImageFrame.Draw("Miss", ref font, new Point(XYCoordinatesOfBalls[i, 0] - 30, XYCoordinatesOfBalls[i, 1] + 10), new Bgr(Color.White));

                    generateXYCoordiantesForBall(i);


                }
            }

        }
        //Function to increase the the number of balls appearing on the screen

        private void IncreaseNumberOfBallsDrawn()
        {
            if (NumberOfBalls < 10)
            {
                NumberOfBalls++;
            }


        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            this.Close();
        }

        private void pauseResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pauseResumeToolStripMenuItem.ToString() == "Pause")
            {
                Application.Idle -= ProcessFrame;
                gamePaused = true;
                pauseResumeToolStripMenuItem.Text = "Resume";

            }
            else
            {
                Application.Idle += ProcessFrame;
                gamePaused = false;
                pauseResumeToolStripMenuItem.Text = "Pause";
            }
        }

        private void aboutGestureBallSmashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();

        }

        private void gameSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Idle -= ProcessFrame;
            gamePaused = true;
            GameSettingOptionsForm f = new GameSettingOptionsForm();
            f.GetVal_BallTimeThreshold = BallTimeThreshold;
            f.GetVal_timeIntervelToIncreaseBalls = TimeIntervelToIncreaseBalls;
            f.GetVal_bombDisplayTime = BombDisplayTime;
            f.GetVal_timeIntervelWhenToDisplayBomb = TimeIntervelWhenToDisplayBomb;

            f.ShowDialog();
            BallTimeThreshold = f.GetVal_BallTimeThreshold;
            TimeIntervelToIncreaseBalls = f.GetVal_timeIntervelToIncreaseBalls;
            BombDisplayTime = f.GetVal_bombDisplayTime;
            TimeIntervelWhenToDisplayBomb = f.GetVal_timeIntervelWhenToDisplayBomb;



            Application.Idle += ProcessFrame;
            gamePaused = false;
        }

        private void showMenuBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }
        //


    }
}
