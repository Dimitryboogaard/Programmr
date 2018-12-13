using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62FindDayOfGivenDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime dteDatum = new DateTime();
        int intDayOfWeek;
        string strDayOfWeek;


        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            dteDatum = Convert.ToDateTime(tbInvoer.Text);

            intDayOfWeek = (int)dteDatum.DayOfWeek;

            switch(intDayOfWeek)
            {
                case 0:
                    strDayOfWeek = "zondag";
                    break;

                case 1:
                    strDayOfWeek = "maandag";
                    break;

                case 2:
                    strDayOfWeek = "dinsdag";
                    break;

                case 3:
                    strDayOfWeek = "woensdag";
                    break;

                case 4:
                    strDayOfWeek = "donderdag";
                    break;

                case 5:
                    strDayOfWeek = "vrijdag";
                    break;

                case 6:
                    strDayOfWeek = "zaterdag";
                    break;
                    
            }

            lblWelkeDag.Text = "Die datum val op een " + strDayOfWeek + ".";
        }
    }
}
