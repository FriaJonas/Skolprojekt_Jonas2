namespace WinFormsApp1
{
    partial class Slumptal
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
            this.Num = new System.Windows.Forms.NumericUpDown();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnPress = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.NumericUpDown();
            this.numAntal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAntal)).BeginInit();
            this.SuspendLayout();
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(191, 81);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(150, 27);
            this.Num.TabIndex = 0;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(492, 81);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(125, 27);
            this.txtNum.TabIndex = 1;
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(389, 189);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(94, 29);
            this.btnPress.TabIndex = 2;
            this.btnPress.Text = "button1";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(194, 129);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(150, 27);
            this.Num2.TabIndex = 3;
            // 
            // numAntal
            // 
            this.numAntal.Location = new System.Drawing.Point(193, 196);
            this.numAntal.Name = "numAntal";
            this.numAntal.Size = new System.Drawing.Size(150, 27);
            this.numAntal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Antal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Från";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Till";
            // 
            // Slumptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAntal);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.btnPress);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.Num);
            this.Name = "Slumptal";
            this.Text = "Slumptal";
            ((System.ComponentModel.ISupportInitialize)(this.Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAntal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown Num;
        private TextBox txtNum;
        private Button btnPress;
        private NumericUpDown Num2;
        private NumericUpDown numAntal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}