using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15PerfectNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intInvoer, intTeller, intPerfect;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt16(tbInvoer.Text);

            for (intTeller = 1; intTeller < intInvoer; intTeller++)
            {
                if(intInvoer % intTeller == 0)
                {
                    rtTest.Text += intTeller.ToString() + Environment.NewLine;
                    intPerfect += intTeller;
                }
            }

            if(intPerfect == intTeller)
            {
                lblPerfectNotPerfect.Text = "Perfect";
            }

            else
            {
                lblPerfectNotPerfect.Text = "Not Perfect";
            }
        }
    }
}
