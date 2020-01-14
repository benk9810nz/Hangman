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
    public partial class FM_Start : Form
    {
        public FM_Start()
        {
            InitializeComponent();
        }

        private void bt_playGame_Click(object sender, EventArgs e)
        {
            Parameters.score = -1;
            if (RB_Easy.Checked == true)
            {
                Parameters.level = 1;
            }
            else
            {
                Parameters.level = 0;
            }
            Parameters.mode = String.Format("{0}",CB_Words.SelectedItem);
            Form f1 = new FM_Game();
            f1.Show();
            this.Hide();
        }

        private void fm_startGame_Load(object sender, EventArgs e)
        {
            RB_Easy.Checked = true;
            CenterToScreen();
            CB_Words.SelectedIndex = 0;
        }

        private void fm_startGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
