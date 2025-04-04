using GameObjects;
using LogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using PresentationLayer;
using System;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Resources;

namespace WinFormsApp1
{
    public partial class FrmMain : Form
    {
        Logic logic = new Logic();
        Player player = new Player();

        private string gemImagePath = Path.Combine(Application.StartupPath, "Resources", "gem_open.jpeg");
        public List<PictureBox> chestBoxes = new List<PictureBox>();

        // needed variables for randomization
        private ImagePaths imagePaths;
        private AllImagePaths _allImagePaths;
        private Random random = new Random();
        List<string> chestBoxPaths = new List<string>();
        private List<Player> _playerList;   

        public FrmMain()
        {
            InitializeComponent();

            // adds images to the list so they can be looped over later
            chestBoxes.Add(openChest1);
            chestBoxes.Add(openChest2);
            chestBoxes.Add(openChest3);
            chestBoxes.Add(openChest4);
            chestBoxes.Add(openChest5);
            chestBoxes.Add(openChest6);
            chestBoxes.Add(openChest7);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        public void NewGame()
        {
            chestBoxPaths.Clear();
            Logic._currentScore = 0;
            Logic._roundNumber = 1;

            roundNumber.Text = "Round number: " + Logic._roundNumber.ToString();
            messageText.Text = "Guess which chest holds the treasure!";
            currentScoreText.Text = "Your score is: " + Logic._currentScore;

            btnTreasure1.Visible = true;
            btnTreasure2.Visible = true;
            btnTreasure3.Visible = true;
            btnTreasure4.Visible = true;
            btnTreasure5.Visible = true;
            btnTreasure6.Visible = true;
            btnTreasure7.Visible = true;

            openChest1.Visible = false;
            openChest2.Visible = false;
            openChest3.Visible = false;
            openChest4.Visible = false;
            openChest5.Visible = false;
            openChest6.Visible = false;
            openChest7.Visible = false;

            roundNumber.Visible = true;
            currentScoreText.Visible = true;
            btnContinue.Visible = false;
            btnQuit.Visible = false;
        }

        private void newRound() //The way the game starts
        {
            // so you can't see the open chests
            openChest1.Visible = false;
            openChest2.Visible = false;
            openChest3.Visible = false;
            openChest4.Visible = false;
            openChest5.Visible = false;
            openChest6.Visible = false;
            openChest7.Visible = false;

            // so the buttons are enabled
            btnTreasure1.Enabled = true;
            btnTreasure2.Enabled = true;
            btnTreasure3.Enabled = true;
            btnTreasure4.Enabled = true;
            btnTreasure5.Enabled = true;
            btnTreasure6.Enabled = true;
            btnTreasure7.Enabled = true;

            Logic._roundNumber += 1;
            roundNumber.Text = "Round number: " + Logic._roundNumber.ToString();
            messageText.Text = "Guess which chest holds the treasure!";
            currentScoreText.Text = "Your score is: " + Logic._currentScore;

            if (Logic._roundNumber >= 7)
            {
                quit();
            }
            chestBoxPaths.Clear();
        }

        public void giveName()
        {
            imagePaths = new ImagePaths();
            _allImagePaths = new AllImagePaths();
            Logic logic = new Logic();
            List<string> currentRoundImagePaths = logic.AssignRandomImage();

            for (int chestIndex = 0; chestIndex < 7; chestIndex++)
            {
                // Get the first image file name from the shuffled list
                string selectedImageFileName = currentRoundImagePaths[chestIndex];

                // Construct the full file path to the selected image
                string imagePath = Path.Combine(Application.StartupPath, "Resources", selectedImageFileName);
                openChest1.Name = "openChest" + chestIndex.ToString();

                // Load and assign the image to PictureBox
                chestBoxes[chestIndex].Image = Image.FromFile(imagePath);
                chestBoxPaths.Add(imagePath);
            }

            openChest1.Visible = true;
            openChest2.Visible = true;
            openChest3.Visible = true;
            openChest4.Visible = true;
            openChest5.Visible = true;
            openChest6.Visible = true;
            openChest7.Visible = true;
        }

        public class ChestBoxList
        {
            public List<PictureBox> chestBoxes { get; } = new List<PictureBox>();

        }


        public void quit()
        {
            // brings to new form
            FrmWriteName writeName = new FrmWriteName(logic, player);
            DialogResult result = writeName.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    _playerList = logic.GetPlayerList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
                }
            }
            NewGame();
        }

        public void showContinueButton()
        {
            btnContinue.Visible = true;
            btnQuit.Visible = true;
        }

        public void isGem()
        {
            Logic._currentScore += 1;
            messageText.Text = "You guessed right!";
            currentScoreText.Text = "Your score is: " + Logic._currentScore;
        }

        public void notGem()
        {
            messageText.Text = "Try again!";
        }

        public void noContinue()
        {
            if (openChest1.Visible == false)
            {
                MessageBox.Show("Pick a box");
            }
            else
            {
                newRound();
            }
        }

        private void click_treasure1(object sender, EventArgs e)
        {
            giveName();
            showContinueButton();
            if (string.Equals(gemImagePath, chestBoxPaths[0], StringComparison.OrdinalIgnoreCase))
            {
                isGem();
            }
            else
            {
                notGem();
            }
        }

        private void click_treasure2(object sender, EventArgs e)
        {
            giveName();
            showContinueButton();
            if (string.Equals(gemImagePath, chestBoxPaths[1], StringComparison.OrdinalIgnoreCase))
            {
                isGem();
            }
            else
            {
                notGem();
            }
        }

        private void click_treasure3(object sender, EventArgs e)
        {
            giveName();
            showContinueButton();
            if (string.Equals(gemImagePath, chestBoxPaths[2], StringComparison.OrdinalIgnoreCase))
            {
                isGem();
            }
            else
            {
                notGem();
            }
        }

        private void click_treasure4(object sender, EventArgs e)
        {
            giveName();
            showContinueButton();
            if (string.Equals(gemImagePath, chestBoxPaths[3], StringComparison.OrdinalIgnoreCase))
            {
                isGem();
            }
            else
            {
                notGem();
            }
        }

        private void click_treasure5(object sender, EventArgs e)
        {
            giveName();
            showContinueButton();
            if (string.Equals(gemImagePath, chestBoxPaths[4], StringComparison.OrdinalIgnoreCase))
            {
                isGem();
            }
            else
            {
                notGem();
            }
        }

        private void click_treasure6(object sender, EventArgs e)
        {
            giveName();
            showContinueButton();
            if (string.Equals(gemImagePath, chestBoxPaths[5], StringComparison.OrdinalIgnoreCase))
            {
                isGem();
            }
            else
            {
                notGem();
            }
        }

        private void click_treasure7(object sender, EventArgs e)
        {
            giveName();
            showContinueButton();
            if (string.Equals(gemImagePath, chestBoxPaths[6], StringComparison.OrdinalIgnoreCase))
            {
                isGem();
            }
            else
            {
                notGem();
            }
        }

        private void quit_click(object sender, EventArgs e)
        {
            quit();
        }

        private void continue_click(object sender, EventArgs e)
        {
            noContinue();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
