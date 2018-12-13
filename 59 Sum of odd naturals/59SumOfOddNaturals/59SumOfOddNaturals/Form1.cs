using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _59SumOfOddNaturals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intInvoer, intAntwoord;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            for(intTeller = 1; intTeller <= intInvoer; intTeller++)
            {
                if(intTeller % 2 != 0)
                {
                    intAntwoord += intTeller;
                }

            }

            tbUitvoer.Text = intAntwoord.ToString();
        }
    }
}
