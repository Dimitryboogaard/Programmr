using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40FactorialOfAGivenNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intFaculteit = 1;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= Convert.ToInt32(tbInvoer.Text); intTeller++)
            {
                intFaculteit = intFaculteit * intTeller;

                tbAntwoord.Text = intFaculteit.ToString();
            }
        }
    }
}
