using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24SumOfTheDigits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intStringLengte, intTeller, intAntwoord, intInvoer;
        string strInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;

            intStringLengte = tbInvoer.Text.Length;

            do
            {
                for(intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                {
                    intAntwoord += Convert.ToInt32(strInvoer.Substring(intTeller, 1));
                }

                strInvoer = Convert.ToString(intAntwoord);

                intStringLengte = strInvoer.Length;

                intAntwoord = 0;

            } while (strInvoer.Length != 1);

            tbUitvoer.Text = strInvoer;
        }
    }
}
