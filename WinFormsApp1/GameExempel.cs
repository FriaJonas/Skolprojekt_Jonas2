using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GameExempel : Form
    {
        public GameExempel()
        {
            InitializeComponent();
            PictureBox pb = new PictureBox();
            pb.Width = 100;
            pb.Height = 200;
            pb.BackColor = Color.RebeccaPurple;
            pb.Left = 200;
            pb.Top = 300;
            this.Controls.Add(pb);
        }

        private void GameExempel_Load(object sender, EventArgs e)
        {

        }

        private void GameExempel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Player.Left -= 15;
            }
            else if(e.KeyCode==Keys.S)
            {
                Player.Left += 15;
                
            }
            else if(e.KeyCode ==Keys.W)
            {
                Player.Top -= 15;

            }
            else if(e.KeyCode == Keys.Z)
            {
                Player.Top += 15;

            }
            CheckCollissions();
        }

        private void CheckCollissions()
        {
            if (Player.Bounds.IntersectsWith(Ball.Bounds))
             {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Du krockade");
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball.Left -= 5;
            if(Ball.Left<=0)
            {
                Ball.Left = 760;
            }
            CheckCollissions();
            
        }
    }
}
