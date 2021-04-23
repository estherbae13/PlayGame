using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of Thread.Sleep()
using System.Media; // add this to your using statements to play .wav sounds 

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //make counter invisible
            counterLabel.Visible = false;

            //make start invisible
            startLabel.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //make button clicking sound
            SoundPlayer clicking = new SoundPlayer(Properties.Resources.clicking);
            clicking.Play();

            //change background of colour of form and make button invisible and show countdown
            this.BackColor = Color.RosyBrown;
            playButton.Visible = false;
            counterLabel.Visible = true;

            //make screen show countdown from 3 to 2
            Refresh();
            Thread.Sleep(1000);
            counterLabel.Text = "GAME STARTS IN 2";

            //countdown from 2 to 1
            SoundPlayer countdown = new SoundPlayer(Properties.Resources.countdown);
            countdown.Play();
            Refresh();
            Thread.Sleep(1000);
            counterLabel.Text = "GAME STARTS IN 1";

            //change background colour and change text to START with sound!
            countdown.Play();
            Refresh();
            Thread.Sleep(1000);
            startLabel.Visible = true;
            counterLabel.Visible = false;
            SoundPlayer startt = new SoundPlayer(Properties.Resources.startt);
            startt.Play();

            //change background colour to green
            this.BackColor = Color.LightGreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
