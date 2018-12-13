using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47RemoveCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strLetter;
        int intTeller, intStringlengte;

        private void button1_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            strLetter = tbLetter.Text;
            intStringlengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringlengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, 1) != strLetter)
                {
                    tbUitvoer.Text += strInvoer.Substring(intTeller, 1);
                }

                else if(strInvoer.Substring(intTeller, 1) == strLetter)
                {
                    tbUitvoer.Text += "";
                }
            }
        }
    }
}
