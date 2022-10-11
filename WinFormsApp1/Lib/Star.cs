using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Properties;

namespace WinFormsApp1.Lib
{
    internal class Star:PictureBox
    {
        public int Gravity = 5;
        public Star()
        {
            this.BackgroundImage = Resources.Star;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Height = 20;
            this.Width = 20;
            this.Left = 150;
            this.Top = 150;
            this.BackColor = System.Drawing.Color.Transparent;
        }
        public void Fall()
        {
            this.Top += Gravity;
            if(this.Top > 500)
            {
                this.Top = 0;
            }

        }
    }
}
