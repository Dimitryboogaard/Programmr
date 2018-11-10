using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4LastSamplesOfANumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intM, intN, intTeller, intAntwoord;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intN = Convert.ToInt32(tbInvoer1.Text);
            intM = Convert.ToInt32(tbInvoer2.Text);
           

            for(intTeller = 1; intTeller <= intM; intTeller++)
            {
                intAntwoord = intN - intTeller;
                tbAntwoord.Text += intAntwoord.ToString() + " ";
            }
        }
    }
}
