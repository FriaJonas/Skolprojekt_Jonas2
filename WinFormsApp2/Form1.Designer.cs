namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPress = new System.Windows.Forms.Button();
            this.txtNamnText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPress
            // 
            this.btnPress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPress.Location = new System.Drawing.Point(184, 247);
            this.btnPress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(217, 62);
            this.btnPress.TabIndex = 0;
            this.btnPress.Text = "Klicka här";
            this.btnPress.UseVisualStyleBackColor = false;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // txtNamnText
            // 
            this.txtNamnText.Location = new System.Drawing.Point(184, 189);
            this.txtNamnText.Name = "txtNamnText";
            this.txtNamnText.Size = new System.Drawing.Size(125, 27);
            this.txtNamnText.TabIndex = 2;
            this.txtNamnText.Text = "Jonas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.txtNamnText);
            this.Controls.Add(this.btnPress);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPress;
        private TextBox txtNamnText;
    }
}