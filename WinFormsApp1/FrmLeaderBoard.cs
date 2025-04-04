using GameObjects;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmLeaderBoard : Form
    {
        private List<Player> _playerList;
        private Logic _logic = null;
        Player _player = null;
        bool _addPlayer = false;
        public FrmLeaderBoard(Logic logic)
        {
            _logic = new Logic();
            _player = new Player();
            InitializeComponent();
        }
        public FrmLeaderBoard(Logic logic, Player player)
        {
            _logic = logic;
            _player = player;
            InitializeComponent();
        }

        private void FrmLeaderBoard_Load(object sender, EventArgs e)
        {
            try
            {
                _playerList = _logic.GetPlayerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }

            displayPlayerData();

        }

        private void displayPlayerData()
        {
            datPlayerList.DataSource = _playerList;


            datPlayerList.Columns[0].HeaderText = "Player Name";
            datPlayerList.Columns[1].HeaderText = "Score";

            datPlayerList.ClearSelection();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
