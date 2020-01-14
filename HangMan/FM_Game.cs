using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace HangMan
{
    public partial class FM_Game : Form
    {
        const int NUM_BUTTONS = 26;
        const int NUM_SIZE = 50;
        const int NUM_COLLUMNS = 7;
        const int PADDING = 20;
        const int SPACING = 8;
        const int LEFT = 33;
        const int TOP = 102;

        string guessedWord;
        string mode;
        int level;
        int correct = 0;
        int incorrect = -1;
        int currentScore = 0;

        StringBuilder sbuilder;
        List<String> words = new List<string>();
        Random ran = new Random();
        
        public FM_Game()
        {
            InitializeComponent();
        }

        private void fm_game_Load(object sender, EventArgs e)
        {
            getParameters();

            CenterToScreen();
            
        }

       public void getParameters()
        {
            this.level = Parameters.level;
            mode = Parameters.mode.ToUpper();
            GetWords();

            int ranInt = ran.Next(words.Count());
            guessedWord = words[ranInt];
            //MessageBox.Show(guessedWord);
            Parameters.word = guessedWord;
            sbuilder = new StringBuilder(guessedWord);
            wordToUnknown();
            CreateButtons();
        }

        private void wordToUnknown()
        {
            for (int i = 0; i < sbuilder.Length; i++)
            {
                sbuilder[i] = '*';
            }
            lb_guess.Text = sbuilder.ToString();
        }

        public void GetWords()
        {
            words.Clear();
            using (StreamReader reader = new StreamReader(@"data/lists/" + mode + ".txt"))
            {
                while (!reader.EndOfStream)
                {
                    words.Add(reader.ReadLine().ToUpper());
                }
                reader.Close();
            }
        }

        public void GetNewGame()
        {
            pb_hangMan.Image = null;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    Button btn = this.Controls[i] as Button;
                    btn.Show();
                }
            }
            correct = 0;
            incorrect = -1;
            guessedWord = words[ran.Next(0, words.Count())];
            wordToUnknown();
            lb_guess.Text = sbuilder.ToString();
            this.Show();
        }

        public void CreateButtons()
        {
            Button[] buttons = new Button[NUM_BUTTONS];
            for (int i = 0; i < NUM_BUTTONS; i++)
            {
                Button bt = new Button();
                bt.Text = ((char)(i + 65)).ToString();
                bt.Size = new Size(NUM_SIZE, NUM_SIZE);
                int col = i % NUM_COLLUMNS;
                int rows = i / NUM_COLLUMNS;
                bt.Location = new Point(LEFT + PADDING + (col * (NUM_SIZE + SPACING)), TOP + PADDING + (rows * (NUM_SIZE + SPACING)));
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
                this.Controls.Add(bt);

                bt.Click += Bt_Click;
            }

        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            // MessageBox.Show(String.Format("{0}",bt.Text[0]));
            if (level == 1) { bt.Visible = false; }  // If Easy hide the button
            char letter = bt.Text[0];
            CheckChar(letter);
        }

        public void CheckChar(char gChar)
        {
            if (guessedWord.Contains(gChar))
            {

                for (int i = 0; i < guessedWord.Length; i++)
                {
                    if (guessedWord[i] == gChar)
                    {
                        sbuilder[i] = gChar;
                        correct++;
                    }

                }
                lb_guess.Text = sbuilder.ToString();
            }
        
            else
            {
                incorrect++;
              //  MessageBox.Show("Wrong" + incorrect);
                pb_hangMan.Image = imageList.Images[incorrect];
            }

            if (incorrect == 13)
            {
                this.Hide();
                Form form = new FM_Incorrect(this);
                form.ShowDialog();
            }

            if (correct == guessedWord.Length)
            {
                GetScore();
                Form form = new FM_Correct(this);
                form.ShowDialog();
            }
        }

        private void GetScore()
        {
            currentScore = correct + incorrect;
            if (currentScore > Parameters.score)
            {
                Parameters.score = currentScore;
                Parameters.bestWord = guessedWord;
        //        MessageBox.Show(Parameters.score + Parameters.bestWord);
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fm_game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void fm_game_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            CheckChar(letter);
        }
    }
}
