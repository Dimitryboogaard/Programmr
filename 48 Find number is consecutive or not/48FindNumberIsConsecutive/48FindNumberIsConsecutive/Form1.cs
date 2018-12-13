using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48FindNumberIsConsecutive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer;
        int intStringlengte, intTeller;
        bool booOpeenVolgend = true;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringlengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringlengte - 1; intTeller++)
            {
                if (Convert.ToInt16(strInvoer.Substring(intTeller, 1)) != Convert.ToInt16(strInvoer.Substring(intTeller + 1, 1)) - 1)
                {
                    booOpeenVolgend = false;
                }

            }

            if(booOpeenVolgend)
            {
                lblOpeenVolgendOfNiet.Text = "Getal is opeenvolgend";
            }
            
            else if(!booOpeenVolgend)
            {
                lblOpeenVolgendOfNiet.Text = "Getal is niet opeenvolgend";
            }
        }
    }
}
