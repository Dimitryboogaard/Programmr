using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54CollatzSequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);
            rtUitvoer.Text += intInvoer.ToString() + Environment.NewLine;

            do
            {
                if (intInvoer % 2 == 0)
                {
                    Even();
                }

                else if (intInvoer % 2 != 0)
                {
                    Oneven();
                }

                rtUitvoer.Text += intInvoer.ToString() + Environment.NewLine;

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
            return;
        }
    }
}
