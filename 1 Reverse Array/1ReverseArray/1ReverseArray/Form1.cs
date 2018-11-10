using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ReverseArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller = 1, intTeller2;
        int[] arrayGetallen = new int[20];

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblTeller.Text = intTeller.ToString();
            arrayGetallen[intTeller] = Convert.ToInt16(tbInvoer.Text);
            intTeller++;
            tbInvoer.Text = "";
        }

        private void btnArrayReverse_Click(object sender, EventArgs e)
        {
             
            for(intTeller2 = intTeller - 1; intTeller2 >= 1; intTeller2--)
            {
                tbAntwoord.Text += arrayGetallen[intTeller2].ToString();
            }
        }
    }
}
