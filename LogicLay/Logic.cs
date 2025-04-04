using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using GameObjects;
using DataAccessLayer;

namespace LogicLayer
{
    public class Logic
    {
        private ScoreAccessor _scoreAccessor = new ScoreAccessor();
        // get important variables:

        public static int _currentScore { get; set; }
        public static int _highestScore { get; set; }
        public static int _roundNumber { get; set; }


        private Random random = new Random();
        private ImagePaths imagePaths;
        private AllImagePaths _allImagePaths;
        List<string> chestBoxPaths = new List<string>();

        public List<string> AssignRandomImage()
        {
            imagePaths = new ImagePaths();
            _allImagePaths = new AllImagePaths();

            // gives the randomly assigned paths
            List<string> randomPaths = new List<string>();


            // Gives the image paths for this round
            List<string> currentRoundImagePaths = _allImagePaths.imagePathsRounds[_roundNumber];
            for (int i = 7 - 1; i >= 0; i--)
            {
                int j = random.Next(0, i + 1);
                string temp = currentRoundImagePaths[i];
                currentRoundImagePaths[i] = currentRoundImagePaths[j];
                currentRoundImagePaths[j] = temp;
            }
            return currentRoundImagePaths;
        } // end of assign random image


        // get scores
        public bool SavePlayer(Player player)
        {
            bool isSaved = false;

            try
            {
                isSaved = _scoreAccessor.SavePlayer(player);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Save Failed", ex);
            }
            return isSaved;
        }

        public List<Player> GetPlayerList()
        {
            List<Player> players = null;

            try
            {
                players = _scoreAccessor.GetPlayerList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Data not available", ex);
            }

            return players;
        }


    }


}


