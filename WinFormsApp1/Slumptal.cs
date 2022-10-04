using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Slumptal : Form
    {
        public Slumptal()
        {
            InitializeComponent();
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            //skapa en slumpgenerator
            Random ran = new Random();

            //Definiera arrayen med antal slumptal som ska göras
            int[] numbers = new int[(int)numAntal.Value];
            
            //Läs in talen vi ska slumpa
            int tal1 = (int)Num.Value;
            int tal2 = (int)Num2.Value;

            //Loopa¨lika många gånger som antal tal som ska slumpas
            for (int i=0;i<(int)numAntal.Value;i++)
            {
                //Slumpa talet mellan två värden
                int newNumber = ran.Next(tal1,tal2);

                //Kolla om det nya talet redan finns i arrayen
                if (numbers.Contains(newNumber))
                {
                    //Lägg inte till talet
                    //Backa loopen med 1
                    i--; // = i= i-1
                }
                else
                {
                    //Den fanns inte med så vi lägger till
                    //det nya slumptalet i arrayen på position i
                    numbers[i] = newNumber;
                }
            }
            //Arrayen klar med siffror

            //Loopa igenom arrayen och skriv ut talen
            txtNum.Text = "";
            Array.Sort(numbers);

            foreach(int i in numbers)
            {
                txtNum.Text += i + " ";
            }
        }
    }
}
