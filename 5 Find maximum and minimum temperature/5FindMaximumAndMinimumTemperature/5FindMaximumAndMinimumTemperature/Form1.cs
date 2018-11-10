using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5FindMaximumAndMinimumTemperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayTemperaturen[0] = 10.0;
            ArrayTemperaturen[1] = 11.3;
            ArrayTemperaturen[2] = 4.5;
            ArrayTemperaturen[3] = -2.0;
            ArrayTemperaturen[4] = 3.6;
            ArrayTemperaturen[5] = -3.3;
            ArrayTemperaturen[6] = 0.0;
        }

        double[] ArrayTemperaturen = new double[10];
        double dblMax, dblMin;
        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller <= 7; intTeller++)
            {
                if(ArrayTemperaturen[intTeller] < dblMin)
                {
                    dblMin = ArrayTemperaturen[intTeller];
                }

                if(ArrayTemperaturen[intTeller] > dblMax)
                {
                    dblMax = ArrayTemperaturen[intTeller];
                }
            }

            tbMinimumTemperatuur.Text = dblMin.ToString();
            tbMaximumTemperatuur.Text = dblMax.ToString();
        }
    }

}
