using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56ConvertBinaryToDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intTeller2;
        double dblAntwoord;
        string strInvoer;
        bool booNotBinary;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            //Bepalen of het een binair getal is
            for (intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if (strInvoer.Substring(intTeller, 1) != "1" && strInvoer.Substring(intTeller, 1) != "0")
                {
                    booNotBinary = true;
                }
            }

            if (booNotBinary)
            {
                lblNietBinair.Text = "Geen binair getal";
                tbInvoer.Text = "";
                booNotBinary = false;
            }

            else if (!booNotBinary)
            {
                for (intTeller = intStringLengte - 1; intTeller >= 0; intTeller--)
                {
                    if (strInvoer.Substring(intTeller, 1) == "1")
                    {
                        dblAntwoord += Math.Pow(2, intTeller2);
                    }

                    intTeller2++;
                }

                tbUitvoer.Text = dblAntwoord.ToString();
                dblAntwoord = 0;
                intTeller2 = 0;
                tbInvoer.Text = "";
                lblNietBinair.Text = "";


            }

        }
    }
}
