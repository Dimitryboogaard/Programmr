using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8PrintRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2;

        private void btnMaakRechthoek_Click(object sender, EventArgs e)
        {
            for (intTeller = 1; intTeller <= Convert.ToInt32(tbBreedte.Text); intTeller++)
            {
                rtUitvoer.Text += "*";
            }
            
            rtUitvoer.Text += Environment.NewLine;

            for (intTeller2 = 1; intTeller2 <= Convert.ToInt32(tbHoogte.Text) - 2; intTeller2++)
            {
                for (intTeller = 1; intTeller <= Convert.ToInt32(tbBreedte.Text); intTeller++)
                {
                    if (intTeller == 1)
                    {
                        rtUitvoer.Text += "*";
                    }

                    else if (intTeller == Convert.ToInt32(tbBreedte.Text))
                    {
                        rtUitvoer.Text += "*";
                    }

                    else if(intTeller > 1 && intTeller < Convert.ToInt32(tbBreedte.Text))
                    {
                        rtUitvoer.Text += " ";
                    }
                }

                rtUitvoer.Text += Environment.NewLine;
            }

            for (intTeller = 1; intTeller <= Convert.ToInt32(tbBreedte.Text); intTeller++)
            {
                rtUitvoer.Text += "*";
            }
            
        }
    }
}
