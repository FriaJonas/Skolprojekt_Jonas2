using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Lib;

namespace WinFormsApp1
{
    public partial class FallingStars : Form
    {
        List<Star> stars = new List<Star>();
        public FallingStars()
        {
            InitializeComponent();
            Random rnd = new Random();
            for(int i=0;i<10;i++)
            {
                Star s = new Star();
                s.Top = 10;
                s.Left = rnd.Next(1, 800);
                s.Gravity = rnd.Next(5, 20);
                this.Controls.Add(s);
                stars.Add(s);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Star s in stars)
            {
                s.Fall();
            }
        }
    }
}
