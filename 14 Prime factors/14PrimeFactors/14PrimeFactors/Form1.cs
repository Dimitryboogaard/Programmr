using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14PrimeFactors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intInvoer, intPriemTeller = 0;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            for(intTeller = 1; intTeller <= intInvoer; intTeller++)
            {
                intPriemTeller = 0;

                for(intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    if(intTeller % intTeller2 == 0)
                    {
                        intPriemTeller++;
                    }
                }

                //rtUitvoer.Text += intPriemTeller.ToString() + Environment.NewLine;

                if(intPriemTeller == 2)
                {
                    //rtUitvoer.Text += intTeller.ToString() + Environment.NewLine;
                    while(intInvoer % intTeller == 0)
                    {
                        rtUitvoer.Text += intTeller.ToString() + Environment.NewLine;
                        intInvoer = intInvoer / intTeller;
                    }
                }
            }
        }
    }
}
