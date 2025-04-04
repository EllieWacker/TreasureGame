using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class AllImagePaths
    {

        private ImagePaths imagePaths;
        public List<List<string>> imagePathsRounds { get; private set; }
        public AllImagePaths() 
        {
            imagePaths = new ImagePaths();
            imagePathsRounds = new List<List<string>>()
            {
                imagePaths.imagePathsRound1,
                imagePaths.imagePathsRound2,
                imagePaths.imagePathsRound3,
                imagePaths.imagePathsRound4,
                imagePaths.imagePathsRound5,
                imagePaths.imagePathsRound6,
                imagePaths.imagePathsRound7
            };
        }
    }
}
