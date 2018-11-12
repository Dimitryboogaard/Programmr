using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21Capitalization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strAntwoord;
        int intStringlengte, intTeller;
        bool booSpatie = false;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringlengte = strInvoer.Length;
            strInvoer.Trim();

            strAntwoord += strInvoer.Substring(0, 1).ToUpper();

            for(intTeller = 1; intTeller <= intStringlengte - 1; intTeller++)
            {
                
                if(strInvoer.Substring(intTeller, 1) != " " && booSpatie)
                {
                    strAntwoord += strInvoer.Substring(intTeller, 1).ToUpper();
                    booSpatie = false;
                }

                else if (strInvoer.Substring(intTeller, 1) != " ")
                {
                    strAntwoord += strInvoer.Substring(intTeller, 1);
                }



                if (strInvoer.Substring(intTeller, 1) == " ")
                {
                    strAntwoord += " ";
                    booSpatie = true;
                }

            }

            tbUitvoer.Text = strAntwoord;
        }
    }
}
