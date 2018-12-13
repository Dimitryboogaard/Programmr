using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44IsBinaryOrNot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte;
        string strInvoer;
        bool booNotBinary = false;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, 1) != "1" && strInvoer.Substring(intTeller, 1) != "0")
                {
                    booNotBinary = true;
                }
            }

            if(booNotBinary)
            {
                lblBinaryOrNot.Text = "Not binary";
            }

            else if(!booNotBinary)
            {
                lblBinaryOrNot.Text = "Binary";
            }
        }
    }
}
