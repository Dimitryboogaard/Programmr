using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49dDateSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime dteDatum1 = new DateTime();
        DateTime dteDatum2 = new DateTime();

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            dteDatum1 = Convert.ToDateTime(tbDatum1.Text);
            dteDatum2 = Convert.ToDateTime(tbDatum2.Text);
                
            if(dteDatum1 < dteDatum2)
            {
                rtUitvoer.Text += dteDatum1.ToShortDateString() + Environment.NewLine + dteDatum2.ToShortDateString();
            }

            else
            {
                rtUitvoer.Text += dteDatum2.ToShortDateString() + Environment.NewLine + dteDatum1.ToShortDateString();
            }
        }
    }
}
