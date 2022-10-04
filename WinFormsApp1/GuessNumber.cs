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
    public partial class GuessNumber : Form
    {
        int Number = 0;
        int Guesses= 0;
        public GuessNumber()
        {
            InitializeComponent();
            RandomNumber();
        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            Guesses += 1;
            if(numNumber.Value < Number)
            {
                lblMessage.Text = "För lågt";
            }
            else if(numNumber.Value > Number)
            {
                lblMessage.Text = "För högt";
            }
            else
            {
                lblMessage.Text = "Grattis - du gissade rätt på " + Guesses + " antal försök";
            }
            lblGuess.Text = Guesses.ToString();
        }

        private void RandomNumber()
        {
            Random r = new Random();
            Number = r.Next(1, 101);
        }
    }
}
