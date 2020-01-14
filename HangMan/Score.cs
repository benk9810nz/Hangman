using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Score : IComparable
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private int guesses;

        public int Guesses
        {
            get { return guesses; }
            set { guesses = value; }
        }

        private string word;

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        private string level;

        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        private int numLevel;

        public int NumLevel
        {
            get { return numLevel; }
            set { numLevel = value; }
        }


        public Score(string username, string word, int level, int guesses)
        {
            this.UserName = username;
            this.Word = word;
            this.Guesses = guesses;
            this.NumLevel = level;
        }

        private void GetLevel(int level)
        {
            if (level == 0)
            {
                this.Level = "Hard";
            }//hard
            else
            {
                this.Level = "Easy";
            }//easy
        }

        public string printLine()
        {
            GetLevel(numLevel);
            return String.Format("Username: {0} | Best Word {1} | Best Guess {2} | Level: {3}", UserName, Word, Guesses, Level);
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3}", UserName, word, NumLevel, Guesses);
        }

        public int CompareTo(object obj)
        {
            Score that = obj as Score;
            int comp = this.NumLevel - that.NumLevel;
            if (comp == 0) { comp = this.Guesses - that.Guesses; }
            return comp;
        }
    }
}
