using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17WindChill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        double dblWindChill;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            dblWindChill = 35.74 + 0.6215 * Convert.ToInt16(tbTemperatuur.Text) +
                           (0.4275 * Convert.ToInt16(tbTemperatuur.Text) - 35.75) *
                           Math.Pow(Convert.ToInt16(tbWindSnelheid.Text), 0.16);

            tbWindChill.Text = dblWindChill.ToString();
        }
    }
}
