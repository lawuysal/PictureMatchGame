using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PictureMatchGame
{
    public class Game
    {
        public static Random random = new Random();
        public static int flashingTime = 10;
        public static int currentTime = flashingTime;
        public static bool isFirstPlayer = true;
        public static List<Image> images = new List<Image>();
        public static int completedPairCount = 0;
        public int score = 0;

        public static void initImages(ref Panel gameScreen)
        {
            List<int> initializedTiles = new List<int>();
            List<Image> duplicatedImages = new List<Image>();

            // Duplicate each image in the list.
            foreach (Image image in images)
            {
                duplicatedImages.Add(image);
                duplicatedImages.Add(image);
            }

            List<Image> shuffledImages = duplicatedImages.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < 20; i++)
            {
                int index = i;

                while (initializedTiles.Contains(index))
                {
                    index = random.Next(20);
                }

                initializedTiles.Add(index);
                Panel tempTile = (Panel)gameScreen.Controls.Find($"tileOpen{i + 1}", false).FirstOrDefault();
                tempTile.BackgroundImageLayout = ImageLayout.Stretch;
                tempTile.BackgroundImage = shuffledImages[i];
            }
        }

    }
}
