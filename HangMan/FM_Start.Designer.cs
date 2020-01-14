namespace HangMan
{
    partial class FM_Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_PlayGame = new System.Windows.Forms.Button();
            this.RB_Easy = new System.Windows.Forms.RadioButton();
            this.RB_Hard = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_Welcome = new System.Windows.Forms.Label();
            this.lb_mode = new System.Windows.Forms.Label();
            this.CB_Words = new System.Windows.Forms.ComboBox();
            this.lb_words = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_PlayGame
            // 
            this.BT_PlayGame.Location = new System.Drawing.Point(242, 117);
            this.BT_PlayGame.Margin = new System.Windows.Forms.Padding(2);
            this.BT_PlayGame.Name = "BT_PlayGame";
            this.BT_PlayGame.Size = new System.Drawing.Size(71, 34);
            this.BT_PlayGame.TabIndex = 0;
            this.BT_PlayGame.Text = "Play Game";
            this.BT_PlayGame.UseVisualStyleBackColor = true;
            this.BT_PlayGame.Click += new System.EventHandler(this.bt_playGame_Click);
            // 
            // RB_Easy
            // 
            this.RB_Easy.AutoSize = true;
            this.RB_Easy.Location = new System.Drawing.Point(2, 2);
            this.RB_Easy.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Easy.Name = "RB_Easy";
            this.RB_Easy.Size = new System.Drawing.Size(48, 17);
            this.RB_Easy.TabIndex = 0;
            this.RB_Easy.TabStop = true;
            this.RB_Easy.Text = "Easy";
            this.RB_Easy.UseVisualStyleBackColor = true;
            // 
            // RB_Hard
            // 
            this.RB_Hard.AutoSize = true;
            this.RB_Hard.Location = new System.Drawing.Point(2, 24);
            this.RB_Hard.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Hard.Name = "RB_Hard";
            this.RB_Hard.Size = new System.Drawing.Size(48, 17);
            this.RB_Hard.TabIndex = 1;
            this.RB_Hard.TabStop = true;
            this.RB_Hard.Text = "Hard";
            this.RB_Hard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RB_Hard);
            this.panel2.Controls.Add(this.RB_Easy);
            this.panel2.Location = new System.Drawing.Point(39, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 51);
            this.panel2.TabIndex = 4;
            // 
            // LB_Welcome
            // 
            this.LB_Welcome.AutoSize = true;
            this.LB_Welcome.Font = new System.Drawing.Font("Magneto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Welcome.Location = new System.Drawing.Point(9, 7);
            this.LB_Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Welcome.Name = "LB_Welcome";
            this.LB_Welcome.Size = new System.Drawing.Size(335, 32);
            this.LB_Welcome.TabIndex = 5;
            this.LB_Welcome.Text = "Welcome to Hangman";
            // 
            // lb_mode
            // 
            this.lb_mode.AutoSize = true;
            this.lb_mode.Location = new System.Drawing.Point(39, 72);
            this.lb_mode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mode.Name = "lb_mode";
            this.lb_mode.Size = new System.Drawing.Size(34, 13);
            this.lb_mode.TabIndex = 6;
            this.lb_mode.Text = "Mode";
            // 
            // CB_Words
            // 
            this.CB_Words.FormattingEnabled = true;
            this.CB_Words.Items.AddRange(new object[] {
            "Animals",
            "Cities",
            "Words"});
            this.CB_Words.Location = new System.Drawing.Point(125, 91);
            this.CB_Words.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Words.Name = "CB_Words";
            this.CB_Words.Size = new System.Drawing.Size(92, 21);
            this.CB_Words.TabIndex = 1;
            // 
            // lb_words
            // 
            this.lb_words.AutoSize = true;
            this.lb_words.Location = new System.Drawing.Point(128, 76);
            this.lb_words.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_words.Name = "lb_words";
            this.lb_words.Size = new System.Drawing.Size(69, 13);
            this.lb_words.TabIndex = 8;
            this.lb_words.Text = "List of Words";
            // 
            // FM_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 165);
            this.Controls.Add(this.lb_words);
            this.Controls.Add(this.CB_Words);
            this.Controls.Add(this.lb_mode);
            this.Controls.Add(this.LB_Welcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BT_PlayGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FM_Start";
            this.Text = "Play Hangman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_startGame_FormClosing);
            this.Load += new System.EventHandler(this.fm_startGame_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_PlayGame;
        private System.Windows.Forms.RadioButton RB_Easy;
        private System.Windows.Forms.RadioButton RB_Hard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LB_Welcome;
        private System.Windows.Forms.Label lb_mode;
        private System.Windows.Forms.ComboBox CB_Words;
        private System.Windows.Forms.Label lb_words;
    }
}

