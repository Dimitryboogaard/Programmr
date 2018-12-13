using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65PalindromString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer;
        int intStringlengte, intTeller, intHalveString;
        bool booPalindrom;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringlengte = strInvoer.Length;

            if(intStringlengte % 2 == 0)
            {
                booPalindrom = true;
                intHalveString = intStringlengte / 2;

                for(intTeller = 0; intTeller < intHalveString; intTeller++)
                {
                    if(strInvoer.Substring(intTeller, 1) != strInvoer.Substring(intStringlengte - intTeller - 1, 1))
                    {
                        booPalindrom = false;
                    }
                }
            }

            else
            {

                booPalindrom = true;
                intHalveString = (intStringlengte - 1) / 2;

                for(intTeller = 0; intTeller < intHalveString; intTeller++)
                {
                    if (strInvoer.Substring(intTeller, 1) != strInvoer.Substring(intStringlengte - intTeller - 1, 1))
                    {
                        booPalindrom = false;
                    }

                }
            }

            if(booPalindrom)
            {
                lblPalindromOrNot.Text = "Palindrom";
            }

            else if(!booPalindrom)
            {
                lblPalindromOrNot.Text = "Not a palindrom";
            }
        }
    }
}
