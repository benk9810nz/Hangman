namespace HangMan
{
    partial class FM_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Game));
            this.pb_hangMan = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lb_guess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hangMan)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_hangMan
            // 
            this.pb_hangMan.Location = new System.Drawing.Point(705, 148);
            this.pb_hangMan.Name = "pb_hangMan";
            this.pb_hangMan.Size = new System.Drawing.Size(320, 350);
            this.pb_hangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_hangMan.TabIndex = 0;
            this.pb_hangMan.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "s0.png");
            this.imageList.Images.SetKeyName(1, "s1.png");
            this.imageList.Images.SetKeyName(2, "s2.png");
            this.imageList.Images.SetKeyName(3, "s3.png");
            this.imageList.Images.SetKeyName(4, "s4.png");
            this.imageList.Images.SetKeyName(5, "s5.png");
            this.imageList.Images.SetKeyName(6, "s6.png");
            this.imageList.Images.SetKeyName(7, "s7.png");
            this.imageList.Images.SetKeyName(8, "s8.png");
            this.imageList.Images.SetKeyName(9, "s9.png");
            this.imageList.Images.SetKeyName(10, "s10.png");
            this.imageList.Images.SetKeyName(11, "s11.png");
            this.imageList.Images.SetKeyName(12, "s12.png");
            this.imageList.Images.SetKeyName(13, "s13.png");
            // 
            // lb_guess
            // 
            this.lb_guess.AutoSize = true;
            this.lb_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_guess.Location = new System.Drawing.Point(120, 42);
            this.lb_guess.Name = "lb_guess";
            this.lb_guess.Size = new System.Drawing.Size(520, 59);
            this.lb_guess.TabIndex = 2;
            this.lb_guess.Text = "GUESS THE WORD";
            // 
            // FM_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1244, 742);
            this.Controls.Add(this.lb_guess);
            this.Controls.Add(this.pb_hangMan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FM_Game";
            this.ShowIcon = false;
            this.Text = "Game Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_game_FormClosing);
            this.Load += new System.EventHandler(this.fm_game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fm_game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hangMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hangMan;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lb_guess;
    }
}