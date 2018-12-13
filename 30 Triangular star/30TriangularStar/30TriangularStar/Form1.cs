using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30TriangularStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intInvoer, intTeller, intStringLengte, intTellerSterretje, intTellerStreepje;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);
            intTellerStreepje = intInvoer;
            if (intInvoer % 2 != 0)
            {
                lblOnevenOfNiet.Text = "";
                do
                {
                    intTellerSterretje++;
                    intTellerStreepje = intTellerStreepje - 2;

                    for (intTeller = 1; intTeller <= intTellerSterretje; intTeller++)
                    {
                        rtUitvoer.Text += "*";
                    }

                    for (intTeller = 1; intTeller <= intTellerStreepje; intTeller++)
                    {
                        rtUitvoer.Text += "-";
                    }

                    for (intTeller = 1; intTeller <= intTellerSterretje; intTeller++)
                    {
                        rtUitvoer.Text += "*";
                    }

                    rtUitvoer.Text += Environment.NewLine;

                } while (intTellerStreepje != 1);

                for (intTeller = 1; intTeller <= intInvoer; intTeller++)
                {
                    rtUitvoer.Text += "*";
                }

                rtUitvoer.Text += Environment.NewLine;

                do
                {

                    for (intTeller = 1; intTeller <= intTellerSterretje; intTeller++)
                    {
                        rtUitvoer.Text += "*";
                    }

                    for (intTeller = 1; intTeller <= intTellerStreepje; intTeller++)
                    {
                        rtUitvoer.Text += "-";
                    }

                    for (intTeller = 1; intTeller <= intTellerSterretje; intTeller++)
                    {
                        rtUitvoer.Text += "*";
                    }

                    rtUitvoer.Text += Environment.NewLine;

                    intTellerStreepje += 2;
                    intTellerSterretje--;

                } while (intTellerStreepje < intInvoer );

            }

            else
            {
                tbInvoer.Text = "";
                lblOnevenOfNiet.Text = "Oneven nummer invullen.";
            }
        }
    }
}
