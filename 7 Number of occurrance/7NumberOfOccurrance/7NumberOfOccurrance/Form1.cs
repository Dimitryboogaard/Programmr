using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7NumberOfOccurrance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intAantal, intStringLengte, intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intStringLengte = tbInvoer.Text.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(tbInvoer.Text.Substring(intTeller, 1) == tbGezochtNummer.Text)
                {
                    intAantal += 1;
                }
            }

            tbAantal.Text = intAantal.ToString();
        }
    }
}
