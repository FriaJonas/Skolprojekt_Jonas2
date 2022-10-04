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
    public partial class HelloWorld : Form
    {
        int antalKlick = 0;
        int slumptal = 0;

        public HelloWorld()
        {
            InitializeComponent();
            //Slumpa ett tal första gången
            Random random = new Random();
            slumptal = random.Next(1, 101);
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            antalKlick += 1; //Ökar antal klick med 1
            lblAntalKlick.Text = antalKlick.ToString();
        }
    }
}
