using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Properties;

namespace WinFormsApp1.Lib
{
    internal class Fighter:PictureBox
    {
        public Fighter()
        {
            this.BackgroundImage = Resources.ufo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Width = 100;
            this.Height = 50;
            this.Left = 300;
            this.Top = 50;
        }

        public void Move()
        {
            this.Left += 10;
        }
    }
}
