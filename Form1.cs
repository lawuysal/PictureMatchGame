namespace PictureMatchGame
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


            // Initialize images
            Game.images.Add((Image)Properties.Resources._11);
            Game.images.Add((Image)Properties.Resources._12);
            Game.images.Add((Image)Properties.Resources._13);
            Game.images.Add((Image)Properties.Resources._14);
            Game.images.Add((Image)Properties.Resources._15);
            Game.images.Add((Image)Properties.Resources._16);
            Game.images.Add((Image)Properties.Resources._17);
            Game.images.Add((Image)Properties.Resources._18);
            Game.images.Add((Image)Properties.Resources._19);
            Game.images.Add((Image)Properties.Resources._20);
            Game.images.Add((Image)Properties.Resources._21);
            Game.images.Add((Image)Properties.Resources._22);
            Game.images.Add((Image)Properties.Resources._23);
            Game.images.Add((Image)Properties.Resources._24);
            Game.images.Add((Image)Properties.Resources._25);
            Game.images.Add((Image)Properties.Resources._26);
            Game.images.Add((Image)Properties.Resources._27);
            Game.images.Add((Image)Properties.Resources._28);
            Game.images.Add((Image)Properties.Resources._29);
            Game.images.Add((Image)Properties.Resources._30);

            // Initialize tile list
            for (int i = 0; i < 40; i++)
            {
                Panel tile = (Panel)gameScreen.Controls.Find($"tileOpen{i + 1}", false).FirstOrDefault();
                Game.tiles.Add(tile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.initImages(ref gameScreen);
            textBox1.Text = Game.currentTime.ToString();
            timer1.Start();
            button1 .Enabled = false;
            button1.BackColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string test = Game.checkGame();
            if (Game.isGameDone && test != " ")
            {
                MessageBox.Show(test);
            }
            if (Game.isGameDone)
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
            if (Game.currentTime > 0)
            {
                Game.currentTime--;
                textBox1.Text = Game.currentTime.ToString();
            }

            if (Game.currentTime == 0)
            {
                Game.turnBackAllImages(gameScreen);
                if (Game.tileFixer == 1)
                {
                    Game.switchPlayer();
                    Game.switchPlayerIndicatorColor(playerFirstLabel, playerSecondLabel);
                }
            }
        }

        private void tilesClicked(object sender, EventArgs e)
        {
            Panel tile = (Panel)sender;
            int index = Game.tileNumberParser(tile) - 1;

            Game.tiles[index].BackgroundImage = Game.currentImages[index];
            if (Game.tileFixer == 0)
            {
                Game.currentTime = 5;
                textBox1.Text = Game.currentTime.ToString();
            }
            if (Game.tileFixer == 1)
            {
                Game.currentTime = 2;
                textBox1.Text = Game.currentTime.ToString();
            }

            Game.checkTileMatch(playerFirstScoreBox, playerSecondScoreBox,
                playerFirstLabel, playerSecondLabel, gameScreen);
        }

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}