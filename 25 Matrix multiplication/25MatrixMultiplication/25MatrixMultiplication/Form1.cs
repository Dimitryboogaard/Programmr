using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25MatrixMultiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayMatrix1[0, 0] = 1;
            arrayMatrix1[0, 1] = 4;
            arrayMatrix1[0, 2] = 7;
            arrayMatrix1[1, 0] = 2;
            arrayMatrix1[1, 1] = 5;
            arrayMatrix1[1, 2] = 8;
            arrayMatrix1[2, 0] = 3;
            arrayMatrix1[2, 1] = 6;
            arrayMatrix1[2, 2] = 1;

            arrayMatrix2[0, 0] = 1;
            arrayMatrix2[0, 1] = 3;
            arrayMatrix2[0, 2] = 4;
            arrayMatrix2[1, 0] = 2;
            arrayMatrix2[1, 1] = 2;
            arrayMatrix2[1, 2] = 5;
            arrayMatrix2[2, 0] = 3;
            arrayMatrix2[2, 1] = 1;
            arrayMatrix2[2, 2] = 2;
        }

        int[,] arrayMatrix2 = new int[3, 3];
        int[,] arrayMatrix1 = new int[3, 3];

        int intTeller, intTeller2, intTeller3, intUitkomst;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 0] * arrayMatrix2[0, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + " ";
            intUitkomst = 0;

            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 0] * arrayMatrix2[1, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + " ";
            intUitkomst = 0;

            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 0] * arrayMatrix2[2, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + Environment.NewLine;
            intUitkomst = 0;

            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 1] * arrayMatrix2[0, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + " ";
            intUitkomst = 0;

            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 1] * arrayMatrix2[1, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + " ";
            intUitkomst = 0;

            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 1] * arrayMatrix2[2, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + Environment.NewLine;
            intUitkomst = 0;

            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 2] * arrayMatrix2[0, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + " ";
            intUitkomst = 0;

            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 2] * arrayMatrix2[1, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + " ";
            intUitkomst = 0;

            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                intUitkomst += arrayMatrix1[intTeller, 2] * arrayMatrix2[2, intTeller];
            }
            rtAntwoord.Text += intUitkomst.ToString() + " ";
            intUitkomst = 0;


        }



    }
}
