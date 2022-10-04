namespace WinFormsApp1
{
    partial class CarPriceTest
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
            this.numCarPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCarPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numCarPrice
            // 
            this.numCarPrice.Location = new System.Drawing.Point(173, 137);
            this.numCarPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numCarPrice.Name = "numCarPrice";
            this.numCarPrice.Size = new System.Drawing.Size(150, 27);
            this.numCarPrice.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(174, 198);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(94, 29);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Kolla pris";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(178, 259);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            // 
            // CarPriceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.numCarPrice);
            this.Name = "CarPriceTest";
            this.Text = "CarPriceTest";
            ((System.ComponentModel.ISupportInitialize)(this.numCarPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numCarPrice;
        private Button btnCheck;
        private Label lblMessage;
    }
}