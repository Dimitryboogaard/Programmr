using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34EuclidsGCDAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intPriemTeller, intInvoer1, intInvoer2, intMax1, intMax2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer1 = Convert.ToInt32(tbInvoer1.Text);
            intInvoer2 = Convert.ToInt32(tbInvoer2.Text);

            for (intTeller = 1; intTeller <= intInvoer1; intTeller++)
            {
                intPriemTeller = 0;

                for (intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    if(intTeller % intTeller2 == 0)
                    {
                        intPriemTeller++;
                    }
                }

                if(intPriemTeller == 2)
                {
                    while (intInvoer1 % intTeller == 0)
                    {
                        intInvoer1 = intInvoer1 / intTeller;

                        if(intTeller > intMax1)
                        {
                            intMax1 = intTeller;
                        }

                        rtTest.Text += intTeller.ToString() + Environment.NewLine;
                    }
                }
            }


            //Getal2
            for (intTeller = 1; intTeller <= intInvoer2; intTeller++)
            {
                intPriemTeller = 0;

                for (intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    if (intTeller % intTeller2 == 0)
                    {
                        intPriemTeller++;
                    }
                }

                if (intPriemTeller == 2)
                {
                    while (intInvoer2 % intTeller == 0)
                    {
                        intInvoer2 = intInvoer2 / intTeller;

                        if (intTeller > intMax2)
                        {
                            intMax2 = intTeller;
                        }

                        rtTest.Text += intTeller.ToString() + Environment.NewLine;
                    }
                }
            }

            if(intMax1 == intMax2)
            {
                tbUitvoer.Text = intMax1.ToString();
            }

        }



    }
}
