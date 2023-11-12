namespace PictureMatchGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameScreen = new Panel();
            playerSecondLabel = new Label();
            playerFirstLabel = new Label();
            playerSecondScoreBox = new TextBox();
            playerFirstScoreBox = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            tileOpen17 = new Panel();
            tileOpen18 = new Panel();
            tileOpen19 = new Panel();
            tileOpen20 = new Panel();
            tileOpen15 = new Panel();
            tileOpen14 = new Panel();
            tileOpen13 = new Panel();
            tileOpen12 = new Panel();
            tileOpen10 = new Panel();
            tileOpen9 = new Panel();
            tileOpen8 = new Panel();
            tileOpen5 = new Panel();
            tileOpen7 = new Panel();
            tileOpen4 = new Panel();
            tileOpen2 = new Panel();
            tileOpen3 = new Panel();
            tileOpen16 = new Panel();
            tileOpen11 = new Panel();
            tileOpen6 = new Panel();
            tileOpen1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            gameScreen.SuspendLayout();
            SuspendLayout();
            // 
            // gameScreen
            // 
            gameScreen.BackColor = Color.SteelBlue;
            gameScreen.Controls.Add(playerSecondLabel);
            gameScreen.Controls.Add(playerFirstLabel);
            gameScreen.Controls.Add(playerSecondScoreBox);
            gameScreen.Controls.Add(playerFirstScoreBox);
            gameScreen.Controls.Add(textBox1);
            gameScreen.Controls.Add(button1);
            gameScreen.Controls.Add(tileOpen17);
            gameScreen.Controls.Add(tileOpen18);
            gameScreen.Controls.Add(tileOpen19);
            gameScreen.Controls.Add(tileOpen20);
            gameScreen.Controls.Add(tileOpen15);
            gameScreen.Controls.Add(tileOpen14);
            gameScreen.Controls.Add(tileOpen13);
            gameScreen.Controls.Add(tileOpen12);
            gameScreen.Controls.Add(tileOpen10);
            gameScreen.Controls.Add(tileOpen9);
            gameScreen.Controls.Add(tileOpen8);
            gameScreen.Controls.Add(tileOpen5);
            gameScreen.Controls.Add(tileOpen7);
            gameScreen.Controls.Add(tileOpen4);
            gameScreen.Controls.Add(tileOpen2);
            gameScreen.Controls.Add(tileOpen3);
            gameScreen.Controls.Add(tileOpen16);
            gameScreen.Controls.Add(tileOpen11);
            gameScreen.Controls.Add(tileOpen6);
            gameScreen.Controls.Add(tileOpen1);
            gameScreen.Location = new Point(50, 50);
            gameScreen.Margin = new Padding(0);
            gameScreen.Name = "gameScreen";
            gameScreen.Size = new Size(889, 654);
            gameScreen.TabIndex = 0;
            gameScreen.Paint += gameScreen_Paint;
            // 
            // playerSecondLabel
            // 
            playerSecondLabel.AutoSize = true;
            playerSecondLabel.Location = new Point(731, 229);
            playerSecondLabel.Name = "playerSecondLabel";
            playerSecondLabel.Size = new Size(61, 20);
            playerSecondLabel.TabIndex = 13;
            playerSecondLabel.Text = "Player 2";
            // 
            // playerFirstLabel
            // 
            playerFirstLabel.AutoSize = true;
            playerFirstLabel.ForeColor = Color.Red;
            playerFirstLabel.Location = new Point(731, 156);
            playerFirstLabel.Name = "playerFirstLabel";
            playerFirstLabel.Size = new Size(61, 20);
            playerFirstLabel.TabIndex = 12;
            playerFirstLabel.Text = "Player 1";
            // 
            // playerSecondScoreBox
            // 
            playerSecondScoreBox.Enabled = false;
            playerSecondScoreBox.Location = new Point(731, 252);
            playerSecondScoreBox.Name = "playerSecondScoreBox";
            playerSecondScoreBox.Size = new Size(125, 27);
            playerSecondScoreBox.TabIndex = 11;
            playerSecondScoreBox.Text = "0";
            playerSecondScoreBox.TextAlign = HorizontalAlignment.Center;
            // 
            // playerFirstScoreBox
            // 
            playerFirstScoreBox.Enabled = false;
            playerFirstScoreBox.Location = new Point(731, 179);
            playerFirstScoreBox.Name = "playerFirstScoreBox";
            playerFirstScoreBox.Size = new Size(125, 27);
            playerFirstScoreBox.TabIndex = 10;
            playerFirstScoreBox.Text = "0";
            playerFirstScoreBox.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(731, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(181, 592);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tileOpen17
            // 
            tileOpen17.BackColor = Color.Wheat;
            tileOpen17.Enabled = false;
            tileOpen17.Location = new Point(181, 441);
            tileOpen17.Name = "tileOpen17";
            tileOpen17.Size = new Size(100, 100);
            tileOpen17.TabIndex = 7;
            tileOpen17.Click += tilesClicked;
            // 
            // tileOpen18
            // 
            tileOpen18.BackColor = Color.Wheat;
            tileOpen18.Enabled = false;
            tileOpen18.Location = new Point(321, 441);
            tileOpen18.Name = "tileOpen18";
            tileOpen18.Size = new Size(100, 100);
            tileOpen18.TabIndex = 7;
            tileOpen18.Click += tilesClicked;
            // 
            // tileOpen19
            // 
            tileOpen19.BackColor = Color.Wheat;
            tileOpen19.Enabled = false;
            tileOpen19.Location = new Point(457, 441);
            tileOpen19.Name = "tileOpen19";
            tileOpen19.Size = new Size(100, 100);
            tileOpen19.TabIndex = 7;
            tileOpen19.Click += tilesClicked;
            // 
            // tileOpen20
            // 
            tileOpen20.BackColor = Color.Wheat;
            tileOpen20.Enabled = false;
            tileOpen20.Location = new Point(593, 441);
            tileOpen20.Name = "tileOpen20";
            tileOpen20.Size = new Size(100, 100);
            tileOpen20.TabIndex = 7;
            tileOpen20.Click += tilesClicked;
            // 
            // tileOpen15
            // 
            tileOpen15.BackColor = Color.Wheat;
            tileOpen15.Enabled = false;
            tileOpen15.Location = new Point(593, 310);
            tileOpen15.Name = "tileOpen15";
            tileOpen15.Size = new Size(100, 100);
            tileOpen15.TabIndex = 7;
            tileOpen15.Click += tilesClicked;
            // 
            // tileOpen14
            // 
            tileOpen14.BackColor = Color.Wheat;
            tileOpen14.Enabled = false;
            tileOpen14.Location = new Point(457, 310);
            tileOpen14.Name = "tileOpen14";
            tileOpen14.Size = new Size(100, 100);
            tileOpen14.TabIndex = 7;
            tileOpen14.Click += tilesClicked;
            // 
            // tileOpen13
            // 
            tileOpen13.BackColor = Color.Wheat;
            tileOpen13.Enabled = false;
            tileOpen13.Location = new Point(321, 310);
            tileOpen13.Name = "tileOpen13";
            tileOpen13.Size = new Size(100, 100);
            tileOpen13.TabIndex = 7;
            tileOpen13.Click += tilesClicked;
            // 
            // tileOpen12
            // 
            tileOpen12.BackColor = Color.Wheat;
            tileOpen12.Enabled = false;
            tileOpen12.Location = new Point(181, 310);
            tileOpen12.Name = "tileOpen12";
            tileOpen12.Size = new Size(100, 100);
            tileOpen12.TabIndex = 7;
            tileOpen12.Click += tilesClicked;
            // 
            // tileOpen10
            // 
            tileOpen10.BackColor = Color.Wheat;
            tileOpen10.Enabled = false;
            tileOpen10.Location = new Point(593, 179);
            tileOpen10.Name = "tileOpen10";
            tileOpen10.Size = new Size(100, 100);
            tileOpen10.TabIndex = 7;
            tileOpen10.Click += tilesClicked;
            // 
            // tileOpen9
            // 
            tileOpen9.BackColor = Color.Wheat;
            tileOpen9.Enabled = false;
            tileOpen9.Location = new Point(457, 179);
            tileOpen9.Name = "tileOpen9";
            tileOpen9.Size = new Size(100, 100);
            tileOpen9.TabIndex = 7;
            tileOpen9.Click += tilesClicked;
            // 
            // tileOpen8
            // 
            tileOpen8.BackColor = Color.Wheat;
            tileOpen8.Enabled = false;
            tileOpen8.Location = new Point(321, 179);
            tileOpen8.Name = "tileOpen8";
            tileOpen8.Size = new Size(100, 100);
            tileOpen8.TabIndex = 7;
            tileOpen8.Click += tilesClicked;
            // 
            // tileOpen5
            // 
            tileOpen5.BackColor = Color.Wheat;
            tileOpen5.Enabled = false;
            tileOpen5.Location = new Point(593, 49);
            tileOpen5.Name = "tileOpen5";
            tileOpen5.Size = new Size(100, 100);
            tileOpen5.TabIndex = 7;
            tileOpen5.Click += tilesClicked;
            // 
            // tileOpen7
            // 
            tileOpen7.BackColor = Color.Wheat;
            tileOpen7.Enabled = false;
            tileOpen7.Location = new Point(181, 179);
            tileOpen7.Name = "tileOpen7";
            tileOpen7.Size = new Size(100, 100);
            tileOpen7.TabIndex = 7;
            tileOpen7.Click += tilesClicked;
            // 
            // tileOpen4
            // 
            tileOpen4.BackColor = Color.Wheat;
            tileOpen4.Enabled = false;
            tileOpen4.Location = new Point(457, 49);
            tileOpen4.Name = "tileOpen4";
            tileOpen4.Size = new Size(100, 100);
            tileOpen4.TabIndex = 6;
            tileOpen4.Click += tilesClicked;
            // 
            // tileOpen2
            // 
            tileOpen2.BackColor = Color.Wheat;
            tileOpen2.Enabled = false;
            tileOpen2.Location = new Point(181, 49);
            tileOpen2.Name = "tileOpen2";
            tileOpen2.Size = new Size(100, 100);
            tileOpen2.TabIndex = 5;
            tileOpen2.Click += tilesClicked;
            // 
            // tileOpen3
            // 
            tileOpen3.BackColor = Color.Wheat;
            tileOpen3.Enabled = false;
            tileOpen3.Location = new Point(321, 49);
            tileOpen3.Name = "tileOpen3";
            tileOpen3.Size = new Size(100, 100);
            tileOpen3.TabIndex = 4;
            tileOpen3.Click += tilesClicked;
            // 
            // tileOpen16
            // 
            tileOpen16.BackColor = Color.Wheat;
            tileOpen16.Enabled = false;
            tileOpen16.Location = new Point(44, 441);
            tileOpen16.Name = "tileOpen16";
            tileOpen16.Size = new Size(100, 100);
            tileOpen16.TabIndex = 3;
            tileOpen16.Click += tilesClicked;
            // 
            // tileOpen11
            // 
            tileOpen11.BackColor = Color.Wheat;
            tileOpen11.Enabled = false;
            tileOpen11.Location = new Point(44, 310);
            tileOpen11.Name = "tileOpen11";
            tileOpen11.Size = new Size(100, 100);
            tileOpen11.TabIndex = 2;
            tileOpen11.Click += tilesClicked;
            // 
            // tileOpen6
            // 
            tileOpen6.BackColor = Color.Wheat;
            tileOpen6.Enabled = false;
            tileOpen6.Location = new Point(44, 179);
            tileOpen6.Name = "tileOpen6";
            tileOpen6.Size = new Size(100, 100);
            tileOpen6.TabIndex = 1;
            tileOpen6.Click += tilesClicked;
            // 
            // tileOpen1
            // 
            tileOpen1.BackColor = Color.Wheat;
            tileOpen1.BackgroundImageLayout = ImageLayout.Stretch;
            tileOpen1.Enabled = false;
            tileOpen1.Location = new Point(44, 49);
            tileOpen1.Name = "tileOpen1";
            tileOpen1.Size = new Size(100, 100);
            tileOpen1.TabIndex = 0;
            tileOpen1.Click += tilesClicked;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(gameScreen);
            Name = "Form1";
            Text = "Form1";
            gameScreen.ResumeLayout(false);
            gameScreen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gameScreen;
        private Panel tileOpen1;
        private Panel tileOpen10;
        private Panel tileOpen12;
        private Panel tileOpen9;
        private Panel tileOpen8;
        private Panel tileOpen5;
        private Panel tileOpen7;
        private Panel tileOpen4;
        private Panel tileOpen2;
        private Panel tileOpen3;
        private Panel tileOpen16;
        private Panel tileOpen11;
        private Panel tileOpen6;
        private Panel tileOpen17;
        private Panel tileOpen18;
        private Panel tileOpen19;
        private Panel tileOpen20;
        private Panel tileOpen15;
        private Panel tileOpen14;
        private Panel tileOpen13;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Label playerSecondLabel;
        private Label playerFirstLabel;
        private TextBox playerSecondScoreBox;
        private TextBox playerFirstScoreBox;
    }
}