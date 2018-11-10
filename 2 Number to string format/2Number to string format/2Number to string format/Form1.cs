using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Number_to_string_format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayOnder10[0] = "nul";
            ArrayOnder10[1] = "een";
            ArrayOnder10[2] = "twee";
            ArrayOnder10[3] = "drie";
            ArrayOnder10[4] = "vier";
            ArrayOnder10[5] = "vijf";
            ArrayOnder10[6] = "zes";
            ArrayOnder10[7] = "zeven";
            ArrayOnder10[8] = "acht";
            ArrayOnder10[9] = "negen";

            Array10Tallen[1] = "tien";
            Array10Tallen[2] = "twintig";
            Array10Tallen[3] = "dertig";
            Array10Tallen[4] = "veertig";
            Array10Tallen[5] = "vijftig";
            Array10Tallen[6] = "zestig";
            Array10Tallen[7] = "zeventig";
            Array10Tallen[8] = "tachtig";
            Array10Tallen[9] = "negentig";
        }

        string[] ArrayOnder10 = new string[10];
        string[] Array10Tallen = new string[10];

        private void btnZetOm_Click(object sender, EventArgs e)
        {
            if(btnZetOm.Text == "Opnieuw")
            {
                tbInvoer.Text = "";
                tbAntwoord.Text = "";
                btnZetOm.Text = "Zet om";
            }

            if(tbInvoer.Text.Length == 1 && btnZetOm.Text == "Zet om")
            {
                tbAntwoord.Text = ArrayOnder10[Convert.ToInt16(tbInvoer.Text)];
                btnZetOm.Text = "Opnieuw";
            }

            if(tbInvoer.Text.Length == 2 && btnZetOm.Text == "Zet om")
            {
                if(tbInvoer.Text.Substring(1, 1) == "0")
                {
                    tbAntwoord.Text = Array10Tallen[Convert.ToInt16(tbInvoer.Text.Substring(0, 1))];
                }

                if(tbInvoer.Text == "11")
                {
                    tbAntwoord.Text = "Elf";

                }

                else if(tbInvoer.Text == "12")
                {
                    tbAntwoord.Text = "Twaalf";
                }

                else if(tbInvoer.Text == "13")
                {
                    tbAntwoord.Text = "Dertien";
                }

                else if(tbInvoer.Text.Substring(1, 1) != "0")
                {
                    tbAntwoord.Text += ArrayOnder10[Convert.ToInt16(tbInvoer.Text.Substring(1, 1))];
                    tbAntwoord.Text += "en";
                    tbAntwoord.Text += Array10Tallen[Convert.ToInt16(tbInvoer.Text.Substring(0, 1))];
                }

                btnZetOm.Text = "Opnieuw";
            }
        }
    }
}
