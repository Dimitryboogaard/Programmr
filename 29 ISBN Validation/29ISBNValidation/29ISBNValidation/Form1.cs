using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29ISBNValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intStringLengte, intTeller, intAntwoord;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            intStringLengte = tbInvoer.Text.Length;

            if(intStringLengte != 10)
            {
                lblValidOrNot.Text = "Not valid";
            }

            else if(intStringLengte == 10)
            {
                for(intTeller = 0; intTeller < 10; intTeller++)
                {
                    intAntwoord += (intTeller + 1) * Convert.ToInt16(tbInvoer.Text.Substring(intTeller, 1));
                }

                if(intAntwoord % 11 == 0)
                {
                    lblValidOrNot.Text = "Valid";
                }

                else
                {
                    lblValidOrNot.Text = "Not valid";
                }
            }
        }
    }
}
