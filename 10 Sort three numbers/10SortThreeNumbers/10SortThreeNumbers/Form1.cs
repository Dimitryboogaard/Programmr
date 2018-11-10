using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10SortThreeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] ArrayNummers = new int[3];
        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            ArrayNummers[0] = Convert.ToInt32(tbNummer1.Text);
            ArrayNummers[1] = Convert.ToInt32(tbNummer2.Text);
            ArrayNummers[2] = Convert.ToInt32(tbNummer3.Text);

            Array.Sort(ArrayNummers);

            for(intTeller = 0; intTeller <= 2; intTeller++)
            {
                rtAntwoord.Text += ArrayNummers[intTeller];
            }
        }
    }
}
