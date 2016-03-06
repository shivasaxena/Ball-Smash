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
    public partial class SplashScreen : Form
    {
       
        public SplashScreen()
        {
            InitializeComponent();
            
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
            
            //button1.Location = new System.Drawing.Point(0, 0);
            
            tableLayoutPanel1.Size = new System.Drawing.Size((this.ClientRectangle.Width), this.ClientRectangle.Height - 50);
           
            pictureBox1.Size = new System.Drawing.Size((this.ClientRectangle.Width) / 2, (this.ClientRectangle.Height - 100) / 2);
            pictureBox2.Size = new System.Drawing.Size((this.ClientRectangle.Width) / 2, (this.ClientRectangle.Height - 100) / 2);
            pictureBox3.Size = new System.Drawing.Size((this.ClientRectangle.Width) / 2, (this.ClientRectangle.Height - 100) / 2);
            pictureBox4.Size = new System.Drawing.Size((this.ClientRectangle.Width) / 2, (this.ClientRectangle.Height - 100) / 2);
            button1.Location = new System.Drawing.Point((this.ClientRectangle.Width-150) / 2, this.ClientRectangle.Height-50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
