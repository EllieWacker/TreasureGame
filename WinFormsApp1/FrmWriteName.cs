using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameObjects;
using LogicLayer;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PresentationLayer
{
    public partial class FrmWriteName : Form
    {
        private List<Player> _playerList;
        private Logic _logic = null;
        Player _player = null;
        bool _addPlayer = false;
        bool _newClick = false;
        public FrmWriteName(Logic logic)
        {
            _logic = new Logic();
            _player = new Player();
            InitializeComponent();
        }
        public FrmWriteName(Logic logic, Player player)
        {
            _logic = logic;
            _player = player;
            InitializeComponent();
        }

        private void FrmWriteName_Load(object sender, EventArgs e)
        {
            displayCurrentScores();
        }

        private void displayCurrentScores()
        {
            if (Logic._currentScore >= Logic._highestScore)
            {
                Logic._highestScore = Logic._currentScore;
            }
            lblCurrentScore.Text = "Current Score: " + Logic._currentScore;
            lblHighestScore.Text = "Highest score: " + Logic._highestScore;
        }

        private bool enterName()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.");
                txtName.Focus();
                return false;
            }

            _player.Name = txtName.Text;
            _player.Score = Logic._currentScore.ToString();

            if (_addPlayer == false) // add mode
            {
                try
                {
                    List<Player> players = _logic.GetPlayerList();

                    if (_logic.SavePlayer(_player))
                    {
                        MessageBox.Show("Player saved.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
                }
            }
            return true;
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if(_newClick == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (enterName() == true)
                {
                    _newClick = true;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnLeader_Click(object sender, EventArgs e)
        {

            if (_newClick == true)
            {
                FrmLeaderBoard leaderBoard = new FrmLeaderBoard(_logic, _player);
                DialogResult result = leaderBoard.ShowDialog();
            }
            else
            {
                if (enterName() == true)
                {
                    FrmLeaderBoard leaderBoard = new FrmLeaderBoard(_logic, _player);
                    DialogResult result = leaderBoard.ShowDialog();
                    _newClick = true;
                }
            }
        }
    }


}
