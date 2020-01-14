namespace HangMan
{
    partial class FM_Highscore
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
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.LB_Scores = new System.Windows.Forms.ListBox();
            this.BT_Quit = new System.Windows.Forms.Button();
            this.lb_hs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(18, 101);
            this.TB_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(241, 22);
            this.TB_Username.TabIndex = 0;
            this.TB_Username.TextChanged += new System.EventHandler(this.TB_Username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your Username";
            // 
            // BT_Submit
            // 
            this.BT_Submit.Enabled = false;
            this.BT_Submit.Location = new System.Drawing.Point(179, 144);
            this.BT_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(80, 34);
            this.BT_Submit.TabIndex = 1;
            this.BT_Submit.Text = "Submit";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // LB_Scores
            // 
            this.LB_Scores.FormattingEnabled = true;
            this.LB_Scores.ItemHeight = 16;
            this.LB_Scores.Location = new System.Drawing.Point(12, 82);
            this.LB_Scores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LB_Scores.Name = "LB_Scores";
            this.LB_Scores.Size = new System.Drawing.Size(457, 340);
            this.LB_Scores.TabIndex = 3;
            this.LB_Scores.Visible = false;
            // 
            // BT_Quit
            // 
            this.BT_Quit.Location = new System.Drawing.Point(289, 23);
            this.BT_Quit.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Quit.Name = "BT_Quit";
            this.BT_Quit.Size = new System.Drawing.Size(180, 42);
            this.BT_Quit.TabIndex = 2;
            this.BT_Quit.Text = "Let Me out of Here. I have had enough!!!";
            this.BT_Quit.UseVisualStyleBackColor = true;
            this.BT_Quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_hs
            // 
            this.lb_hs.AutoSize = true;
            this.lb_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hs.Location = new System.Drawing.Point(12, 23);
            this.lb_hs.Name = "lb_hs";
            this.lb_hs.Size = new System.Drawing.Size(189, 32);
            this.lb_hs.TabIndex = 4;
            this.lb_hs.Text = "High Scores:";
            // 
            // FM_Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.lb_hs);
            this.Controls.Add(this.BT_Quit);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.LB_Scores);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FM_Highscore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM_Highscore_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Submit;
        private System.Windows.Forms.ListBox LB_Scores;
        private System.Windows.Forms.Button BT_Quit;
        private System.Windows.Forms.Label lb_hs;
    }
}