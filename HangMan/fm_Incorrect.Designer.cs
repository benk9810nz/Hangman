namespace HangMan
{
    partial class FM_Incorrect
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_word = new System.Windows.Forms.Label();
            this.BT_PlayAgain = new System.Windows.Forms.Button();
            this.fail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Stickman is Dead. Bad Luck";
            // 
            // lb_word
            // 
            this.lb_word.AutoSize = true;
            this.lb_word.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_word.Location = new System.Drawing.Point(12, 47);
            this.lb_word.Name = "lb_word";
            this.lb_word.Size = new System.Drawing.Size(197, 38);
            this.lb_word.TabIndex = 1;
            this.lb_word.Text = "The word was";
            // 
            // BT_PlayAgain
            // 
            this.BT_PlayAgain.Location = new System.Drawing.Point(19, 127);
            this.BT_PlayAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_PlayAgain.Name = "BT_PlayAgain";
            this.BT_PlayAgain.Size = new System.Drawing.Size(121, 53);
            this.BT_PlayAgain.TabIndex = 0;
            this.BT_PlayAgain.Text = "Play Again";
            this.BT_PlayAgain.UseVisualStyleBackColor = true;
            this.BT_PlayAgain.Click += new System.EventHandler(this.button1_Click);
            // 
            // fail
            // 
            this.fail.Location = new System.Drawing.Point(265, 127);
            this.fail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fail.Name = "fail";
            this.fail.Size = new System.Drawing.Size(184, 53);
            this.fail.TabIndex = 1;
            this.fail.Text = "This Game Sucks!!! I\'m Outta Here";
            this.fail.UseVisualStyleBackColor = true;
            this.fail.Click += new System.EventHandler(this.button2_Click);
            // 
            // FM_Incorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 187);
            this.Controls.Add(this.fail);
            this.Controls.Add(this.BT_PlayAgain);
            this.Controls.Add(this.lb_word);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FM_Incorrect";
            this.Text = "BAD LUCK";
            this.Load += new System.EventHandler(this.fm_Incorrect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_word;
        private System.Windows.Forms.Button BT_PlayAgain;
        private System.Windows.Forms.Button fail;
    }
}