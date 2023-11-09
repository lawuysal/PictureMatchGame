namespace PictureMatchGame
{
    public partial class Form1 : Form
    {
        Game playerFirst;
        Game playerSecond;
        public Form1()
        {
            InitializeComponent();

            // Initialize players
            playerFirst = new Game();
            playerSecond = new Game();

            // Initialize images
            Game.images.Add((Image)Properties.Resources._01);
            Game.images.Add((Image)Properties.Resources._02);
            Game.images.Add((Image)Properties.Resources._03);
            Game.images.Add((Image)Properties.Resources._04);
            Game.images.Add((Image)Properties.Resources._05);
            Game.images.Add((Image)Properties.Resources._06);
            Game.images.Add((Image)Properties.Resources._07);
            Game.images.Add((Image)Properties.Resources._08);
            Game.images.Add((Image)Properties.Resources._09);
            Game.images.Add((Image)Properties.Resources._10);

            // Initialize tile list
            for (int i = 0; i < 20; i++)
            {
                Panel tile = (Panel)gameScreen.Controls.Find($"tileOpen{i + 1}", false).FirstOrDefault();
                Game.tiles.Add(tile);
            }

            // Start the timer

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.initImages(ref gameScreen);
            textBox1.Text = Game.currentTime.ToString();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Game.currentTime > 0)
            {
                Game.currentTime--;
                textBox1.Text = Game.currentTime.ToString();
            }

            if (Game.currentTime == 0)
            {
                Game.turnBackAllImages(ref gameScreen);

            }

            Game.checkTileMatch();
        }

        private void tilesClicked(object sender, EventArgs e)
        {
            Panel tile = (Panel)sender;
            int index = Game.tileNumberParser(tile) - 1;

            Game.tiles[index].BackgroundImage = Game.currentImages[index];
            Game.currentTime = Game.flashingTime;

            
        }
    }
}