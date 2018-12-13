using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intInvoer, intVolgende;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            do
            {
                for(intTeller = 1; intTeller <= intInvoer - intVolgende; intTeller++)
                {
                    rtUitvoer.Text += intTeller.ToString();
                }

                rtUitvoer.Text += Environment.NewLine;
                intVolgende++;
            } while (intVolgende < intInvoer);
        }
    }
}
