using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43FindVowelsAndConsonants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayLetters[0] = "A";
            arrayLetters[1] = "E";
            arrayLetters[2] = "I";
            arrayLetters[3] = "O";
            arrayLetters[4] = "U";
            arrayLetters[5] = "F";
            arrayLetters[6] = "G";
            arrayLetters[7] = "H";
            arrayLetters[8] = "C";
            arrayLetters[9] = "J";
            arrayLetters[10] = "K";
            arrayLetters[11] = "L";
            arrayLetters[12] = "M";
            arrayLetters[13] = "N";
            arrayLetters[14] = "D";
            arrayLetters[15] = "P";
            arrayLetters[16] = "Q";
            arrayLetters[17] = "R";
            arrayLetters[18] = "S";
            arrayLetters[19] = "T";
            arrayLetters[20] = "B";
            arrayLetters[21] = "V";
            arrayLetters[22] = "W";
            arrayLetters[23] = "X";
            arrayLetters[24] = "Y";
            arrayLetters[25] = "Z";
            arrayLetters[26] = "a";
            arrayLetters[27] = "e";
            arrayLetters[28] = "i";
            arrayLetters[29] = "o";
            arrayLetters[30] = "u";
            arrayLetters[31] = "f";
            arrayLetters[32] = "g";
            arrayLetters[33] = "h";
            arrayLetters[34] = "c";
            arrayLetters[35] = "j";
            arrayLetters[36] = "k";
            arrayLetters[37] = "l";
            arrayLetters[38] = "m";
            arrayLetters[39] = "n";
            arrayLetters[40] = "d";
            arrayLetters[41] = "p";
            arrayLetters[42] = "q";
            arrayLetters[43] = "r";
            arrayLetters[44] = "s";
            arrayLetters[45] = "t";
            arrayLetters[46] = "b";
            arrayLetters[47] = "w";
            arrayLetters[48] = "v";
            arrayLetters[49] = "x";
            arrayLetters[50] = "y";
            arrayLetters[51] = "z";
        }

        string[] arrayLetters = new string[100];
        string strInvoer, strSubstring;
        int intStringLengte, intTeller, intTeller2, intHoofdLetterMedeKlinker, intHoofdLetterKlinker,
            intKleineLetterMedeKlinker, intKleineLetterKlinker, intAantalKlinkers;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                strSubstring = strInvoer.Substring(intTeller, 1);

                for(intTeller2 = 0; intTeller2 <= 52; intTeller2++)
                {
                    if(arrayLetters[intTeller2] == strSubstring && intTeller2 < 5)
                    {
                        intHoofdLetterKlinker++;
                        intAantalKlinkers++;
                    }

                    if(arrayLetters[intTeller2] == strSubstring && intTeller2 > 4 && intTeller2 < 26)
                    {
                        intHoofdLetterMedeKlinker++;
                    }

                    if(arrayLetters[intTeller2] == strSubstring && intTeller2 > 25 && intTeller2 < 31)
                    {
                        intKleineLetterKlinker++;
                        intAantalKlinkers++;
                    }

                    if (arrayLetters[intTeller2] == strSubstring && intTeller2 > 30 && intTeller2 < 52)
                    {
                        intKleineLetterMedeKlinker++;
                    }


                }
            }
            tbHoofdLetterMedeKlinkers.Text = intHoofdLetterMedeKlinker.ToString();
            tbHoofdLetterKlinkers.Text = intHoofdLetterKlinker.ToString();
            tbKleineLetterKlinkers.Text = intKleineLetterKlinker.ToString();
            tbKleineLettersMedeKlinkers.Text = intKleineLetterMedeKlinker.ToString();
            tbAantalKlinkers.Text = intAantalKlinkers.ToString();
        }
    }
}
