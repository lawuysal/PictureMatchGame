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
        public static int flashingTime = 5;
        public static int currentTime = flashingTime;
        public static bool isGameDone = false;
        public static bool isGameStarted = false;
        public static bool isFirstPlayer = true;
        public static List<Image> images = new List<Image>();
        public static List<Panel> tiles = new List<Panel>();
        public static List<Image> randomizedImages = new List<Image>();
        public static List<Image> currentImages = new List<Image>();
        public static int completedPairCount = 0;
        public static int openedTileCount = 0;
        public static int tileFixer = 0;
        public static int firstPlayerScore = 0;
        public static int secondPlayerScore = 0;

        public static string checkGame()
        {
            if (firstPlayerScore == 110 && !isGameDone)
            {
                isGameDone = true;
                return "Player 1 Won!";
                
            }
            if (secondPlayerScore == 110 && !isGameDone)
            {
                isGameDone = true;
                return "Player 2 Won!";
                
            }
            if (firstPlayerScore == 100 && secondPlayerScore == firstPlayerScore && !isGameDone)
            {
                isGameDone = true;
                return "Draw!";                
            }
            return " ";
        }
        public static void switchPlayerIndicatorColor
            (Label playerFirstScoreLabel, Label playerSecondScoreLabel)
        {
            if (isFirstPlayer)
            {
                playerFirstScoreLabel.ForeColor = Color.Red;
                playerSecondScoreLabel.ForeColor = Color.Black;
            }
            else
            {
                playerSecondScoreLabel.ForeColor = Color.Red;
                playerFirstScoreLabel.ForeColor = Color.Black;
            }
        }
        public static void switchPlayer()
        {
            isFirstPlayer = !isFirstPlayer;
            tileFixer = 0;
        }
        public static void addPoints(TextBox playerFirstScoreBox, TextBox playerSecondScoreBox)
        {
            if (isFirstPlayer)
            {
                firstPlayerScore += 10;
                playerFirstScoreBox.Text = firstPlayerScore.ToString();
            } 
            else
            {
                secondPlayerScore += 10;
                playerSecondScoreBox.Text = secondPlayerScore.ToString();
            }
        }
        public async static void checkTileMatch
            (TextBox playerFirstScoreBox, TextBox playerSecondScoreBox, 
            Label playerFirstScoreLabel, Label playerSecondScoreLabel, Panel gameScreen)
        { 
            
            List<Panel> openedTiles = new List<Panel>(); 
            foreach (Panel tile in tiles)
            {
                if (tile.BackgroundImage != null)
                {
                    openedTiles.Add(tile);
                    openedTileCount++;
                    tileFixer++;
                }
            }
            if (openedTileCount == 1 && Game.currentTime == 0) 
            {
                switchPlayer();
                switchPlayerIndicatorColor(playerFirstScoreLabel, playerSecondScoreLabel);
                turnBackAllImages(gameScreen);

            }
            if (openedTileCount == 2)
            {
                await Task.Delay(1000);
                if (openedTiles[0].BackgroundImage == openedTiles[1].BackgroundImage)
                {
                    
                    foreach (Panel tile in openedTiles)
                    {
                        currentTime++;
                        tile.BackColor = Color.SteelBlue;
                        tile.BackgroundImage = null;
                        tile.Enabled = false;
                    }
                    completedPairCount++;
                    addPoints(playerFirstScoreBox, playerSecondScoreBox);
                    openedTileCount = 0;
                    tileFixer = 0;
                    
             
                }
                else
                {
                    switchPlayer();
                    switchPlayerIndicatorColor(playerFirstScoreLabel, playerSecondScoreLabel);
                    
                }
            }
            openedTileCount = 0;
        }
        public static int tileNumberParser (Panel tile)
        {
            string tileName = tile.Name.Substring(8);
            return int.Parse(tileName.ToString());
        }
        public static void turnBackAllImages(Panel gameScreen)
        {
            foreach (Panel tile in tiles)
            {
                tile.BackgroundImage = null;
                //tile.BackColor = Color.Wheat;
                if (!isGameStarted)
                {
                    tile.Enabled = true;
                }
            }
            isGameStarted = true;
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


            for (int i = 0; i < 40; i++)
            {
                int index = i;

                while (initializedTiles.Contains(index))
                {
                    index = random.Next(40);
                }

                initializedTiles.Add(index);
                Panel tempTile = tiles[i];
                tempTile.BackgroundImageLayout = ImageLayout.Stretch;
                tempTile.BackgroundImage = shuffledImages[i];
                
            }
        }

    }
}
