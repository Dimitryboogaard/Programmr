using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36UlamSequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intInvoer, intUitvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            do
            {
                if(intInvoer % 2 == 0)
                {
                    Even();
                }

                else
                {
                    Oneven();
                }

                if (intInvoer != 1)
                {
                    rtUitvoer.Text += intInvoer.ToString() + " -> ";
                }
                else
                {
                    rtUitvoer.Text += intInvoer.ToString() ;

                }
            } while (intInvoer != 1);

        }

        void Even()
        {
            intInvoer = intInvoer / 2;
            return;
        }

        void Oneven()
        {
            intInvoer = intInvoer * 3 + 1;
        }
    }
}
