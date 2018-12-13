using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39ConvertInSeconds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTotaal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intTotaal += Convert.ToInt32(tbInvoerUren.Text) * 3600;
            intTotaal += Convert.ToInt32(tbInvoerMinuten.Text) * 60;
            intTotaal += Convert.ToInt32(tbInvoerSeconden.Text);

            tbAntwoord.Text = intTotaal.ToString();
        }
    }
}
