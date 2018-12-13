using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52ArmstrongNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte;
        double dblTijdelijk, dblAntwoord;
        string strInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                dblTijdelijk = Convert.ToDouble(strInvoer.Substring(intTeller, 1));
                dblAntwoord += Math.Pow(dblTijdelijk, 3);
            }

            if(dblAntwoord == Convert.ToDouble(strInvoer))
            {
                lblArmstrongOrNot.Text = "Number is Armstrong";

            }

            else
            {
                lblArmstrongOrNot.Text = "Number is not Armstrong";
            }
        }
    }
}
