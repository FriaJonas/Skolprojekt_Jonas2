namespace WinFormsApp1
{
    partial class Game
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
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer1Points = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer2Points = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.BackgroundImage = global::WinFormsApp1.Properties.Resources.bomb;
            this.Player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1.InitialImage = null;
            this.Player1.Location = new System.Drawing.Point(80, 117);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(79, 91);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(31, 26);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(108, 31);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Spelare 1";
            // 
            // lblPlayer1Points
            // 
            this.lblPlayer1Points.AutoSize = true;
            this.lblPlayer1Points.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Points.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Points.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Points.Location = new System.Drawing.Point(31, 57);
            this.lblPlayer1Points.Name = "lblPlayer1Points";
            this.lblPlayer1Points.Size = new System.Drawing.Size(26, 31);
            this.lblPlayer1Points.TabIndex = 3;
            this.lblPlayer1Points.Text = "0";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(640, 26);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(108, 31);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Spelare 2";
            // 
            // lblPlayer2Points
            // 
            this.lblPlayer2Points.AutoSize = true;
            this.lblPlayer2Points.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Points.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Points.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Points.Location = new System.Drawing.Point(640, 57);
            this.lblPlayer2Points.Name = "lblPlayer2Points";
            this.lblPlayer2Points.Size = new System.Drawing.Size(26, 31);
            this.lblPlayer2Points.TabIndex = 5;
            this.lblPlayer2Points.Text = "0";
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Lime;
            this.Player2.Location = new System.Drawing.Point(827, 101);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(32, 70);
            this.Player2.TabIndex = 6;
            this.Player2.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Orange;
            this.Ball.Location = new System.Drawing.Point(435, 518);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 31);
            this.Ball.TabIndex = 7;
            this.Ball.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.bgspace;
            this.ClientSize = new System.Drawing.Size(892, 575);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.lblPlayer2Points);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1Points);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.Player1);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Player1;
        private Label lblPlayer1;
        private Label lblPlayer1Points;
        private Label lblPlayer2;
        private Label lblPlayer2Points;
        private PictureBox Player2;
        private PictureBox Ball;
    }
}