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
        public static int flashingTime = 3;
        public static int currentTime = flashingTime;
        public static bool isFirstPlayer = true;
        public static List<Image> images = new List<Image>();
        public static List<Panel> tiles = new List<Panel>();
        public static List<Image> randomizedImages = new List<Image>();
        public static List<Image> currentImages = new List<Image>();
        public static int completedPairCount = 0;
        public int score = 0;


        public static void checkTileMatch()
        {
            
            int openedTileCount = 0;
            List<Panel> openedTiles = new List<Panel>(); 
            foreach (Panel tile in tiles)
            {
                if (tile.BackgroundImage != null)
                {
                    openedTiles.Add(tile);
                    openedTileCount++;
                }
            }
            if (openedTileCount == 2)
            {
                if (openedTiles[0].BackgroundImage == openedTiles[1].BackgroundImage)
                {
                    foreach (Panel tile in openedTiles)
                    {
                        currentTime++;
                        tile.BackgroundImage = null;
                        tile.BackColor = Color.White;
                    }
                }
            }
        }
        public static int tileNumberParser (Panel tile)
        {
            string tileName = tile.Name.Substring(8);
            return int.Parse(tileName.ToString());
        }
        public static void turnBackAllImages(ref Panel gameScreen)
        {
            foreach (Panel tile in tiles)
            {
                tile.BackgroundImage = null;
                //tile.BackColor = Color.Wheat;
            }
        }
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
            randomizedImages = shuffledImages;
            currentImages = shuffledImages;


            for (int i = 0; i < 20; i++)
            {
                int index = i;

                while (initializedTiles.Contains(index))
                {
                    index = random.Next(20);
                }

                initializedTiles.Add(index);
                Panel tempTile = tiles[i];
                tempTile.BackgroundImageLayout = ImageLayout.Stretch;
                tempTile.BackgroundImage = shuffledImages[i];
                
            }
        }

    }
}
