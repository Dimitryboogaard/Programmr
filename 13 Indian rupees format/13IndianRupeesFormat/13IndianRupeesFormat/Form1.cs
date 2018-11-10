using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13IndianRupeesFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intInvoer, intGedeeldDoorDuizend;
        
        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt16(tbInvoer.Text);

            intGedeeldDoorDuizend = intInvoer / 1000;

            if(intGedeeldDoorDuizend > 0)
            {
                tbIndianRupeesFormat.Text = intGedeeldDoorDuizend.ToString() + "Thousand " + 
                                            Convert.ToString(intInvoer % 1000);
            }

            else if(intGedeeldDoorDuizend == 0)
            {
                tbIndianRupeesFormat.Text = intInvoer.ToString();
            }


        }
    }
}
