using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19SexyPairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intInvoer, intTeller, intTeller2, intTellerPlus6, intPriem, intPriemGetal, intPriemGetal6;

        bool booPriem1, booPriem2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            for(intTeller = 1; intTeller <= intInvoer; intTeller++)
            {
                PriemBepaler();
                intTellerPlus6 = intTeller + 6;
                PriemBepaler6();

                if(booPriem1 && booPriem2)
                {
                    rtUitvoer.Text += "(" + intPriemGetal.ToString() + ", " + intPriemGetal6.ToString() + 
                                       ")" + Environment.NewLine;
                }

            }

        }

        void PriemBepaler()
        {
            intPriem = 0;
            booPriem1 = false;

            for (intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
            {
                if (intTeller % intTeller2 == 0)
                {
                    intPriem++;
                }
            }

            if (intPriem == 2)
            {
                intPriemGetal = intTeller;
                booPriem1 = true;
                
            }

            return;
        }

        void PriemBepaler6()
        {
            intPriem = 0;
            booPriem2 = false;

            for (intTeller2 = 1; intTeller2 <= intTellerPlus6; intTeller2++)
            {
                if (intTellerPlus6 % intTeller2 == 0)
                {
                    intPriem++;
                }
            }

            if (intPriem == 2)
            {

                intPriemGetal6 = intTellerPlus6;
                booPriem2 = true;
                
            }

            if(intPriemGetal6 > intInvoer)
            {
                booPriem2 = false;
            }

            return;
        }

    }
}
