using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace BanditWithOneArm
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randGen = new Random();

        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            // get random values for each reel (store each in separate int variable)
            int generator1;
            int generator2;
            int generator3;

            generator1 = randGen.Next(1, 4);
            generator2 = randGen.Next(1, 4);
            generator3 = randGen.Next(1, 4);

            // 1 = seven
            // 2 = cherry
            // 3 = diamond


            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (generator1)
            {
                case 1:
                    reel1Output.BackgroundImage = (Image)Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel1Output.BackgroundImage = (Image)Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel1Output.BackgroundImage = (Image)Properties.Resources.diamond_100x125;
                    break;
            }


            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (generator2)
            {
                case 1:
                    reel2Output.BackgroundImage = (Image)Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel2Output.BackgroundImage = (Image)Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel2Output.BackgroundImage = (Image)Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (generator3)
            {
                case 1:
                    reel3Output.BackgroundImage = (Image)Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel3Output.BackgroundImage = (Image)Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel3Output.BackgroundImage = (Image)Properties.Resources.diamond_100x125;
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.
            // 

            if (generator1 == generator2 && generator1 == generator3)
            {
                outputLabel.Text = "Winner!";
                score = score + 3;
                scoreDisplay.Text = $"{score}";
            }
            else
            {
                outputLabel.Text = "Try Again!";
                score--;
                scoreDisplay.Text = $"{score}";

            }


            // if score has reached 0 display "lose" message and set button enabled property to false
            if (scoreDisplay.Text == "0")
            {
                outputLabel.Text = "Lose!";
                spinButton.Enabled = false;
            }

            // display updated score
            scoreDisplay.Text = $"{score}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
