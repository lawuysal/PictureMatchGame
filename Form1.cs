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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.initImages(ref gameScreen);

        }
    }
}