using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9StatementReverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intStringLengte, intTeller, intTeller2, intWoordlengte;
        string strWoord;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intStringLengte = tbInvoer.Text.Length;

            for(intTeller = intStringLengte - 1; intTeller >= 0; intTeller--)
            {
                intWoordlengte += 1;
                if(tbInvoer.Text.Substring(intTeller, 1) == " ")
                {
                    for(intTeller2 = intTeller + 1; intTeller2 <= intTeller + intWoordlengte - 1; intTeller2++)
                    {
                        strWoord += tbInvoer.Text.Substring(intTeller2, 1);
                    }

                    tbUitvoer.Text += strWoord + " ";
                    strWoord = "";
                    intWoordlengte = 0;
                }

                else if(intTeller == 0)
                {
                    for (intTeller2 = intTeller; intTeller2 <= intTeller + intWoordlengte - 1; intTeller2++)
                    {
                        strWoord += tbInvoer.Text.Substring(intTeller2, 1);
                    }

                    tbUitvoer.Text += strWoord + " ";
                    strWoord = "";
                    intWoordlengte = 0;

                }

            }
        }
    }
}
