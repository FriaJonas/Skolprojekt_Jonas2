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
    public partial class Moms : Form
    {
        public Moms()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            decimal price = Convert.ToDecimal(txtPrice.Text);
            decimal tax = Convert.ToDecimal(txtTaxrate.Text);
            decimal priceextax =  (price/ (tax + 100)) * 100;
            txtPriceExTax.Text = priceextax.ToString();

        }
    }
}
