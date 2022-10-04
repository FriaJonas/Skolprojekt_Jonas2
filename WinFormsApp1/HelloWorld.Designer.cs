namespace WinFormsApp1
{
    partial class HelloWorld
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
            this.btnPress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAntalKlick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(195, 152);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(94, 29);
            this.btnPress.TabIndex = 0;
            this.btnPress.Text = "Klicka här";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Antal klick";
            // 
            // lblAntalKlick
            // 
            this.lblAntalKlick.AutoSize = true;
            this.lblAntalKlick.Location = new System.Drawing.Point(142, 77);
            this.lblAntalKlick.Name = "lblAntalKlick";
            this.lblAntalKlick.Size = new System.Drawing.Size(17, 20);
            this.lblAntalKlick.TabIndex = 2;
            this.lblAntalKlick.Text = "0";
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 360);
            this.Controls.Add(this.lblAntalKlick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPress);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HelloWorld";
            this.Text = "SpaceInvador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPress;
        private Label label1;
        private Label lblAntalKlick;
    }
}