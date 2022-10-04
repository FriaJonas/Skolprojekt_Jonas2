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
    public partial class CarPriceTest : Form
    {
        public CarPriceTest()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            decimal decimalTal = numCarPrice.Value;
            
            if(decimalTal>100000)
            {
                lblMessage.Text = "Bilen är dyr och kostar mer än 100000";

            }
            if(numCarPrice.Value>200000)
            {
                lblMessage.Text += "bilen är skitdyr";
            }
            else
            {
                lblMessage.Text = "Priset är exakt 100000";
            }
           
        }
    }
}
