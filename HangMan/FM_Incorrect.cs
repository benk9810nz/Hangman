﻿using System;
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
    public partial class FM_Incorrect : Form
    {
        Form parent = null;
        public FM_Incorrect(Form item)
        {
            InitializeComponent();
            parent = item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((FM_Game)(parent)).GetNewGame();
            this.Close();
        }

        private void fm_Incorrect_Load(object sender, EventArgs e)
        {
            lb_word.Text = String.Format("The word was: {0}", Parameters.word);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fm = new FM_Highscore();
            this.Close();
            fm.Show();
        }
    }
}
