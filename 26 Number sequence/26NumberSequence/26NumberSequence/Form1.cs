using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26NumberSequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intGetal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal = Convert.ToInt32(tbInvoer.Text);

            for(intTeller = 1; intTeller <= intGetal; intTeller++)
            {
                tbUitvoer.Text += intTeller.ToString();
            }

            for(intTeller = intGetal - 1; intTeller > 0; intTeller--)
            {
                tbUitvoer.Text += intTeller.ToString();
            }
        }
    }
}
