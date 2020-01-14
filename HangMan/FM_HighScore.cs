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
    public partial class FM_Highscore : Form
    {
        string username = null;

        public FM_Highscore()
        {
            InitializeComponent();
        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            BT_Submit.Visible = false; //hide button
            TB_Username.Visible = false; //hide input box
            label1.Visible = false; // Hide label

            username = TB_Username.Text;
            Score score = new Score(username, Parameters.bestWord, Parameters.level, Parameters.score);
            using (StreamWriter streamWriter = new StreamWriter(@"data/scores.txt",true))
            {
                streamWriter.WriteLine(score);
                streamWriter.Close();
            }

            GetScores();
            LB_Scores.Show();
        }

        private void GetScores()
        {
            List<Score> scores = new List<Score>();
            using (StreamReader reader = new StreamReader(@"data/scores.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');
                    //Username,bestword,level,score
                    Score score = new Score(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]));
                    scores.Add(score);
                }
            }

            scores.Sort();
            foreach (Score score in scores)
            {
                LB_Scores.Items.Add(score.printLine());
            }
        }

        private void TB_Username_TextChanged(object sender, EventArgs e)
        {
            BT_Submit.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FM_Highscore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
