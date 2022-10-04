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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }


        private void helloWorldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelloWorld Hello = new HelloWorld();
            Hello.MdiParent = this;
            Hello.Show();
        }

        private void trikalkylatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TriCalc tc = new TriCalc();
            tc.MdiParent = this;
            tc.Show();
        }

        private void momsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Moms moms = new Moms();
            moms.MdiParent = this;
            moms.Show();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.MdiParent=this;
            g.Show();
            g.Focus();
        }

        private void gameExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameExempel ge = new GameExempel();
            ge.MdiParent = this;
            ge.Show();
            ge.Focus();
        }

        private void game2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelloWorld game2 = new HelloWorld();
            game2.MdiParent = this;
            game2.Show();
            game2.Focus();
        }

        private void slumptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Slumptal st = new Slumptal();
            st.MdiParent = this;
            st.Show();
            st.Focus();
        }

        private void gissaTalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuessNumber gn = new GuessNumber();
            gn.MdiParent = this;
            gn.Show();
            gn.Focus();
        }
    }
}
