using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28QuadrantOfAnAngle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intHoekInGraden;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intHoekInGraden = Convert.ToInt32(tbHoekInGraden.Text);

            if(intHoekInGraden >= 0 && intHoekInGraden <= 90)
            {
                tbQuadrant.Text = "Quadrant 1";
            }

            if(intHoekInGraden > 90 && intHoekInGraden <= 180)
            {
                tbQuadrant.Text = "Quadrant 2";
            }

            if(intHoekInGraden > 180 && intHoekInGraden <= 270)
            {
                tbQuadrant.Text = "Quadrant 3";
            }

            if(intHoekInGraden > 270 && intHoekInGraden <= 359)
            {
                tbQuadrant.Text = "Quadrant 4";
            }
        }
    }
}
