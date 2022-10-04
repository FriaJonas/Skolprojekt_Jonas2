namespace WinFormsApp1
{
    partial class GuessNumber
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
            this.btnGissa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(159, 161);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(178, 29);
            this.btnGissa.TabIndex = 0;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gissa ett tal mellan 1-100";
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(161, 117);
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(150, 27);
            this.numNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antal försök: ";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(277, 216);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(17, 20);
            this.lblGuess.TabIndex = 4;
            this.lblGuess.Text = "0";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(161, 278);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(93, 20);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Meddelande";
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 408);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGissa);
            this.Name = "GuessNumber";
            this.Text = "GuessNumber";
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGissa;
        private Label label1;
        private NumericUpDown numNumber;
        private Label label2;
        private Label lblGuess;
        private Label lblMessage;
    }
}