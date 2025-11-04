using System;
using System.Windows.Forms;
using System.Threading;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // Random number generator
        private Random rand = new Random();

        // int value for score initialized to 10
        private int score = 10;

        public Form1()
        {
            InitializeComponent();

            // display initial score
            scoreDisplay.Text = score.ToString();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            // disable button during spin animation
            spinButton.Enabled = false;

            /// SPIN EFFECT ----------------------------------------------------------
            /// Use a while loop to simulate spinning reels with semi-exponential delay
            /// -----------------------------------------------------------------------
            int delay = 50; // initial delay in milliseconds
            int maxDelay = 700; // maximum delay before stopping

            while (delay <= maxDelay)
            {
                // get temporary random values for each reel
                int temp1 = rand.Next(1, 4);
                int temp2 = rand.Next(1, 4);
                int temp3 = rand.Next(1, 4);

                // set temporary images to simulate spinning
                SetReelImage(pictureBox1, temp1);
                SetReelImage(pictureBox2, temp2);
                SetReelImage(pictureBox3, temp3);

                // allow UI to update during loop
                Application.DoEvents();

                // pause for current delay
                Thread.Sleep(delay);

                // increase delay exponentially to simulate slowing down
                delay = (int)(delay * 1.3);
            }

            /// FINAL RESULT ----------------------------------------------------------
            /// Get final random values for each reel and set images accordingly
            /// -----------------------------------------------------------------------
            int reel1 = rand.Next(1, 4);
            int reel2 = rand.Next(1, 4);
            int reel3 = rand.Next(1, 4);

            SetReelImage(pictureBox1, reel1);
            SetReelImage(pictureBox2, reel2);
            SetReelImage(pictureBox3, reel3);

            /// WIN/LOSS LOGIC --------------------------------------------------------
            /// Use compound if statement to check if all reels are equal.
            /// If yes, show "winner" message and add 3 to score.
            /// If no, show "play again" message and subtract 1 from score.
            /// -----------------------------------------------------------------------
            if (reel1 == reel2 && reel2 == reel3)
            {
                outputLabel.Text = "Winner!";
                score += 3;
            }
            else
            {
                outputLabel.Text = "Play again!";
                score -= 1;
            }

            /// GAME OVER CHECK -------------------------------------------------------
            /// If score has reached 0, display "lose" message and disable spin button
            /// -----------------------------------------------------------------------
            if (score <= 0)
            {
                outputLabel.Text = "You lose!";
                spinButton.Enabled = false;
            }

            // display updated score
            scoreDisplay.Text = score.ToString();

            // re-enable spin button if game is still active
            spinButton.Enabled = true;
        }

        /// IMAGE SETTER -------------------------------------------------------------
        /// Sets the appropriate image to the BackgroundImage property of a PictureBox
        /// based on the reel value. Uses images from Properties.Resources.
        /// ---------------------------------------------------------------------------
        private void SetReelImage(PictureBox box, int value)
        {
            switch (value)
            {
                case 1:
                    box.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    box.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    box.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            // ensure image stretches to fit PictureBox
            box.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
