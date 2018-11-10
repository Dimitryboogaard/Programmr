using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16NumberOccurrenceInArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayGetallen[0] = 12;
            arrayGetallen[1] = 15;
            arrayGetallen[2] = 15;
            arrayGetallen[3] = 16;
            arrayGetallen[4] = 14;
            arrayGetallen[5] = 45;
            arrayGetallen[6] = 23;
            arrayGetallen[7] = 15;
        }

        int[] arrayGetallen = new int[20];
        int intInvoer, intTeller, intOccurrence;

        private void button1_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            for(intTeller = 0; intTeller <=7; intTeller++)
            {
                if(arrayGetallen[intTeller] == intInvoer)
                {
                    intOccurrence++;
                }
            }

            tbUitvoer.Text = intOccurrence.ToString();
        }
    }
}
