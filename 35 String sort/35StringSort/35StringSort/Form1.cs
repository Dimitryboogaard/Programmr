using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35StringSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strUitvoer;
        int intTeller, intStringLengte;
        string[] arrayInvoer = new string[1000];

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;

            intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                arrayInvoer[intTeller] = strInvoer.Substring(intTeller, 1);
            }

            Array.Sort(arrayInvoer);

            for(intTeller = 1000 - intStringLengte; intTeller < 1000; intTeller++)
            {
                tbUitvoer.Text += arrayInvoer[intTeller];
            }
        }
    }
}
