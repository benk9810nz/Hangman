using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class FM_Correct : Form
    {
        Form parent = null;
        public FM_Correct(Form item)
        {
            InitializeComponent();
            parent = item;
        }

        private void bt_playAgain_Click(object sender, EventArgs e)
        {
            ((FM_Game)(parent)).GetNewGame();
            this.Close(); 
        }

        private void bt_giveup_Click(object sender, EventArgs e)
        {
            Form fm = new FM_Highscore();
            this.Close();
            fm.Show();
        }

        private void FM_Correct_Load(object sender, EventArgs e)
        {
            LB_Word.Text = String.Format("The word was: {0}", Parameters.word);
        }
    }
}
