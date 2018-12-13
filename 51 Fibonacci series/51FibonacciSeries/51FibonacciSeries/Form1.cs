using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51FibonacciSeries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arrayFibonacci[0] = 0;
            arrayFibonacci[1] = 1;
        }

        int[] arrayFibonacci = new int[1000];
        int intTeller, intInvoer, intFibonacci;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt16(tbInvoer.Text);

            for(intTeller = 2; intTeller <= intInvoer; intTeller++)
            {
                arrayFibonacci[intTeller] = arrayFibonacci[intTeller - 2] + arrayFibonacci[intTeller - 1];
            }

            for(intTeller = 0; intTeller < intInvoer; intTeller++)
            {
                rtUitvoer.Text += arrayFibonacci[intTeller].ToString() + Environment.NewLine;
            }
        }
    }
}
