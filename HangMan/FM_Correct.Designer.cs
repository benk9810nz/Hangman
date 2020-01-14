namespace HangMan
{
    partial class FM_Correct
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
            this.BT_GiveUp = new System.Windows.Forms.Button();
            this.BT_PlayAgain = new System.Windows.Forms.Button();
            this.LB_Word = new System.Windows.Forms.Label();
            this.LB_WellDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_GiveUp
            // 
            this.BT_GiveUp.Location = new System.Drawing.Point(295, 132);
            this.BT_GiveUp.Margin = new System.Windows.Forms.Padding(2);
            this.BT_GiveUp.Name = "BT_GiveUp";
            this.BT_GiveUp.Size = new System.Drawing.Size(84, 36);
            this.BT_GiveUp.TabIndex = 1;
            this.BT_GiveUp.Text = "I Give Up";
            this.BT_GiveUp.UseVisualStyleBackColor = true;
            this.BT_GiveUp.Click += new System.EventHandler(this.bt_giveup_Click);
            // 
            // BT_PlayAgain
            // 
            this.BT_PlayAgain.Location = new System.Drawing.Point(23, 132);
            this.BT_PlayAgain.Margin = new System.Windows.Forms.Padding(2);
            this.BT_PlayAgain.Name = "BT_PlayAgain";
            this.BT_PlayAgain.Size = new System.Drawing.Size(94, 36);
            this.BT_PlayAgain.TabIndex = 0;
            this.BT_PlayAgain.Text = "Yayyyy I wanna play again";
            this.BT_PlayAgain.UseVisualStyleBackColor = true;
            this.BT_PlayAgain.Click += new System.EventHandler(this.bt_playAgain_Click);
            // 
            // LB_Word
            // 
            this.LB_Word.AutoSize = true;
            this.LB_Word.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold);
            this.LB_Word.Location = new System.Drawing.Point(9, 51);
            this.LB_Word.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Word.Name = "LB_Word";
            this.LB_Word.Size = new System.Drawing.Size(163, 30);
            this.LB_Word.TabIndex = 5;
            this.LB_Word.Text = "The word was:";
            // 
            // LB_WellDone
            // 
            this.LB_WellDone.AutoSize = true;
            this.LB_WellDone.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold);
            this.LB_WellDone.Location = new System.Drawing.Point(9, 7);
            this.LB_WellDone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_WellDone.Name = "LB_WellDone";
            this.LB_WellDone.Size = new System.Drawing.Size(403, 30);
            this.LB_WellDone.TabIndex = 4;
            this.LB_WellDone.Text = "Congratulations you Stickman is Alive";
            // 
            // FM_Correct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(415, 180);
            this.Controls.Add(this.BT_GiveUp);
            this.Controls.Add(this.BT_PlayAgain);
            this.Controls.Add(this.LB_Word);
            this.Controls.Add(this.LB_WellDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FM_Correct";
            this.Text = "Yayyyy You Were Right";
            this.Load += new System.EventHandler(this.FM_Correct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_GiveUp;
        private System.Windows.Forms.Button BT_PlayAgain;
        private System.Windows.Forms.Label LB_Word;
        private System.Windows.Forms.Label LB_WellDone;
    }
}