using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57WordReverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer;
        int intStringLengte, intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;

            intStringLengte = strInvoer.Length;

            for(intTeller = intStringLengte - 1; intTeller >= 0; intTeller--)
            {
                tbUitvoer.Text += strInvoer.Substring(intTeller, 1);
            }
        }
    }
}
