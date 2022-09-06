namespace WinFormsApp1
{
    partial class StartForm
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
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloWorldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trikalkylatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.momsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloWorldToolStripMenuItem1,
            this.trikalkylatorToolStripMenuItem,
            this.momsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloWorldToolStripMenuItem1
            // 
            this.helloWorldToolStripMenuItem1.Name = "helloWorldToolStripMenuItem1";
            this.helloWorldToolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.helloWorldToolStripMenuItem1.Text = "Hello World";
            this.helloWorldToolStripMenuItem1.Click += new System.EventHandler(this.helloWorldToolStripMenuItem1_Click);
            // 
            // trikalkylatorToolStripMenuItem
            // 
            this.trikalkylatorToolStripMenuItem.Name = "trikalkylatorToolStripMenuItem";
            this.trikalkylatorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.trikalkylatorToolStripMenuItem.Text = "Trikalkylator";
            this.trikalkylatorToolStripMenuItem.Click += new System.EventHandler(this.trikalkylatorToolStripMenuItem_Click);
            // 
            // momsToolStripMenuItem
            // 
            this.momsToolStripMenuItem.Name = "momsToolStripMenuItem";
            this.momsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.momsToolStripMenuItem.Text = "Moms";
            this.momsToolStripMenuItem.Click += new System.EventHandler(this.momsToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem helloWorldToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helloWorldToolStripMenuItem1;
        private ToolStripMenuItem trikalkylatorToolStripMenuItem;
        private ToolStripMenuItem momsToolStripMenuItem;
    }
}