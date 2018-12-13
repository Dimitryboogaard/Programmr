using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60TransposeOfMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayMatrix[0, 0] = 1;
            arrayMatrix[1, 0] = 2;
            arrayMatrix[2, 0] = 3;
            arrayMatrix[0, 1] = 4;
            arrayMatrix[1, 1] = 5;
            arrayMatrix[2, 1] = 6;
            arrayMatrix[0, 2] = 7;
            arrayMatrix[1, 2] = 8;
            arrayMatrix[2, 2] = 9;
        }

        int[,] arrayMatrix = new int[3, 3];
        int intTeller, intTeller2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for (intTeller2 = 0; intTeller2 <= 2; intTeller2++)
            {
                for (intTeller = 0; intTeller <= 2; intTeller++)
                {
                    rtUitvoer.Text += arrayMatrix[intTeller2, intTeller] + " ";
                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
