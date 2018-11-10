using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6PrintBinaryTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intMaximum, intTeller2, int0Of1 = 1;
        

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intMaximum = Convert.ToInt16(tbInvoer.Text);

            for(intTeller = 1; intTeller <= intMaximum; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    rtUitvoer.Text += int0Of1.ToString();

                    if(int0Of1 == 0)
                    {
                        int0Of1 = 1;
                    }
                    else if(int0Of1 == 1)
                    {
                        int0Of1 = 0;
                    }
                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
