using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        private string PlayerChoice;
        private int PlayerScore = 0;
        private string ComputerChoice;
        private int ComputerScore = 0;
        private int round;
        


        


        private Random random = new Random();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            PlayerChoice = "stone";
            Image imageChoie = Properties.Resources.stone;
            shuffleImage(imageChoie);
            round++;
            WhoWinThisRound(PlayerChoice, ComputerChoice);
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            PlayerChoice = "paper";
            Image imageChoie = Properties.Resources.paper;
            shuffleImage(imageChoie);
            round++;
            WhoWinThisRound(PlayerChoice, ComputerChoice);
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            PlayerChoice = "scissors";
            Image imageChoie = Properties.Resources.scissors;
            shuffleImage(imageChoie);
            round++;
            WhoWinThisRound(PlayerChoice, ComputerChoice);
        }

        private void shuffleImage(Image imageChoice)
        {

            

            for(int i =0; i < 10; i++)
            {
                int index = random.Next(0, 3);
                
                if (index == 0)
                {
                    PlayerOutput.Image = Properties.Resources.scissors;
                    ComputerOutput.Image = Properties.Resources.paper;
                }
                    

                else if(index == 1)
                {
                    PlayerOutput.Image = Properties.Resources.paper;
                    ComputerOutput.Image = Properties.Resources.stone;
                }
                    
                else if(index == 2)
                {
                    PlayerOutput.Image = Properties.Resources.stone;
                    ComputerOutput.Image = Properties.Resources.scissors;
                }



                ComputerOutput.Refresh();
                PlayerOutput.Refresh();
                System.Threading.Thread.Sleep(150);
            }

            int index2 = random.Next(0, 3);

            if (index2 == 0)
            {
                ComputerOutput.Image = Properties.Resources.scissors;
                ComputerChoice = "scissors";
            }


            else if (index2 == 1)
            {
                
                ComputerOutput.Image = Properties.Resources.paper;
                ComputerChoice = "paper";
            }

            else if (index2 == 2)
            {
                ComputerOutput.Image = Properties.Resources.stone;
                ComputerChoice = "stone";
            }

            PlayerOutput.Image = imageChoice;
            PlayerOutput.Refresh();
            ComputerOutput.Refresh();
        }


        private void WhoWinThisRound(string playerChoice, string computerChoice)
        {
            if(playerChoice =="stone" && computerChoice == "stone")
            {
                roundText.Text = "Round " + round + ": Berabere";
            }

            else if(playerChoice == "stone" && computerChoice == "scissors")
            {
                PlayerScore++;
                playerScoreboard.Text = Convert.ToString(PlayerScore);
                roundText.Text = "Round " + round + ": Player Kazandı";
            }

            else if (playerChoice == "stone" && computerChoice == "paper")
            {
                ComputerScore++;
                computerScoreboard.Text = Convert.ToString(ComputerScore);
                roundText.Text = "Round " + round + ": Bilgisayar Kazandı";
            }

            /////////
            

            else if (playerChoice == "scissors" && computerChoice == "stone")
            {
                ComputerScore++;
                computerScoreboard.Text = Convert.ToString(ComputerScore);
                roundText.Text = "Round " + round + ": Bilgisayar Kazandı";
            }

            else if (playerChoice == "scissors" && computerChoice == "scissors")
            {
                roundText.Text = "Round " + round + ": Berabere";
            }

            else if (playerChoice == "scissors" && computerChoice == "paper")
            {
                PlayerScore++;
                playerScoreboard.Text = Convert.ToString(PlayerScore);
                roundText.Text = "Round " + round + ": Player Kazandı";
            }

            /////////

            else if (playerChoice == "paper" && computerChoice == "scissors")
            {
                ComputerScore++;
                computerScoreboard.Text = Convert.ToString(ComputerScore);
                roundText.Text = "Round " + round + ": Bilgisayar Kazandı";
            }

            else if (playerChoice == "paper" && computerChoice == "paper")
            {
                roundText.Text = "Round " + round + ": Berabere";
            }

            else if (playerChoice == "paper" && computerChoice == "stone")
            {
                PlayerScore++;
                playerScoreboard.Text = Convert.ToString(PlayerScore);
                roundText.Text = "Round " + round + ": Player Kazandı";
            }





        }

    }
}
