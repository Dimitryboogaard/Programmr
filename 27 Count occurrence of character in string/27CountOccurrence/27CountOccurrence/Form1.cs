using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27CountOccurrence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intStringlengte, intTeller, intVoorkomen;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intStringlengte = rtInvoer.Text.Length;

            for(intTeller = 0; intTeller <= intStringlengte - 1; intTeller++)
            {
                if(rtInvoer.Text.Substring(intTeller, 1) == tbLetter.Text)
                {
                    intVoorkomen++;
                }
            }

            lblVoorkomen.Text = tbLetter.Text + " komt " + intVoorkomen.ToString() + " keer voor.";
        }
    }
}
